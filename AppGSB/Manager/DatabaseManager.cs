using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppGSB.Manager
{
    internal class DatabaseManager
    {
        private const string connectionString = "server=172.20.77.120;port=3306;database=gsb_database;uid=gsb_user;pwd=gsb_password;";
        
        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
