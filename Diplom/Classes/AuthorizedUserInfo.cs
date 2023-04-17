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
    public class AuthorizedUserInfo
    {
        public static string UserName;
        public static string UserRole;
        public static int UserId;

        public static bool AuthorizationOperator(TextBox TbxLogin, TextBox TbxPassword, string StoredProcedureName)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(StoredProcedureName, Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    cmd.Parameters.AddWithValue("@u_login", TbxLogin.Text);
                    cmd.Parameters.AddWithValue("@u_password", PasswordHash.GetHashedPassword(TbxPassword.Text));
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        UserName = dt.Rows[0]["name_operator"].ToString();
                        UserRole = dt.Rows[0]["role_operator"].ToString();
                        UserId = Convert.ToInt32(dt.Rows[0]["id_operator"]);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    dt.Dispose();
                    da.Dispose();
                    Connection.Close();
                }
            }
        }
    }
}
