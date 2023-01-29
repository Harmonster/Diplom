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
    public partial class Tickets : Form
    {
        public int currTicketId;

        public Tickets()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            GetTicketList();
        }

        public void GetTicketList()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetTicketList", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgv_tickets.DataSource = dt;

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

        private void GetTicketsByPriority(DataGridView dgv, string temp)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetTicketsByPriority", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@priority", temp);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgv.DataSource = dt;

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

        private void cb_searchByPriority_SelectedValueChanged(object sender, EventArgs e)
        {
            string currValue = (string)cb_searchByPriority.SelectedItem;

            switch (currValue)
            {
                case "Обычные":
                    GetTicketsByPriority(dgv_tickets, "Обычный");
                    break;
                case "Средние":
                    GetTicketsByPriority(dgv_tickets, "Средний");
                    break;
                case "Срочные":
                    GetTicketsByPriority(dgv_tickets, "Срочный");
                    break;
                case "Все":
                    GetTicketList();
                    break;
            }
        }

        private void tbp_search_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetTicketsByLike", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                if (tbp_search.Text == string.Empty) { GetTicketList(); }
                else 
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@input", tbp_search.Text);
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        dgv_tickets.DataSource = dt;
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

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetTicketsByDate", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@input", dtp_date.Value);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgv_tickets.DataSource = dt;

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

        private void btn_ticketCreate_Click(object sender, EventArgs e)
        {
            CreateTicket f = new CreateTicket(this);
            f.ShowDialog();
        }

        private void dgv_tickets_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TicketDetails f = new TicketDetails(this);
            f.ShowDialog();
        }

        private void dgv_tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_tickets.Rows[e.RowIndex];
                currTicketId = (int)row.Cells[0].Value;
            }

        }
    }
}
