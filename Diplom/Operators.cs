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
    public partial class Operators : Form
    {
        private string initialName;
        private string initialSurname;
        private string initialPatron;
        private string initialEmail;
        private string initialRole;

        private Random random = new Random();


        public Operators()
        {
            InitializeComponent();
        }

        private void Operators_Load(object sender, EventArgs e)
        {
            Classes.Database.GetTableContent(CbSearchOperators, "GetOperatorList", "operators", "ФИО", "№");
            CbRole.SelectedIndex = 0;
        }

        private int GetSelectedOperatorId()
        {
            int converter;
            bool parseOK = Int32.TryParse(CbSearchOperators.SelectedValue.ToString(), out converter);
            return converter;
        }

        private void CbSearchOperators_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = GetSelectedOperatorId();
            GetOperatorDetails(id);
        }

        private void GetOperatorDetails(int id)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmdDetails = new MySqlCommand("GetOperatorInfoById", Connection);
                MySqlDataAdapter daDetails = new MySqlDataAdapter();
                DataTable dtDetails = new DataTable();
                string role = null;

                try
                {
                    Connection.Open();

                    cmdDetails.CommandType = CommandType.StoredProcedure;
                    cmdDetails.Parameters.AddWithValue("@u_id", id);
                    daDetails.SelectCommand = cmdDetails;
                    daDetails.Fill(dtDetails);

                    if (dtDetails.Rows.Count > 0)
                    {
                        TxtSurname.Text = dtDetails.Rows[0]["Фамилия"].ToString();
                        TxtName.Text = dtDetails.Rows[0]["Имя"].ToString();
                        TxtPatron.Text = dtDetails.Rows[0]["Отчество"].ToString();
                        TxtEmail.Text = dtDetails.Rows[0]["Эл. почта"].ToString();
                        role = dtDetails.Rows[0]["Роль"].ToString();
                        CbRole.SelectedIndex = CbRole.FindString(role);

                        initialSurname = TxtSurname.Text;
                        initialName = TxtName.Text;
                        initialPatron = TxtPatron.Text;
                        initialEmail = TxtEmail.Text;
                        initialRole = role;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                finally
                {
                    cmdDetails.Dispose();
                    daDetails.Dispose();
                    Connection.Close();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSurname.Text) || string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtPatron.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(CbRole.Text))
            {
                MessageBox.Show("Пожалуйста, выберите оператора для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = GetSelectedOperatorId();

            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись об операторе " + CbSearchOperators.Text + " ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DeleteOperator(id);
            }
        }

        //private void UpdateOperatorInfo(int id)
        //{
        //    using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
        //    {
        //        MySqlCommand cmd = new MySqlCommand("UpdateOperatorInfo", Connection);

        //        try
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@u_id", id);
        //            cmd.Parameters.AddWithValue("@u_surname", TxtSurname.Text);
        //            cmd.Parameters.AddWithValue("@u_name", TxtName.Text);
        //            cmd.Parameters.AddWithValue("@u_patron", TxtPatron.Text);
        //            cmd.Parameters.AddWithValue("@u_shortname", $"{TxtSurname.Text} {TxtName.Text[0]}.{TxtPatron.Text[0]}.");
        //            cmd.Parameters.AddWithValue("@u_email", TxtEmail.Text);
        //            cmd.Parameters.AddWithValue("@u_role", CbRole.SelectedItem.ToString());
        //            Connection.Open();
        //            if (cmd.ExecuteNonQuery() > 0)
        //            {
        //                MessageBox.Show("Данные успешно изменены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                initialSurname = TxtSurname.Text;
        //                initialName = TxtName.Text;
        //                initialPatron = TxtPatron.Text;
        //                initialEmail = TxtEmail.Text;
        //                initialRole = CbRole.SelectedItem.ToString();

        //                Classes.Database.GetTableContent(CbSearchOperators, "GetOperatorList", "operators", "ФИО", "№");
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        finally
        //        {
        //            cmd.Dispose();
        //            Connection.Close();
        //        }
        //    }
        //}

        private void UpdateOperator(int id, string surname, string name, string patron, string email, string role)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("UpdateOperatorInfo", Connection);

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", id);
                    cmd.Parameters.AddWithValue("@u_surname", surname);
                    cmd.Parameters.AddWithValue("@u_name", name);
                    cmd.Parameters.AddWithValue("@u_patron", patron);
                    cmd.Parameters.AddWithValue("@u_shortname", $"{surname} {name[0]}.{patron[0]}.");
                    cmd.Parameters.AddWithValue("@u_email", email);
                    cmd.Parameters.AddWithValue("@u_role", role);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно изменены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        initialSurname = surname;
                        initialName = name;
                        initialPatron = patron;
                        initialEmail = email;
                        initialRole = role;
                        Classes.Database.GetTableContent(CbSearchOperators, "GetOperatorList", "operators", "ФИО", "№");
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

        private void AddOperator(string surname, string name, string patron, string email, string role)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("CreateOperator", Connection);
                string password = Classes.PasswordGenerator.GeneratePassword(6);

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_surname", surname);
                    cmd.Parameters.AddWithValue("@u_name", name);
                    cmd.Parameters.AddWithValue("@u_patron", patron);
                    cmd.Parameters.AddWithValue("@u_shortname", $"{surname} {name[0]}.{patron[0]}.");
                    cmd.Parameters.AddWithValue("@u_email", email);
                    cmd.Parameters.AddWithValue("@u_password", Classes.HashHelper.GetHashedValue(password));
                    cmd.Parameters.AddWithValue("@u_role", role);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно добавлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SendEmailPassword(email, password);
                        Classes.Database.GetTableContent(CbSearchOperators, "GetOperatorList", "operators", "ФИО", "№");
                    }
                }
                catch (Exception ex)
                {
                    if (ex is MySqlException mysqlEx && mysqlEx.Number == (int)MySqlErrorCode.DuplicateKeyEntry)
                    {
                        MessageBox.Show("Оператор с такими данными уже зарегистрирован. Введите другие данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }

        private void DeleteOperator(int id)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("DeleteOperator", Connection);

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", id);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данный оператор успешно удален.", "Успех", MessageBoxButtons.OK);
                        Classes.Database.GetTableContent(CbSearchOperators, "GetOperatorList", "operators", "ФИО", "№");
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string surname = TxtSurname.Text;
            string name = TxtName.Text;
            string patron = TxtPatron.Text;
            string email = TxtEmail.Text;
            string role = CbRole.Text;

            if (string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(patron) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Classes.Validations.IsAllLetters(surname) || !Classes.Validations.IsAllLetters(name) || !Classes.Validations.IsAllLetters(patron))
            {
                MessageBox.Show("Поля Фамилия, Имя, Отчество должны содержать только буквы");
                return;
            }

            (bool isEmailValid, string validationMessage) validationResult = Classes.Validations.ValidateEmail(email);

            if (!validationResult.isEmailValid)
            {
                MessageBox.Show(validationResult.validationMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = GetSelectedOperatorId();

            if (!string.Equals(surname, initialSurname) || !string.Equals(name, initialName) || !string.Equals(patron, initialPatron) || !string.Equals(email, initialEmail) || !string.Equals(role, initialRole))
            {
                DialogResult dr = MessageBox.Show("Вы действительно хотите изменить данные сотрудника " + CbSearchOperators.Text + "?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    UpdateOperator(id, surname, name, patron, email, role);
                }
            }
            else
            {
                MessageBox.Show("Данные не изменились. Обновление не требуется.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtSurname.Clear();
            TxtName.Clear();
            TxtPatron.Clear();
            TxtEmail.Clear();
            CbRole.SelectedIndex = 0;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string surname = TxtSurname.Text;
            string name = TxtName.Text;
            string patron = TxtPatron.Text;
            string email = TxtEmail.Text;
            string role = CbRole.Text;

            if (string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(patron) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            (bool isEmailValid, string validationMessage) validationResult = Classes.Validations.ValidateEmail(email);

            if (!validationResult.isEmailValid)
            {
                MessageBox.Show(validationResult.validationMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddOperator(surname, name, patron, email, role);
        }

        private void SendEmailPassword(string email, string password)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Система учёта обращений в тех. поддержку", Properties.Settings.Default.SmtpEmail));
            message.To.Add(new MailboxAddress("Оператор", email));
            message.Subject = "Регистрация учетной записи оператора";

            var builder = new StringBuilder();
            builder.AppendLine("Данный почтовый адрес был использован для регистрации в системе учёта обращений тех. поддержку.");
            builder.AppendLine("Пожалуйста, используйте присланный пароль для первого входа в программу. Далее система предложит вам создать новый пароль.");
            builder.AppendLine("Пароль: " + password);
            builder.AppendLine("Если вы уверены что это письмо пришло к Вам по ошибке, пожалуйста проигнорируйте его.");
            message.Body = new TextPart("plain")
            {
                Text = builder.ToString()
            };

            using (var client = new SmtpClient())
            {
                client.Connect(Properties.Settings.Default.SmtpServer, 587, SecureSocketOptions.StartTls);
                client.Authenticate(Properties.Settings.Default.SmtpEmail, Properties.Settings.Default.SmtpPassword);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}

