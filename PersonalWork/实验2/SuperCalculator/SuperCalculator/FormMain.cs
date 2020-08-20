using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperCalculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// 将字符串转换为32位整数或64位浮点数
        /// </summary>
        /// <param name="str">被转换的字符串</param>
        /// <param name="mustGreatThanZero">是否有必须大于零的要求</param>
        /// <param name="result">转换后的结果</param>
        /// <returns></returns>
        private bool ConvertStringToNumber(string str, bool mustGreatThanZero, out int result)
        {
            bool isValid = false;
            if (int.TryParse(str, out result) == false)
            {
                MessageBox.Show(string.Format("无法将{0}转换为整数", str));
            }
            else
            {
                if (result <= 0)
                {
                    MessageBox.Show(string.Format("{0}不是正数", str));
                }
                else
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        /// <summary>
        /// 将字符串转换为32位整数或64位浮点数
        /// </summary>
        /// <param name="str">被转换的字符串</param>
        /// <param name="mustGreatThanZero">是否有必须大于零的要求</param>
        /// <param name="result">转换后的结果</param>
        /// <returns></returns>
        private bool ConvertStringToNumber(string str, bool mustGreatThanZero, out double result)
        {
            bool isValid = false;
            if (double.TryParse(str, out result) == false)
            {
                MessageBox.Show(string.Format("无法将{0}转换为实数", str));
            }
            else
            {
                if (result <= 0)
                {
                    MessageBox.Show(string.Format("{0}不是正数", str));
                }
                else
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            int startAmount;   //存款金额
            double yearRate;   //年利率
            int years;　　   　//存期
            if (ConvertStringToNumber(textBoxStartAmount.Text, true, out startAmount) == false) return;
            if (startAmount < 100)
            {
                MessageBox.Show("金额不能小于100元");
                return;
            }
            if (ConvertStringToNumber(textBoxYearRate.Text, true, out yearRate) == false) return;
            yearRate /= 100;
            if (ConvertStringToNumber(textBoxYears.Text, true, out years) == false) return;
            if (comboBoxCalculateFrequency.SelectedIndex == -1)
            {
                MessageBox.Show("请选择提供的利息计算方式");
                return;
            }
            string calculateFrequency = comboBoxCalculateFrequency.SelectedItem.ToString();
            switch (calculateFrequency)
            {
                case "按月计息":
                    textBoxTotal.Text = string.Format("{0:F2}元", Caculate(startAmount, yearRate / 12, years * 12));
                    break;
                case "按季度计息":
                    textBoxTotal.Text = string.Format("{0:F2}元", Caculate(startAmount, yearRate / 4, years * 4));
                    break;
                case "按年计息":
                    textBoxTotal.Text = string.Format("{0:F2}元", Caculate(startAmount, yearRate, years));
                    break;
            }
        }
        /// <summary>
        /// 计算到期结算金额
        /// </summary>
        /// <param name="startAmount">存款金额</param>
        /// <param name="rate">利率</param>
        /// <param name="count">叠加次数</param>
        /// <returns></returns>
        private double Caculate(double startAmount, double rate, int count)
        {
            double total = startAmount;
            for (int i = 1; i <= count; i++)
            {
                total += total * rate;
            }
            return total;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            textBoxStartAmount.Focus();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //保证修改任一输入值时，不显示计算结果
            textBoxTotal.Clear();
        }
    }
}