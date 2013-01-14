namespace MyControls.CustomControls.BaseControl
{
    partial class BaseSearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.listPanel = new System.Windows.Forms.Panel();
            this.listMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageMyLabel = new MyControls.WindowsControls.myLabel(this.components);
            this.filtersPanel = new System.Windows.Forms.Panel();
            this.exitMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.selectMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.nameFilterMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.nameMyLabel = new MyControls.WindowsControls.myLabel(this.components);
            this.codeFilterMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.codeMyLabel = new MyControls.WindowsControls.myLabel(this.components);
            this.searchGroupBox.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMyDataGridViewRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            this.filtersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.listPanel);
            this.searchGroupBox.Controls.Add(this.messageMyLabel);
            this.searchGroupBox.Controls.Add(this.filtersPanel);
            this.searchGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGroupBox.ForeColor = System.Drawing.Color.White;
            this.searchGroupBox.Location = new System.Drawing.Point(5, 0);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(490, 345);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Cautare {0}";
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.listMyDataGridViewRO);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(3, 92);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(484, 228);
            this.listPanel.TabIndex = 1;
            // 
            // listMyDataGridViewRO
            // 
            this.listMyDataGridViewRO.AllowUserToAddRows = false;
            this.listMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.listMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.listMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCod,
            this.colName});
            this.listMyDataGridViewRO.DataSource = this.listBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle3;
            this.listMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMyDataGridViewRO.EditableGrid = false;
            this.listMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.listMyDataGridViewRO.MultiSelect = false;
            this.listMyDataGridViewRO.Name = "listMyDataGridViewRO";
            this.listMyDataGridViewRO.ReadOnly = true;
            this.listMyDataGridViewRO.RowHeadersVisible = false;
            this.listMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listMyDataGridViewRO.Size = new System.Drawing.Size(484, 228);
            this.listMyDataGridViewRO.TabIndex = 0;
            this.listMyDataGridViewRO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listMyDataGridViewRO_KeyUp);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 43;
            // 
            // colCod
            // 
            this.colCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCod.HeaderText = "Cod";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            this.colCod.Width = 54;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Denumire";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // messageMyLabel
            // 
            this.messageMyLabel.BackColor = System.Drawing.Color.Gray;
            this.messageMyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageMyLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageMyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageMyLabel.ForeColor = System.Drawing.Color.White;
            this.messageMyLabel.Location = new System.Drawing.Point(3, 320);
            this.messageMyLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.messageMyLabel.Name = "messageMyLabel";
            this.messageMyLabel.Size = new System.Drawing.Size(484, 22);
            this.messageMyLabel.TabIndex = 2;
            this.messageMyLabel.Text = "Apasati F5 pentru confirmarea selectiei facute, Escape pentru iesire";
            this.messageMyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filtersPanel
            // 
            this.filtersPanel.Controls.Add(this.exitMyRibbonMenuButton);
            this.filtersPanel.Controls.Add(this.selectMyRibbonMenuButton);
            this.filtersPanel.Controls.Add(this.nameFilterMyTextBox);
            this.filtersPanel.Controls.Add(this.nameMyLabel);
            this.filtersPanel.Controls.Add(this.codeFilterMyTextBox);
            this.filtersPanel.Controls.Add(this.codeMyLabel);
            this.filtersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtersPanel.Location = new System.Drawing.Point(3, 16);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(484, 76);
            this.filtersPanel.TabIndex = 0;
            // 
            // exitMyRibbonMenuButton
            // 
            this.exitMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.exitMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.exitMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.exitMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.exitMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.exitMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.exitMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.exitMyRibbonMenuButton.FadingSpeed = 35;
            this.exitMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.exitMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitMyRibbonMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMyRibbonMenuButton.ForeColor = System.Drawing.Color.Black;
            this.exitMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.exitMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.no;
            this.exitMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.exitMyRibbonMenuButton.ImageOffset = 0;
            this.exitMyRibbonMenuButton.IsPressed = false;
            this.exitMyRibbonMenuButton.KeepPress = false;
            this.exitMyRibbonMenuButton.Location = new System.Drawing.Point(380, 35);
            this.exitMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.exitMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.exitMyRibbonMenuButton.Name = "exitMyRibbonMenuButton";
            this.exitMyRibbonMenuButton.Radius = 6;
            this.exitMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.exitMyRibbonMenuButton.Size = new System.Drawing.Size(90, 23);
            this.exitMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.exitMyRibbonMenuButton.SplitDistance = 0;
            this.exitMyRibbonMenuButton.TabIndex = 4;
            this.exitMyRibbonMenuButton.TabStop = false;
            this.exitMyRibbonMenuButton.Text = "Iesire";
            this.exitMyRibbonMenuButton.Title = "";
            this.exitMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.exitMyRibbonMenuButton.Click += new System.EventHandler(this.exitMyRibbonMenuButton_Click);
            // 
            // selectMyRibbonMenuButton
            // 
            this.selectMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.selectMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.selectMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.selectMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.selectMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.selectMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.selectMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.selectMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.selectMyRibbonMenuButton.FadingSpeed = 35;
            this.selectMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.selectMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectMyRibbonMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMyRibbonMenuButton.ForeColor = System.Drawing.Color.Black;
            this.selectMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.selectMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.yes;
            this.selectMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.selectMyRibbonMenuButton.ImageOffset = 0;
            this.selectMyRibbonMenuButton.IsPressed = false;
            this.selectMyRibbonMenuButton.KeepPress = false;
            this.selectMyRibbonMenuButton.Location = new System.Drawing.Point(380, 9);
            this.selectMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.selectMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.selectMyRibbonMenuButton.Name = "selectMyRibbonMenuButton";
            this.selectMyRibbonMenuButton.Radius = 6;
            this.selectMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.selectMyRibbonMenuButton.Size = new System.Drawing.Size(90, 23);
            this.selectMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.selectMyRibbonMenuButton.SplitDistance = 0;
            this.selectMyRibbonMenuButton.TabIndex = 3;
            this.selectMyRibbonMenuButton.TabStop = false;
            this.selectMyRibbonMenuButton.Text = "Selecteaza";
            this.selectMyRibbonMenuButton.Title = "";
            this.selectMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.selectMyRibbonMenuButton.Click += new System.EventHandler(this.selectMyRibbonMenuButton_Click);
            // 
            // nameFilterMyTextBox
            // 
            this.nameFilterMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nameFilterMyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFilterMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameFilterMyTextBox.Location = new System.Drawing.Point(169, 37);
            this.nameFilterMyTextBox.Name = "nameFilterMyTextBox";
            this.nameFilterMyTextBox.Size = new System.Drawing.Size(205, 20);
            this.nameFilterMyTextBox.TabIndex = 1;
            this.nameFilterMyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameFilterMyTextBox_KeyUp);
            this.nameFilterMyTextBox.TextChanged += new System.EventHandler(this.nameFilterMyTextBox_TextChanged);
            // 
            // nameMyLabel
            // 
            this.nameMyLabel.AutoSize = true;
            this.nameMyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameMyLabel.ForeColor = System.Drawing.Color.White;
            this.nameMyLabel.Location = new System.Drawing.Point(12, 40);
            this.nameMyLabel.Name = "nameMyLabel";
            this.nameMyLabel.Size = new System.Drawing.Size(85, 13);
            this.nameMyLabel.TabIndex = 2;
            this.nameMyLabel.Text = "Denumire {0}:";
            // 
            // codeFilterMyTextBox
            // 
            this.codeFilterMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.codeFilterMyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeFilterMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.codeFilterMyTextBox.Location = new System.Drawing.Point(169, 11);
            this.codeFilterMyTextBox.Name = "codeFilterMyTextBox";
            this.codeFilterMyTextBox.Size = new System.Drawing.Size(205, 20);
            this.codeFilterMyTextBox.TabIndex = 0;
            this.codeFilterMyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codeFilterMyTextBox_KeyUp);
            this.codeFilterMyTextBox.TextChanged += new System.EventHandler(this.codeFilterMyTextBox_TextChanged);
            // 
            // codeMyLabel
            // 
            this.codeMyLabel.AutoSize = true;
            this.codeMyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeMyLabel.ForeColor = System.Drawing.Color.White;
            this.codeMyLabel.Location = new System.Drawing.Point(12, 14);
            this.codeMyLabel.Name = "codeMyLabel";
            this.codeMyLabel.Size = new System.Drawing.Size(54, 13);
            this.codeMyLabel.TabIndex = 0;
            this.codeMyLabel.Text = "Cod {0}:";
            // 
            // BaseSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.searchGroupBox);
            this.Name = "BaseSearchControl";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Size = new System.Drawing.Size(500, 350);
            this.Load += new System.EventHandler(this.BaseSearchControl_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listMyDataGridViewRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            this.filtersPanel.ResumeLayout(false);
            this.filtersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Panel filtersPanel;
        private MyControls.WindowsControls.myLabel codeMyLabel;
        private MyControls.WindowsControls.myTextBox codeFilterMyTextBox;
        private MyControls.WindowsControls.myTextBox nameFilterMyTextBox;
        private MyControls.WindowsControls.myLabel nameMyLabel;
        private System.Windows.Forms.Panel listPanel;
        private MyControls.WindowsControls.myDataGridViewRO listMyDataGridViewRO;
        private System.Windows.Forms.BindingSource listBindingSource;
        private MyControls.WindowsControls.myRibbonMenuButton exitMyRibbonMenuButton;
        private MyControls.WindowsControls.myRibbonMenuButton selectMyRibbonMenuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private MyControls.WindowsControls.myLabel messageMyLabel;
    }
}
