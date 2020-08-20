using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustoms
{
    /// <summary>
    /// ��ʾ���ڴ���ʻ�
    /// </summary>
    class FixedCustom : Custom
    {
        private static int newAccountNumber = 5000;
        public float InterestRate  //��������
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
        //Ϊ�����ʻ������ʺŵ�ͬһ�ԣ��������ⲿ��AccountName������ֵ
        //���ڴ��������ͻ������������ͬ��������new���η������˻��������
        public new string AccountName
        {
            get
            {
                return base.AccountName;
            }
        }
        //Ϊ�����ʻ������ʺŵ�ͬһ�ԣ��������ⲿ��AccountNumber������ֵ
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

        //���캯��
        public FixedCustom(string accountName, double accountBalance)
        {
            if (newAccountNumber > 9999)
            {
                throw new Exception("�ʻ����Ѿ�����");
            }
            else
            {
                //���baseǰ׺�������ʵ��ǻ�������ԣ������Ǳ����е�����
                base.AccountName = accountName;
                base.AccountBalance = accountBalance;
                base.AccountNumber = newAccountNumber;
                newAccountNumber++;
            }
        }

        /// <summary>
        ///ȡ�� 
        /// </summary>
        /// <param name="money">ȡ����</param>
        public override void Withdraw(double money)
        {
            //ÿȡ��һ���Ƚ���һ��
            base.AccountBalance += InterestRate * AccountBalance;
            //���û����Withdraw���ȡ���
            base.Withdraw(money);
        }
    }
}
