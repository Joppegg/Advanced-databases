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
    public partial class AddCustomer : Form, IAddCustomer
    {
        private Presenter presenter = null;
        public string PersonSsn { get { return textBoxCustomerID.Text; } set { textBoxCustomerID.Text = value; } }
        public string PersonAddress { get { return textBoxCustomerAddress.Text; } set { textBoxCustomerAddress.Text = value; } }
        public string PersonName { get { return textBoxCustomerName.Text; } set { textBoxCustomerName.Text = value; } }

        public delegate void NotifyUpdate();
        public NotifyUpdate notifyUpdate;

        public AddCustomer()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (PersonSsn.Length == 10) {
                try
                {
                    presenter.AddCustomer();
                    if (notifyUpdate != null)
                    {
                        notifyUpdate();
                    }
                    this.Close();
                }

                 catch (SqlException e1)
                {
                    lblAddCustomerError.Text = ErrorHandler.GetErrorMessage(e1.Number);
                }

                catch (Exception )
                {
                    lblAddCustomerError.Text = ErrorHandler.GetGenericErrorMessage();

                }

            }

            else
            {
                lblAddCustomerError.Text = "Please use the correct ID format";
            }


        }
    }
}
