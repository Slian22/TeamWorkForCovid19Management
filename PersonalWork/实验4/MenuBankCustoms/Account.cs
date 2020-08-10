using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBankCustoms
{
    class Account
    {
        public static int newAccountNumber = 0001;
        public string accountName;//账户名
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        private int accountNumber;//账户号
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        private double accountBalance;//账户余额

        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }
        public float YearRate
        {
            get { return 0.005f; }
        }
        public Account(string name, double money)
        {
            accountName = name;
            accountBalance = money;
            accountNumber = newAccountNumber;
            newAccountNumber++;
        }
        public Account()
        {
        }
        
        public void Deposit(double money)
        {
            accountBalance += money;
        }
      
        public virtual bool Withdraw(double money)
        {
            if (money > accountBalance)
            {
                return false;
            }
            else
            {
                accountBalance += accountBalance * YearRate;
                accountBalance -= money;
                return true;
            }
        }
    }
}
