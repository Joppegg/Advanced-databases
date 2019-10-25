using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Application;

namespace StartForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPa1_Click(object sender, EventArgs e)
        {
            Windows_Application.Form1 form = new Windows_Application.Form1();
            form.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //btnpa2
            WindowsFormsApp1.Form1 form = new WindowsFormsApp1.Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnpa3
            WindowsFormsFileReader.Form1 form = new WindowsFormsFileReader.Form1();
            form.Show();
        }

        private void button2btnPa4_Click(object sender, EventArgs e)
        {
            //btnpa4
            DBReaderForm.Form1 form = new DBReaderForm.Form1();
            form.Show();

        }

        private void btnPa5_Click(object sender, EventArgs e)
        {
            //btnpa5
            CronusCrudForm.Form1 form = new CronusCrudForm.Form1();
            form.Show();
        }

        private void btnPa6_Click(object sender, EventArgs e)
        {
            CronusQueryForm.Form1 form = new CronusQueryForm.Form1();
            form.Show();
        }
    }
}
