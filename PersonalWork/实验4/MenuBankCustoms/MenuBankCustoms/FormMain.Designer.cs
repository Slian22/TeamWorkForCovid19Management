namespace MenuBankCustoms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemShowAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonShow = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMenuTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(523, 114);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(80, 23);
            this.buttonWithdraw.TabIndex = 20;
            this.buttonWithdraw.Text = "取款";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            this.buttonWithdraw.MouseEnter += new System.EventHandler(this.buttonWithdraw_MouseEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxUserName);
            this.groupBox2.Controls.Add(this.textBoxMoney);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 66);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入信息";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(81, 25);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(86, 21);
            this.textBoxUserName.TabIndex = 0;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(324, 25);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(86, 21);
            this.textBoxMoney.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "帐户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "存（取）款金额";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(523, 79);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(80, 23);
            this.buttonDeposit.TabIndex = 19;
            this.buttonDeposit.Text = "存款";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            this.buttonDeposit.MouseEnter += new System.EventHandler(this.buttonDeposit_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem,
            this.操作ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemSave});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.操作ToolStripMenuItem.Text = "文件";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(152, 22);
            this.menuItemOpen.Text = "打开";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(152, 22);
            this.menuItemSave.Text = "保存";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // 操作ToolStripMenuItem1
            // 
            this.操作ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDeposit,
            this.menuItemWithdraw,
            this.toolStripSeparator1,
            this.menuItemShowAccount});
            this.操作ToolStripMenuItem1.Name = "操作ToolStripMenuItem1";
            this.操作ToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.操作ToolStripMenuItem1.Text = "操作";
            // 
            // menuItemDeposit
            // 
            this.menuItemDeposit.Name = "menuItemDeposit";
            this.menuItemDeposit.Size = new System.Drawing.Size(166, 22);
            this.menuItemDeposit.Text = "存款";
            // 
            // menuItemWithdraw
            // 
            this.menuItemWithdraw.Name = "menuItemWithdraw";
            this.menuItemWithdraw.Size = new System.Drawing.Size(166, 22);
            this.menuItemWithdraw.Text = "取款";
            // 
            // menuItemShowAccount
            // 
            this.menuItemShowAccount.Name = "menuItemShowAccount";
            this.menuItemShowAccount.Size = new System.Drawing.Size(166, 22);
            this.menuItemShowAccount.Text = "显示所有帐户信息";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripLabel1,
            this.toolStripButtonSave,
            this.toolStripLabel2,
            this.toolStripButtonShow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonOpen.Text = "打开文件";
            this.toolStripButtonOpen.MouseEnter += new System.EventHandler(this.toolStripButtonOpen_MouseEnter);
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonSave.Text = "保存文件";
            this.toolStripButtonSave.MouseEnter += new System.EventHandler(this.toolStripButtonSave_MouseEnter);
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel1.Text = "　";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "　";
            // 
            // toolStripButtonShow
            // 
            this.toolStripButtonShow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShow.Image")));
            this.toolStripButtonShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShow.Name = "toolStripButtonShow";
            this.toolStripButtonShow.Size = new System.Drawing.Size(121, 22);
            this.toolStripButtonShow.Text = "显示所有帐户信息";
            this.toolStripButtonShow.MouseEnter += new System.EventHandler(this.toolStripButtonShow_MouseEnter);
            this.toolStripButtonShow.Click += new System.EventHandler(this.toolStripButtonShow_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMenuTip,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMenuTip
            // 
            this.toolStripStatusLabelMenuTip.Name = "toolStripStatusLabelMenuTip";
            this.toolStripStatusLabelMenuTip.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 152);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "业务记录";
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 12;
            this.listBoxStatus.Location = new System.Drawing.Point(6, 21);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(602, 124);
            this.listBoxStatus.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 339);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "活期存款业务处理";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeposit;
        private System.Windows.Forms.ToolStripMenuItem menuItemWithdraw;
        private System.Windows.Forms.ToolStripMenuItem menuItemShowAccount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButtonShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMenuTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

