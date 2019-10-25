using DBReaderForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBReaderForm
{
    class DatabaseDAL
    {

        public DataTable getCustomers()
        {
            localhost.WebServiceDBReader dbReader = new localhost.WebServiceDBReader();
            localhost.Customer[] customerList = dbReader.GetCustomers();

            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Customer number");
            dtbl.Columns.Add("Name");
            dtbl.Columns.Add("Address");
            dtbl.Columns.Add("Ssn");

            foreach (localhost.Customer c in customerList)
            {
                var row = dtbl.NewRow();
                row["Customer Number"] = c.idNbr;
                row["Name"] = c.name;
                row["Address"] = c.address;
                row["Ssn"] = c.ssn;
                dtbl.Rows.Add(row);

            }
            return dtbl;

        }

        public DataTable getDestinations()
        {
            localhost.WebServiceDBReader dbReader = new localhost.WebServiceDBReader();
            localhost.Destination[] destinationList = dbReader.GetDestinations();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Destination No.");
            dtbl.Columns.Add("City");
            dtbl.Columns.Add("Country");
            dtbl.Columns.Add("Hotel");


            foreach (localhost.Destination d in destinationList)
            {
                var row = dtbl.NewRow();
                row["Destination No."] = d.destinationNbr;
                row["City"] = d.city;
                row["Country"] = d.country;
                row["Hotel"] = d.hotel;
                dtbl.Rows.Add(row);

            }
            return dtbl;

        }
        public DataTable getBookings()
        {
            localhost.WebServiceDBReader dbReader = new localhost.WebServiceDBReader();
            localhost.Booking[] bookingList = dbReader.GetBookings();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Customer No.");
            dtbl.Columns.Add("Destination No.");
            dtbl.Columns.Add("Date out");
            dtbl.Columns.Add("Date home");
            dtbl.Columns.Add("Booking No.");


            foreach (localhost.Booking b in bookingList)
            {
                var row = dtbl.NewRow();
                row["Customer No."] = b.customerNbr;
                row["Destination No."] = b.destinationNbr;
                row["Date out"] = b.dateOut;
                row["Date home"] = b.dateHome;
                row["Booking No."] = b.bookingNbr;
                dtbl.Rows.Add(row);

            }
            return dtbl;

        }
    }
}
