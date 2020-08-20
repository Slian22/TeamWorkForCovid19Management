namespace BankCustoms
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxAccountType = new System.Windows.Forms.ComboBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonShowCustoms = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAccountType
            // 
            this.comboBoxAccountType.FormattingEnabled = true;
            this.comboBoxAccountType.Location = new System.Drawing.Point(436, 19);
            this.comboBoxAccountType.Name = "comboBoxAccountType";
            this.comboBoxAccountType.Size = new System.Drawing.Size(114, 20);
            this.comboBoxAccountType.TabIndex = 2;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(253, 88);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(113, 23);
            this.buttonWithdraw.TabIndex = 2;
            this.buttonWithdraw.Text = "取款";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxAccountType);
            this.groupBox2.Controls.Add(this.textBoxUserName);
            this.groupBox2.Controls.Add(this.textBoxMoney);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 52);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入信息";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(89, 19);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(75, 21);
            this.textBoxUserName.TabIndex = 0;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(275, 19);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(86, 21);
            this.textBoxMoney.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "帐户类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "帐户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "存（取）款金额";
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 12;
            this.listBoxStatus.Location = new System.Drawing.Point(10, 131);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(605, 148);
            this.listBoxStatus.TabIndex = 4;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(104, 88);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(111, 23);
            this.buttonDeposit.TabIndex = 1;
            this.buttonDeposit.Text = "存款";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonShowCustoms
            // 
            this.buttonShowCustoms.Location = new System.Drawing.Point(407, 88);
            this.buttonShowCustoms.Name = "buttonShowCustoms";
            this.buttonShowCustoms.Size = new System.Drawing.Size(112, 23);
            this.buttonShowCustoms.TabIndex = 3;
            this.buttonShowCustoms.Text = "显示帐户信息";
            this.buttonShowCustoms.UseVisualStyleBackColor = true;
            this.buttonShowCustoms.Click += new System.EventHandler(this.buttonShowCustoms_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 293);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonShowCustoms);
            this.Name = "FormMain";
            this.Text = "个人存款业务处理";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAccountType;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonShowCustoms;
    }
}

