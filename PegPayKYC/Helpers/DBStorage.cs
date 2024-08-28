using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PegPayKYC.Helpers
{
    public class DBStorage:IStorage
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);

        public List<object> ExecuteSelectQuery(string query)
        {
            // Initialize the list to hold the result
            List<object> resultList = new List<object>();

            // Establish a connection to the database
            using (connection)
            {
                try
                {
                    connection.Open();

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and obtain a SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Iterate through the rows
                            while (reader.Read())
                            {
                                
                                // Loop through each column in the row
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    resultList.Add(reader.GetValue(i));
                                }

                                // Add the row to the result list
                                
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Handle SQL errors
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Handle other possible errors
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return resultList;
        }
    }
}