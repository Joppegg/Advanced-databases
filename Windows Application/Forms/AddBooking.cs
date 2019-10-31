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
    public partial class AddBooking : Form, IBooking
    {
        private int customerNbr;
        private int destinationNbr;
        private DateTime dateOut;
        private DateTime dateHome;
        public int CustomerNbr { get { return customerNbr; } set { customerNbr = value; } }
        public int DestinationNbr { get { return destinationNbr; } set { destinationNbr = value; } }
        public DateTime DateOut { get { return dateOut;  } set { dateOut = value; } }
        public DateTime DateHome{ get { return dateHome; } set { dateHome = value; } }
        private Controller presenter = null;
        public delegate void NotifyUpdate();
        public NotifyUpdate notifyUpdate;
        public DataGridView DataGridViewCustomer { get { return dataGridViewCustomerBooking; } set { dataGridViewCustomerBooking = value; } }
        public DataGridView DataGridViewDestination { get { return dataGridViewDestinationBooking; } set { dataGridViewDestinationBooking = value; } }

        public AddBooking()
        {
            InitializeComponent();
            presenter = new Controller(this);
            try
            {
                FillList();
            }
            catch (SqlException e1)
            {
                lblAddBookingError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }
            catch (Exception)
            {
                lblAddBookingError.Text = ErrorHandler.GetGenericErrorMessage();
            }

        }


        private void FillList()
        {
            presenter.PopulateAddBookingTables();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDestinationBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridViewDestinationBooking.Rows[index];
                destinationNbr = int.Parse(selectedRow.Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateOut = dateTimePickerOut.Value.Date;
            DateHome = dateTimePickerHome.Value.Date;
            try
            {
                presenter.AddBooking();
                if (notifyUpdate != null)
                {
                    notifyUpdate();
                }
                this.Close();
            }
            catch (SqlException e1)
            {
                lblAddBookingError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }

            catch (Exception)
            {
                lblAddBookingError.Text = ErrorHandler.GetGenericErrorMessage();

            }

        }

        private void AddBooking_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerHome_ValueChanged(object sender, EventArgs e)
        {
            btnConfirmBooking.Enabled = true;
        }

        private void dateTimePickerOut_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerHome.MinDate = dateTimePickerOut.Value;
            dateTimePickerHome.Enabled = true;
        }

        private void dataGridViewCustomerBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridViewCustomerBooking.Rows[index];
                CustomerNbr = int.Parse(selectedRow.Cells[0].Value.ToString());
                dataGridViewDestinationBooking.Enabled = true;
            }
        }

        private void dataGridViewDestinationBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridViewDestinationBooking.Rows[index];
                destinationNbr = int.Parse(selectedRow.Cells[0].Value.ToString());
                dateTimePickerOut.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddBooking_Shown(object sender, EventArgs e)
        {
            dataGridViewCustomerBooking.ClearSelection();
            dataGridViewDestinationBooking.ClearSelection();
        }
    }
}

