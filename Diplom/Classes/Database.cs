using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom.Classes
{
    public class Database
    {
        /// <summary>
        /// Заполнение таблицы записями из БД
        /// </summary>
        /// <param name="dgv">Таблица DataGridView</param>
        /// <param name="storedProcedureName">Имя хранимой процедуры</param>
        public static void GetTicketList(DataGridView dgv, string storedProcedureName)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(storedProcedureName, Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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

        /// <summary>
        /// Заполнение таблицы записями из БД используется LIMIT OFFSET для пагинации
        /// </summary>
        /// <param name="dgv">Таблица DataGridView</param>
        /// <param name="storedProcedureName">Имя хранимой процедуры</param>
        /// <param name="paginationSize">Размер страницы</param>
        /// <param name="paginationStartIndex">Индекс откуда будет выводится</param>
        public static void GetTicketList(DataGridView dgv, string storedProcedureName, int paginationSize, int paginationStartIndex)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(storedProcedureName, Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@paginationSize", paginationSize);
                    cmd.Parameters.AddWithValue("@paginationStart", paginationStartIndex);
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
        /// <summary>
        /// Запрос количества записей в БД
        /// </summary>
        /// <returns>Количество записей</returns>
        public static int GetTicketsCount()
        {
            int ticketsCount = 0;
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetTicketsCount", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    Connection.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        ticketsCount = Convert.ToInt32(rdr["COUNT(`id_ticket`)"]);
                    }
                    return ticketsCount;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    Connection.Close();
                    cmd.Dispose();
                }
            }
        }

        public static void GetTableContent(ComboBox cb, string storedProcedureName, string tableName, string cb_displayMember, string cb_valueMember)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(storedProcedureName, Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, tableName);
                    cb.DataSource = ds.Tables[tableName];
                    cb.DisplayMember = cb_displayMember;
                    cb.ValueMember = cb_valueMember;
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

        public static void Search(DataGridView dgv, string storedProcedureName, string searchText)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(storedProcedureName, Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                if (searchText == string.Empty)
                {
                    Tickets form = new Tickets();
                    form.FormLoad();
                }
                else
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@input", searchText);
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
        }

        public static void SearchDate(DataGridView dgv)
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
        public static void DeleteTicketById(int id)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("DeleteTicketById", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@input", id);
                    Connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Запись успешна удалена.", "Успех", MessageBoxButtons.OK);
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
