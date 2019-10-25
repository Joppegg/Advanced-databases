using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Windows_Application { 


     
   public class DatabaseConnection
    {
     
        public static void Query(string query) 
        {
            using (SqlConnection sqlCon = new SqlConnection(DatabaseConnection.GetConnectionString()))
            {
                string sqlQuery = query;
                sqlCon.Open();
                SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
                command.ExecuteNonQuery();
            }
        }

        public static string GetConnectionString()
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-94IVMEG\\SQLEXPRESS";
            builder.UserID = "Jonny";
            builder.Password = "Dumdum123";
            builder.InitialCatalog = "Travel";
           
            return builder.ConnectionString;
         

        }
 
        public SqlConnection GetDatabaseConnection ()
        {
            try
            {
                
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "DESKTOP-94IVMEG\\SQLEXPRESS";
                builder.UserID = "Jonny";
                builder.Password = "Dumdum123";
                builder.InitialCatalog = "Travel";


                Console.Write("Connecting to SQL Server ... ");

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    return connection;
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            
        }
    }
}