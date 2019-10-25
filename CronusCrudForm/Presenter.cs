using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronusCrudForm
{
    public delegate void PopulateDelegate();
    public class Presenter
    {

        private IForm m_View;
        private DatabaseDAL model = new DatabaseDAL();
        private AddEmployee addView;
        private UpdateEmployee updateView;
       
        public Presenter(IForm view)
        {
            m_View = view;
        }

        public Presenter (AddEmployee view)
        {
            addView = view;
        }
        public Presenter(UpdateEmployee view)
        {
            updateView = view;
        }

        public void GetEmployees()
        {
            
            DataTable dtblEmployees = model.getEmployees();
            m_View.DataGridViewEmployee.DataSource = dtblEmployees;
        }

        public void AddEmployee() {

            model.AddEmployee(addView.IdNbr, addView.FirstName, addView.LastName, addView.JobTitle);
        }
        public void DeleteEmployee() {
            model.deleteEmployee(m_View.IdNbr);
   
        }
        public void UpdateEmployee()
        {
            model.updateEmployee(updateView.IdNbr, updateView.FirstName, updateView.LastName, updateView.JobTitle);
        }
 
        public void What(object source, EventArgs e)
        {
            this.GetEmployees();
        }
    }
}
