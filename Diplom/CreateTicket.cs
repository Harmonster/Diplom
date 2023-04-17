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
    public partial class CreateTicket : Form
    {
        private Tickets fromForm { get; set; }
        private int currentPage, offset;

        public CreateTicket(Tickets form, int page, int query_offset)
        {
            InitializeComponent();
            fromForm = form;
            currentPage = page;
            offset = query_offset;
        }

        private void CreateTicket_Load(object sender, EventArgs e)
        {
            GetStaffList();
            GetStatusList();
            GetPriorityList();
            GetTypeList();
        }

        private void GetStaffList()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetStaffList", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "staff");
                    cb_staff.DataSource = ds.Tables["staff"];
                    cb_staff.DisplayMember = "ФИО";
                    cb_staff.ValueMember = "№";

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

        private void GetStatusList()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetStatusList", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "ticket_status");
                    cb_status.DataSource = ds.Tables["ticket_status"];
                    cb_status.DisplayMember = "name_status";
                    cb_status.ValueMember = "id_status";
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

        private void GetPriorityList()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetPriorityList", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "ticket_priority");
                    cb_priority.DataSource = ds.Tables["ticket_priority"];
                    cb_priority.DisplayMember = "name_priority";
                    cb_priority.ValueMember = "id_priority";
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

        private void GetTypeList()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetTypeList", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "ticket_priority");
                    cb_type.DataSource = ds.Tables["ticket_priority"];
                    cb_type.DisplayMember = "name_type";
                    cb_type.ValueMember = "id_type";
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            fromForm.FormLoad(currentPage, offset);
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("CreateTicket", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_type", cb_type.SelectedValue); // Тип
                    cmd.Parameters.AddWithValue("@u_status", cb_status.SelectedValue); // Статус
                    cmd.Parameters.AddWithValue("@u_prio", cb_priority.SelectedValue); // Приоритет
                    cmd.Parameters.AddWithValue("@u_author", cb_staff.SelectedValue); // Автор
                    cmd.Parameters.AddWithValue("@u_date", DateTime.Now.ToString("yyyy-MM-dd")); // Текущая дата и время
                    cmd.Parameters.AddWithValue("@u_misc", tb_misc.Text); // Детали
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно добавлены");
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
