using System;
using System.Data.SqlClient;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB();
            var connectionString = " ";
            using var connection = new SqlConnection(connectionString);
                    
            connection.Open();

            db.Select(connection);
            db.Insert(connection, 12, "Bielsko");
            db.Delete(connection, "Customers", "Bielsko");


            connection.Close();
        }
    }
}
