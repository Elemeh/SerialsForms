using MySql.Data.MySqlClient;
using Renci.SshNet.Security;
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
    public partial class WorkForm : Form
    {
        public string login;
        public WorkForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusComboBox.SelectedIndex = 0;
            countryComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedIndex = 0;

            search();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Autorisation autorisationForm = new Autorisation(this.loginButton);
            autorisationForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void valueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
            }
        }
        /// <summary>
        /// Метод, обрабатывающий нажатие на кнопку "Найти", используя все параметры поиска
        /// </summary>
        private void search()
        {
            string sqlstr = "SELECT * FROM serialinfoview WHERE serialinfoview.`Название` LIKE CONCAT('%','" + valueTextBox.Text + "', '%') ";
            if (categoryComboBox.SelectedIndex != 0)
            {
                sqlstr += "and serialinfoview.`Категория` = '" + categoryComboBox.SelectedItem.ToString() + "'";
            }
            if (statusComboBox.SelectedIndex != 0)
            {
                sqlstr += "and serialinfoview.`Статус` = '" + statusComboBox.SelectedItem.ToString() + "'";
            }
            if (countryComboBox.SelectedIndex != 0)
            {
                sqlstr += " and serialinfoview.`Страна` = '" + countryComboBox.SelectedItem.ToString() + "'";
            }
            sqlstr += " and serialinfoview.`Год выхода` >= " + numericUpDown1.Value + " and serialinfoview.`Год выхода` <= " + numericUpDown2.Value;
            if (checkBox1.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр`LIKE '%боевик%'";
            }
            if (checkBox2.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%детектив%'";
            }
            if (checkBox3.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%драма%'";
            }
            if (checkBox4.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%история%'";
            }
            if (checkBox5.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%комедия%'";
            }
            if (checkBox6.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%криминал%'";
            }
            if (checkBox7.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%мелодрама%'";
            }
            if (checkBox8.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%приключения%'";
            }
            if (checkBox9.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%спорт%'";
            }
            if (checkBox10.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%триллер%'";
            }
            if (checkBox11.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%ужасы%'";
            }
            if (checkBox12.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%фантастика%'";
            }
            if (checkBox13.Checked)
            {
                sqlstr += " and serialinfoview.`Жанр` LIKE '%фэнтези%'";
            }
            sqlstr += ";";

            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(sqlstr, db.getConnection()); ;

            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            serialsDataGridView.DataSource = table;

            if (table.Rows.Count == 0)
                MessageBox.Show("Поиск не дал результатов");
        }
    }
}
