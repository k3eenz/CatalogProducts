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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CatalogProd
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool InputValidation(ProductDbContext db)
        {
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return false;
            }
            var user = db.Users.FirstOrDefault(u => u.Login == UserNameTextBox.Text);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден. Проверьте логин.", "Ошибка");
                return false;
            }
            if (user.Password != PasswordTextBox.Text)
            {
                MessageBox.Show("Неправильный пароль. Попробуйте снова.", "Ошибка");
                return false;
            }
            return true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using var db = new ProductDbContext();
            if (InputValidation(db))
            {
                MessageBox.Show("Успешный вход!", "Успех");
                this.Hide();
                new MainForm().Show();
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }
    }
}
