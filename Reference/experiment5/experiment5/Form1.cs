using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace experiment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                   Form2 f = new Form2();
                   f.Show();
                }
                if (radioButton2.Checked)
                {
                    int[] Count = new int[3];
                    SortedList<string, int> sl = DBUtil.queryGender();//查询统计表中不同性别的个数
                    /*foreach(KeyValuePair<string,int> s in sl)
                    { MessageBox.Show(s.Key + s.Value); }*///这段代码可以看列表里面的具体键和对应的值

                    //sl.TryGetValue("男", out  mCount);//注意在数据库中字段的数据类型，有可能存在字符串补齐空格，比如说我之前用的varchar(10),存储的实际是“男    ”，导致我用“男”作为键找不到对应的值，建议大家用KEY属性访问
                    // sl.TryGetValue(sl.Keys[1], out  fmCount);
                    int i = 0;
                    string showmessage="职员总计 ";
                    foreach(string Gender in sl.Keys)
                    {
                        sl.TryGetValue(Gender, out Count[i]);
                        showmessage += string.Format("{0}: ", sl.Keys[i]);
                        showmessage += string.Format("{0}, ", Count[i]);

                        i++;
                    }
                        
                    //MessageBox.Show("职员总计 男 ：" + mCount + " 个,   "+sl.Keys[1]+": " + fmCount + " 个");
                    
                    MessageBox.Show(showmessage);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';//输入文本不可见
            groupBox1.Enabled = false;//权限设置，验证身份后才能选择相应的功能
            string sql = "select 操作员 from 职工信息表";
            LinkedList<string> operators = DBUtil.queryOperator();
            foreach (string str in operators)
            {
                comboBox1.Items.Add(str);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
