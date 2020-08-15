using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace CovidApp
{
    public partial class Reportinformation : Form
    {
        public Reportinformation(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
            if (str == null)
                textBox1.Text = null;
            else

            {
                string data = DateTime.Now.ToShortDateString().ToString();
                textBox1.Text = str + data;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportinformation R = new Reportinformation(null);
            R.ShowDialog(this);
            this.Close();
            this.Dispose();
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reportinformation_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-Q34EQV2;database=Covid_Management;Integrated Security=true;"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select proName from promary";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("proName"));
                            comboBox1.Items.Add(name);
                        }
                    }
                }
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] paras = new string[11];
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
            paras[9] = "0";
            paras[10] = textBox7.Text;
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
            string sql = "insert into units_dayli values(@para0,@para1,@para2,@para3,@para4,@para5,@para6,@para7,@para8,@para9,@para10)";
            int count = Reporter.update(sql, paras);
            MessageBox.Show("更新 " + count + " 条记录成功!");
            Reportinformation_Load(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-Q34EQV2;database=Covid_Management;Integrated Security=true;"))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select cityName from city,promary where city.proID=promary.proID and promary.proName=@pname";
                    cmd.Parameters.Add(new SqlParameter("pname", comboBox1.SelectedItem));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("cityName"));
                            comboBox2.Items.Add(name);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporterLogin R = new ReporterLogin();
            R.ShowDialog(this);
            this.Close();
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
