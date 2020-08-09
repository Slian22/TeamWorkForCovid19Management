using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidApp
{
    public partial class ChoseTheUser : Form
    {
        public ChoseTheUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin f = new ManagerLogin();
            f.ShowDialog(this);
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporterLogin R = new ReporterLogin();
            R.ShowDialog(this);
            this.Close();
            this.Dispose();
        }
    }
}
