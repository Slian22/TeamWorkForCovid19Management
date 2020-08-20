using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace MenuBankCustoms
{
    /// <summary>
    /// 活期存款帐户
    /// </summary>
    class Account
    {
        private string fileName = "bankdata.txt";
        private static int newAccountNumber = 0;
        /// <summary>
        /// 活期利率
        /// </summary>
        public float InterestRate
        {
            get
            {
                return 0.005f;
            }
        }
        private string accountName; 
        /// <summary>
        /// 帐户名
        /// </summary>
        public string AccountName
        {
            get
            {
                return accountName;
            }
        }
        private int accountNumber;
        /// <summary>
        /// 帐号
        /// </summary>
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }
        private double accountBalance;
        /// <summary>
        /// 帐户余额
        /// </summary>
        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }
        }

        /// <summary>
        /// 创建活期存款帐户
        /// </summary>
        /// <param name="accountName">帐户名</param>
        /// <param name="accountNumber">帐号</param>
        /// <param name="accountBalance">余额</param>
        public Account(string accountName, int accountNumber, double accountBalance)
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
        }

        /// <summary>
        /// 创建活期存款帐户（自动生成帐号）
        /// </summary>
        /// <param name="accountName">帐户名</param>
        /// <param name="accountBalance">余额</param>
        public Account(string accountName, double accountBalance)
        {
            if (newAccountNumber > 4999)
            {
                throw new Exception("帐户号已经用完");
            }
            else
            {
                //判断参数中的accountName是否合法
                if (string.IsNullOrEmpty(accountName) == true)
                {
                    throw new Exception("帐户名不能为null或空字符串");
                }
                else
                {
                    for (int i = 0; i < accountName.Length; i++)
                    {
                        if (char.IsLetter(accountName[i]) == false)
                        {
                            throw new Exception("帐户名中不允许有非法字符");
                        }
                        else
                        {
                            this.accountName = accountName;
                        }
                    }
                }
                //判断参数中的accountBalance是否合法
                if (accountBalance <= 0)
                {
                    throw new Exception("帐户余额不能为零或负值");
                }
                else
                {
                    this.accountBalance = accountBalance;
                }
                if (newAccountNumber == 0)
                {
                    //先计算自动产生的新帐号的值
                    InitializeNewAccountNumber();
                }
                accountNumber = newAccountNumber;
                newAccountNumber++;
            }
        }
        /// <summary>
        /// 初始化将要使用的新帐号
        /// </summary>
        private void InitializeNewAccountNumber()
        {
            //读出原有帐号个数
            if (File.Exists(fileName) == true)
            {
                StreamReader sr = File.OpenText(fileName);
                while (sr.ReadLine() != null)
                {
                    newAccountNumber++;
                }
                sr.Close();
            }
            //新帐号应该是原有帐号个数加1
            newAccountNumber++;
        }
        /// <summary>
        ///存款 
        /// </summary>
        /// <param name="money">存款金额</param>
        public void Diposit(double money)
        {
            if (money <= 0)
            {
                throw new Exception("存款余额不能为零或负值");
            }
            else
            {
                //修改余额
                accountBalance += money;
            }
        }

        /// <summary>
        ///取款 
        /// </summary>
        /// <param name="money">取款金额</param>
        public void Withdraw(double money)
        {
            if (money <= 0)
            {
                throw new Exception("取款余额不能为零或负值");
            }
            else
            {
                if (money > accountBalance)
                {
                    throw new Exception("取款数不能比余额大");
                }
                else
                {
                    //每取款一次先结算一次
                    accountBalance += InterestRate * accountBalance;
                    //取款
                    accountBalance -= money;
                }
            }
        }
    }
}
