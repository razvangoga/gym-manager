namespace GUI.Operations.ProductEntries
{
    partial class ProductEntriesControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateFilterMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.productEntriesMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productEntryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_idmyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryPricemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.entryQuantitymyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.productEntryDatemyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel6 = new MyControls.WindowsControls.myLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
            this.baseGroupBox.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.saveCancelPannel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.detailsPannel.SuspendLayout();
            this.listPannel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            this.filtersGroupBox.SuspendLayout();
            this.detailsParentPanel.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            this.listContainerPanel.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productEntriesMyDataGridViewRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Operations.Product_Entry);
            // 
            // detailsPannel
            // 
            this.detailsPannel.AutoScroll = true;
            this.detailsPannel.Controls.Add(this.myLabel6);
            this.detailsPannel.Controls.Add(this.myLabel5);
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.myLabel1);
            this.detailsPannel.Controls.Add(this.productEntryDatemyDateTimePicker);
            this.detailsPannel.Controls.Add(this.entryQuantitymyTextBox);
            this.detailsPannel.Controls.Add(this.entryPricemyTextBox);
            this.detailsPannel.Controls.Add(this.product_idmyComboBox);
            this.detailsPannel.Size = new System.Drawing.Size(616, 403);
            // 
            // listPannel
            // 
            this.listPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPannel.Size = new System.Drawing.Size(628, 428);
            // 
            // filterPanel
            // 
            this.filterPanel.Size = new System.Drawing.Size(628, 188);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.productEntriesMyDataGridViewRO);
            this.gridPanel.Size = new System.Drawing.Size(616, 215);
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.dateFilterMonthCalendar);
            this.filtersGroupBox.Size = new System.Drawing.Size(622, 182);
            // 
            // detailsParentPanel
            // 
            this.detailsParentPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsParentPanel.Size = new System.Drawing.Size(628, 428);
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Size = new System.Drawing.Size(622, 422);
            // 
            // listContainerPanel
            // 
            this.listContainerPanel.Location = new System.Drawing.Point(0, 188);
            this.listContainerPanel.Size = new System.Drawing.Size(628, 240);
            // 
            // listGroupBox
            // 
            this.listGroupBox.Size = new System.Drawing.Size(622, 234);
            // 
            // dateFilterMonthCalendar
            // 
            this.dateFilterMonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.dateFilterMonthCalendar.Location = new System.Drawing.Point(23, 16);
            this.dateFilterMonthCalendar.MaxSelectionCount = 1;
            this.dateFilterMonthCalendar.Name = "dateFilterMonthCalendar";
            this.dateFilterMonthCalendar.TabIndex = 1;
            this.dateFilterMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateFilterMonthCalendar_DateChanged);
            // 
            // productEntriesMyDataGridViewRO
            // 
            this.productEntriesMyDataGridViewRO.AllowUserToAddRows = false;
            this.productEntriesMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.productEntriesMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.productEntriesMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productEntriesMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productEntriesMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productEntriesMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productEntriesMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.productEntryDateDataGridViewTextBoxColumn,
            this.entryPriceDataGridViewTextBoxColumn,
            this.entryQuantityDataGridViewTextBoxColumn});
            this.productEntriesMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productEntriesMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle5;
            this.productEntriesMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productEntriesMyDataGridViewRO.EditableGrid = false;
            this.productEntriesMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.productEntriesMyDataGridViewRO.MultiSelect = false;
            this.productEntriesMyDataGridViewRO.Name = "productEntriesMyDataGridViewRO";
            this.productEntriesMyDataGridViewRO.ReadOnly = true;
            this.productEntriesMyDataGridViewRO.RowHeadersVisible = false;
            this.productEntriesMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productEntriesMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productEntriesMyDataGridViewRO.Size = new System.Drawing.Size(616, 215);
            this.productEntriesMyDataGridViewRO.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Nr Achizitie";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 97;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Produs";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Width = 71;
            // 
            // productEntryDateDataGridViewTextBoxColumn
            // 
            this.productEntryDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productEntryDateDataGridViewTextBoxColumn.DataPropertyName = "ProductEntryDate";
            this.productEntryDateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.productEntryDateDataGridViewTextBoxColumn.Name = "productEntryDateDataGridViewTextBoxColumn";
            this.productEntryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.productEntryDateDataGridViewTextBoxColumn.Width = 59;
            // 
            // entryPriceDataGridViewTextBoxColumn
            // 
            this.entryPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.entryPriceDataGridViewTextBoxColumn.DataPropertyName = "EntryPrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.entryPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.entryPriceDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.entryPriceDataGridViewTextBoxColumn.Name = "entryPriceDataGridViewTextBoxColumn";
            this.entryPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryQuantityDataGridViewTextBoxColumn
            // 
            this.entryQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.entryQuantityDataGridViewTextBoxColumn.DataPropertyName = "EntryQuantity";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.entryQuantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.entryQuantityDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.entryQuantityDataGridViewTextBoxColumn.Name = "entryQuantityDataGridViewTextBoxColumn";
            this.entryQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // product_idmyComboBox
            // 
            this.product_idmyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.product_idmyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.product_idmyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.product_idmyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.baseBindingSource, "Product_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.product_idmyComboBox.DataSource = this.productsBindingSource;
            this.product_idmyComboBox.DisplayMember = "ProductName";
            this.product_idmyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_idmyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_idmyComboBox.ForeColor = System.Drawing.Color.Black;
            this.product_idmyComboBox.FormattingEnabled = true;
            this.product_idmyComboBox.Location = new System.Drawing.Point(107, 28);
            this.product_idmyComboBox.MessageStrip = null;
            this.product_idmyComboBox.Name = "product_idmyComboBox";
            this.product_idmyComboBox.ReadOnly = false;
            this.product_idmyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.product_idmyComboBox.Size = new System.Drawing.Size(231, 21);
            this.product_idmyComboBox.TabIndex = 1;
            this.product_idmyComboBox.ValueMember = "id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Product);
            // 
            // entryPricemyTextBox
            // 
            this.entryPricemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.entryPricemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "EntryPrice", true));
            this.entryPricemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.entryPricemyTextBox.Location = new System.Drawing.Point(107, 55);
            this.entryPricemyTextBox.Name = "entryPricemyTextBox";
            this.entryPricemyTextBox.Size = new System.Drawing.Size(66, 20);
            this.entryPricemyTextBox.TabIndex = 3;
            this.entryPricemyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // entryQuantitymyTextBox
            // 
            this.entryQuantitymyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.entryQuantitymyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "EntryQuantity", true));
            this.entryQuantitymyTextBox.ForeColor = System.Drawing.Color.Black;
            this.entryQuantitymyTextBox.Location = new System.Drawing.Point(107, 81);
            this.entryQuantitymyTextBox.Name = "entryQuantitymyTextBox";
            this.entryQuantitymyTextBox.Size = new System.Drawing.Size(66, 20);
            this.entryQuantitymyTextBox.TabIndex = 5;
            this.entryQuantitymyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // productEntryDatemyDateTimePicker
            // 
            this.productEntryDatemyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.productEntryDatemyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.productEntryDatemyDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.baseBindingSource, "ProductEntryDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.productEntryDatemyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productEntryDatemyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.productEntryDatemyDateTimePicker.Location = new System.Drawing.Point(107, 107);
            this.productEntryDatemyDateTimePicker.Name = "productEntryDatemyDateTimePicker";
            this.productEntryDatemyDateTimePicker.ReadOnly = false;
            this.productEntryDatemyDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.productEntryDatemyDateTimePicker.TabIndex = 7;
            this.productEntryDatemyDateTimePicker.Value = new System.DateTime(2008, 4, 16, 0, 6, 21, 437);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(55, 31);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(46, 13);
            this.myLabel1.TabIndex = 8;
            this.myLabel1.Text = "Produs";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(19, 58);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(82, 13);
            this.myLabel2.TabIndex = 9;
            this.myLabel2.Text = "Pret Achizitie";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(43, 84);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(58, 13);
            this.myLabel3.TabIndex = 10;
            this.myLabel3.Text = "Cantitate";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(15, 111);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(86, 13);
            this.myLabel4.TabIndex = 11;
            this.myLabel4.Text = "Data Achizitie";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(179, 58);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(42, 13);
            this.myLabel5.TabIndex = 12;
            this.myLabel5.Text = "(RON)";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.White;
            this.myLabel6.Location = new System.Drawing.Point(179, 84);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(40, 13);
            this.myLabel6.TabIndex = 13;
            this.myLabel6.Text = "(BUC)";
            // 
            // ProductEntriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlDisplayTypeOnEdit = MyControls.CustomControls.BaseControl.ControlDisplayTypeOnEdit.Alternative;
            this.DeleteMessage = "Intrare produs stearsa!";
            this.FirstFocusControl = this.product_idmyComboBox;
            this.LastFocusControl = this.productEntryDatemyDateTimePicker;
            this.Name = "ProductEntriesControl";
            this.ObjectName = "Intrare produs";
            this.SaveMessage = "Intrare produs salvata!";
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.baseGroupBox.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.saveCancelPannel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.detailsPannel.ResumeLayout(false);
            this.detailsPannel.PerformLayout();
            this.listPannel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            this.filtersGroupBox.ResumeLayout(false);
            this.detailsParentPanel.ResumeLayout(false);
            this.detailsGroupBox.ResumeLayout(false);
            this.listContainerPanel.ResumeLayout(false);
            this.listGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productEntriesMyDataGridViewRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dateFilterMonthCalendar;
        private MyControls.WindowsControls.myDataGridViewRO productEntriesMyDataGridViewRO;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myDateTimePicker productEntryDatemyDateTimePicker;
        private MyControls.WindowsControls.myTextBox entryQuantitymyTextBox;
        private MyControls.WindowsControls.myTextBox entryPricemyTextBox;
        private MyControls.WindowsControls.myComboBox product_idmyComboBox;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel6;
        private MyControls.WindowsControls.myLabel myLabel5;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productEntryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryQuantityDataGridViewTextBoxColumn;
    }
}
