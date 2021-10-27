using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

public static class MMABooksDB
{
    public static SqlConnection GetConnection()
    {
        string connectionString =
       "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MMABooks.mdf;" +
       "Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);

        return connection;
    }
}
