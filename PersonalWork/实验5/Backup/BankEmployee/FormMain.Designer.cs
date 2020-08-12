namespace BankEmployee
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
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
            this.components = new System.ComponentModel.Container();
            this.radioButtonManage = new System.Windows.Forms.RadioButton();
            this.radioButtonQuery = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.selectAllUserNameFromOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet1 = new BankEmployee.EmployeeDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.selectOperatorTableAdapter1 = new BankEmployee.EmployeeDataSetTableAdapters.SelectOperatorTableAdapter();
            this.selectAllUserNameFromOperatorTableAdapter = new BankEmployee.EmployeeDataSetTableAdapters.SelectAllUserNameFromOperatorTableAdapter();
            this.simpleQueryTableAdapter1 = new BankEmployee.EmployeeDataSetTableAdapters.SimpleQueryTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllUserNameFromOperatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonManage
            // 
            this.radioButtonManage.AutoSize = true;
            this.radioButtonManage.Location = new System.Drawing.Point(43, 26);
            this.radioButtonManage.Name = "radioButtonManage";
            this.radioButtonManage.Size = new System.Drawing.Size(95, 16);
            this.radioButtonManage.TabIndex = 0;
            this.radioButtonManage.TabStop = true;
            this.radioButtonManage.Text = "基本信息管理";
            this.radioButtonManage.UseVisualStyleBackColor = true;
            this.radioButtonManage.CheckedChanged += new System.EventHandler(this.radioButtonManage_CheckedChanged);
            // 
            // radioButtonQuery
            // 
            this.radioButtonQuery.AutoSize = true;
            this.radioButtonQuery.Location = new System.Drawing.Point(193, 26);
            this.radioButtonQuery.Name = "radioButtonQuery";
            this.radioButtonQuery.Size = new System.Drawing.Size(95, 16);
            this.radioButtonQuery.TabIndex = 1;
            this.radioButtonQuery.TabStop = true;
            this.radioButtonQuery.Text = "统计男女人数";
            this.radioButtonQuery.UseVisualStyleBackColor = true;
            this.radioButtonQuery.CheckedChanged += new System.EventHandler(this.radioButtonQuery_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQuery);
            this.groupBox1.Controls.Add(this.radioButtonManage);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(33, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统功能";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(262, 71);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(121, 21);
            this.textBoxPassword.TabIndex = 9;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectAllUserNameFromOperatorBindingSource, "username", true));
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(84, 71);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(121, 20);
            this.comboBoxOperator.TabIndex = 8;
            // 
            // selectAllUserNameFromOperatorBindingSource
            // 
            this.selectAllUserNameFromOperatorBindingSource.DataMember = "SelectAllUserNameFromOperator";
            this.selectAllUserNameFromOperatorBindingSource.DataSource = this.employeeDataSet1;
            // 
            // employeeDataSet1
            // 
            this.employeeDataSet1.DataSetName = "EmployeeDataSet";
            this.employeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "密　码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "操作员";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(130, 115);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "进入";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 23F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "银行职员信息管理";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(226, 115);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // selectOperatorTableAdapter1
            // 
            this.selectOperatorTableAdapter1.ClearBeforeFill = true;
            // 
            // selectAllUserNameFromOperatorTableAdapter
            // 
            this.selectAllUserNameFromOperatorTableAdapter.ClearBeforeFill = true;
            // 
            // simpleQueryTableAdapter1
            // 
            this.simpleQueryTableAdapter1.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllUserNameFromOperatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonManage;
        private System.Windows.Forms.RadioButton radioButtonQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private BankEmployee.EmployeeDataSetTableAdapters.SelectOperatorTableAdapter selectOperatorTableAdapter1;
        private EmployeeDataSet employeeDataSet1;
        private System.Windows.Forms.BindingSource selectAllUserNameFromOperatorBindingSource;
        private BankEmployee.EmployeeDataSetTableAdapters.SelectAllUserNameFromOperatorTableAdapter selectAllUserNameFromOperatorTableAdapter;
        private BankEmployee.EmployeeDataSetTableAdapters.SimpleQueryTableAdapter simpleQueryTableAdapter1;
    }
}