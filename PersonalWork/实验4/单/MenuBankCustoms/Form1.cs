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
    public partial class Form1 : Form
    {
        public Form1(string[] custm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            for (int i = 0; i < custm.Length; i++)
            {
                listBoxShowall.Items.Add(custm[i]);
            }
        }
    }
}
