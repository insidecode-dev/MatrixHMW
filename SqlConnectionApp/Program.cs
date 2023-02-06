using System;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.PortableExecutable;

namespace SqlConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Source is server's name
            // Inital Catalog is database's name
            string connectionString = "" +
                "Data Source = DESKTOP-TOURGOO\\SQLEXPRESS ; " +
                "Initial Catalog = Northwind; " +
                "Integrated Security = true";

            // This is our sql query string
            string queryString =
                "Select ProductName, UnitPrice, UnitsInStock from Products";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(queryString, con))
                    {
                       // string productName = Console.ReadLine();
                        //cmd.Parameters.AddWithValue("@ProductName", productName);
                        try
                        {
                            con.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                                }
                                reader.Close();
                                con.Close();
                            }
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
                            Console.WriteLine("Stack Trace: " + ex.ErrorCode);
                            Console.WriteLine("Error State: " + ex.State);
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
                        }
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
            }
        }
    }
}
