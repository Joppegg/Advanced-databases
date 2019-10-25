using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class Program
    {


        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(Program.GetConnectionString()))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM TablesOfInterest", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                     
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader.GetValue(i) + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }




        }

        public static SqlDataReader Query(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.GetConnectionString()))
            {
                //Kör en query och returnerar resultset i "Reader"
                string sqlQuery = query;
                sqlCon.Open();
                SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }
        }


        public static string GetConnectionString()
        {
            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "uwdb18.srv.lu.se\\icssql001";   // update me
            builder.UserID = "sysa14reader";              // update me
            builder.Password = "INFreader1";      // update me
            builder.InitialCatalog = "SYSA14_PK_ProgAssignment2";
            return builder.ConnectionString;

        }


    }
}
