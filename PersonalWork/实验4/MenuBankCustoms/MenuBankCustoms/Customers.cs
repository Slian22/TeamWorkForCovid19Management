using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace MenuBankCustoms
{
    /// <summary>
    /// ������ڴ��ҵ��
    /// </summary>
    class Customers
    {
        private string fileName = "bankdata.txt";

        /// <summary>
        /// ���ı��ļ���ȡ�ʻ������м�/ֵ�Լ��ϵķ����б���
        /// </summary>
        /// <returns>���ʻ���Ϊ�������ڴ���ʻ�Ϊֵ�ķ����б�</returns>
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
                //ÿ�и�ʽΪ���ʻ���/�ʺ�/���
                string[] splitString = sr.ReadLine().Split('/');
                Account account = new Account(splitString[0], int.Parse(splitString[1]), double.Parse(splitString[2]));
                customs.Add(splitString[0], account);
            }
            sr.Close();
            return customs;
        }

        /// <summary>
        /// �����л��ڴ���ʻ���Ϣ���浽�ı��ļ���
        /// </summary>
        /// <param name="customs">���ʻ���Ϊ�������ڴ���ʻ�Ϊֵ�ķ����б�</param>
        /// <returns>����ɹ�����true�����򷵻�false</returns>
        public bool Save(SortedList<string, Account> customs)
        {
            if (File.Exists(fileName) == true)
            {
                if (MessageBox.Show("���浽�ļ��лḲ��ԭ�����ļ���������", "��ʾ",
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
        /// ���ڴ���
        /// </summary>
        /// <param name="userName">�ʻ���</param>
        /// <param name="initMoney">�������</param>
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
