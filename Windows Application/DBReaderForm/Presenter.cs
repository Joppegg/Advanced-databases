using DBReaderForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBReaderForm
{
    class Presenter
    {
        private IForm m_View;
        private DatabaseDAL model = new DatabaseDAL();
        public Presenter(IForm view)
        {
            m_View = view;
        }

        public void FillTables(DataGridView customers, DataGridView destinations, DataGridView bookings)
        {
            DataTable dtblCustomers = model.getCustomers();
            customers.DataSource = dtblCustomers;

            DataTable dtblDestinations = model.getDestinations();
            destinations.DataSource = dtblDestinations;

            DataTable dtblBookings = model.getBookings();
            bookings.DataSource = dtblBookings;

        }



    }
}
