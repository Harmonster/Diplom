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

namespace Diplom
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                try
                {
                    string query = "SELECT * FROM `Diplom`.`operators` WHERE `email_operator` = @user AND `password_operator` = @password";
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@user", tbp_login.Text);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@password", tbp_password.Text);
                    dataAdapter.Fill(dataTable);

                    if (tbp_login.Text == "") { MessageBox.Show("Вы не ввели логин. Перепроверьте вводимые данные!"); }
                    else if (tbp_password.Text == "") { MessageBox.Show("Вы не ввели пароль. Перепроверьте вводимые данные!"); }
                    else if (dataTable.Rows.Count == 1)
                    {
                        AuthorizedUserInfo.UserName = dataTable.Rows[0]["name_operator"].ToString();
                        Main mainForm = new Main();
                        this.Hide();
                        mainForm.Show();
                    }
                    else
                    { 
                        MessageBox.Show("Работник с такими данными не найден. Перепроверьте вводимые данные!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); 
                        return; 
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); };
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            //tbp_login.Text = "dennyharmless@gmail.com";
            //tbp_password.Text = "12345678";
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
