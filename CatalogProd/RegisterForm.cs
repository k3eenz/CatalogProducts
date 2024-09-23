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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private bool InputValidation(ProductDbContext db)
        {
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return false;
            }
            if (PasswordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Пароль должен быть не менее 8 символов.", "Ошибка");
                return false;
            }
            if (!PasswordTextBox.Text.Any(char.IsDigit) ||
                !PasswordTextBox.Text.Any(char.IsLetter) ||
                !PasswordTextBox.Text.Any(c => char.IsPunctuation(c) || char.IsSymbol(c)))
            {
                MessageBox.Show("Пароль должен содержать буквы, цифры и специальные символы.", "Ошибка");
                return false;
            }
            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают. Пожалуйста, убедитесь, что оба поля заполнены одинаково.", "Ошибка");
                return false;
            }
            if (db.Users.Any(u => u.Login == UserNameTextBox.Text))
            {
                MessageBox.Show("Пользователь с таким именем уже существует. Пожалуйста, выберите другое имя.", "Ошибка");
                return false;
            }
            return true;
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            using var db = new ProductDbContext();
            if (InputValidation(db))
            {
                db.Users.Add(new Users() { Login = UserNameTextBox.Text, Password = PasswordTextBox.Text });
                db.SaveChanges();
                MessageBox.Show("Успешная регистрация!", "Успех");
                this.Hide();
                new MainForm().Show();
            }
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
