using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experiment5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string imagepath="";
            string[] paras = new string[6];
            paras[0] = textBox1.Text;
            paras[1] = textBox2.Text;
            paras[2] = comboBox1.Text;
            paras[3] = dateTimePicker1.Text;
            paras[4] = textBox3.Text;
            paras[5] = imagepath;
            int flag = 1;
            string reminderMessage="";
            for(int i=0;i<4;i++)
            {
                if(paras[i]=="")
                {
                    string ss = "label" + (i + 1).ToString();
                    reminderMessage += string.Format("请输入{0}!\n", groupBox1.Controls[ss].Text);
                    flag = 0;
                }
            }
            if(reminderMessage!="")
            {
                MessageBox.Show(reminderMessage);
            }
            if(flag==1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {//根据打开的图像文件创建原始图像大小的Bitmap 对象
                        Bitmap image = new Bitmap(openFileDialog1.FileName);
                        //按比例缩放显示（因为Picture 的SizeMode 属性为Zoom）,但原始图像大小未变
                        pictureBox1.Image = image;
                    }
                    imagepath = openFileDialog1.FileName;
                    paras[5] = imagepath;
                }

                string sql = "select * from 信息表 where 职员号=@para0";
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
                Form2_Load(sender, e);//窗体重载，显示数据更新效果
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string sql = "select * from 信息表";
            DBUtil.BindDataGridView(dataGridView1, sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                if(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()!="")
                {
                    pictureBox1.Image = Image.FromFile(@dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from 信息表 where 职员号=@para0";
            string[] paras = new string[1];
            paras[0] = textBox1.Text;
            DBUtil.update(sql, paras);
            MessageBox.Show("记录删除成功！");
            Form2_Load(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
