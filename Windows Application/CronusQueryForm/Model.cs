using CronusQueryForm.localhost1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronusQueryForm
{
    class Model
    {
        public DataTable GetMostAbsent()
        {
            localhost1.CronusQueryWebService dbReader = new localhost1.CronusQueryWebService();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("First name");


            foreach (string s in dbReader.GetMostAbsent())
            {
                var row = dtbl.NewRow();
                row["First Name"] = s;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }

        public DataTable GetKeys()
        {
            localhost1.CronusQueryWebService dbReader = new localhost1.CronusQueryWebService();

            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Keys");

      

            foreach (string s in dbReader.GetKeys())
            {
                var row = dtbl.NewRow();
                row["Keys"] = s;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }
        public DataTable GetIndexes()
        {
            localhost1.CronusQueryWebService dbReader = new localhost1.CronusQueryWebService();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Indexes");


            foreach (string s in dbReader.GetIndexes())
            {
                var row = dtbl.NewRow();
                row["Indexes"] = s;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }
        public DataTable GetConstraints()
        {
            localhost1.CronusQueryWebService dbReader = new localhost1.CronusQueryWebService();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Constraints");


            foreach (string s in dbReader.GetConstraints())
            {
                var row = dtbl.NewRow();
                row["Constraints"] = s;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }
        public DataTable GetTables()
        {
            localhost1.CronusQueryWebService dbReader = new localhost1.CronusQueryWebService();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Tables");


            foreach (string s in dbReader.GetTables())
            {
                var row = dtbl.NewRow();
                row["Tables"] = s;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }
        public DataTable GetColumns()
        {
            localhost1.CronusQueryWebService dbReader = new localhost1.CronusQueryWebService();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Columns");

            foreach (string s in dbReader.GetColumns())
            {
                var row = dtbl.NewRow();
                row["Columns"] = s;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }
        public DataTable GetEmployees()
        {
            localhost1.CronusQueryWebService dbReader = new localhost1.CronusQueryWebService();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Employee Number");
            dtbl.Columns.Add("Employee First Name");
            dtbl.Columns.Add("Employee Last Name");

            foreach (Employee e in dbReader.GetEmployees())
            {
                var row = dtbl.NewRow();
                row["Employee Number"] = e.no_;
                row["Employee First Name"] = e.firstName;
                row["Employee Last Name"] = e.lastName;
                dtbl.Rows.Add(row);
            }   
            return dtbl;
        }
        public DataTable GetRelatives()
        {
            localhost1.CronusQueryWebService dbReader = new localhost1.CronusQueryWebService();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Employee First Name");
            dtbl.Columns.Add("Employee Last Name");
            dtbl.Columns.Add("Employee Number");
            dtbl.Columns.Add("Relative Code");
            dtbl.Columns.Add("Relative First Name");
            dtbl.Columns.Add("Relative Last Name");


            foreach (Relative r in dbReader.GetRelatives())
            {
                var row = dtbl.NewRow();
                row["Employee First Name"] = r.empFirstName;
                row["Employee Last Name"] = r.empLastName;
                row["Employee Number"] = r.empNo_;
                row["Relative Code"] = r.relativeCode;
                row["Relative First Name"] = r.firstName;
                row["Relative Last Name"] = r.lastName;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }
        public DataTable GetAbsence()
        {
            localhost1.CronusQueryWebService dbReader = new localhost1.CronusQueryWebService();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Employee Number");
            dtbl.Columns.Add("Employee First Name");
            dtbl.Columns.Add("Employee Last Name");
            dtbl.Columns.Add("From Date");
            dtbl.Columns.Add("Cause of Absence");



            foreach (EmployeeAbsence a in dbReader.GetAbcense())
            {
                var row = dtbl.NewRow();
                row["Employee Number"] = a.empNo_;
                row["Employee First Name"] = a.empFirstName;
                row["Employee Last Name"] = a.empLastName;
                row["From Date"] = a.fromDate;
                row["Cause of Absence"] = a.causeOfAbsenceCode;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }

    }
}
