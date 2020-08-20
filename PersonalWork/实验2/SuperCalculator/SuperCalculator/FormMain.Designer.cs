namespace SuperCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCalculateFrequency = new System.Windows.Forms.ComboBox();
            this.textBoxYears = new System.Windows.Forms.TextBox();
            this.textBoxYearRate = new System.Windows.Forms.TextBox();
            this.textBoxStartAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCalculateFrequency);
            this.groupBox1.Controls.Add(this.textBoxYears);
            this.groupBox1.Controls.Add(this.textBoxYearRate);
            this.groupBox1.Controls.Add(this.textBoxStartAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxCalculateFrequency
            // 
            this.comboBoxCalculateFrequency.FormattingEnabled = true;
            this.comboBoxCalculateFrequency.Items.AddRange(new object[] {
            "按月计息",
            "按季度计息",
            "按年计息"});
            this.comboBoxCalculateFrequency.Location = new System.Drawing.Point(115, 137);
            this.comboBoxCalculateFrequency.Name = "comboBoxCalculateFrequency";
            this.comboBoxCalculateFrequency.Size = new System.Drawing.Size(165, 20);
            this.comboBoxCalculateFrequency.TabIndex = 3;
            // 
            // textBoxYears
            // 
            this.textBoxYears.Location = new System.Drawing.Point(115, 99);
            this.textBoxYears.Name = "textBoxYears";
            this.textBoxYears.Size = new System.Drawing.Size(165, 21);
            this.textBoxYears.TabIndex = 2;
            // 
            // textBoxYearRate
            // 
            this.textBoxYearRate.Location = new System.Drawing.Point(115, 61);
            this.textBoxYearRate.Name = "textBoxYearRate";
            this.textBoxYearRate.Size = new System.Drawing.Size(165, 21);
            this.textBoxYearRate.TabIndex = 1;
            // 
            // textBoxStartAmount
            // 
            this.textBoxStartAmount.Location = new System.Drawing.Point(115, 23);
            this.textBoxStartAmount.Name = "textBoxStartAmount";
            this.textBoxStartAmount.Size = new System.Drawing.Size(165, 21);
            this.textBoxStartAmount.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "利息计算方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "存期（年）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "年利率（％）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "存款金额（元）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "到期结算金额";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(127, 210);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(165, 21);
            this.textBoxTotal.TabIndex = 2;
            this.textBoxTotal.TabStop = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(117, 249);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "计算";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 284);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "超级存款计算器";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYears;
        private System.Windows.Forms.TextBox textBoxYearRate;
        private System.Windows.Forms.TextBox textBoxStartAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBoxCalculateFrequency;
    }
}

