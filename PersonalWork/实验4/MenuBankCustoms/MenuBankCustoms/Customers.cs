using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace MenuBankCustoms
{
    /// <summary>
    /// 处理活期存款业务
    /// </summary>
    class Customers
    {
        private string fileName = "bankdata.txt";

        /// <summary>
        /// 从文本文件读取帐户到具有键/值对集合的泛型列表中
        /// </summary>
        /// <returns>以帐户名为键，活期存款帐户为值的泛型列表</returns>
        public SortedList<string, Account> Load()
        {
            SortedList<string, Account> customs = new SortedList<string, Account>();
            if (File.Exists(fileName) == false)
            {
                return customs;
            }
            StreamReader sr = File.OpenText(fileName);
            while (sr.Peek() != -1)
            {
                //每行格式为：帐户名/帐号/余额
                string[] splitString = sr.ReadLine().Split('/');
                Account account = new Account(splitString[0], int.Parse(splitString[1]), double.Parse(splitString[2]));
                customs.Add(splitString[0], account);
            }
            sr.Close();
            return customs;
        }

        /// <summary>
        /// 将所有活期存款帐户信息保存到文本文件中
        /// </summary>
        /// <param name="customs">以帐户名为键，活期存款帐户为值的泛型列表</param>
        /// <returns>保存成功返回true，否则返回false</returns>
        public bool Save(SortedList<string, Account> customs)
        {
            if (File.Exists(fileName) == true)
            {
                if (MessageBox.Show("保存到文件中会覆盖原来的文件，继续吗？", "提示",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return false;
                }
            }
            StreamWriter sw = File.CreateText(fileName);
            for (int i = 0; i < customs.Count; i++)
            {
                sw.WriteLine(string.Format("{0}/{1}/{2}", customs.Values[i].AccountName, customs.Values[i].AccountNumber, customs.Values[i].AccountBalance));
            }
            sw.Close();
            return true;
        }

        /// <summary>
        /// 活期存款开户
        /// </summary>
        /// <param name="userName">帐户名</param>
        /// <param name="initMoney">开户金额</param>
        public Account CreateAccount(string userName, double initMoney)
        {
            try
            {
                Account account = new Account(userName, initMoney);
                return account;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return null;
            }
        }

    }
}
