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
    public partial class Form1 : Form, IForm
    {
        private Presenter presenter = null;
        private string idNbr;
        private string firstName;
        private string lastName;
        private string jobTitle;
        public string IdNbr { get { return idNbr; } set { idNbr = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }
        public DataGridView DataGridViewEmployee { get { return dataGridViewEmployee; } set { dataGridViewEmployee = value; } }


        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            try { 
            presenter.GetEmployees();
            }
            catch (SqlException e1)
            {
                lblError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }
            catch (Exception e)
            {
                lblError.Text = ErrorHandler.GetGenericErrorMessage();
            }
            DataGridViewEmployee.ClearSelection();
             
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //Delegate solution.
            AddEmployee addEmployee = new AddEmployee(this);
            addEmployee.notifyUpdate = new AddEmployee.NotifyUpdate(UpdateEmployeeGrid);
            addEmployee.Show();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployee form = new UpdateEmployee(this);
            form.notifyUpdate = new UpdateEmployee.NotifyUpdate(UpdateEmployeeGrid);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you really want to delete this customer?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    presenter.DeleteEmployee();
                    UpdateEmployeeGrid();
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

        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridViewEmployee.Rows[index];
                IdNbr = selectedRow.Cells[0].Value.ToString();
                FirstName= selectedRow.Cells[1].Value.ToString();
                LastName = selectedRow.Cells[2].Value.ToString();
                JobTitle = selectedRow.Cells[3].Value.ToString();
                btnDeleteEmployee.Enabled = true;
                btnUpdateEmployee.Enabled = true;

            }
        }

        private void updateGrid_Click(object sender, EventArgs e)
        {
            UpdateEmployeeGrid();
        }

        private void UpdateEmployeeGrid()
        {
            presenter.GetEmployees();
        }
    }
}
