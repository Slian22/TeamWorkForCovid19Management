using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuBankCustoms
{
    public partial class Form2 : Form
    {
        public Form2(string[] str)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            for (int i = 0; i < str.Length; i++)
            {
                string[] s = str[i].Split(',');
                AddlistviewItem(s[0],s[1],s[2]);
            }
        }
        private void AddlistviewItem(string s1,string s2,string s3)
        {
            int imageIndex = 0;
            ListViewItem item = new ListViewItem(
                new string[] {s1,s2,s3}, imageIndex);
            listView1.Items.Add(item);
            listView1.View = View.Details;
        }
    }
}
