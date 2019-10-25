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
using Uppgift2Wform;
using Windows_Application;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Presenter presenter = null;
        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 
            dataGridViewTob.DataSource = null;

            dataGridViewTob.Refresh();

            dataGridViewTob.DataSource = presenter.TableNames().Select(x => new { Value = x }).ToList();

            dataGridViewColumns.DataSource = presenter.ColumnNames().Select(x => new { Value = x }).ToList();

            dataGridViewRows.DataSource = presenter.RowsNumber().Select(x => new { Value = x }).ToList();

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
