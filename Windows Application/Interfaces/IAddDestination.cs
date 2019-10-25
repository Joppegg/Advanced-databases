using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Application.Views
{
   public interface IAddDestination
    {
        string DestinationCity { get; set; }
        string DestinationHotel { get; set; }
        string DestinationCountry { get; set; }
    }
}
