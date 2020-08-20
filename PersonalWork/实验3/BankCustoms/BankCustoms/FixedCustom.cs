using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustoms
{
    /// <summary>
    /// 表示定期存款帐户
    /// </summary>
    class FixedCustom : Custom
    {
        private static int newAccountNumber = 5000;
        public float InterestRate  //定期利率
        {
            get
            {
                if (AccountBalance > 500)
                {
                    return 0.06f;
                }
                else
                {
                    return 0.03f;
                }
            }
        }
        //为保护帐户名、帐号的同一性，不允许外部给AccountName单独赋值
        //由于此属性名和基类的属性名相同，所以用new修饰符隐藏了基类的属性
        public new string AccountName
        {
            get
            {
                return base.AccountName;
            }
        }
        //为保护帐户名、帐号的同一性，不允许外部给AccountNumber单独赋值
        public new int AccountNumber
        {
            get
            {
                return base.AccountNumber;
            }
        }
        public new double AccountBalance
        {
            get
            {
                return base.AccountBalance;
            }
        }

        //构造函数
        public FixedCustom(string accountName, double accountBalance)
        {
            if (newAccountNumber > 9999)
            {
                throw new Exception("帐户号已经用完");
            }
            else
            {
                //添加base前缀表明访问的是基类的属性，而不是本类中的属性
                base.AccountName = accountName;
                base.AccountBalance = accountBalance;
                base.AccountNumber = newAccountNumber;
                newAccountNumber++;
            }
        }

        /// <summary>
        ///取款 
        /// </summary>
        /// <param name="money">取款金额</param>
        public override void Withdraw(double money)
        {
            //每取款一次先结算一次
            base.AccountBalance += InterestRate * AccountBalance;
            //调用基类的Withdraw完成取款功能
            base.Withdraw(money);
        }
    }
}
