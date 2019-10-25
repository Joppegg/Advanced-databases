using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronusCrudForm
{
    class DatabaseDAL
    {

        public void AddEmployee(string idNbr, string firstName, string lastName, string jobTitle)
        {
            localhost.CronusWebService dbReader = new localhost.CronusWebService();
            dbReader.AddEmployee(idNbr, firstName, lastName, jobTitle);
        }


        public void UpdateEmployee() { }

        public DataTable getEmployees()
        {
            localhost.CronusWebService dbReader = new localhost.CronusWebService();
            localhost.Employee[] employeeList = dbReader.GetEmployees();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Employee Id");
            dtbl.Columns.Add("First Name");
            dtbl.Columns.Add("Last Name");
            dtbl.Columns.Add("Title");


            foreach (localhost.Employee e in employeeList)
            {
                var row = dtbl.NewRow();
                row["Employee Id"] = e.idNbr;
                row["First Name"] = e.firstName;
                row["Last Name"] = e.lastName;
                row["Title"] = e.jobTitle;
                dtbl.Rows.Add(row);

            }
            return dtbl;

        }

        public void deleteEmployee(string employeeNumber)
        {
            localhost.CronusWebService dbReader = new localhost.CronusWebService();
            dbReader.DeleteEmployee(employeeNumber);


        }

        public void updateEmployee(string idNbr, string firstName, string lastName, string jobTitle)
        {
            localhost.CronusWebService dbReader = new localhost.CronusWebService();
            dbReader.UpdateEmployee(idNbr, firstName, lastName, jobTitle);
        }





    }
}
