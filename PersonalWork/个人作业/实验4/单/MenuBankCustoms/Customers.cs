using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MenuBankCustoms
{
    class Customers
    {
        public static int m;
        Account[] a = new Account[100];
        string path = "account.txt";
        public Account[] Load()
        {
            m = 0;
            string line;
            //检查文件是否存在，存在打开，不存在就创建空文件。
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                while ((line = sr.ReadLine()) != null)
                {
                    string[] ln = line.Split(' ');
                    a[m] = new Account();
                    a[m].AccountName = Convert.ToString(ln[0]);
                    a[m].AccountNumber = Convert.ToInt32(ln[1]);
                    a[m].AccountBalance = Convert.ToDouble(ln[2]);
                    m++;
                }
                sr.Close();
            }
            else
            {
                File.AppendAllText(path, "", Encoding.Default);
            }
            return a;
        }

        public void Save(Account[] cust)
        {
            if (File.Exists(path))
                File.Delete(path);
            for (int n = 0; n < cust.Length; n++)
            { 
               string str=string.Format("{0} {1} {2} {3}",cust[n].AccountName,cust[n].AccountNumber,cust[n].AccountBalance,Environment.NewLine);
               File.AppendAllText(path, str, Encoding.Default);
            }
        }
    }
}
