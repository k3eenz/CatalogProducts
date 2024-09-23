using CatalogProd.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CatalogProd
{
    public partial class ElementProduct : UserControl
    {
        public ElementProduct()
        {
            InitializeComponent();
        }
        public void SetProductData(Product product)
        {
            nameLabel.Text = $"Название: {product.Name}";
            manufacturerLabel.Text = $"Производитель: {product.Manufacturer}";
            priceLabel.Text = $"Цена: {product.Price:C}";
            countLabel.Text = $"Осталось:\n{product.Count} шт.";
            descriptionTextBox.Text = $"Описание: {product.Description}";
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = baseDirectory;
            while (projectRoot != null && !Directory.Exists(Path.Combine(projectRoot, "img")))
            {
                projectRoot = Directory.GetParent(projectRoot)?.FullName;
            }
            string imgPath = Path.Combine(projectRoot, "img", $"{(product.PhotoID != -1 ? product.PhotoID : -1)}.jpg");
            pictureBox1.Image = Image.FromFile(imgPath);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
