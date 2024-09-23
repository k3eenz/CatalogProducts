using CatalogProd.DataBase;

namespace CatalogProd
{
    public partial class MainForm : Form
    {
        private int currentPage = 1;
        private int itemsPerPage = 10;
        public MainForm()
        {
            InitializeComponent();
        }
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            var newProductForm = new NewProduct(this);
            newProductForm.Show();
        }
        public void AddProductToPanel(Product product)
        {
            var productElement = new ElementProduct();
            productElement.SetProductData(product);
            flowLayoutPanel1.Controls.Add(productElement);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LoadProduct(string manufacturer = null, string search = null, string sortOrder = null)
        {
            using var db = new ProductDbContext();
            var totalProductCount = db.Products.Count();
            LoadManufacturers(db, manufacturer); 
            var filteredProducts = GetFilteredProducts(db, manufacturer, search);
            var sortedProducts = SortProducts(filteredProducts, sortOrder);
            PaginateAndDisplayProducts(sortedProducts, totalProductCount);
        }


        private void LoadManufacturers(ProductDbContext db, string manufacturer = null)
        {
            var manufacturers = db.Products.Select(p => p.Manufacturer).Distinct().ToList();
            ManufacturerComboBox.SelectedIndexChanged -= ManufacturerComboBox_SelectedIndexChanged;
            ManufacturerComboBox.Items.Clear();
            ManufacturerComboBox.Items.Add("Все производители");

            foreach (var manu in manufacturers)
            {
                ManufacturerComboBox.Items.Add(manu);
            }

            if (manufacturer == null || manufacturer == "Все производители") // Если не передан конкретный производитель
            {
                ManufacturerComboBox.SelectedItem = ManufacturerComboBox.Items[0]; // Устанавливаем "Все производители" по умолчанию
            }
            else // Если передан конкретный производитель
            {
                ManufacturerComboBox.SelectedItem = manufacturer;
            }

            ManufacturerComboBox.SelectedIndexChanged += ManufacturerComboBox_SelectedIndexChanged;
        }



        private List<Product> GetFilteredProducts(ProductDbContext db, string manufacturer, string search)
        {
            var products = db.Products.ToList();

            if (manufacturer != null && manufacturer != "Все производители")
            {
                products = products.Where(p => p.Manufacturer == manufacturer).ToList();
            }

            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.Contains(search)).ToList();
            }

            return products;
        }

        private List<Product> SortProducts(List<Product> products, string sortOrder)
        {
            switch (sortOrder)
            {
                case "NoSort":
                    return products.OrderBy(p => p.ProductID).ToList();
                case "NameAsc":
                    return products.OrderBy(p => p.Name).ToList();
                case "NameDesc":
                    return products.OrderByDescending(p => p.Name).ToList();
                case "PriceAsc":
                    return products.OrderBy(p => (double)p.Price).ToList();
                case "PriceDesc":
                    return products.OrderByDescending(p => (double)p.Price).ToList();
                case "QuantityAsc":
                    return products.OrderBy(p => p.Count).ToList();
                case "QuantityDesc":
                    return products.OrderByDescending(p => p.Count).ToList();
                default:
                    return products;
            }
        }

        private void PaginateAndDisplayProducts(List<Product> filteredProducts, int totalProductCount)
        {
            flowLayoutPanel1.Controls.Clear();

            int totalPages = (int)Math.Ceiling((double)filteredProducts.Count / itemsPerPage);
            if (totalProductCount == 0) totalPages = 1;
            NowPageLabel.Text = $"Страница {currentPage} из {totalPages}";

            var paginatedProducts = filteredProducts.Skip((currentPage - 1) * itemsPerPage).Take(itemsPerPage).ToList();

            foreach (var product in paginatedProducts)
            {
                var productElement = new ElementProduct();
                productElement.SetProductData(product);
                flowLayoutPanel1.Controls.Add(productElement);
            }

            CountProducts.Text = $"Показано {paginatedProducts.Count} из {totalProductCount}";
            BackBtn.Enabled = currentPage > 1;
            NextBtn.Enabled = currentPage < totalPages;
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadProduct(ManufacturerComboBox.SelectedItem?.ToString(), SearchTextBox.Text, SortComboBox.SelectedItem?.ToString());
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            using var db = new ProductDbContext();
            if (currentPage < Math.Ceiling((double)db.Products.Count() / itemsPerPage))
            {
                currentPage++;
                LoadProduct(ManufacturerComboBox.SelectedItem?.ToString(), SearchTextBox.Text, SortComboBox.SelectedItem?.ToString());
            }
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedSortOrder = SortComboBox.SelectedIndex switch
            {
                0 => "NoSort",
                1 => "NameAsc",
                2 => "NameDesc",
                3 => "PriceAsc",
                4 => "PriceDesc",
                5 => "QuantityAsc",
                6 => "QuantityDesc",
                _ => null
            };
            LoadProduct(ManufacturerComboBox.SelectedItem?.ToString(), SearchTextBox.Text, selectedSortOrder);
        }

        private void ManufacturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ManufacturerComboBox.SelectedIndex == 0)
            {
                LoadProduct(null, SearchTextBox.Text, SortComboBox.SelectedItem?.ToString());
            }
            else
            {
                string? selectedManufacturer = ManufacturerComboBox.SelectedItem.ToString();
                LoadProduct(selectedManufacturer, SearchTextBox.Text, SortComboBox.SelectedItem?.ToString());
            }
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string? selectedManufacturer = ManufacturerComboBox.SelectedIndex == 0 ? null : ManufacturerComboBox.SelectedItem?.ToString();
            LoadProduct(selectedManufacturer, SearchTextBox.Text, SortComboBox.SelectedItem?.ToString());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
