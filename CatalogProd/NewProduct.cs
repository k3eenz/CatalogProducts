using CatalogProd.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogProd
{
    public partial class NewProduct : Form
    {
        private MainForm main;
        private string ImagePath;
        public NewProduct(MainForm mainForm)
        {
            InitializeComponent();
            main = mainForm;
            ClearBtn.Click += (sender, e) => ClearInfo();
            BackBtn.Click += (sender, e) => this.Close();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ManufacturerTextBox.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ||
                CountNumeric.Value < 1)
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }
            if (!decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Неверный формат цены", "Ошибка");
                return;
            }
            using var db = new ProductDbContext();
            var existingProduct = db.Products.FirstOrDefault(p => p.Name == NameTextBox.Text && p.Manufacturer == ManufacturerTextBox.Text);
            if (existingProduct != null)
            {
                MessageBox.Show("Такой товар уже существует", "Ошибка");
                return;
            }
            var product = new Product
            {
                Name = NameTextBox.Text,
                Manufacturer = ManufacturerTextBox.Text,
                Description = DescriptionTextBox.Text,
                Price = price,
                Count = (int)CountNumeric.Value
            };
            db.Products.Add(product);
            db.SaveChanges();
            int generatedID = product.ProductID;
            if (!string.IsNullOrWhiteSpace(ImagePath))
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = baseDirectory;
                while (projectRoot != null && !Directory.Exists(Path.Combine(projectRoot, "img")))
                {
                    projectRoot = Directory.GetParent(projectRoot)?.FullName;
                }
                string newFileName = $"{generatedID}.jpg";
                string newPath = System.IO.Path.Combine(projectRoot, "img", newFileName);
                System.IO.File.Copy(ImagePath, newPath);
                product.PhotoID = generatedID;
                db.Products.Update(product);
                db.SaveChanges();
            }

            main.AddProductToPanel(product);
            MessageBox.Show("Продукт успешно добавлен", "Успех");
            ClearInfo();
        }

        private void ClearInfo()
        {
            NameTextBox.Text = ManufacturerTextBox.Text = DescriptionTextBox.Text = PriceTextBox.Text = null;
            CountNumeric.Value = 0;
            ImagePath = null;
            pictureBox.Image = null;
        }

        private void AddPhotoBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImagePath = openFileDialog.FileName;
                        using (var stream = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }
    }
}
