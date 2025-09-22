using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString ="Server=LAPTOP-INKR4433\\SQLEXPRESS;Database=Practice;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    Console.WriteLine("Connection Established");
                    // Select all data from Employee table
                    string query = "SELECT * FROM Employee";
                    SqlCommand command = new SqlCommand(query, conn);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id :{reader["ID"]},{reader["Name"]},{reader["Postion"]},{reader["Salary"]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
