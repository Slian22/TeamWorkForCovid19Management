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
    public partial class ReporterLogin : Form
    {
        public ReporterLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = comboBox1.Text;
            string password = textBox1.Text;
            if (!Reporter.verify(username, password))
            {
                MessageBox.Show("密码错误！");
                return;
            }
            else
            {
                this.Hide();
                Reportinformation R = new Reportinformation();
                R.ShowDialog(this);
                this.Close();
                this.Dispose();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChoseTheUser C = new ChoseTheUser();
            C.ShowDialog(this);
            this.Close();
            this.Dispose();
        }

        private void ReporterLogin_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';//输入文本不可见
            string sql = "select userid from  [user]";
            LinkedList<string> operators = Reporter.queryOperator();
            foreach (string str in operators)
            {
                comboBox1.Items.Add(str);
            }
        }
    }
}
