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
    public partial class Staff : Form
    {
        string initialName;
        string initialSurname;
        string initialPatron;
        string initialEmail;
        string initialPhone;

        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            Classes.Database.GetTableContent(CbStaff, "GetStaffList", "staff", "ФИО", "№");


            if (Classes.AuthorizedUserInfo.UserRole != "Администратор")
            {
                BtnDelete.Hide();
            }
        }

        private void CbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmdDetails = new MySqlCommand("GetStaffDetailsById", Connection);
                MySqlCommand cmdTickets = new MySqlCommand("GetTicketsByAuthor", Connection);
                MySqlDataAdapter daDetails = new MySqlDataAdapter();
                MySqlDataAdapter daTickets = new MySqlDataAdapter();
                DataTable dtDetails = new DataTable();
                DataTable dtTickets = new DataTable();

                int converter;
                bool parseOK = Int32.TryParse(CbStaff.SelectedValue.ToString(), out converter);

                try
                {
                    Connection.Open();

                    cmdDetails.CommandType = CommandType.StoredProcedure;
                    cmdDetails.Parameters.AddWithValue("@u_id", converter);
                    daDetails.SelectCommand = cmdDetails;
                    daDetails.Fill(dtDetails);

                    if (dtDetails.Rows.Count > 0)
                    {
                        TxtSurname.Text = dtDetails.Rows[0]["Фамилия"].ToString();
                        TxtName.Text = dtDetails.Rows[0]["Имя"].ToString();
                        TxtPatron.Text = dtDetails.Rows[0]["Отчество"].ToString();
                        TxtEmail.Text = dtDetails.Rows[0]["Эл. почта"].ToString();
                        TxtPhone.Text = dtDetails.Rows[0]["Моб. номер"].ToString();

                        initialSurname = TxtSurname.Text;
                        initialName = TxtName.Text;
                        initialPatron = TxtPatron.Text;
                        initialEmail = TxtEmail.Text;
                        initialPhone = TxtPhone.Text;

                    }

                    cmdTickets.CommandType = CommandType.StoredProcedure;
                    cmdTickets.Parameters.AddWithValue("@u_id", converter);
                    daTickets.SelectCommand = cmdTickets;
                    daTickets.Fill(dtTickets);
                    dgv_details.DataSource = dtTickets;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                finally
                {
                    cmdDetails.Dispose();
                    cmdTickets.Dispose();
                    daDetails.Dispose();
                    daTickets.Dispose();
                    Connection.Close();
                }
            }
        }

        private void UpdateStaff()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("UpdateStaffDetails", Connection);
                int converter;
                bool parseOK = Int32.TryParse(CbStaff.SelectedValue.ToString(), out converter);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", converter);
                    cmd.Parameters.AddWithValue("@u_surname", TxtSurname.Text);
                    cmd.Parameters.AddWithValue("@u_name", TxtName.Text);
                    cmd.Parameters.AddWithValue("@u_patron", TxtPatron.Text);
                    cmd.Parameters.AddWithValue("@u_shortname", $"{TxtSurname.Text} {TxtName.Text[0]}.{TxtPatron.Text[0]}.");
                    cmd.Parameters.AddWithValue("@u_email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@u_phone", TxtPhone.Text);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно изменены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        initialSurname = TxtSurname.Text;
                        initialName = TxtName.Text;
                        initialPatron = TxtPatron.Text;
                        initialEmail = TxtEmail.Text;
                        initialPhone = TxtPhone.Text;

                        Classes.Database.GetTableContent(CbStaff, "GetStaffList", "staff", "ФИО", "№");
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

        private void DeleteStaff()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("DeleteStaff", Connection);
                int converter;
                bool parseOK = Int32.TryParse(CbStaff.SelectedValue.ToString(), out converter);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", converter);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные сотрудника успешно удалены.", "Успех", MessageBoxButtons.OK);
                        Classes.Database.GetTableContent(CbStaff, "GetStaffList", "staff", "ФИО", "№");
                    }
                }
                catch (Exception ex)
                {
                    if (ex is MySqlException mysqlEx && mysqlEx.Number == (int)MySqlErrorCode.RowIsReferenced2)
                    {
                        MessageBox.Show("Вы не можете удалить пользователя который оставлял заявки. Сначала нужно удалить их.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }

        private void CreateStaff()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("CreateStaff", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_surname", TxtSurname.Text);
                    cmd.Parameters.AddWithValue("@u_name", TxtName.Text);
                    cmd.Parameters.AddWithValue("@u_patron", TxtPatron.Text);
                    cmd.Parameters.AddWithValue("@u_shortname", $"{TxtSurname.Text} {TxtName.Text[0]}.{TxtPatron.Text[0]}.");
                    cmd.Parameters.AddWithValue("@u_email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@u_phone", TxtPhone.Text);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно добавлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Classes.Database.GetTableContent(CbStaff, "GetStaffList", "staff", "ФИО", "№");
                    }
                }
                catch (Exception ex)
                {
                    if (ex is MySqlException mysqlEx && mysqlEx.Number == (int)MySqlErrorCode.DuplicateKeyEntry)
                    {
                        MessageBox.Show("Сотрудник с такими данными уже зарегистрирован. Введите другие данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }
        
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSurname.Text) || string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtPatron.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPhone.Text))
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

            if (TxtSurname.Text != initialSurname || TxtName.Text != initialName || TxtPatron.Text != initialPatron || TxtEmail.Text != initialEmail || TxtPhone.Text != initialPhone)
            {
                DialogResult dr = MessageBox.Show("Вы действительно хотите изменить данные сотрудника " + CbStaff.Text + "?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    UpdateStaff();
                }
            }
            else
            {
                MessageBox.Show("Данные не изменились. Обновление не требуется.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSurname.Text) || string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtPatron.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPhone.Text))
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

            CreateStaff();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSurname.Text) || string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtPatron.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись о сотруднике " + CbStaff.Text + " ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DeleteStaff();
            } 
            else if (dr == DialogResult.No)
            {
                return;
            }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtSurname.Clear();
            TxtName.Clear();
            TxtPatron.Clear();
            TxtEmail.Clear();
            TxtPhone.Clear();
            dgv_details.DataSource = null;
        }
    }
}
