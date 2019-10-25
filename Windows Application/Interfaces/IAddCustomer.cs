using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Application.Views
{
   public interface IAddCustomer
    {
        string PersonSsn { get; set; }
        string PersonAddress { get; set; }
        string PersonName { get; set; }
  
    }
}
