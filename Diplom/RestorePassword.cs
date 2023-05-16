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
        // Восстановление через код
        private Label LblCode;
        private TextBox TxtCode;
        private Button BtnCodeSend;
        private Button BtnCodeConfirm;

        private int? confirmCode = null; // Код восстановления
        private bool codeButtonLocked = false;
        private bool formUnlocked = true;

        // Восстановление через секретное слово
        private Label LblSecret;
        private TextBox TxtSecret;
        private CheckBox CbSecret;
        private Button BtnSecretConfirm;

        private (string secret, int id) result;
        private string tempName;
        private int timeLeft = 0;

        public RestorePassword()
        {
            InitializeComponent();
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
                    BtnSecretConfirm = new Button
                    {
                        Name = "BtnSecretConfirm",
                        Text = "Подтвердить секрет",
                        Font = new Font("Microsoft Sans Serif", 9),
                        BackColor = SystemColors.Window,
                        Size = new Size(186, 27),
                        Location = new Point(0, 66)
                    };

                    CbSecret.CheckedChanged += CbSecret_CheckedChanged;
                    BtnSecretConfirm.Click += BtnSecretConfirm_Click;

                    PnlRecovery.Controls.Add(LblSecret);
                    PnlRecovery.Controls.Add(TxtSecret);
                    PnlRecovery.Controls.Add(CbSecret);
                    PnlRecovery.Controls.Add(BtnSecretConfirm);
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

        private void BtnSecretConfirm_Click(object sender, EventArgs e)
        {
            string secret = PasswordHash.GetHashedPassword(TxtSecret.Text); 
            string email = TxtLogin.Text;
            (bool isEmailValid, string validationMessage) validationResult = Classes.Validations.ValidateEmail(email);
            result = Classes.Database.GetSecretWordByLogin(email);

            if (!validationResult.isEmailValid)
            {
                MessageBox.Show(validationResult.validationMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, false);
                ErrEmail.SetError(TxtLogin, validationResult.validationMessage);
                return;
            }

            if ((result.secret == default) && (result.id == default))
            {
                MessageBox.Show("Запись с такими данными не найдена. Перепроверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, false);
                ErrEmail.SetError(TxtLogin, "Запись с такими данными не найдена");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtSecret.Text))
            {
                MessageBox.Show("Введите секретное слово", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, false);
                ErrEmail.SetError(TxtSecret, "Введите секретное слово");
                return;
            }

            if (secret != result.secret)
            {
                MessageBox.Show("Вы ввели неправильное секретное слово. Перепроверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, false);
                ErrEmail.SetError(TxtSecret, "Неправильный секрет");
                return;
            }


            ErrEmail.SetError(TxtLogin, null);
            ErrEmail.SetError(TxtSecret, null);
            successOk.SetError(TxtLogin, "Пользователь найден");
            successOk.SetError(TxtSecret, "Секрет указан правильно");
            EnableControls(new List<Control> { TxtLogin, CbRecoveryMode, CbSecret, TxtSecret, BtnSecretConfirm }, false);
            TxtSecret.UseSystemPasswordChar = true;
            EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, true);

            tempName = BtnSecretConfirm.Text;
            if (timeLeft <= 0)
            {
                timeLeft = 300000;
                BtnSecretConfirm.Enabled = false;
                codeButtonLocked = true;

                TmrSecret.Start();
            }
            
        }

        private void BtnCodeSend_Click(object sender, EventArgs e)
        {
            string email = TxtLogin.Text;
            (bool isEmailValid, string validationMessage) validationResult = Classes.Validations.ValidateEmail(email);
            result = Classes.Database.GetSecretWordByLogin(email);
            
            if (!validationResult.isEmailValid)
            {
                MessageBox.Show(validationResult.validationMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, false);
                ErrEmail.SetError(TxtLogin, validationResult.validationMessage);
                return;
            }

            if ((result.secret == default) && (result.id == default))
            {
                MessageBox.Show("Запись с такими данными не найдена. Перепроверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, false);
                ErrEmail.SetError(TxtLogin, "Запись с такими данными не найдена");
                return;
            }

            ErrEmail.SetError(TxtLogin, null);
            successOk.SetError(TxtLogin, "Пользователь найден");
            EnableControls(new List<Control> { TxtLogin, CbRecoveryMode }, false);
            SendEmailCode(result.id, email);
        }

        private void BtnCodeConfirm_Click(object sender, EventArgs e)
        {
            if (confirmCode == null)
            {
                MessageBox.Show("Вы не запрашивали код. Сначала запросите код подтверждения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtCode.Text))
            {
                MessageBox.Show("Введите код подтверждения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrEmail.SetError(TxtCode, "Введите код подтверждения");
                return;
            }

            if (!int.TryParse(TxtCode.Text, out int enteredCode))
            {
                MessageBox.Show("Код подтверждения должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrEmail.SetError(TxtCode, "Код подтверждения должен быть числом");
                return;
            }

            if (enteredCode != confirmCode)
            {
                MessageBox.Show("Вы ввели неправильный код подтверждения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrEmail.SetError(TxtCode, "Неправильный код");
                return;
            }

            if (enteredCode == confirmCode)
            {
                successOk.SetError(TxtCode, "Код введён правильно");
                ErrEmail.SetError(TxtCode, null);
                EnableControls(new List<Control> { TxtLogin, BtnCodeConfirm, CbRecoveryMode, BtnCodeSend }, false);
                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, true);
                return;
            }
        }

        private void CbSecret_CheckedChanged(object sender, EventArgs e)
        {
            TxtSecret.UseSystemPasswordChar = !CbSecret.Checked;
        }

        private void EnableControls(List<Control> controls, bool statement)
        {
            foreach (var control in controls)
            {
                control.Enabled = statement;
            }
        }

        private void SendEmailCode(int id, string email)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Система учёта обращений в тех. поддержку", "dennyharmless@gmail.com"));
            message.To.Add(new MailboxAddress("Пользователь №" + id, email));
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
                client.Connect(Properties.Settings.Default.SmtpServer, 587, SecureSocketOptions.StartTls);
                client.Authenticate(Properties.Settings.Default.SmtpEmail, Properties.Settings.Default.SmtpPassword);
                tempName = BtnCodeSend.Text;
                if (timeLeft <= 0)
                {
                    timeLeft = 300000;
                    BtnCodeSend.Enabled = false;
                    codeButtonLocked = true;
                    TmrEmail.Start();
                }
                client.Send(message);
                client.Disconnect(true);
            }
        }

        private void TmrEmail_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1000;
            EnableControls(new List<Control> { TxtLogin, CbRecoveryMode }, false);

            if (timeLeft <= 0)
            {
                confirmCode = null;
                EnableControls(new List<Control> { TxtLogin, TxtCode, CbRecoveryMode, BtnCodeConfirm, BtnCodeSend }, true);
                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, false);
                TxtLogin.Clear();
                TxtCode.Clear();
                successOk.SetError(TxtLogin, null);
                successOk.SetError(TxtCode, null);
                codeButtonLocked = false;
                TmrEmail.Stop();
                BtnCodeSend.Text = tempName;
            }
            else
            {
                BtnCodeSend.Text = $"Подождите {Math.Ceiling(timeLeft / 1000.0)} секунд";
            }
        }

        private void PicPasswordHelp_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.PicPasswordHelp, "Требования к паролю:\n- Не менее 6 символов\n- Без пробелов\n- Содержать 1 цифру \n- Содержать по 1 букве разных регистров");
        }

        private void CbPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = !CbPasswordShow.Checked;
            TxtPasswordRepeat.UseSystemPasswordChar = !CbPasswordShow.Checked;
        }

        private void TmrSecret_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1000;
            EnableControls(new List<Control> { TxtLogin, CbSecret, CbRecoveryMode, TxtSecret, BtnSecretConfirm }, false);

            if (timeLeft <= 0)
            {
                confirmCode = null;
                EnableControls(new List<Control> { TxtLogin, CbSecret, CbRecoveryMode, TxtSecret, BtnSecretConfirm }, true);
                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, false);
                TxtLogin.Clear();
                TxtSecret.Clear();
                successOk.SetError(TxtLogin, null);
                successOk.SetError(TxtSecret, null);
                codeButtonLocked = false;
                TmrSecret.Stop();
                BtnSecretConfirm.Text = tempName;
            }
            else
            {
                BtnSecretConfirm.Text = $"Подождите {Math.Ceiling(timeLeft / 1000.0)} секунд";
            }
        }

        private void RestorePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CbRecoveryMode.SelectedIndex == 0) 
            { 
                Properties.Settings.Default.TimerNumber = 0;
                Properties.Settings.Default.LastChoice = 0;
            }
            else if (CbRecoveryMode.SelectedIndex == 1) 
            {
                Properties.Settings.Default.TimerNumber = 1;
                Properties.Settings.Default.LastChoice = 1;
            }
            Properties.Settings.Default.TimerLeft = timeLeft;
            Properties.Settings.Default.Email = TxtLogin.Text;
            Properties.Settings.Default.Save();
        }

        private void RestorePassword_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void FormLoad()
        {
            CbRecoveryMode.SelectedIndex = 0;
            EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, false);
            timeLeft = Properties.Settings.Default.TimerLeft;
            CbRecoveryMode.SelectedIndex = Properties.Settings.Default.LastChoice;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Email))
            {
                TxtLogin.Text = Properties.Settings.Default.Email;
            }

            if (timeLeft > 0)
            {
                if (Properties.Settings.Default.TimerNumber == 0)
                {
                    TmrSecret.Start();
                }
                else if (Properties.Settings.Default.TimerNumber == 1)
                {
                    TmrEmail.Start();
                }

                EnableControls(new List<Control> { BtnReset, TxtPassword, TxtPasswordRepeat, CbPasswordShow }, true);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            (bool isPasswordValid, string validationMessage) validationResult= Classes.Validations.ValidatePassword(TxtPassword.Text);

            if (!validationResult.isPasswordValid)
            {
                MessageBox.Show(validationResult.validationMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrEmail.SetError(TxtPassword, validationResult.validationMessage);
                return;
            }

            if (string.IsNullOrEmpty(TxtPasswordRepeat.Text))
            {
                MessageBox.Show("Повторите новый пароль. Перепроверьте данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TxtPassword.Text != TxtPasswordRepeat.Text)
            {
                MessageBox.Show("Указанные пароли не совпадают. Перепроверьте данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrEmail.SetError(TxtPassword, "Пароли не совпадают");
                return;
            }


            ErrEmail.SetError(TxtPassword, null);
            successOk.SetError(TxtPassword, "Пароли совпадают");
            ResetPassword(TxtPassword.Text, result.id);
        }

        private void ResetPassword(string password, int id)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("ResetPassword", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@password", PasswordHash.GetHashedPassword(password));
                    cmd.Parameters.AddWithValue("@id", id);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Пароль успешно изменён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtLogin.Clear();
                        TxtPassword.Clear();
                        TxtPasswordRepeat.Clear();
                        CbRecoveryMode.SelectedIndex = 0;
                        successOk.SetError(TxtPassword, null);
                        FormLoad();
                        return;
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
    }
}
