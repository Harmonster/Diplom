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
        private int currentPage, offset;
        private int id;

        public TicketDetails(Tickets form, int currentTicketId, int page, int query_offset)
        {
            InitializeComponent();
            id = currentTicketId;
            fromForm = form;
            currentPage = page;
            offset = query_offset;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            fromForm.FormLoad(currentPage, offset);
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите изменить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                UpdateTicketStatusById();
            }
            else
                return;
        }

        private void TicketDetails_Load(object sender, EventArgs e)
        {
            Classes.Database.GetTableContent(cb_prio, "GetPriorityList", "ticket_priority", "name_priority", "id_priority");
            Classes.Database.GetTableContent(cb_status, "GetStatusList", "ticket_status", "name_status", "id_status");
            Classes.Database.GetTableContent(cb_type, "GetTypeList", "ticket_priority", "name_type", "id_type");

            if (Classes.AuthorizedUserInfo.UserRole == "Администратор")
            {
                tb_type.Hide();
                tb_prio.Hide();
            }
            else
            {
                cb_type.Hide();
                cb_prio.Hide();
            }

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
                    cb_status.SelectedIndex = cb_status.FindString(dt.Rows[0]["Статус"].ToString());

                    if (Classes.AuthorizedUserInfo.UserRole == "Администратор")
                    {
                        cb_type.SelectedIndex = cb_type.FindString(dt.Rows[0]["Тип"].ToString());
                        cb_prio.SelectedIndex = cb_prio.FindString(dt.Rows[0]["Приоритет"].ToString());
                    }
                    else
                    {
                        tb_type.Text = dt.Rows[0]["Тип"].ToString();
                        tb_prio.Text = dt.Rows[0]["Приоритет"].ToString();
                    }

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

        private void UpdateTicketStatusById()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("UpdateTicketStatusById", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@u_id", id);
                    if ((cb_type.Visible == true) && (cb_prio.Visible == true))
                    {
                        cmd.Parameters.AddWithValue("@u_type", cb_type.SelectedValue);
                        cmd.Parameters.AddWithValue("@u_status", cb_status.SelectedValue);
                        cmd.Parameters.AddWithValue("@u_priority", cb_prio.SelectedValue);
                    }
                    else
                    {
                        if (tb_type.Text == "Ошибка")
                            cmd.Parameters.AddWithValue("@u_type", 1);
                        else if (tb_type.Text == "Критическая ошибка")
                            cmd.Parameters.AddWithValue("@u_type", 2);
                        else if (tb_type.Text == "Пожелание")
                            cmd.Parameters.AddWithValue("@u_type", 3);
                        else if (tb_type.Text == "Запрос")
                            cmd.Parameters.AddWithValue("@u_type", 4);
                        else if (tb_type.Text == "Отзыв")
                            cmd.Parameters.AddWithValue("@u_type", 5);
                        else if (tb_type.Text == "Не указано")
                            cmd.Parameters.AddWithValue("@u_type", 6);

                        if (tb_prio.Text == "Обычный")
                            cmd.Parameters.AddWithValue("@u_priority", 1);
                        else if (tb_prio.Text == "Средний")
                            cmd.Parameters.AddWithValue("@u_priority", 2);
                        else if (tb_prio.Text == "Срочный")
                            cmd.Parameters.AddWithValue("@u_priority", 3);
                        else if (tb_prio.Text == "Не указано")
                            cmd.Parameters.AddWithValue("@u_priority", 4);

                        cmd.Parameters.AddWithValue("@u_status", cb_status.SelectedValue);
                        
                    }
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные успешно обновлены");
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
