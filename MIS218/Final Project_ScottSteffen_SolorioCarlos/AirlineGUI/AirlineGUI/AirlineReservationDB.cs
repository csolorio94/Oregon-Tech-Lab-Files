using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AirlineGUI
{
    /// <summary>
    /// Class that provide SQL connection to the LocalDB database
    /// </summary>
    public static class AirlineReservationDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|\\AirlineReservation.mdf;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
