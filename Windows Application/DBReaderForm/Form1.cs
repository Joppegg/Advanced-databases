using DBReaderForm.Interfaces;
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
using Windows_Application;

namespace DBReaderForm
{
    public partial class Form1 : Form, IForm
    {
        private Presenter presenter = null;
        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On load - update all tables
            try { 
            presenter.FillTables(dataGridViewCustomers, dataGridViewDestinations, dataGridViewBookings);
           }
             catch (SqlException e1)
            {
                lblError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }

            catch (Exception)
            {
                lblError.Text = ErrorHandler.GetGenericErrorMessage();
           
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
         
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

