using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Resturent
{
    class Dbemploye
    {
        public bool cuscheack(string cusname, string password)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string qury = "select * from employe";
                MySqlCommand cmd = new MySqlCommand(qury, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (cusname.Equals(reader.GetString("cus_name")) && password.Equals(reader.GetString("Password")))
                    {
                        MessageBox.Show("Login Succsess As Employee !");
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
