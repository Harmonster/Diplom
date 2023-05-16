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
    public partial class FirstAuth : Form
    {
        public FirstAuth()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSecret.Text))
            {
                MessageBox.Show("Введите секретное слово", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            (bool isPasswordValid, string validationMessage) validationResult = Classes.Validations.ValidatePassword(TxtPassword.Text);

            if (!validationResult.isPasswordValid)
            {
                MessageBox.Show(validationResult.validationMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtPasswordRepeat.Text))
            {
                MessageBox.Show("Повторите новый пароль. Перепроверьте данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!string.Equals(TxtPassword.Text, TxtPasswordRepeat.Text))
            {
                MessageBox.Show("Указанные пароли не совпадают. Перепроверьте данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatePassword();
        }

        private void UpdatePassword()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("CreateOperatorPassword", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", Classes.AuthorizedUserInfo.UserId);
                    cmd.Parameters.AddWithValue("@u_password", PasswordHash.GetHashedPassword(TxtPassword.Text));
                    cmd.Parameters.AddWithValue("@u_secret", PasswordHash.GetHashedPassword(TxtSecret.Text));
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        DialogResult dr = MessageBox.Show("Пароль успешно изменён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            this.Close();
                        }
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

        private void FirstAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void СhbSecret_CheckedChanged(object sender, EventArgs e)
        {
            TxtSecret.UseSystemPasswordChar = !ChbSecrets.Checked;
        }

        private void ChbPassword_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = !ChbPassword.Checked;
            TxtPasswordRepeat.UseSystemPasswordChar = !ChbPassword.Checked;
        }
    }
}
