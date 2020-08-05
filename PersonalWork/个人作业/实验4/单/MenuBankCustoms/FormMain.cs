using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MenuBankCustoms
{
    
    public partial class FormMain : Form
    {
        double starmoney;
        Customers cus = new Customers();
        Account custom;
        
        SortedList<string, Account> Customs = new SortedList<string, Account>();
        public FormMain()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
        ///判断金额格式是否正确
        private void textBoxAccountBalance_Leave(object sender, EventArgs e)
        {
            bool ok = double.TryParse(textBoxAccountBalance.Text, out starmoney);
            if (!ok)
            {
                MessageBox.Show("存（取）款金额格式不正确，请检查后重新输入");
            }
            else
            {
                if (starmoney < 0)
                    MessageBox.Show("存（取）款金额不能小于零");
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBoxAccountName.Focus();
            //设置状态栏显示
            toolStripStatusLabel1.Text = "文件还没打开，请先打开文件，再操作";
        }

        /// 向listbox中添加字符串
        private void AddItemTolistBox(Account Custom)
        {
            listBoxshow.Items.Add(string.Format("账户信息:帐户名{0},帐号{1:d4},当前余额{2:n2}元",custom.AccountName,custom.AccountNumber,custom.AccountBalance));
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Account[] b = new Account[100];
                b = cus.Load();
                int[] number = new int[100];
                for (int i = 0; i < Customers.m; i++)
                {
                    Customs.Add(b[i].AccountName, b[i]);
                    listBoxshow.Items.Add(string.Format("账户信息:帐户名{0},帐号{1:d4},当前余额{2:n2}元", b[i].AccountName, b[i].AccountNumber, b[i].AccountBalance));
                    number[i] = b[i].AccountNumber;
                }

                Account.newAccountNumber = number.Max() + 1;
                toolStripStatusLabel1.Text = "文件已打开";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// 文件保存。
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == "文件还没打开，请先打开文件，再操作")
                MessageBox.Show("文件还没打开", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("是否将所有信息保存到文件中？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                { 
                    Account[] acc = new Account[Customs.Count];
                    for (int i = 0; i < Customs.Count; i++)
                        acc[i] = Customs.Values[i];
                    cus.Save(acc);
                    toolStripStatusLabel1.Text = "文件已保存";
                    MessageBox.Show("保存文件成功！");
                }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            打开ToolStripMenuItem.PerformClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            保存ToolStripMenuItem.PerformClick();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            显示所有帐户信息ToolStripMenuItem.PerformClick();
        }

        /// 取款按钮处理事件
        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == "文件还没打开，请先打开文件，再操作")
                MessageBox.Show("文件还没打开", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Customs.ContainsKey(textBoxAccountName.Text) == false)
                {
                    MessageBox.Show("无此账户，无法取款", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    custom = Customs[textBoxAccountName.Text];
                    if (!custom.Withdraw(starmoney))
                    {
                        MessageBox.Show("余额不足", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    AddItemTolistBox(custom);
                }
            }
        }

        /// 存款按钮处理事件
        private void buttonDesposit_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == "文件还没打开，请先打开文件，再操作")
                MessageBox.Show("文件还没打开", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (string.IsNullOrEmpty(textBoxAccountName.Text))
                {
                    MessageBox.Show("用户名不可为空", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Customs.ContainsKey(textBoxAccountName.Text) == false)
                    {
                        custom = new Account(textBoxAccountName.Text, starmoney);
                        Customs.Add(textBoxAccountName.Text, custom);
                        AddItemTolistBox(custom);

                    }
                    else
                    {
                        custom = Customs[textBoxAccountName.Text];
                        custom.Deposit(starmoney);
                        AddItemTolistBox(custom);
                    }
                }   
               
            }
        }

        /// 显示所有用户按钮处理事件
        private void 显示所有帐户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == "文件还没打开，请先打开文件，再操作")
                MessageBox.Show("文件还没打开", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    Account[] b = new Account[100];
                    b = cus.Load();
                    string[] str = new string[Customers.m];

                    for (int i = 0; i < Customers.m; i++)
                    {
                        str[i] = string.Format("{0},{1:d4},{2:f2}", b[i].AccountName, b[i].AccountNumber, b[i].AccountBalance);
                    }
                    Form2 fm2 = new Form2(str);
                    fm2.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 存款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDesposit.PerformClick();
        }

        private void 取款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonWithdraw.PerformClick();
        }

        private void listBoxshow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
