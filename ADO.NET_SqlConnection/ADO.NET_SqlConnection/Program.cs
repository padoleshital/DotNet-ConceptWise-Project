using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;



    class Program
    {
        static void Main(string[] args)
        {
            Program.Connection();
            Console.ReadLine();
        }
       static void Connection()
        {
        string connectionString = "Data Source=LAPTOP-INKR4433\\SQLEXPRESS;Initial Catalog=Practice;Integrated Security=True;TrustServerCertificate=True;";
        SqlConnection conn = new SqlConnection(connectionString);

        try
        {
            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("Connection is Establisd");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            conn.Close();
        }
       
           

        conn.Close();

        }
    }
