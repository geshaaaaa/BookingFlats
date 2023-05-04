using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    public class ForConnection
    {
        SqlConnection connection = new SqlConnection("Data Source=GENA;Initial Catalog=FlatBooking;Integrated Security=True");
        public SqlConnection getconnection()
        {
            return connection;
        }
        public void openconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeconnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
