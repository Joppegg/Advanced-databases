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
using Windows_Application;
namespace CronusCrudForm
{
    public partial class UpdateEmployee : Form
   
    {
      
        private Presenter presenter = null;

        public string IdNbr { get { return textBoxEmployeeId.Text; } set { textBoxEmployeeId.Text = value; } }
        public string FirstName { get { return textBoxFirstName.Text; } set { textBoxFirstName.Text = value; } }
        public string LastName { get { return textBoxLastName.Text; } set { textBoxLastName.Text = value; } }
        public string JobTitle { get { return textBoxJobTitle.Text; } set { textBoxJobTitle.Text = value; } }
        public delegate void NotifyUpdate();
        public NotifyUpdate notifyUpdate;

        public UpdateEmployee(Form1 form)
        {
            InitializeComponent();
            IdNbr = form.IdNbr;
            FirstName = form.FirstName;
            LastName = form.LastName;
            JobTitle = form.JobTitle;
            presenter = new Presenter(this);
            
           
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {

            try { 
            presenter.UpdateEmployee();

                if (notifyUpdate != null)
                {
                    notifyUpdate();

                }
            this.Close();
               

            }
            catch (SqlException e1)
            {
                lblError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }

            catch (Exception)
            {
                lblError.Text = ErrorHandler.GetGenericErrorMessage();
               
            }
        }
    }
}
