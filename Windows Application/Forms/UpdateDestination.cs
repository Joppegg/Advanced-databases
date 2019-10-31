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
    public partial class UpdateDestination : Form, IUpdateDestination
    {
        private Controller presenter = null;
        public string DestinationHotel { get { return textBoxDestinationHotel.Text; } set { textBoxDestinationHotel.Text = value; } }
        public string DestinationCountry { get { return textBoxDestinationCountry.Text; } set { textBoxDestinationCountry.Text = value; } }
        public string DestinationCity { get { return textBoxDestinationCity.Text; } set { textBoxDestinationCity.Text = value; } }
        public string DestinationNbr { get { return textBoxDestinationNbr.Text; } set { textBoxDestinationNbr.Text = value; } }
        public delegate void NotifyUpdate();
        public NotifyUpdate notifyUpdate;

        public UpdateDestination(string destinationNbr, string destinationHotel, string destinationCountry, string destinationCity)
        {
            InitializeComponent();
            DestinationNbr = destinationNbr;
            DestinationHotel = destinationHotel;
            DestinationCountry = destinationCountry;
            DestinationCity = destinationCity;
       
            presenter = new Controller(this);
        }

        private void textBoxDestinationCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateDestination_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.UpdateDestination();
                if (notifyUpdate != null)
                {
                    notifyUpdate();
                }
                this.Close();
            }

            catch (SqlException e1)
            {
                lblUpdateDestinationError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }

            catch (Exception)
            {
                lblUpdateDestinationError.Text = ErrorHandler.GetGenericErrorMessage();

            }
        }
    }
}
