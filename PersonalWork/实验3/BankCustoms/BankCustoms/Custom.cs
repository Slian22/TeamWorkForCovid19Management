using System;
using System.Collections.Generic;
using System.Text;
namespace BankCustoms
{
    class Custom
    {
        private string accountName; //�ʻ���
        //protected���η���֤����ֻ�ܹ���������ʣ��ⲿ�޷�����
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
                    throw new Exception("�ʻ�������Ϊnull����ַ���");
                }
                else
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsLetter(value[i]) == false)
                        {
                            throw new Exception("�ʻ����в������зǷ��ַ�");
                        }
                        else
                        {
                            accountName = value;
                        }
                    }
                }
            }
        }
        private int accountNumber;  //�ʻ���
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
        private double accountBalance;  //�ʻ����
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
                    throw new Exception("�ʻ�����Ϊ���ֵ");
                }
                else
                {
                    accountBalance = value;
                }
            }
        }

        /// <summary>
        ///��� 
        /// </summary>
        /// <param name="money">�����</param>
        public void Diposit(double money)
        {
            if (money <= 0)
            {
                throw new Exception("�������Ϊ���ֵ");
            }
            else
            {
                //�޸����
                accountBalance += money;
            }
        }

        /// <summary>
        ///ȡ�� 
        /// </summary>
        /// <param name="money">ȡ����</param>
        public virtual void Withdraw(double money)
        {
            if (money <= 0)
            {
                throw new Exception("ȡ������Ϊ���ֵ");
            }
            else
            {
                if (money > accountBalance)
                {
                    throw new Exception("ȡ�������ܱ�����");
                }
                else
                {
                    accountBalance -= money;
                }
            }
        }
    }
}
