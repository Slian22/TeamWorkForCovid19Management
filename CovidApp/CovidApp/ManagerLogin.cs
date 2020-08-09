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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AccountText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';//输入文本不可见
            groupBox1.Enabled = false;//权限设置，验证身份后才能选择相应的功能
            string sql = "select manger_ID from manager";
            LinkedList<string> operators = DBUtil.queryOperator();
            foreach (string str in operators)
            {
                comboBox1.Items.Add(str);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChoseTheUser T= new ChoseTheUser();
            T.ShowDialog(this);
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = comboBox1.Text;
            string password = textBox1.Text;
            if (!DBUtil.verify(username, password))
            {
                MessageBox.Show("密码错误！");
                return;
            }
            else
            {
                groupBox1.Enabled = true;
                if (radioButton1.Checked)
                {
                    ManagerOperating f = new ManagerOperating();
                    f.ShowDialog();
                    this.Close();
                    this.Dispose();
                }
                if (radioButton2.Checked)
                {
                    this.Hide();
                    Viewallinformation V = new Viewallinformation();
                    V.ShowDialog();
                    this.Close();
                    this.Dispose();

                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
