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
    public partial class UpdateCustomer : Form, IUpdateCustomer
    {
        private Presenter presenter = null;
        public string PersonSsn { get { return textBoxCustomerIdNumber.Text; } set { textBoxCustomerIdNumber.Text = value; } }
        public string PersonAddress { get { return textBoxCustomerAddress.Text; } set { textBoxCustomerAddress.Text = value; } }
        public string PersonName { get { return textBoxCustomerName.Text; } set { textBoxCustomerName.Text = value; } }
        public string CustomerNbr { get { return textBoxCustomerNbr.Text;  } set { textBoxCustomerNbr.Text = value; } }
        public delegate void NotifyUpdate();
        public NotifyUpdate notifyUpdate;

        public UpdateCustomer(string customerNbr, string personSsn, string personAddress, string personName)
        {
            InitializeComponent();
            CustomerNbr = customerNbr;
            PersonSsn = personSsn;
            PersonAddress = personAddress;
            PersonName = personName;
            presenter = new Presenter(this);

        }

        private void textBoxCustomerNbr_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (PersonSsn.Length == 10) {
                try
                {
                    presenter.Updatecustomer();
                    if (notifyUpdate != null)
                    {
                        notifyUpdate();
                    }
                    this.Close();
                }
                catch (SqlException e1)
                {
                    lblUpdateCustomerError.Text = ErrorHandler.GetErrorMessage(e1.Number);
                }

                catch (Exception )
                {
                    lblUpdateCustomerError.Text = ErrorHandler.GetGenericErrorMessage();

                }
            }

            else
            {
                lblUpdateCustomerError.Text = "Please use the correct ID format"; 
            }
        }
    }
}
