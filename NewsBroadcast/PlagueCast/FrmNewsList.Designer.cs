namespace PlagueCast
{
    partial class FrmNewsList
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
            this.tblLiskContainer = new System.Windows.Forms.Panel();
            this.scrollBarArea = new System.Windows.Forms.Label();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.itemTemplate = new System.Windows.Forms.Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInfoArea = new System.Windows.Forms.Label();
            this.tblLiskContainer.SuspendLayout();
            this.itemTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLiskContainer
            // 
            this.tblLiskContainer.Controls.Add(this.scrollBarArea);
            this.tblLiskContainer.Location = new System.Drawing.Point(1, 1);
            this.tblLiskContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblLiskContainer.Name = "tblLiskContainer";
            this.tblLiskContainer.Size = new System.Drawing.Size(624, 404);
            this.tblLiskContainer.TabIndex = 0;
            this.tblLiskContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.tblLiskContainer_Paint);
            this.tblLiskContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblTaskContainer_MouseDown);
            this.tblLiskContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblTaskContainer_MouseMove);
            this.tblLiskContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblTaskContainer_MouseUp);
            // 
            // scrollBarArea
            // 
            this.scrollBarArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scrollBarArea.Location = new System.Drawing.Point(599, 0);
            this.scrollBarArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scrollBarArea.Name = "scrollBarArea";
            this.scrollBarArea.Size = new System.Drawing.Size(25, 404);
            this.scrollBarArea.TabIndex = 0;
            this.scrollBarArea.Text = "label1";
            this.scrollBarArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scrollBarArea_MouseDown);
            this.scrollBarArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scrollBarArea_MouseMove);
            this.scrollBarArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scrollBarArea_MouseUp);
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 1;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // itemTemplate
            // 
            this.itemTemplate.Controls.Add(this.lblContent);
            this.itemTemplate.Controls.Add(this.lblTime);
            this.itemTemplate.Location = new System.Drawing.Point(8, 448);
            this.itemTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemTemplate.Name = "itemTemplate";
            this.itemTemplate.Size = new System.Drawing.Size(624, 53);
            this.itemTemplate.TabIndex = 2;
            // 
            // lblContent
            // 
            this.lblContent.Location = new System.Drawing.Point(0, 27);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(599, 27);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "label1";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(624, 27);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoArea
            // 
            this.lblInfoArea.Location = new System.Drawing.Point(16, 404);
            this.lblInfoArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoArea.Name = "lblInfoArea";
            this.lblInfoArea.Size = new System.Drawing.Size(591, 18);
            this.lblInfoArea.TabIndex = 3;
            this.lblInfoArea.Text = "新闻加载中";
            this.lblInfoArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmNewsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlagueCast.Properties.Resources.bg_list;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 422);
            this.Controls.Add(this.lblInfoArea);
            this.Controls.Add(this.itemTemplate);
            this.Controls.Add(this.tblLiskContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmNewsList";
            this.ShowInTaskbar = false;
            this.Text = "FrmNewsList";
            this.Load += new System.EventHandler(this.FrmNewsList_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmNewsList_VisibleChanged);
            this.tblLiskContainer.ResumeLayout(false);
            this.itemTemplate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tblLiskContainer;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.Label scrollBarArea;
        private System.Windows.Forms.Panel itemTemplate;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblInfoArea;
    }
}