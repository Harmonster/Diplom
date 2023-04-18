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
    public partial class RestorePassword : Form
    {
        string secret = null;
        int id;

        public RestorePassword()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            (string str, int iid) result = Classes.Database.GetSecretWordByLogin(textBox1.Text);
            secret = result.str;
            id = result.iid;

            if (secret != null)
            {
                pictureBox1.BackColor = Color.Green;
                button1.Enabled = true;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
                button1.Enabled = false;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == secret)
            {
                pictureBox2.BackColor = Color.Green;
                button1.Enabled = true;
            }
            else
            {
                pictureBox2.BackColor = Color.Red;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand("ResetPassword", Connection);
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@password", PasswordHash.GetHashedPassword(textBox3.Text));
                        cmd.Parameters.AddWithValue("@id", id);
                        Connection.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Данные успешно обновлены");
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        cmd.Dispose();
                        Connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают. Перепроверьте вводимые данные.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
