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
            //should be changed to static
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "LAPTOP-N4492EUJ\\SQLEXPRESS";
            builder.UserID = "adbadmin";
            builder.Password = "Travel123";
            builder.InitialCatalog = "Travel";
            return builder.ConnectionString;
         
        }
 
   
    }
}