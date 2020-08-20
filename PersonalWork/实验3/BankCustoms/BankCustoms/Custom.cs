using System;
using System.Collections.Generic;
using System.Text;
namespace BankCustoms
{
    class Custom
    {
        private string accountName; //帐户名
        //protected修饰符保证属性只能供扩充类访问，外部无法访问
        protected string AccountName
        {
            get
            {
                return accountName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    throw new Exception("帐户名不能为null或空字符串");
                }
                else
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsLetter(value[i]) == false)
                        {
                            throw new Exception("帐户名中不允许有非法字符");
                        }
                        else
                        {
                            accountName = value;
                        }
                    }
                }
            }
        }
        private int accountNumber;  //帐户号
        protected int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        private double accountBalance;  //帐户余额
        protected double AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("帐户余额不能为零或负值");
                }
                else
                {
                    accountBalance = value;
                }
            }
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
        public virtual void Withdraw(double money)
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
                    accountBalance -= money;
                }
            }
        }
    }
}
