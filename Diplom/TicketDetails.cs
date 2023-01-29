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
    public partial class TicketDetails : Form
    {
        private Tickets fromForm { get; set; }
        private int id;

        public TicketDetails(Tickets form)
        {
            InitializeComponent();
            fromForm = form;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            fromForm.GetTicketList();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateTicketStatusById();
        }

        private void TicketDetails_Load(object sender, EventArgs e)
        {
            GetStatusList();
            id = fromForm.currTicketId;
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetTicketInfoById", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", id);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    tb_id.Text = dt.Rows[0]["№ Запроса"].ToString();
                    tb_date.Text = dt.Rows[0]["Дата создания"].ToString();
                    tb_type.Text = dt.Rows[0]["Тип"].ToString();
                    cb_status.SelectedIndex = cb_status.FindString(dt.Rows[0]["Статус"].ToString());
                    tb_prio.Text = dt.Rows[0]["Приоритет"].ToString();
                    tb_author.Text = dt.Rows[0]["Автор"].ToString();
                    tb_misc.Text = dt.Rows[0]["Детали"].ToString();
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

        private void UpdateTicketStatusById()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("UpdateTicketStatusById", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", id);
                    cmd.Parameters.AddWithValue("@u_status", cb_status.SelectedValue);
                    Connection.Open();
                    cmd.ExecuteNonQuery();
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
