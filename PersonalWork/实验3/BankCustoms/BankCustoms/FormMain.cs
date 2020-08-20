using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankCustoms
{
    public partial class FormMain : Form
    {
        //定义一个枚举类型，表示提供的业务类型
        private enum CustomType
        {
            活期存款,
            定期存款
        }
        //保存所有活期存款帐户，用帐户名做键，同一个人只能有一个活期帐号
        static SortedList<string, CheckingCustom> checkingCustomers = new SortedList<string, CheckingCustom>();
        //保存所有定期存款帐户，用帐户名做键，同一个人只能有一个定期帐号
        static SortedList<string, FixedCustom> fixedCustomers = new SortedList<string, FixedCustom>();
        public FormMain()
        {
            InitializeComponent();
            //将表示存款类型的所有枚举值添入到下拉列表框中
            comboBoxAccountType.Items.AddRange(Enum.GetNames(typeof(CustomType)));
            //设置默认选项为活期存款
            comboBoxAccountType.SelectedIndex = 0;
        }

        /// <summary>
        /// 活期存款或定期存款开户
        /// </summary>
        /// <param name="customType">存款类型，有两种：活期存款，定期存款</param>
        /// <param name="userName">帐户名</param>
        /// <param name="initMoney">开户金额</param>
        private void CreateCustom(CustomType customType, string userName, double initMoney)
        {
            if (customType == CustomType.活期存款)
            {
                try
                {
                    CheckingCustom newCustom = new CheckingCustom(userName, initMoney);
                    checkingCustomers.Add(userName, newCustom);
                    AddItemToListBox(string.Format("{0}开户{1}元", userName, initMoney), newCustom);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                //定期存款
                try
                {
                    FixedCustom newCustom = new FixedCustom(userName, initMoney);
                    fixedCustomers.Add(userName, newCustom);
                    AddItemToListBox(string.Format("{0}开户{1}元", userName, initMoney), newCustom);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        /// <summary>
        /// 将操作信息添加到状态信息列表中
        /// </summary>
        /// <param name="prompt">提示信息</param>
        /// <param name="user">活期存款帐户</param>
        private void AddItemToListBox(string prompt, CheckingCustom custom)
        {
            listBoxStatus.Items.Add(string.Format("{0}, 帐户信息：帐户名{1}，账号{2:d4}，当前余额{3:n2}元",
                prompt, custom.AccountName, custom.AccountNumber, custom.AccountBalance));
        }

        /// <summary>
        /// 将操作信息添加到状态信息列表中
        /// </summary>
        /// <param name="prompt">提示信息</param>
        /// <param name="user">定期存款帐户</param>
        private void AddItemToListBox(string prompt, FixedCustom custom)
        {
            listBoxStatus.Items.Add(string.Format("{0}, 帐户信息：帐户名{1}，账号{2:d4}，当前余额{3:n2}元",
                prompt, custom.AccountName, custom.AccountNumber, custom.AccountBalance));
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            double money;
            if (double.TryParse(textBoxMoney.Text, out money) == false)
            {
                MessageBox.Show("存款金额不正确", "无法存款", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (comboBoxAccountType.SelectedItem.ToString() == "活期存款")
            {
                if (checkingCustomers.ContainsKey(textBoxUserName.Text) == false)
                {
                    //如果无此帐户，创建帐户，并将存款作为开户金额
                    CreateCustom(CustomType.活期存款, textBoxUserName.Text, money);
                }
                else
                {
                    //如果有此帐户，在现有帐户上追加存款
                    try
                    {
                        CheckingCustom custom = checkingCustomers[textBoxUserName.Text];
                        custom.Diposit(money);
                        AddItemToListBox(string.Format("{0}存款{1}元", textBoxUserName.Text, money), custom);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            else
            {
                if (fixedCustomers.ContainsKey(textBoxUserName.Text) == false)
                {
                    CreateCustom(CustomType.定期存款, textBoxUserName.Text, money);
                }
                else
                {
                    try
                    {
                        FixedCustom custom = fixedCustomers[textBoxUserName.Text];
                        custom.Diposit(money);
                        AddItemToListBox(string.Format("{0}存款{1}元", textBoxUserName.Text, money), custom);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
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
            if (comboBoxAccountType.SelectedItem.ToString() == "活期存款")
            {
                if (checkingCustomers.ContainsKey(textBoxUserName.Text) == false)
                {
                    MessageBox.Show("无此帐户,无法取款", "取款失败", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    //如果有此帐户，在现有帐户中取款
                    try
                    {
                        CheckingCustom custom = checkingCustomers[textBoxUserName.Text];
                        //获取结算前余额
                        double balance = custom.AccountBalance;
                        //取款
                        custom.Withdraw(money);
                        AddItemToListBox(string.Format("{0}取款{1}元，结算利息{2:n2}元", textBoxUserName.Text, money, custom.AccountBalance + money - balance), custom);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            else
            {
                if (fixedCustomers.ContainsKey(textBoxUserName.Text) == false)
                {
                    MessageBox.Show("无此帐户,无法取款", "取款失败", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    //如果有此帐户，在现有帐户中取款
                    try
                    {
                        FixedCustom custom = fixedCustomers[textBoxUserName.Text];
                        //获取结算前余额
                        double balance = custom.AccountBalance;
                        //取款
                        custom.Withdraw(money);
                        AddItemToListBox(string.Format("{0}取款{1}元，结算利息{2:n2}元", textBoxUserName.Text, money, custom.AccountBalance + money - balance), custom);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        private void buttonShowCustoms_Click(object sender, EventArgs e)
        {
            listBoxStatus.Items.Clear();
            for (int i = 0; i < checkingCustomers.Count; i++)
            {
                AddItemToListBox("活期存款", checkingCustomers.Values[i]);
            }
            for (int i = 0; i < fixedCustomers.Count; i++)
            {
                AddItemToListBox("定期存款", fixedCustomers.Values[i]);
            }
        }
    }
}