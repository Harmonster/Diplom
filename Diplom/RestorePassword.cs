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
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace Diplom
{
    public partial class RestorePassword : Form
    {
        private Label LblCode;
        private TextBox TxtCode;
        private Button BtnCodeSend;
        private Button BtnCodeConfirm;
        private Label LblSecret;
        private TextBox TxtSecret;
        private CheckBox CbSecret;

        private (string str, int iid) result;
        private string secret = null;
        private string tempName;
        private int id;
        private int timeLeft = 0;
        private int? confirmCode = null;
        private bool codeButtonLocked = false;
        private bool codeConfirmed = false;

        public RestorePassword()
        {
            InitializeComponent();
            CbRecoveryMode.SelectedIndex = 0;
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            result = Classes.Database.GetSecretWordByLogin(TxtLogin.Text);
            secret = result.str;
            id = result.iid;

            if (secret != null)
            {
                ErrEmail.SetError(TxtLogin, null);
                btnReset.Enabled = true;
            }
            else if (secret == null)
            {
                btnReset.Enabled = false;
                ErrEmail.SetError(TxtLogin, "Запись с такими данными не найдена");
                MessageBox.Show("Запись с такими данными не найдена. Перепроверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (txtSecret.Text == secret)
        //    {
        //        if (txtPassword.Text.Equals(txtPasswordRepeat.Text))
        //        {
        //            if (Classes.Validations.ValidatePassword(txtPassword.Text) == true)
        //            {
        //                using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
        //                {
        //                    MySqlCommand cmd = new MySqlCommand("ResetPassword", Connection);
        //                    try
        //                    {
        //                        cmd.CommandType = CommandType.StoredProcedure;
        //                        cmd.Parameters.AddWithValue("@password", PasswordHash.GetHashedPassword(txtPassword.Text));
        //                        cmd.Parameters.AddWithValue("@id", id);
        //                        Connection.Open();
        //                        if (cmd.ExecuteNonQuery() > 0)
        //                        {
        //                            MessageBox.Show("Пароль успешно изменён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        }
        //                    }
        //                    catch (Exception)
        //                    {
        //                        throw;
        //                    }
        //                    finally
        //                    {
        //                        cmd.Dispose();
        //                        Connection.Close();
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Введённые пароли не совпадают. Перепроверьте данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Вы ввели неправильное секретное слово. Перепроверьте данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите закрыть окно восстановления пароля?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
                
        }


        private void TxtLogin_Validating(object sender, CancelEventArgs e)
        {
            result = Classes.Database.GetSecretWordByLogin(TxtLogin.Text);
            secret = result.str;
            id = result.iid;

            if (secret != null)
            {
                ErrEmail.SetError(TxtLogin, null);
                btnReset.Enabled = true; 
            }
            else if (secret == null)
            {
                btnReset.Enabled = false;
                ErrEmail.SetError(TxtLogin, "Запись с такими данными не найдена");
                MessageBox.Show("Запись с такими данными не найдена. Перепроверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RestorePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }

        private void BtnCodeConfirm_Click(object sender, EventArgs e)
        {
            if (confirmCode == null)
            {
                MessageBox.Show("Вы не запрашивали код. Нажмите кнопку отправки кода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codeConfirmed = false;
                return;
            }
            else if (TxtCode.Text != confirmCode.ToString())
            {
                MessageBox.Show("Вы ввели неправильный код подтверждения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                codeConfirmed = false;
                return;
            }
            else if (TxtCode.Text == confirmCode.ToString())
            {
                MessageBox.Show("Код правильный");
                codeConfirmed = true;
            }
        }

        private void BtnCodeSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtLogin.Text))
            {
                SendEmailCode();
            }
            else
            {
                MessageBox.Show("Вы не ввели адрес электронной почты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendEmailCode()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Система учёта обращений в тех. поддержку", "dennyharmless@gmail.com"));
            message.To.Add(new MailboxAddress("Пользователь №" + id, TxtLogin.Text));
            message.Subject = "Восстановление пароля";

            Random rand = new Random();
            int code = rand.Next(100000, 999999);
            confirmCode = code;

            var builder = new StringBuilder();
            builder.AppendLine("Для восстановления пароля введите следующий код подтверждения:");
            builder.AppendLine(code.ToString());
            message.Body = new TextPart("plain")
            {
                Text = builder.ToString()
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate("dennyharmless@gmail.com", "vzvmepndhxgecqko");

                tempName = BtnCodeSend.Text;
                if (timeLeft <= 0)
                {
                    // Делаем кнопку неактивной на 5 минут
                    timeLeft = 5 * 60 * 1000; // 5 минут в миллисекундах
                    BtnCodeSend.Enabled = false;
                    codeButtonLocked = true;
                    TmrEmail.Start();
                }
                client.Send(message);
                client.Disconnect(true);
            }
        }

        private void CbRecoveryMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbRecoveryMode.SelectedIndex)
            {
                case 0:
                    PnlRecovery.Controls.Clear();
                    LblSecret = new Label
                    {
                        Name = "LblSecret",
                        Text = "Секретное слово",
                        Font = new Font("Microsoft Sans Serif", 9),
                        Size = new Size(121, 16),
                        Location = new Point(0, 0)
                    };
                    TxtSecret = new TextBox
                    {
                        Name = "TxtSecret",
                        Font = new Font("Microsoft Sans Serif", 9),
                        Size = new Size(186, 22),
                        UseSystemPasswordChar = true,
                        Location = new Point(0, 20)
                    };
                    CbSecret = new CheckBox
                    {
                        Name = "CbSecret",
                        Text = "Показать",
                        Font = new Font("Microsoft Sans Serif", 9),
                        Size = new Size(186, 22),
                        Location = new Point(0, 42)
                    };

                    CbSecret.CheckedChanged += CbSecret_CheckedChanged;

                    PnlRecovery.Controls.Add(LblSecret);
                    PnlRecovery.Controls.Add(TxtSecret);
                    PnlRecovery.Controls.Add(CbSecret);
                    break;

                case 1:
                    PnlRecovery.Controls.Clear();
                    LblCode = new Label
                    {
                        Name = "LblCode",
                        Text = "Код подтверждения",
                        Font = new Font("Microsoft Sans Serif", 9),
                        Size = new Size(186, 16),
                        Location = new Point(0, 0)
                    };
                    TxtCode = new TextBox
                    {
                        Name = "TxtCode",
                        Font = new Font("Microsoft Sans Serif", 9),
                        Size = new Size(186, 22),
                        Location = new Point(0, 20)
                    };
                    BtnCodeSend = new Button
                    {
                        Name = "BtnCodeSend",
                        Text = "Отправить код",
                        Font = new Font("Microsoft Sans Serif", 9),
                        BackColor = SystemColors.Window,
                        Size = new Size(186, 27),
                        Location = new Point(0, 72)
                    };
                    BtnCodeConfirm = new Button
                    {
                        Name = "BtnCodeConfirm",
                        Text = "Подтвердить код",
                        Font = new Font("Microsoft Sans Serif", 9),
                        BackColor = SystemColors.Window,
                        Size = new Size(186, 27),
                        Location = new Point(0, 44)
                    };

                    BtnCodeConfirm.Click += BtnCodeConfirm_Click;
                    BtnCodeSend.Click += BtnCodeSend_Click;

                    if (codeButtonLocked == true)
                    {
                        BtnCodeSend.Enabled = false;
                    }
                    else
                    {
                        BtnCodeSend.Enabled = true;
                    }

                    PnlRecovery.Controls.Add(LblCode);
                    PnlRecovery.Controls.Add(TxtCode);
                    PnlRecovery.Controls.Add(BtnCodeConfirm);
                    PnlRecovery.Controls.Add(BtnCodeSend);
                    break;
            }
        }

        private void TmrEmail_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1000;
            if (timeLeft <= 0)
            {
                BtnCodeSend.Enabled = true;
                codeButtonLocked = false;
                TmrEmail.Stop();
                BtnCodeSend.Text = tempName;
            }
            else
            {
                BtnCodeSend.Text = $"Подождите {Math.Ceiling(timeLeft / 1000.0)} секунд";
            }
        }

        private void CbPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = !CbPasswordShow.Checked;
            TxtPasswordRepeat.UseSystemPasswordChar = !CbPasswordShow.Checked;
        }

        private void CbSecret_CheckedChanged(object sender, EventArgs e)
        {
            TxtSecret.UseSystemPasswordChar = !CbSecret.Checked;
        }
    }
}
