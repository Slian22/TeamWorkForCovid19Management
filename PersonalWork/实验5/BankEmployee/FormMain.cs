using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace BankEmployee
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.selectAllUserNameFromOperatorTableAdapter.Fill(this.employeeDataSet1.SelectAllUserNameFromOperator);
            comboBoxOperator.DataSource = employeeDataSet1.SelectAllUserNameFromOperator;
            comboBoxOperator.DisplayMember = employeeDataSet1.SelectAllUserNameFromOperator.usernameColumn.ColumnName;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            selectOperatorTableAdapter1.Fill(employeeDataSet1.SelectOperator, comboBoxOperator.Text, textBoxPassword.Text);
            if (employeeDataSet1.SelectOperator.Count == 0)
            {
                MessageBox.Show("操作员或密码不正确", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonManage_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonManage.Checked == true)
            {
                this.Hide();
                FormEmployee fm = new FormEmployee();
                fm.ShowDialog();
                this.Show();
            }
        }

        private void radioButtonQuery_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQuery.Checked == true)
            {
                int? maleNumber = 0;
                int? femaleNumber = 0;
                simpleQueryTableAdapter1.GetData(ref maleNumber , ref femaleNumber);
                MessageBox.Show(string.Format("男：{0}，女：{1}", maleNumber, femaleNumber));
            }
        }
    }
}