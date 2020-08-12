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
    public partial class Viewallinformation : Form
    {
        public bool clicked = false;
        public Viewallinformation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin C = new ManagerLogin();
            C.ShowDialog(this);
            this.Close();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerOperating C = new ManagerOperating();
            C.ShowDialog(this);
            this.Close();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Viewallinformation_Load(object sender, EventArgs e)
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
            if(clicked==false)
            {
                string sql2 = "select * from city_msg";
                DBUtil.BindDataGridView(dataGridView2, sql2);
            }
            else
            {
                string s = comboBox1.SelectedItem as string;
                string s2 = comboBox2.SelectedItem as string;
                DataTable dt = (DataTable)dataGridView2.DataSource;
                dt.Rows.Clear();
                dataGridView2.DataSource = dt;
                string sql2 = "select * from city_msg where province='" +s +"' and city='"+s2+"'";
                //MessageBox.Show(sql2);
                DBUtil.BindDataGridView(dataGridView2, sql2);
                clicked = false;
            }
            string sql = "select * from country_msg";
            DBUtil.BindDataGridView(dataGridView1, sql);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicked = true;
            Viewallinformation_Load(sender, e);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
