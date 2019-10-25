using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Application.Views
{
   public interface IUpdateCustomer
    {
        string PersonSsn { get; set; }
        string PersonAddress { get; set; }
        string PersonName { get; set; }
        string CustomerNbr { get; set; }
    }
}
