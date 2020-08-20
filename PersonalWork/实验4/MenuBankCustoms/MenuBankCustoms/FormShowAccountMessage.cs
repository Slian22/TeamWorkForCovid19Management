using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MenuBankCustoms
{
    public partial class FormShowAccountMessage : Form
    {
        public FormShowAccountMessage(string[] strArray)
        {
            InitializeComponent();
            for (int i = 0; i < strArray.Length; i++)
            {
                listView1.Items.Add(new ListViewItem(strArray[i].Split('/')));
            }
        }
    }
}