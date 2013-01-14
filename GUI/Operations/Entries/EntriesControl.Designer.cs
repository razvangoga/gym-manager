namespace GUI.Operations.Entries
{
    partial class EntriesControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.entryesMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFilterMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.entry_Type_idmyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.entryTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.pricemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.entryDatemyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.client_idmyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.clientsBindingSource = new MyControls.WindowsControls.myBindingSource(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel6 = new MyControls.WindowsControls.myLabel(this.components);
            this.discountProcentmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.myLabel7 = new MyControls.WindowsControls.myLabel(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.entryesMyDataGridViewRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Operations.Entry);
            // 
            // detailsPannel
            // 
            this.detailsPannel.AutoScroll = true;
            this.detailsPannel.Controls.Add(this.myLabel7);
            this.detailsPannel.Controls.Add(this.discountProcentmyTextBox);
            this.detailsPannel.Controls.Add(this.myLabel6);
            this.detailsPannel.Controls.Add(this.myLabel5);
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.myLabel1);
            this.detailsPannel.Controls.Add(this.client_idmyComboBox);
            this.detailsPannel.Controls.Add(this.entryDatemyDateTimePicker);
            this.detailsPannel.Controls.Add(this.pricemyTextBox);
            this.detailsPannel.Controls.Add(this.detailsmyTextBox);
            this.detailsPannel.Controls.Add(this.entry_Type_idmyComboBox);
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
            this.gridPanel.Controls.Add(this.entryesMyDataGridViewRO);
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
            // entryesMyDataGridViewRO
            // 
            this.entryesMyDataGridViewRO.AllowUserToAddRows = false;
            this.entryesMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.entryesMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.entryesMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.entryesMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.entryesMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.entryesMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entryesMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.entryTypeidDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn});
            this.entryesMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.entryesMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle4;
            this.entryesMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryesMyDataGridViewRO.EditableGrid = false;
            this.entryesMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.entryesMyDataGridViewRO.MultiSelect = false;
            this.entryesMyDataGridViewRO.Name = "entryesMyDataGridViewRO";
            this.entryesMyDataGridViewRO.ReadOnly = true;
            this.entryesMyDataGridViewRO.RowHeadersVisible = false;
            this.entryesMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.entryesMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entryesMyDataGridViewRO.Size = new System.Drawing.Size(616, 215);
            this.entryesMyDataGridViewRO.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Nr Intrare";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 86;
            // 
            // entryTypeidDataGridViewTextBoxColumn
            // 
            this.entryTypeidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.entryTypeidDataGridViewTextBoxColumn.DataPropertyName = "EntryType";
            this.entryTypeidDataGridViewTextBoxColumn.HeaderText = "Tip Intrare";
            this.entryTypeidDataGridViewTextBoxColumn.Name = "entryTypeidDataGridViewTextBoxColumn";
            this.entryTypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryTypeidDataGridViewTextBoxColumn.Width = 91;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryDateDataGridViewTextBoxColumn.Width = 59;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Detalii";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn.Width = 64;
            // 
            // dateFilterMonthCalendar
            // 
            this.dateFilterMonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.dateFilterMonthCalendar.Location = new System.Drawing.Point(23, 16);
            this.dateFilterMonthCalendar.MaxSelectionCount = 1;
            this.dateFilterMonthCalendar.Name = "dateFilterMonthCalendar";
            this.dateFilterMonthCalendar.TabIndex = 0;
            this.dateFilterMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateFilterMonthCalendar_DateChanged);
            // 
            // entry_Type_idmyComboBox
            // 
            this.entry_Type_idmyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.entry_Type_idmyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.entry_Type_idmyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.entry_Type_idmyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.baseBindingSource, "Entry_Type_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.entry_Type_idmyComboBox.DataSource = this.entryTypesBindingSource;
            this.entry_Type_idmyComboBox.DisplayMember = "EntryType";
            this.entry_Type_idmyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entry_Type_idmyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_Type_idmyComboBox.ForeColor = System.Drawing.Color.Black;
            this.entry_Type_idmyComboBox.FormattingEnabled = true;
            this.entry_Type_idmyComboBox.Location = new System.Drawing.Point(106, 30);
            this.entry_Type_idmyComboBox.MessageStrip = null;
            this.entry_Type_idmyComboBox.Name = "entry_Type_idmyComboBox";
            this.entry_Type_idmyComboBox.ReadOnly = false;
            this.entry_Type_idmyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.entry_Type_idmyComboBox.Size = new System.Drawing.Size(247, 21);
            this.entry_Type_idmyComboBox.TabIndex = 1;
            this.entry_Type_idmyComboBox.ValueMember = "id";
            this.entry_Type_idmyComboBox.SelectedIndexChanged += new System.EventHandler(this.entry_Type_idmyComboBox_SelectedIndexChanged);
            // 
            // entryTypesBindingSource
            // 
            this.entryTypesBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Entry_Type);
            // 
            // detailsmyTextBox
            // 
            this.detailsmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.detailsmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Details", true));
            this.detailsmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.detailsmyTextBox.Location = new System.Drawing.Point(106, 56);
            this.detailsmyTextBox.Multiline = true;
            this.detailsmyTextBox.Name = "detailsmyTextBox";
            this.detailsmyTextBox.Size = new System.Drawing.Size(247, 42);
            this.detailsmyTextBox.TabIndex = 3;
            // 
            // pricemyTextBox
            // 
            this.pricemyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.pricemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.pricemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.pricemyTextBox.Location = new System.Drawing.Point(106, 103);
            this.pricemyTextBox.Name = "pricemyTextBox";
            this.pricemyTextBox.ReadOnly = true;
            this.pricemyTextBox.Size = new System.Drawing.Size(57, 20);
            this.pricemyTextBox.TabIndex = 5;
            this.pricemyTextBox.TabStop = false;
            this.pricemyTextBox.Tag = "Unlocked";
            this.pricemyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // entryDatemyDateTimePicker
            // 
            this.entryDatemyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.entryDatemyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.entryDatemyDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.baseBindingSource, "EntryDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.entryDatemyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDatemyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.entryDatemyDateTimePicker.Location = new System.Drawing.Point(106, 128);
            this.entryDatemyDateTimePicker.Name = "entryDatemyDateTimePicker";
            this.entryDatemyDateTimePicker.ReadOnly = false;
            this.entryDatemyDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.entryDatemyDateTimePicker.TabIndex = 7;
            this.entryDatemyDateTimePicker.Value = new System.DateTime(2008, 4, 14, 16, 5, 16, 953);
            // 
            // client_idmyComboBox
            // 
            this.client_idmyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.client_idmyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.client_idmyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.client_idmyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.baseBindingSource, "Client_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.client_idmyComboBox.DataSource = this.clientsBindingSource;
            this.client_idmyComboBox.DisplayMember = "ClientName";
            this.client_idmyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_idmyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_idmyComboBox.ForeColor = System.Drawing.Color.Black;
            this.client_idmyComboBox.FormattingEnabled = true;
            this.client_idmyComboBox.Location = new System.Drawing.Point(106, 153);
            this.client_idmyComboBox.MessageStrip = null;
            this.client_idmyComboBox.Name = "client_idmyComboBox";
            this.client_idmyComboBox.ReadOnly = false;
            this.client_idmyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.client_idmyComboBox.Size = new System.Drawing.Size(247, 21);
            this.client_idmyComboBox.TabIndex = 9;
            this.client_idmyComboBox.ValueMember = "id";
            this.client_idmyComboBox.SelectedIndexChanged += new System.EventHandler(this.client_idmyComboBox_SelectedIndexChanged);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Client);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(34, 33);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(66, 13);
            this.myLabel1.TabIndex = 10;
            this.myLabel1.Text = "Tip Intrare";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(57, 59);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(43, 13);
            this.myLabel2.TabIndex = 11;
            this.myLabel2.Text = "Detalii";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(70, 106);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(30, 13);
            this.myLabel3.TabIndex = 12;
            this.myLabel3.Text = "Pret";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(26, 132);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(74, 13);
            this.myLabel4.TabIndex = 13;
            this.myLabel4.Text = "Data Intrarii";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(61, 156);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(39, 13);
            this.myLabel5.TabIndex = 14;
            this.myLabel5.Text = "Client";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.White;
            this.myLabel6.Location = new System.Drawing.Point(169, 106);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(42, 13);
            this.myLabel6.TabIndex = 15;
            this.myLabel6.Text = "(RON)";
            // 
            // discountProcentmyTextBox
            // 
            this.discountProcentmyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.discountProcentmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "DiscountProcent", true));
            this.discountProcentmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.discountProcentmyTextBox.Location = new System.Drawing.Point(181, 180);
            this.discountProcentmyTextBox.Name = "discountProcentmyTextBox";
            this.discountProcentmyTextBox.ReadOnly = true;
            this.discountProcentmyTextBox.Size = new System.Drawing.Size(30, 20);
            this.discountProcentmyTextBox.TabIndex = 16;
            this.discountProcentmyTextBox.TabStop = false;
            this.discountProcentmyTextBox.Tag = "Unlocked";
            this.discountProcentmyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.White;
            this.myLabel7.Location = new System.Drawing.Point(61, 183);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(114, 13);
            this.myLabel7.TabIndex = 17;
            this.myLabel7.Text = "Discount Client (%)";
            // 
            // EntriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlDisplayTypeOnEdit = MyControls.CustomControls.BaseControl.ControlDisplayTypeOnEdit.Alternative;
            this.DeleteMessage = "Intrare stearsa!";
            this.FirstFocusControl = this.entry_Type_idmyComboBox;
            this.LastFocusControl = this.client_idmyComboBox;
            this.Name = "EntriesControl";
            this.ObjectName = "Intrare";
            this.SaveMessage = "Intrare salvata!";
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
            ((System.ComponentModel.ISupportInitialize)(this.entryesMyDataGridViewRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myDataGridViewRO entryesMyDataGridViewRO;
        private System.Windows.Forms.MonthCalendar dateFilterMonthCalendar;
        private MyControls.WindowsControls.myLabel myLabel5;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myComboBox client_idmyComboBox;
        private MyControls.WindowsControls.myDateTimePicker entryDatemyDateTimePicker;
        private MyControls.WindowsControls.myTextBox pricemyTextBox;
        private MyControls.WindowsControls.myTextBox detailsmyTextBox;
        private MyControls.WindowsControls.myComboBox entry_Type_idmyComboBox;
        private MyControls.WindowsControls.myLabel myLabel6;
        private MyControls.WindowsControls.myBindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource entryTypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private MyControls.WindowsControls.myLabel myLabel7;
        private MyControls.WindowsControls.myTextBox discountProcentmyTextBox;
    }
}
