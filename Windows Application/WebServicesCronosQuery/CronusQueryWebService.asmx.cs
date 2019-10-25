using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesCronosQuery
{
    /// <summary>
    /// Summary description for CronusQueryWebService
    /// </summary>
    [WebService(Namespace = "http://SeskarptCronusQuery")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CronusQueryWebService : System.Web.Services.WebService
    {

        public class Employee
        {
            public String no_;
            public String firstName;
            public String lastName;
        }
        public class EmployeeAbsence
        {

            public String fromDate;
            public String causeOfAbsenceCode;
            public String empNo_;
            public String empFirstName;
            public String empLastName;
        }

        public class Relative
        {
            public String firstName;
            public String lastName;
            public String relativeCode;
            public String empNo_;
            public String empFirstName;
            public String empLastName;
        }

        public static string GetConnectionString()
        {
            string connectionString = "Data Source=SYST4DEV01;Initial Catalog = Demo Database NAV (5-0); Integrated Security = True";
            return connectionString;

        }

        [WebMethod]
        public List<string> GetKeys()
        {
            List<string> keysList = new List<string>();
            using (SqlConnection connection = new SqlConnection(CronusQueryWebService.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT DISTINCT CONSTRAINT_NAME AS Keys FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE", connection))

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        keysList.Add(reader.GetValue(0).ToString());

                    }
                }
                return keysList;
            }


        }

        [WebMethod]
        public List<string> GetIndexes()
        {
            List<string> indexList = new List<string>();
            using (SqlConnection connection = new SqlConnection(CronusQueryWebService.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT DISTINCT name FROM sys.indexes",connection))

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        indexList.Add(reader.GetValue(0).ToString());

                    }
                }
                return indexList;
            }


        }
        [WebMethod]
        public List<String> GetConstraints()
        {
            List<String> constraintsList = new List<String>();
            using (SqlConnection connection = new SqlConnection(CronusQueryWebService.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS",connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            constraintsList.Add(reader.GetValue(0).ToString());
                        }
                    }
                }
                return constraintsList;
            }


        }
        [WebMethod]
        public List<String> GetTables()
        {
            List<String> tablesList = new List<String>();
            using (SqlConnection connection = new SqlConnection(CronusQueryWebService.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES",connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablesList.Add(reader.GetValue(0).ToString());
                        }
                    }
                }
                return tablesList;
            }


        }
        [WebMethod]
        public List<String> GetColumns()
        {
            List<String> columnsList = new List<String>();
            using (SqlConnection connection = new SqlConnection(CronusQueryWebService.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'",connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            columnsList.Add(reader.GetValue(0).ToString());
                        }
                    }
                }
                return columnsList;
            }


        }
        [WebMethod]

        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(CronusQueryWebService.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT No_ AS 'Employee Number' , [First Name] AS 'First Name', [Last Name] AS 'Last Name' FROM [CRONUS Sverige AB$Employee]", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Employee newEmployee = new Employee();
                            newEmployee.no_ = reader.GetValue(0).ToString();
                            newEmployee.firstName = reader.GetValue(1).ToString();
                            newEmployee.lastName = reader.GetValue(2).ToString();
                            employeeList.Add(newEmployee);
                        }
                    }
                }
            }
            return employeeList;

        }
        [WebMethod]

        public List<Relative> GetRelatives()
        {
            List<Relative> relativeList = new List<Relative>();

            using (SqlConnection connection = new SqlConnection(CronusQueryWebService.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT[CRONUS Sverige AB$Employee].[First Name], [CRONUS Sverige AB$Employee].[Last Name],[CRONUS Sverige AB$Employee].No_, [Relative Code], [CRONUS Sverige AB$Employee Relative].[First Name], [CRONUS Sverige AB$Employee Relative].[Last Name] FROM[CRONUS Sverige AB$Employee] INNER JOIN[CRONUS Sverige AB$Employee Relative]  ON[CRONUS Sverige AB$Employee].[No_] = [CRONUS Sverige AB$Employee Relative].[Employee No_]",connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                      
                        while (reader.Read())
                        {
                            Relative newRelative = new Relative();
                            newRelative.empFirstName = reader.GetValue(0).ToString();
                            newRelative.empLastName = reader.GetValue(1).ToString();
                            newRelative.empNo_ = reader.GetValue(2).ToString();
                            newRelative.relativeCode = reader.GetValue(3).ToString();
                            newRelative.firstName = reader.GetValue(4).ToString();
                            newRelative.lastName = reader.GetValue(5).ToString();
                            relativeList.Add(newRelative);
                        }
                    }
                }


            }
            return relativeList;


        }
        [WebMethod]

        public List<EmployeeAbsence> GetAbcense()
        {
            List<EmployeeAbsence> absenceList = new List<EmployeeAbsence>();

            using (SqlConnection connection = new SqlConnection(CronusQueryWebService.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT  [Employee No_], [First Name], [Last Name], [From Date], [Cause of Absence Code] FROM [CRONUS Sverige AB$Employee]  INNER JOIN [CRONUS Sverige AB$Employee Absence] ON [CRONUS Sverige AB$Employee].No_= [CRONUS Sverige AB$Employee Absence].[Employee No_]  WHERE [Cause of Absence Code]= 'SJUK' AND [From Date] LIKE '%2004%'",connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            EmployeeAbsence newAbsence = new EmployeeAbsence();
                            newAbsence.empNo_ = reader.GetValue(0).ToString();
                            newAbsence.empFirstName = reader.GetValue(1).ToString();
                            newAbsence.empLastName = reader.GetValue(2).ToString();
                            newAbsence.fromDate = reader.GetValue(3).ToString();
                            newAbsence.causeOfAbsenceCode = reader.GetValue(4).ToString();
                            absenceList.Add(newAbsence);
                        }
                    }
                }
            }
            return absenceList;


        }
        [WebMethod]

        public List<String> GetMostAbsent()
        {
            List<String> mostAbsent = new List<String>();
            using (SqlConnection connection = new SqlConnection(CronusQueryWebService.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT TOP 1[First Name], COUNT([First Name]) AS 'Antal dagar borta' FROM[CRONUS Sverige AB$Employee Absence] JOIN[CRONUS Sverige AB$Employee] ON[CRONUS Sverige AB$Employee Absence].[Employee No_] =[CRONUS Sverige AB$Employee].No_ GROUP BY[First Name] ORDER BY COUNT([First Name]) DESC",connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            mostAbsent.Add(reader.GetValue(0).ToString());
                        }
                    }
                }
                return mostAbsent;
            }


        }

    }

}

    