using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesCronus
{
    /// <summary>
    /// Summary description for CronusWebService
    /// </summary>
    [WebService(Namespace = "http://SeSkarptCronus.se/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CronusWebService : System.Web.Services.WebService
    {
        public static String connectionString = "Data Source=SYST4DEV01;Initial Catalog = Demo Database NAV (5-0); Integrated Security = True";

        public static void Query(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                string sqlQuery = query;
                sqlCon.Open();
                SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
                command.ExecuteNonQuery();
            }
        }


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public class Employee
        {
            public string idNbr;
            public string firstName;
            public string lastName;
            public string jobTitle;
          
        }
        [WebMethod]
        public void AddEmployee(string idNbr, string firstName, string lastName, string jobTitle)
        {
          Query("INSERT INTO[CRONUS Sverige AB$Employee] VALUES(default,'" + idNbr + "', '"+firstName+"', ' ', '"+lastName+"', ' ', '"+jobTitle+"', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ')");
        }
        [WebMethod]
        public void DeleteEmployee(string idNbr)
        {
            Query("DELETE FROM [CRONUS Sverige AB$Employee] WHERE No_ = '" + idNbr + "'");
        }
        [WebMethod]
        public void UpdateEmployee(string idNbr, string firstName, string lastName, string jobTitle)
        {
            Query("UPDATE[CRONUS Sverige AB$Employee] SET[First Name] = '"+ firstName +"',[Last Name] = '"+ lastName+"', [Job Title] = '"+ jobTitle+"' WHERE No_ = '"+ idNbr +"'");
        }



    [WebMethod]
        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            //Anropa reader, och läg till varje customer i en lista.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT No_ AS [ID No.], [First Name], [Last Name],[Job Title] FROM[CRONUS Sverige AB$Employee]", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Mappar från databaseraden till list.. kanske inte det snyggaste, göra om?
                        while (reader.Read())
                        {

                            Employee newEmployee = new Employee();
                            newEmployee.idNbr = reader.GetValue(0).ToString();
                            newEmployee.firstName = reader.GetValue(1).ToString();
                            newEmployee.lastName = reader.GetValue(2).ToString();
                            newEmployee.jobTitle = reader.GetValue(3).ToString();
                            employeeList.Add(newEmployee);
                        }
                    }
                }


            }
            return employeeList;
        }








    }
}
