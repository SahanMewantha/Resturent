using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Resturent
{
    class DbConnection
    {
        public MySqlConnection connectDB()
        {
            string con_string = "server=127.0.0.1;uid=root;pwd=;database=restaurant_reservation";
            MySqlConnection con = new MySqlConnection(con_string);
            return con;
        }
    }
}
//hello world