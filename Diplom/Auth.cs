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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_login.Text))
            {
                MessageBox.Show("Вы не ввели логин. Пожалуйста повторите ввод.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(tb_password.Text))
            {
                MessageBox.Show("Вы не ввели пароль. Пожалуйста повторите ввод.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (Classes.AuthorizedUserInfo.AuthorizationOperator(tb_login, tb_password, "AuthorizationOperator") == true)
                {
                    Main form = new Main();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Запись с такими данными не найдена. Перепроверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            //tb_login.Text = "dennyharmless@gmail.com";
            //tb_password.Text = "12345678";
            //tb_login.Text = "ivanov@mail.ru";
            //tb_password.Text = "1234567";
            tb_login.Text = "petrov@hotmail.com";
            tb_password.Text = "qwerty123";
            //Clipboard.SetText(GetHashedPassword(tbp_password.Text));
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tb_login_Validating(object sender, CancelEventArgs e)
        {
            if (Classes.Validations.ValidateEmail(tb_login.Text) == false)
            {
                btn_login.Enabled = false;
            }
            else
            {
                btn_login.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                tb_password.UseSystemPasswordChar = false;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
                {
                    tb_password.UseSystemPasswordChar = true;
                }
        }

        private void LblRestore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestorePassword form = new RestorePassword();
            form.Show();
        }
    }
}
