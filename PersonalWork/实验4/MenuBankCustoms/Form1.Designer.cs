namespace MenuBankCustoms
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
            this.listBoxShowall = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxShowall
            // 
            this.listBoxShowall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxShowall.FormattingEnabled = true;
            this.listBoxShowall.ItemHeight = 12;
            this.listBoxShowall.Location = new System.Drawing.Point(0, 0);
            this.listBoxShowall.Name = "listBoxShowall";
            this.listBoxShowall.Size = new System.Drawing.Size(458, 292);
            this.listBoxShowall.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 301);
            this.Controls.Add(this.listBoxShowall);
            this.Name = "Form1";
            this.Text = "显示所有用户";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShowall;
    }
}