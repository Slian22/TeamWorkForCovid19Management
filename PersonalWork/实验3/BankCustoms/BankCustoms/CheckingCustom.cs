using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustoms
{
    /// <summary>
    /// ��ʾ���ڴ���ʻ�
    /// </summary>
    class CheckingCustom : Custom
    {
        private static int newAccountNumber = 1;
        public float InterestRate  //��������
        {
            get
            {
                return 0.005f;
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
        public CheckingCustom(string accountName, double accountBalance)
        {
            if (newAccountNumber > 4999)
            {
                throw new Exception("�ʻ����Ѿ�����");
            }
            else
            {
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
