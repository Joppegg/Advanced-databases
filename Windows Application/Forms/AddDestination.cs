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
    public partial class AddDestination : Form, IAddDestination
    {
        private Controller presenter = null;
        public string DestinationHotel { get { return textBoxDestinationHotel.Text; } set { textBoxDestinationHotel.Text = value; } }
        public string DestinationCountry { get { return textBoxDestinationCountry.Text; } set { textBoxDestinationCountry.Text = value; } }
        public string DestinationCity { get { return textBoxDestinationCity.Text; } set { textBoxDestinationCity.Text = value; } }
        public delegate void NotifyUpdate();
        public NotifyUpdate notifyUpdate;

        public AddDestination()
        {
            InitializeComponent();
            presenter = new Controller(this);
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            try { 
            presenter.AddDestination();
                if (notifyUpdate != null)
                {
                    notifyUpdate();
                }
                this.Close();
            }
            catch (SqlException e1)
            {
                lblAddDestinationError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }

            catch (Exception)
            {
                lblAddDestinationError.Text = ErrorHandler.GetGenericErrorMessage();

            }


        }
    }
}
