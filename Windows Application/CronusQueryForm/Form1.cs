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

namespace CronusQueryForm
{
    public partial class Form1 : Form
    {
        private Presenter presenter = null;
        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);

            try { 
            presenter.PopulateTables(dataGridViewKeys, dataGridViewIndexes, dataGridViewConstraints, dataGridViewTables, dataGridViewColumns , dataGridViewEmployees , dataGridViewRelatives, dataGridViewAbsence, dataGridViewMostAbsent);
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

        private void dataGridViewKeys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
