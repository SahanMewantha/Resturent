using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent
{
    class DbTransactions
    {
        public bool loginCheck(string username, string password)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "select * from user_login";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (username.Equals(reader.GetString("user_name")) && password.Equals(reader.GetString("Password")))
                    {
                        //MessageBox.Show("login success !");
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }

}
