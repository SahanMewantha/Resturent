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
        private string access;
        public string Access
        {
            get { return access; }
            set { access = value; }
        }
        public bool loginCheck(string username, string password)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "select * from login_details";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (username.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                    {
                        //MessageBox.Show("login success !");
                        access = reader.GetString("access");
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
