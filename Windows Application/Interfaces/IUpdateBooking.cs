using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Application.Views
{
   public interface IUpdateBooking
    {
        int CustomerNbr { get; set; }
        int DestinationNbr { get; set; }
        DateTime DateOut { get; set; }
        DateTime DateHome { get; set; }
        int BookingNbr { get; set; }

        DataGridView DataGridViewCustomer { get; set; }
        DataGridView DataGridViewDestination { get; set; }
    }
}
