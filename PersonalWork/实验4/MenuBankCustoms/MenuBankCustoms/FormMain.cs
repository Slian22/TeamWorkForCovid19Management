using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MenuBankCustoms
{
    public partial class FormMain : Form
    {
        SortedList<string, Account> accounts = new SortedList<string, Account>();
        Customers customs = new Customers();
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 将操作信息添加到状态信息列表中
        /// </summary>
        /// <param name="prompt">提示信息</param>
        /// <param name="user">活期存款帐户</param>
        private void AddItemToListBox(string prompt, Account account)
        {
            listBoxStatus.Items.Add(string.Format("{0}, 帐户信息：帐户名{1}，帐号{2:d4}，当前余额{3:n2}元",
                prompt, account.AccountName, account.AccountNumber, account.AccountBalance));
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            accounts = customs.Load();
            listBoxStatus.Items.Clear();
            for (int i = 0; i < accounts.Count; i++)
            {
                AddItemToListBox("记录"+(i+1), accounts.Values[i]);
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (customs.Save(accounts) == true)
            {
                MessageBox.Show("保存成功", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            double money;
            if (double.TryParse(textBoxMoney.Text, out money) == false)
            {
                MessageBox.Show("存款金额不正确", "无法存款", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (accounts.ContainsKey(textBoxUserName.Text) == false)
            {
                //如果无此帐户，创建帐户，并将存款作为开户金额
                Account account=customs.CreateAccount(textBoxUserName.Text, money);
                accounts.Add(account.AccountName, account);
                AddItemToListBox(string.Format("{0}开户{1}元", textBoxUserName.Text, money), account);
            }
            else
            {
                //如果有此帐户，在现有帐户上追加存款
                try
                {
                    Account account = accounts[textBoxUserName.Text];
                    account.Diposit(money);
                    AddItemToListBox(string.Format("{0}存款{1}元", textBoxUserName.Text, money), account);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            double money;
            if (double.TryParse(textBoxMoney.Text, out money) == false)
            {
                MessageBox.Show("取款金额不正确", "无法取款", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (accounts.ContainsKey(textBoxUserName.Text) == false)
            {
                MessageBox.Show("无此帐户,无法取款", "取款失败", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                //如果有此帐户，在现有帐户中取款
                try
                {
                   Account account = accounts[textBoxUserName.Text];
                    //获取结算前余额
                    double balance = account.AccountBalance;
                    //取款
                    account.Withdraw(money);
                    AddItemToListBox(string.Format("{0}取款{1}元，结算利息{2:n2}元", textBoxUserName.Text, money, account.AccountBalance + money - balance), account);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            menuItemOpen_Click(null, null);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            menuItemSave_Click(null, null);
        }

        private void toolStripButtonShow_Click(object sender, EventArgs e)
        {
            string[] strArray = new string[accounts.Count];
            for (int i = 0; i < accounts.Count; i++)
            {
                strArray[i] = string.Format("{0}/{1:d4}/当前余额{2:n2}",
                    accounts.Values[i].AccountName,
                    accounts.Values[i].AccountNumber,
                    accounts.Values[i].AccountBalance);
            } 
            FormShowAccountMessage fm = new FormShowAccountMessage(strArray);
            fm.ShowDialog();
        }

        private void toolStripButtonShow_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "将内存中所有存款人的信息显示出来";
        }

        private void toolStripButtonSave_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "将所有存款人的信息保存到文件bankdata.txt中";
        }

        private void toolStripButtonOpen_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "从文件bankdata.txt中将所有存款人的信息读到内存中";
        }

        private void buttonDeposit_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "处理存款人开户或者在其已有帐户上添加新的存款";
        }

        private void buttonWithdraw_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "处理存款人在其已有帐户上取款";
        }
    }
}