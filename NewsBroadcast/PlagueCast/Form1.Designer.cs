namespace PlagueCast
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.btnExpand = new System.Windows.Forms.Button();
            this.conMarquee = new System.Windows.Forms.Label();
            this.btnContext = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chkNotification = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打开丁香园疫情播报页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开Github页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsGetter = new System.ComponentModel.BackgroundWorker();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.ptListBegin = new System.Windows.Forms.Label();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 1;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // btnExpand
            // 
            this.btnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpand.Location = new System.Drawing.Point(482, 7);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(24, 16);
            this.btnExpand.TabIndex = 0;
            this.btnExpand.Text = "button1";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // conMarquee
            // 
            this.conMarquee.BackColor = System.Drawing.Color.Transparent;
            this.conMarquee.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conMarquee.ForeColor = System.Drawing.Color.White;
            this.conMarquee.Location = new System.Drawing.Point(56, 2);
            this.conMarquee.Name = "conMarquee";
            this.conMarquee.Size = new System.Drawing.Size(412, 28);
            this.conMarquee.TabIndex = 1;
            this.conMarquee.Text = "格陵兰封锁港口";
            this.conMarquee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conMarquee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragger_MouseDown);
            this.conMarquee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragger_MouseMove);
            this.conMarquee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragger_MouseUp);
            // 
            // btnContext
            // 
            this.btnContext.ContextMenuStrip = this.contextMenuStrip1;
            this.btnContext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContext.Location = new System.Drawing.Point(3, 2);
            this.btnContext.Name = "btnContext";
            this.btnContext.Size = new System.Drawing.Size(49, 50);
            this.btnContext.TabIndex = 2;
            this.btnContext.Text = "button1";
            this.btnContext.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkNotification,
            this.toolStripMenuItem1,
            this.更新ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.toolStripSeparator1,
            this.打开丁香园疫情播报页面ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.打开Github页面ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 186);
            // 
            // chkNotification
            // 
            this.chkNotification.Checked = true;
            this.chkNotification.CheckOnClick = true;
            this.chkNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotification.Name = "chkNotification";
            this.chkNotification.Size = new System.Drawing.Size(217, 22);
            this.chkNotification.Text = "通知";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem1.Text = "置顶";
            this.toolStripMenuItem1.CheckedChanged += new System.EventHandler(this.toolStripMenuItem1_CheckedChanged);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.更新ToolStripMenuItem.Text = "刷新";
            this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click_1);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // 打开丁香园疫情播报页面ToolStripMenuItem
            // 
            this.打开丁香园疫情播报页面ToolStripMenuItem.Name = "打开丁香园疫情播报页面ToolStripMenuItem";
            this.打开丁香园疫情播报页面ToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.打开丁香园疫情播报页面ToolStripMenuItem.Text = "打开丁香园疫情播报页面";
            this.打开丁香园疫情播报页面ToolStripMenuItem.Click += new System.EventHandler(this.打开丁香园疫情播报页面ToolStripMenuItem_Click);
            // 
            // 打开Github页面ToolStripMenuItem
            // 
            this.打开Github页面ToolStripMenuItem.Name = "打开Github页面ToolStripMenuItem";
            this.打开Github页面ToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.打开Github页面ToolStripMenuItem.Text = "打开Github页面";
            this.打开Github页面ToolStripMenuItem.Click += new System.EventHandler(this.打开Github页面ToolStripMenuItem_Click);
            // 
            // newsGetter
            // 
            this.newsGetter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.newsGetter_DoWork);
            this.newsGetter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.newsGetter_RunWorkerCompleted);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // ptListBegin
            // 
            this.ptListBegin.AutoSize = true;
            this.ptListBegin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ptListBegin.Location = new System.Drawing.Point(55, 32);
            this.ptListBegin.Name = "ptListBegin";
            this.ptListBegin.Size = new System.Drawing.Size(35, 13);
            this.ptListBegin.TabIndex = 3;
            this.ptListBegin.Text = "label1";
            // 
            // splashTimer
            // 
            this.splashTimer.Enabled = true;
            this.splashTimer.Interval = 1000;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "疫情动态";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem2.Text = "打开疫情相关网址导航";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlagueCast.Properties.Resources.bg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 54);
            this.Controls.Add(this.ptListBegin);
            this.Controls.Add(this.btnContext);
            this.Controls.Add(this.conMarquee);
            this.Controls.Add(this.btnExpand);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(30, 30);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "疫情播报";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Label conMarquee;
        private System.Windows.Forms.Button btnContext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker newsGetter;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label ptListBegin;
        private System.Windows.Forms.ToolStripMenuItem chkNotification;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.ToolStripMenuItem 打开丁香园疫情播报页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开Github页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

