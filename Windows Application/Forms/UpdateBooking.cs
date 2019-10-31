using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Application.Presenters;
using Windows_Application.Views;

namespace Windows_Application
{
    public partial class UpdateBooking : Form, IUpdateBooking
    {
        private int customerNbr;
        private int destinationNbr;
        private DateTime dateOut;
        private DateTime dateHome;
        private int bookingNbr;
        public int CustomerNbr { get { return customerNbr; } set { customerNbr = value; } }
        public int DestinationNbr { get { return destinationNbr; } set { destinationNbr = value; } }
        public DateTime DateOut { get { return dateOut; } set { dateOut = value; } }
        public DateTime DateHome { get { return dateHome; } set { dateHome = value; } }
        public int BookingNbr { get { return bookingNbr; } set { bookingNbr = value; } }
        private Controller presenter = null;
        public delegate void NotifyUpdate();
        public NotifyUpdate notifyUpdate;
        public DataGridView DataGridViewCustomer { get { return dataGridViewCustomerBooking; } set { dataGridViewCustomerBooking = value; } }
        public DataGridView DataGridViewDestination { get { return dataGridViewDestinationBooking; } set { dataGridViewDestinationBooking = value; } }

        public UpdateBooking(int bookingNbr)
        {
            InitializeComponent();
            BookingNbr = bookingNbr;
            presenter = new Controller(this);

            try {
            FillList();
            }
            catch (SqlException e1)
            {
                lblUpdateBookingError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }
            catch (Exception)
            {
                lblUpdateBookingError.Text = ErrorHandler.GetGenericErrorMessage();
            }

        }

        private void FillList()
        {

            presenter.PopulateUpdateBookingTables();
       
        }
        private void dataGridViewCustomerBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxBookingNbrShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            try {
                DateOut = dateTimePickerOut.Value.Date;
                DateHome = dateTimePickerHome.Value.Date;
                presenter.UpdateBooking();
                if (notifyUpdate != null)
                {
                    notifyUpdate();
                }
                this.Close();
            }
            catch (SqlException e1)
            {
                lblUpdateBookingError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }

            catch (Exception )
            {
                lblUpdateBookingError.Text = ErrorHandler.GetGenericErrorMessage();

            }
        }

        private void dateTimePickerOut_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerHome.MinDate = dateTimePickerOut.Value;
            dateTimePickerHome.Enabled = true;
        }

        private void dateTimePickerHome_ValueChanged(object sender, EventArgs e)
        {
            btnConfirmBooking.Enabled = true;
        }

        private void UpdateBooking_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBooking_Shown(object sender, EventArgs e)
        {
            dataGridViewCustomerBooking.ClearSelection();
            dataGridViewDestinationBooking.ClearSelection();
        }
    }
}