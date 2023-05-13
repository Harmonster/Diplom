using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLogin.Text))
            {
                MessageBox.Show("Вы не ввели логин. Пожалуйста повторите ввод.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Вы не ввели пароль. Пожалуйста повторите ввод.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (Classes.AuthorizedUserInfo.AuthorizationOperator(TxtLogin, TxtPassword, "AuthorizationOperator") == true)
                {
                    Main form = new Main();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Запись с такими данными не найдена. Перепроверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            //tb_login.Text = "dennyharmless@gmail.com";
            //tb_password.Text = "12345678";
            //tb_login.Text = "ivanov@mail.ru";
            //tb_password.Text = "1234567";
            TxtLogin.Text = "petrov@hotmail.com";
            TxtPassword.Text = "qwerty123";
            //Clipboard.SetText(GetHashedPassword(tbp_password.Text));
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tb_login_Validating(object sender, CancelEventArgs e)
        {
            if (Classes.Validations.ValidateEmail(TxtLogin.Text) == false)
            {
                BtnLogin.Enabled = false;
            }
            else
            {
                BtnLogin.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPasswordShow.CheckState == CheckState.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else if (CbPasswordShow.CheckState == CheckState.Unchecked)
                {
                    TxtPassword.UseSystemPasswordChar = true;
                }
        }

        private void LblRestore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestorePassword form = new RestorePassword();
            form.ShowDialog();
        }
    }
}
