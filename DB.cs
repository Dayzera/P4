using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace lab1
{
    public class DB
    {
        public void Select(System.Data.SqlClient.SqlConnection connection)
        {
            var query = "SELECT * FROM Customers";
            var command = new SqlCommand(query, connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["CompanyName"]);
            }

            reader.Close();
          
        }

        public void Insert(SqlConnection connection, int id, string description)
        {
            var query = "INSERT INTO region(regionID, regionDescription) VALUES (@id, '@description')";
            var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@description", description);
            var affected = command.ExecuteNonQuery();
            Console.WriteLine($"{affected} rows affected");
        }


        public void Delete(SqlConnection connection, string table, string description)
        {
            var query = "DELETE FROM @table WHERE @description = 'Bielsko'";
            var command = new SqlCommand(query, connection);

            command.Parameters.Add(table);
            command.Parameters.Add(description);
            var off = command.ExecuteNonQuery();
            Console.WriteLine($"{off} row");

        }

    }
}
