using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bombardier
{
    public static class DbHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;



        public static void EstablishConnection()
        {
           
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "+";
                builder.UserID = "+";
                builder.Password = "+";
                builder.Database = "+";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
             //   MessageBox.Show("Database connection successful", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }
    }
}
