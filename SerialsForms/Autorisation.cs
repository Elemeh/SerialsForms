using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialsForms
{
    public partial class Autorisation : Form
    {
        private Button but1;
        /// <summary>
        /// Метод для инициализации компонентов формы
        /// </summary>
        /// <param name="button"></param>
        public Autorisation(Button button)
        {
            but1 = button;
            InitializeComponent();
        }
        /// <summary>
        /// Метод, обрабатывающий нажатие на кнопку "Войти"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            String login = LoginField.Text;
            String password = PasswordField.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Users WHERE login = @userlogin AND password = @userpassword",db.getConnection());
            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = login; 
            command.Parameters.Add("@userpassword", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вход выполнен успешно");
                but1.Text = "Выйти из "+login;
                this.Close();
            }
            else
                MessageBox.Show("Вход не был выполнен");
        }
        /// <summary>
        /// Метод, обрабатывающий нажатие на кнопку "Зарегистрироваться"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerButton_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
            this.Close();
        }
    }
}
