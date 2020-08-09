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
    public partial class ManagerOperating : Form
    {
        public ManagerOperating()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ManagerOperating_Load(object sender, EventArgs e)
        {
            string sql = "select * from units where verification=0";
            DBUtil.BindDataGridView(dataGridView1, sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox3.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] paras = new string[12];
            int flag = 1;
            paras[0] = textBox1.Text;
            paras[1] = comboBox1.Text;
            paras[2] = comboBox2.Text;
            paras[3] = dateTimePicker1.Text;
            paras[4] = textBox2.Text;
            paras[5] = textBox3.Text;
            paras[6] = textBox4.Text;
            paras[7] = textBox5.Text;
            paras[8] = textBox6.Text;
            paras[9] = textBox7.Text;
            paras[10] = comboBox3.Text;
            paras[11] = textBox8.Text;
            string reminderMessage = "";
            for (int i = 0; i < 11; i++)
            {
                if (paras[i] == "")
                {
                    string ss = "label" + (i + 1).ToString();
                    reminderMessage += string.Format("请输入{0}!\n", groupBox1.Controls[ss].Text);
                }
            }
            if (reminderMessage != "")
            {
                MessageBox.Show(reminderMessage);
            }
                string sql = "select * from units where verification=0";
                string[] paras1 = new string[1];
                paras1[0] = textBox1.Text;
                LinkedList<string[]> result; //LinkedListNode<string[]> linkedListNodeS = result.First;MessageBox.Show(linkedListNodeS.Value[0]);
                DBUtil.query(sql, paras1, out result);
                //
                if (result.Count == 0)
                {

                    sql = "insert into 信息表 values(@para0,@para1,@para2,@para3,@para4,@para5)";

                }
                else
                {

                    sql = "update 信息表 set 姓名=@para1,性别=@para2,出生日期=@para3,地址=@para4,头像=@para5 where 职员号=@para0";
                }
                int count = DBUtil.update(sql, paras);
                MessageBox.Show("更新 " + count + " 条记录成功!");
                ManagerOperating_Load(sender, e);//窗体重载，显示数据更新效果
            }
        }
}
