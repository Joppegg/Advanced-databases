using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Application.Views
{
    public interface IView
    {
       
         string PersonSsn { get; set; }
         string PersonAddress { get; set; }
         string PersonName { get; set; }
         string DestinationCity { get; set; }
         string DestinationHotel{ get; set; }
         string DestinationCountry { get; set; }
         string CustomerNbr { get; set; }
        string DestinationNbr { get; set; }
        int BookingNbr { get; set; }
        DataGridView DataGridViewCustomer { get; set; }
        DataGridView DataGridViewDestination { get; set; }
        DataGridView DataGridViewBooking{ get; set; }

    }
}