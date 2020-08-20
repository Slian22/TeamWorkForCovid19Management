using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace MenuBankCustoms
{
    /// <summary>
    /// ���ڴ���ʻ�
    /// </summary>
    class Account
    {
        private string fileName = "bankdata.txt";
        private static int newAccountNumber = 0;
        /// <summary>
        /// ��������
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
        /// �ʻ���
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
        /// �ʺ�
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
        /// �ʻ����
        /// </summary>
        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }
        }

        /// <summary>
        /// �������ڴ���ʻ�
        /// </summary>
        /// <param name="accountName">�ʻ���</param>
        /// <param name="accountNumber">�ʺ�</param>
        /// <param name="accountBalance">���</param>
        public Account(string accountName, int accountNumber, double accountBalance)
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
        }

        /// <summary>
        /// �������ڴ���ʻ����Զ������ʺţ�
        /// </summary>
        /// <param name="accountName">�ʻ���</param>
        /// <param name="accountBalance">���</param>
        public Account(string accountName, double accountBalance)
        {
            if (newAccountNumber > 4999)
            {
                throw new Exception("�ʻ����Ѿ�����");
            }
            else
            {
                //�жϲ����е�accountName�Ƿ�Ϸ�
                if (string.IsNullOrEmpty(accountName) == true)
                {
                    throw new Exception("�ʻ�������Ϊnull����ַ���");
                }
                else
                {
                    for (int i = 0; i < accountName.Length; i++)
                    {
                        if (char.IsLetter(accountName[i]) == false)
                        {
                            throw new Exception("�ʻ����в������зǷ��ַ�");
                        }
                        else
                        {
                            this.accountName = accountName;
                        }
                    }
                }
                //�жϲ����е�accountBalance�Ƿ�Ϸ�
                if (accountBalance <= 0)
                {
                    throw new Exception("�ʻ�����Ϊ���ֵ");
                }
                else
                {
                    this.accountBalance = accountBalance;
                }
                if (newAccountNumber == 0)
                {
                    //�ȼ����Զ����������ʺŵ�ֵ
                    InitializeNewAccountNumber();
                }
                accountNumber = newAccountNumber;
                newAccountNumber++;
            }
        }
        /// <summary>
        /// ��ʼ����Ҫʹ�õ����ʺ�
        /// </summary>
        private void InitializeNewAccountNumber()
        {
            //����ԭ���ʺŸ���
            if (File.Exists(fileName) == true)
            {
                StreamReader sr = File.OpenText(fileName);
                while (sr.ReadLine() != null)
                {
                    newAccountNumber++;
                }
                sr.Close();
            }
            //���ʺ�Ӧ����ԭ���ʺŸ�����1
            newAccountNumber++;
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
        public void Withdraw(double money)
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
                    //ÿȡ��һ���Ƚ���һ��
                    accountBalance += InterestRate * accountBalance;
                    //ȡ��
                    accountBalance -= money;
                }
            }
        }
    }
}
