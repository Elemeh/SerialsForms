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
using System.Text.RegularExpressions;

namespace SerialsForms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод обрабатывающий нажатие на кнопку "Зарегистрироваться"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length < 4 || loginTextBox.Text.Length > 20)
            {
                MessageBox.Show("Логин должен быть длиннее 4 символов и короче 20 символов");
                return;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (phoneTextBox.Text == "")
            {
                MessageBox.Show("Введите номер телефона");
                return;
            }
            string str = phoneTextBox.Text;
            Regex regex = new Regex(@"^\d{11}$");
            if (regex.IsMatch(str))
            {
                MessageBox.Show("Телефон подтвержден");
            }
            else
            {
                MessageBox.Show("Некорректный телефон");
                return;
            }


            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (login,password,phone) VALUES (@login, @password, @phone)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginTextBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordTextBox.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phoneTextBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ваш аккаунт успешно создан");
                this.Close();
            }

            else
                MessageBox.Show("Аккаунт не был создан");

            db.CloseConnection();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Метод для проверки существования пользователя
        /// </summary>
        /// <returns></returns>
        public Boolean isUserExists() 
        {
            
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Users WHERE login = @userlogin or phone = @userphone", db.getConnection());
            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = loginTextBox.Text;
            command.Parameters.Add("@userphone", MySqlDbType.VarChar).Value = phoneTextBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин или телефон уже занят");
                return true;
            }
            else
                return false;
        }
    }
}
