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
    public partial class Operators : Form
    {
        private string initialName;
        private string initialSurname;
        private string initialPatron;
        private string initialEmail;
        private string initialRole;



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

        private void UpdateOperatorInfo(int id)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("UpdateOperatorInfo", Connection);

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", id);
                    cmd.Parameters.AddWithValue("@u_surname", TxtSurname.Text);
                    cmd.Parameters.AddWithValue("@u_name", TxtName.Text);
                    cmd.Parameters.AddWithValue("@u_patron", TxtPatron.Text);
                    cmd.Parameters.AddWithValue("@u_shortname", $"{TxtSurname.Text} {TxtName.Text[0]}.{TxtPatron.Text[0]}.");
                    cmd.Parameters.AddWithValue("@u_email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@u_role", CbRole.SelectedItem.ToString());
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно изменены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        initialSurname = TxtSurname.Text;
                        initialName = TxtName.Text;
                        initialPatron = TxtPatron.Text;
                        initialEmail = TxtEmail.Text;
                        initialRole = CbRole.SelectedItem.ToString();

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

        private void CreateOperator()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("CreateOperator", Connection);

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_surname", TxtSurname.Text);
                    cmd.Parameters.AddWithValue("@u_name", TxtName.Text);
                    cmd.Parameters.AddWithValue("@u_patron", TxtPatron.Text);
                    cmd.Parameters.AddWithValue("@u_shortname", $"{TxtSurname.Text} {TxtName.Text[0]}.{TxtPatron.Text[0]}.");
                    cmd.Parameters.AddWithValue("@u_email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@u_role", CbRole.SelectedItem.ToString());
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно добавлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MySqlCommand cmd = new MySqlCommand("DeleteStaff", Connection);

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
            if (string.IsNullOrWhiteSpace(TxtSurname.Text) || string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtPatron.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(CbRole.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = TxtEmail.Text;
            (bool isEmailValid, string validationMessage) validationResult = Classes.Validations.ValidateEmail(email);

            if (!validationResult.isEmailValid)
            {
                MessageBox.Show(validationResult.validationMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = GetSelectedOperatorId();

            if (!string.Equals(TxtSurname.Text, initialSurname) || !string.Equals(TxtName.Text, initialName) || !string.Equals(TxtPatron.Text, initialPatron) || !string.Equals(TxtEmail.Text, initialEmail) || !string.Equals(CbRole.Text, initialRole))
            {
                DialogResult dr = MessageBox.Show("Вы действительно хотите изменить данные сотрудника " + CbSearchOperators.Text + "?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    UpdateOperatorInfo(id);
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
            if (string.IsNullOrWhiteSpace(TxtSurname.Text) || string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtPatron.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(CbRole.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = TxtEmail.Text;
            (bool isEmailValid, string validationMessage) validationResult = Classes.Validations.ValidateEmail(email);

            if (!validationResult.isEmailValid)
            {
                MessageBox.Show(validationResult.validationMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateOperator();
        }
    }
}
