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
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            GetStaffList();
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

        private void cb_staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetTicketsByAuthor", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                int converter;
                bool parseOK = Int32.TryParse(cb_staff.SelectedValue.ToString(), out converter);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", converter);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgv_details.DataSource = dt;

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

        private void cb_staff_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetStaffDetailsById", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                int converter;
                bool parseOK = Int32.TryParse(cb_staff.SelectedValue.ToString(), out converter);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", converter);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    tb_name.Text = dt.Rows[0]["ФИО"].ToString();
                    tb_email.Text = dt.Rows[0]["Эл. почта"].ToString();
                    mtb_phone.Text = dt.Rows[0]["Моб. номер"].ToString();
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("UpdateStaffDetails", Connection);
                int converter;
                bool parseOK = Int32.TryParse(cb_staff.SelectedValue.ToString(), out converter);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", converter);
                    cmd.Parameters.AddWithValue("@u_name", tb_name.Text);
                    cmd.Parameters.AddWithValue("@u_email", tb_email.Text);
                    cmd.Parameters.AddWithValue("@u_phone", mtb_phone.Text);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно изменены.", "Успех", MessageBoxButtons.OK);
                        GetStaffList();
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

        private void btn_create_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("CreateStaff", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_name", tb_name.Text);
                    cmd.Parameters.AddWithValue("@u_email", tb_email.Text);
                    cmd.Parameters.AddWithValue("@u_phone", mtb_phone.Text);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно добавлены");
                        GetStaffList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validations.ValidateEmail(tb_email.Text) == false)
            {
                MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_email.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
