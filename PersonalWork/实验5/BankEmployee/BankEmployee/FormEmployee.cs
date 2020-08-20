using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankEmployee
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            groupBox1.Text = "";
        }

        private void basicTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.basicTableBindingSource.EndEdit();
                this.basicTableTableAdapter.Update(this.employeeDataSet.BasicTable);
                labelTip.Text = "保存成功";
            }
            catch(Exception err)
            {
                labelTip.Text = "保存失败：" + err.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.basicTableTableAdapter.Fill(this.employeeDataSet.BasicTable);
            ChangeCurrentPosition(CurrentOperator.当前记录);
         }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //根据打开的图像文件创建原始图像大小的Bitmap对象
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                //按比例缩放显示（因为Picture的SizeMode属性为Zoom）,但原始图像大小未变
                pictureBoxPhoto.Image = image;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxPhoto.Image = null;
        }

        private void basicTableBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                basicTableBindingSource.AddNew();
                ChangeCurrentPosition(CurrentOperator.当前记录);
                textBoxName.Focus();
            }
            catch(Exception err)
            {
                labelTip.Text = "当前记录有错："+err.Message;
            }
        }

        enum CurrentOperator { 第一个记录, 前一个记录, 下一个记录, 最后一个记录, 当前记录 };
        private void ChangeCurrentPosition(CurrentOperator cp)
        {
            labelTip.Text = "温馨提示：操作一段时间后别忘了保存一下";
            try
            {
                switch (cp)
                {
                    case CurrentOperator.第一个记录:
                        basicTableBindingSource.MoveFirst();
                        break;
                    case CurrentOperator.前一个记录:
                        basicTableBindingSource.MovePrevious();
                        break;
                    case CurrentOperator.下一个记录:
                        basicTableBindingSource.MoveNext();
                        break;
                    case CurrentOperator.最后一个记录:
                        basicTableBindingSource.MoveLast();
                        break;
                }
            }
            catch (Exception err)
            {
                labelTip.Text = "当前记录有错：" + err.Message;
            }
            int pos = basicTableBindingSource.Position;
            int max=basicTableBindingSource.Count;
            bindingNavigatorMoveFirstItem.Enabled = pos <= 0 ? false : true;
            bindingNavigatorMovePreviousItem.Enabled = pos <= 0 ? false : true;
            bindingNavigatorMoveNextItem.Enabled = pos >= max - 1 ? false : true;
            bindingNavigatorMoveLastItem.Enabled = pos >= max - 1 ? false : true;
            if (basicTableBindingSource.Count == 0)
            {
                labelTip.Text = "操作提示：库中无记录，请单击【+】添加新记录";
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            ChangeCurrentPosition(CurrentOperator.前一个记录);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            ChangeCurrentPosition(CurrentOperator.下一个记录);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            ChangeCurrentPosition(CurrentOperator.最后一个记录);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            ChangeCurrentPosition(CurrentOperator.第一个记录);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                basicTableBindingSource.RemoveCurrent();
                ChangeCurrentPosition(CurrentOperator.当前记录);
            }
            catch (Exception err)
            {
                labelTip.Text = "出错：" + err.Message;
            }
        }

    }
}