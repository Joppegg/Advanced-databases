using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronusCrudForm
{
    public interface IForm
    {
        string IdNbr { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string JobTitle { get; set; }
        DataGridView DataGridViewEmployee { get; set; }
    }
}
