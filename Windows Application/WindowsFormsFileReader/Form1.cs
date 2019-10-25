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
using FileReaderConsoleApp;
namespace WindowsFormsFileReader
{
    public partial class Form1 : Form
    {
        private Presenter presenter = null;
        public string fileTextName { get { return textBoxFilePath.Text; } set { textBoxFilePath.Text = value; } }
        public string fileText { get { return richTextBoxOutput.Text; } set { richTextBoxOutput.Text = value; } }

        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileTextName = openFileDialog1.FileName;
                
            }
            try { 
            presenter.ShowText();
            }

            catch (SqlException e1) {

                lblFileError.Text = ErrorHandler.GetErrorMessage(e1.Number);
            }

            catch (Exception)
            {
                lblFileError.Text = ErrorHandler.GetWrongFileMessage();

            }
       

        }

       
    }
}
