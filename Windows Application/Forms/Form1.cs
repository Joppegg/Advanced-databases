using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Application.Views;
using Windows_Application.Presenters;
using System.Data.SqlClient;

namespace Windows_Application
{
    public partial class Form1 : Form, IView
    {
        private string customerNbr;
        private string destinationNbr;
        private int bookingNbr;
        private string personSsn;
        private string personAddress;
        private string personName;
        private string destinationCity;
        private string destinationCountry;
        private string destinationHotel;
        private Controller presenter = null;
        public string PersonSsn { get { return personSsn; } set { personSsn = value; } }
        public string PersonAddress { get { return personAddress; } set { personAddress = value; } }
        public string PersonName { get { return personName; } set { personName = value; } }
        public string DestinationHotel { get { return destinationHotel; } set { destinationHotel = value; } }
        public string DestinationCountry { get { return destinationCountry; } set { destinationCountry = value; } }
        public string DestinationCity { get { return destinationCity; } set { destinationCity = value; } }
        public string DestinationNbr { get { return destinationNbr; } set { destinationNbr = value; } }
        public string CustomerNbr { get { return customerNbr; } set { customerNbr = value; } }
        
        public int BookingNbr { get { return bookingNbr; } set { bookingNbr = value; } }
        public DataGridView DataGridViewCustomer { get { return dataGridView1; } set { dataGridView1 = value; } }
        public DataGridView DataGridViewDestination { get { return dataGridViewDestination; } set { dataGridViewDestination = value; } }
        public DataGridView DataGridViewBooking { get { return dataGridViewBooking; } set { dataGridViewBooking = value; } }


        public Form1()
        {
            InitializeComponent();
            presenter = new Controller(this);
            try
            {  
                presenter.PopulateTables();
            }
            catch (SqlException e1)
            {
                lblDeletePersonError.Text = ErrorHandler.GetErrorMessage(e1.Number) + e1.Message;
            }
            catch (Exception)
            {
                lblDeletePersonError.Text = ErrorHandler.GetGenericErrorMessage();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.notifyUpdate = new AddCustomer.NotifyUpdate(UpdateGrids);
            addCustomer.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this customer?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try {
                presenter.DeleteCustomer();
                presenter.PopulateTables();
                }
                catch (SqlException e1)
                {
                    lblDeletePersonError.Text = ErrorHandler.GetErrorMessage(e1.Number);
                }

                catch (Exception )
                {
                    lblDeletePersonError.Text = ErrorHandler.GetGenericErrorMessage();

                }


            }
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            UpdateCustomer form = new UpdateCustomer(CustomerNbr, PersonSsn, PersonAddress, PersonName);
            form.notifyUpdate = new UpdateCustomer.NotifyUpdate(UpdateGrids);
            form.Show();

        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        //On click method - för att lättare kunna ta bort en person. 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                CustomerNbr = selectedRow.Cells[0].Value.ToString();
                PersonName = selectedRow.Cells[1].Value.ToString();
                personAddress = selectedRow.Cells[2].Value.ToString();
                personSsn = selectedRow.Cells[3].Value.ToString();
                btnDeletePerson.Enabled = true;
                btnUpdatePerson.Enabled = true;


            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

  
        

        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking();
            addBooking.notifyUpdate = new AddBooking.NotifyUpdate(UpdateGrids);
            addBooking.Show();
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            AddDestination addDestination = new AddDestination();
            addDestination.notifyUpdate = new AddDestination.NotifyUpdate(UpdateGrids);
            addDestination.Show();
        }

        private void dataGridViewDestination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void destinationCityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateGrids()
        {
            presenter.PopulateTables();
        }
        private void dataGridViewBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridViewBooking.Rows[index];
                BookingNbr = int.Parse(selectedRow.Cells[6].Value.ToString());
                btnUpdateBooking.Enabled = true;
                btnDeleteBooking.Enabled = true;

            }
        }
        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this booking?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { 
                presenter.DeleteBooking();
                   UpdateGrids();
                }
                catch (SqlException e1)
                {
                    lblDeleteBooking.Text = ErrorHandler.GetErrorMessage(e1.Number);
                }

                catch (Exception)
                {
                    lblDeleteBooking.Text = ErrorHandler.GetGenericErrorMessage();

                }

            }
        }

        private void dataGridViewDestination_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridViewDestination.Rows[index];
                DestinationNbr = selectedRow.Cells[0].Value.ToString();
                DestinationCity = selectedRow.Cells[1].Value.ToString();
                DestinationCountry = selectedRow.Cells[2].Value.ToString();
                DestinationHotel = selectedRow.Cells[3].Value.ToString();
                btnDeleteDestination.Enabled = true;
                btnUpdateDestination.Enabled = true;
            }
        }

        private void btnUpdateDestination_Click(object sender, EventArgs e)
        {
            UpdateDestination form = new UpdateDestination(DestinationNbr, DestinationHotel, DestinationCountry, DestinationCity);
            form.notifyUpdate = new UpdateDestination.NotifyUpdate(UpdateGrids);
            form.Show();

        }

        private void btnDeleteDestination_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this destination?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    presenter.DeleteDestination();
                    UpdateGrids();
                }
                catch (SqlException e1)
                {
                    lblDeleteDestination.Text = ErrorHandler.GetErrorMessage(e1.Number);
                }

                catch (Exception)
                {
                    lblDeleteDestination.Text = ErrorHandler.GetGenericErrorMessage();

                }
            }

        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            UpdateBooking form = new UpdateBooking(BookingNbr);
            form.notifyUpdate = new UpdateBooking.NotifyUpdate(UpdateGrids);
            form.Show();
     
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DataGridViewDestination.ClearSelection();
            DataGridViewCustomer.ClearSelection();
       
            DataGridViewBooking.ClearSelection();
        }

        private void tabDestination_Selected(object sender, TabControlEventArgs e)
        {
            DataGridViewDestination.ClearSelection();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            DataGridViewBooking.ClearSelection();
        }
    }
}

