namespace BankEmployee
{
    partial class FormEmployee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label 职员号Label;
            System.Windows.Forms.Label 姓名Label;
            System.Windows.Forms.Label 性别Label;
            System.Windows.Forms.Label 出生日期Label;
            System.Windows.Forms.Label 地址Label;
            System.Windows.Forms.Label 照片Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.employeeDataSet = new BankEmployee.EmployeeDataSet();
            this.basicTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basicTableTableAdapter = new BankEmployee.EmployeeDataSetTableAdapters.BasicTableTableAdapter();
            this.basicTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.basicTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.basicTableDataGridView = new System.Windows.Forms.DataGridView();
            this.职员号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.照片DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.地址TextBox = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.性别TextBox = new System.Windows.Forms.TextBox();
            this.姓名TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTip = new System.Windows.Forms.Label();
            职员号Label = new System.Windows.Forms.Label();
            姓名Label = new System.Windows.Forms.Label();
            性别Label = new System.Windows.Forms.Label();
            出生日期Label = new System.Windows.Forms.Label();
            地址Label = new System.Windows.Forms.Label();
            照片Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicTableBindingNavigator)).BeginInit();
            this.basicTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basicTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 职员号Label
            // 
            职员号Label.AutoSize = true;
            职员号Label.Location = new System.Drawing.Point(25, 27);
            职员号Label.Name = "职员号Label";
            职员号Label.Size = new System.Drawing.Size(47, 12);
            职员号Label.TabIndex = 2;
            职员号Label.Text = "职员号:";
            // 
            // 姓名Label
            // 
            姓名Label.AutoSize = true;
            姓名Label.Location = new System.Drawing.Point(25, 56);
            姓名Label.Name = "姓名Label";
            姓名Label.Size = new System.Drawing.Size(35, 12);
            姓名Label.TabIndex = 4;
            姓名Label.Text = "姓名:";
            // 
            // 性别Label
            // 
            性别Label.AutoSize = true;
            性别Label.Location = new System.Drawing.Point(25, 85);
            性别Label.Name = "性别Label";
            性别Label.Size = new System.Drawing.Size(35, 12);
            性别Label.TabIndex = 6;
            性别Label.Text = "性别:";
            // 
            // 出生日期Label
            // 
            出生日期Label.AutoSize = true;
            出生日期Label.Location = new System.Drawing.Point(25, 114);
            出生日期Label.Name = "出生日期Label";
            出生日期Label.Size = new System.Drawing.Size(59, 12);
            出生日期Label.TabIndex = 8;
            出生日期Label.Text = "出生日期:";
            // 
            // 地址Label
            // 
            地址Label.AutoSize = true;
            地址Label.Location = new System.Drawing.Point(25, 143);
            地址Label.Name = "地址Label";
            地址Label.Size = new System.Drawing.Size(35, 12);
            地址Label.TabIndex = 10;
            地址Label.Text = "地址:";
            // 
            // 照片Label
            // 
            照片Label.AutoSize = true;
            照片Label.Location = new System.Drawing.Point(266, 27);
            照片Label.Name = "照片Label";
            照片Label.Size = new System.Drawing.Size(35, 12);
            照片Label.TabIndex = 12;
            照片Label.Text = "照片:";
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basicTableBindingSource
            // 
            this.basicTableBindingSource.DataMember = "BasicTable";
            this.basicTableBindingSource.DataSource = this.employeeDataSet;
            // 
            // basicTableTableAdapter
            // 
            this.basicTableTableAdapter.ClearBeforeFill = true;
            // 
            // basicTableBindingNavigator
            // 
            this.basicTableBindingNavigator.AddNewItem = null;
            this.basicTableBindingNavigator.BindingSource = this.basicTableBindingSource;
            this.basicTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.basicTableBindingNavigator.DeleteItem = null;
            this.basicTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.basicTableBindingNavigatorSaveItem});
            this.basicTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.basicTableBindingNavigator.MoveFirstItem = null;
            this.basicTableBindingNavigator.MoveLastItem = null;
            this.basicTableBindingNavigator.MoveNextItem = null;
            this.basicTableBindingNavigator.MovePreviousItem = null;
            this.basicTableBindingNavigator.Name = "basicTableBindingNavigator";
            this.basicTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.basicTableBindingNavigator.Size = new System.Drawing.Size(491, 25);
            this.basicTableBindingNavigator.TabIndex = 0;
            this.basicTableBindingNavigator.Text = "bindingNavigator1";
            this.basicTableBindingNavigator.RefreshItems += new System.EventHandler(this.basicTableBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // basicTableBindingNavigatorSaveItem
            // 
            this.basicTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.basicTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("basicTableBindingNavigatorSaveItem.Image")));
            this.basicTableBindingNavigatorSaveItem.Name = "basicTableBindingNavigatorSaveItem";
            this.basicTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.basicTableBindingNavigatorSaveItem.Text = "保存数据";
            this.basicTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.basicTableBindingNavigatorSaveItem_Click);
            // 
            // basicTableDataGridView
            // 
            this.basicTableDataGridView.AllowUserToAddRows = false;
            this.basicTableDataGridView.AllowUserToOrderColumns = true;
            this.basicTableDataGridView.AutoGenerateColumns = false;
            this.basicTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.职员号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.出生日期DataGridViewTextBoxColumn,
            this.地址DataGridViewTextBoxColumn,
            this.照片DataGridViewImageColumn});
            this.basicTableDataGridView.DataSource = this.basicTableBindingSource;
            this.basicTableDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.basicTableDataGridView.Location = new System.Drawing.Point(0, 244);
            this.basicTableDataGridView.Name = "basicTableDataGridView";
            this.basicTableDataGridView.RowHeadersVisible = false;
            this.basicTableDataGridView.RowTemplate.Height = 23;
            this.basicTableDataGridView.Size = new System.Drawing.Size(491, 126);
            this.basicTableDataGridView.TabIndex = 1;
            // 
            // 职员号DataGridViewTextBoxColumn
            // 
            this.职员号DataGridViewTextBoxColumn.DataPropertyName = "职员号";
            this.职员号DataGridViewTextBoxColumn.HeaderText = "职员号";
            this.职员号DataGridViewTextBoxColumn.Name = "职员号DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 出生日期DataGridViewTextBoxColumn
            // 
            this.出生日期DataGridViewTextBoxColumn.DataPropertyName = "出生日期";
            this.出生日期DataGridViewTextBoxColumn.HeaderText = "出生日期";
            this.出生日期DataGridViewTextBoxColumn.Name = "出生日期DataGridViewTextBoxColumn";
            // 
            // 地址DataGridViewTextBoxColumn
            // 
            this.地址DataGridViewTextBoxColumn.DataPropertyName = "地址";
            this.地址DataGridViewTextBoxColumn.HeaderText = "地址";
            this.地址DataGridViewTextBoxColumn.Name = "地址DataGridViewTextBoxColumn";
            // 
            // 照片DataGridViewImageColumn
            // 
            this.照片DataGridViewImageColumn.DataPropertyName = "照片";
            this.照片DataGridViewImageColumn.HeaderText = "照片";
            this.照片DataGridViewImageColumn.Name = "照片DataGridViewImageColumn";
            // 
            // DateTimePickerBirthDay
            // 
            this.DateTimePickerBirthDay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.basicTableBindingSource, "出生日期", true));
            this.DateTimePickerBirthDay.Location = new System.Drawing.Point(90, 111);
            this.DateTimePickerBirthDay.Name = "DateTimePickerBirthDay";
            this.DateTimePickerBirthDay.Size = new System.Drawing.Size(124, 21);
            this.DateTimePickerBirthDay.TabIndex = 9;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxPhoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.basicTableBindingSource, "照片", true));
            this.pictureBoxPhoto.Location = new System.Drawing.Point(307, 12);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(128, 120);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 13;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(307, 143);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(57, 23);
            this.buttonImport.TabIndex = 14;
            this.buttonImport.Text = "导入";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(378, 143);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(58, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "移除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // 地址TextBox
            // 
            this.地址TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.basicTableBindingSource, "地址", true));
            this.地址TextBox.Location = new System.Drawing.Point(90, 140);
            this.地址TextBox.Name = "地址TextBox";
            this.地址TextBox.Size = new System.Drawing.Size(200, 21);
            this.地址TextBox.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.basicTableBindingSource, "职员号", true));
            this.textBoxName.Location = new System.Drawing.Point(90, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(124, 21);
            this.textBoxName.TabIndex = 3;
            // 
            // 性别TextBox
            // 
            this.性别TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.basicTableBindingSource, "性别", true));
            this.性别TextBox.Location = new System.Drawing.Point(90, 82);
            this.性别TextBox.Name = "性别TextBox";
            this.性别TextBox.Size = new System.Drawing.Size(53, 21);
            this.性别TextBox.TabIndex = 7;
            // 
            // 姓名TextBox
            // 
            this.姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.basicTableBindingSource, "姓名", true));
            this.姓名TextBox.Location = new System.Drawing.Point(90, 53);
            this.姓名TextBox.Name = "姓名TextBox";
            this.姓名TextBox.Size = new System.Drawing.Size(124, 21);
            this.姓名TextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(职员号Label);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.pictureBoxPhoto);
            this.groupBox1.Controls.Add(this.buttonImport);
            this.groupBox1.Controls.Add(照片Label);
            this.groupBox1.Controls.Add(this.地址TextBox);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(地址Label);
            this.groupBox1.Controls.Add(姓名Label);
            this.groupBox1.Controls.Add(this.DateTimePickerBirthDay);
            this.groupBox1.Controls.Add(this.姓名TextBox);
            this.groupBox1.Controls.Add(出生日期Label);
            this.groupBox1.Controls.Add(性别Label);
            this.groupBox1.Controls.Add(this.性别TextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 180);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labelTip
            // 
            this.labelTip.ForeColor = System.Drawing.Color.Red;
            this.labelTip.Location = new System.Drawing.Point(15, 31);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(464, 25);
            this.labelTip.TabIndex = 16;
            this.labelTip.Text = "labelTip";
            this.labelTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 370);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.basicTableDataGridView);
            this.Controls.Add(this.basicTableBindingNavigator);
            this.Name = "FormEmployee";
            this.Text = "基本信息管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicTableBindingNavigator)).EndInit();
            this.basicTableBindingNavigator.ResumeLayout(false);
            this.basicTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basicTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource basicTableBindingSource;
        private BankEmployee.EmployeeDataSetTableAdapters.BasicTableTableAdapter basicTableTableAdapter;
        private System.Windows.Forms.BindingNavigator basicTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton basicTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView basicTableDataGridView;
        private System.Windows.Forms.DateTimePicker DateTimePickerBirthDay;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox 地址TextBox;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox 性别TextBox;
        private System.Windows.Forms.TextBox 姓名TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职员号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn 照片DataGridViewImageColumn;

    }
}

