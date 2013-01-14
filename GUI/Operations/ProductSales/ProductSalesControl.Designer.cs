namespace GUI.Operations.ProductSales
{
    partial class ProductSalesControl
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
            this.productSalesMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSalesDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_idmyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.salesPricemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.salesQuantitymyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.productSalesDatemyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.client_idmyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel6 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel7 = new MyControls.WindowsControls.myLabel(this.components);
            this.discountProcentmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.myLabel8 = new MyControls.WindowsControls.myLabel(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.productSalesMyDataGridViewRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Operations.Product_Sale);
            // 
            // detailsPannel
            // 
            this.detailsPannel.AutoScroll = true;
            this.detailsPannel.Controls.Add(this.myLabel8);
            this.detailsPannel.Controls.Add(this.discountProcentmyTextBox);
            this.detailsPannel.Controls.Add(this.myLabel7);
            this.detailsPannel.Controls.Add(this.myLabel6);
            this.detailsPannel.Controls.Add(this.myLabel5);
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.myLabel1);
            this.detailsPannel.Controls.Add(this.client_idmyComboBox);
            this.detailsPannel.Controls.Add(this.productSalesDatemyDateTimePicker);
            this.detailsPannel.Controls.Add(this.salesQuantitymyTextBox);
            this.detailsPannel.Controls.Add(this.salesPricemyTextBox);
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
            this.gridPanel.Controls.Add(this.productSalesMyDataGridViewRO);
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
            this.dateFilterMonthCalendar.TabIndex = 2;
            this.dateFilterMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateFilterMonthCalendar_DateChanged);
            // 
            // productSalesMyDataGridViewRO
            // 
            this.productSalesMyDataGridViewRO.AllowUserToAddRows = false;
            this.productSalesMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.productSalesMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.productSalesMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productSalesMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productSalesMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productSalesMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSalesMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.productSalesDateDataGridViewTextBoxColumn,
            this.salesPriceDataGridViewTextBoxColumn,
            this.salesQuantityDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn});
            this.productSalesMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productSalesMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle5;
            this.productSalesMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productSalesMyDataGridViewRO.EditableGrid = false;
            this.productSalesMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.productSalesMyDataGridViewRO.MultiSelect = false;
            this.productSalesMyDataGridViewRO.Name = "productSalesMyDataGridViewRO";
            this.productSalesMyDataGridViewRO.ReadOnly = true;
            this.productSalesMyDataGridViewRO.RowHeadersVisible = false;
            this.productSalesMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productSalesMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productSalesMyDataGridViewRO.Size = new System.Drawing.Size(616, 215);
            this.productSalesMyDataGridViewRO.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Nr Vanzare";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 95;
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
            // productSalesDateDataGridViewTextBoxColumn
            // 
            this.productSalesDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productSalesDateDataGridViewTextBoxColumn.DataPropertyName = "ProductSalesDate";
            this.productSalesDateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.productSalesDateDataGridViewTextBoxColumn.Name = "productSalesDateDataGridViewTextBoxColumn";
            this.productSalesDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.productSalesDateDataGridViewTextBoxColumn.Width = 59;
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "SalesPrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.salesPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            this.salesPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesQuantityDataGridViewTextBoxColumn
            // 
            this.salesQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.salesQuantityDataGridViewTextBoxColumn.DataPropertyName = "SalesQuantity";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.salesQuantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.salesQuantityDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.salesQuantityDataGridViewTextBoxColumn.Name = "salesQuantityDataGridViewTextBoxColumn";
            this.salesQuantityDataGridViewTextBoxColumn.ReadOnly = true;
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
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Product);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Client);
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
            this.product_idmyComboBox.Location = new System.Drawing.Point(102, 17);
            this.product_idmyComboBox.MessageStrip = null;
            this.product_idmyComboBox.Name = "product_idmyComboBox";
            this.product_idmyComboBox.ReadOnly = false;
            this.product_idmyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.product_idmyComboBox.Size = new System.Drawing.Size(242, 21);
            this.product_idmyComboBox.TabIndex = 1;
            this.product_idmyComboBox.ValueMember = "id";
            this.product_idmyComboBox.SelectedIndexChanged += new System.EventHandler(this.product_idmyComboBox_SelectedIndexChanged);
            // 
            // salesPricemyTextBox
            // 
            this.salesPricemyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.salesPricemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "SalesPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.salesPricemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.salesPricemyTextBox.Location = new System.Drawing.Point(102, 44);
            this.salesPricemyTextBox.Name = "salesPricemyTextBox";
            this.salesPricemyTextBox.ReadOnly = true;
            this.salesPricemyTextBox.Size = new System.Drawing.Size(56, 20);
            this.salesPricemyTextBox.TabIndex = 3;
            this.salesPricemyTextBox.TabStop = false;
            this.salesPricemyTextBox.Tag = "Unlocked";
            // 
            // salesQuantitymyTextBox
            // 
            this.salesQuantitymyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.salesQuantitymyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "SalesQuantity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.salesQuantitymyTextBox.ForeColor = System.Drawing.Color.Black;
            this.salesQuantitymyTextBox.Location = new System.Drawing.Point(102, 70);
            this.salesQuantitymyTextBox.Name = "salesQuantitymyTextBox";
            this.salesQuantitymyTextBox.Size = new System.Drawing.Size(56, 20);
            this.salesQuantitymyTextBox.TabIndex = 5;
            // 
            // productSalesDatemyDateTimePicker
            // 
            this.productSalesDatemyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.productSalesDatemyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.productSalesDatemyDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.baseBindingSource, "ProductSalesDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.productSalesDatemyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSalesDatemyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.productSalesDatemyDateTimePicker.Location = new System.Drawing.Point(102, 96);
            this.productSalesDatemyDateTimePicker.Name = "productSalesDatemyDateTimePicker";
            this.productSalesDatemyDateTimePicker.ReadOnly = false;
            this.productSalesDatemyDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.productSalesDatemyDateTimePicker.TabIndex = 7;
            this.productSalesDatemyDateTimePicker.Value = new System.DateTime(2008, 4, 16, 0, 54, 51, 375);
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
            this.client_idmyComboBox.Location = new System.Drawing.Point(102, 122);
            this.client_idmyComboBox.MessageStrip = null;
            this.client_idmyComboBox.Name = "client_idmyComboBox";
            this.client_idmyComboBox.ReadOnly = false;
            this.client_idmyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.client_idmyComboBox.Size = new System.Drawing.Size(242, 21);
            this.client_idmyComboBox.TabIndex = 9;
            this.client_idmyComboBox.ValueMember = "id";
            this.client_idmyComboBox.SelectedIndexChanged += new System.EventHandler(this.client_idmyComboBox_SelectedIndexChanged);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(50, 20);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(46, 13);
            this.myLabel1.TabIndex = 10;
            this.myLabel1.Text = "Produs";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(16, 47);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(80, 13);
            this.myLabel2.TabIndex = 11;
            this.myLabel2.Text = "Pret Vanzare";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(38, 73);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(58, 13);
            this.myLabel3.TabIndex = 12;
            this.myLabel3.Text = "Cantitate";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(12, 100);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(83, 13);
            this.myLabel4.TabIndex = 13;
            this.myLabel4.Text = "Data Vanzarii";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(57, 125);
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
            this.myLabel6.Location = new System.Drawing.Point(164, 47);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(42, 13);
            this.myLabel6.TabIndex = 15;
            this.myLabel6.Text = "(RON)";
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.White;
            this.myLabel7.Location = new System.Drawing.Point(164, 73);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(40, 13);
            this.myLabel7.TabIndex = 16;
            this.myLabel7.Text = "(BUC)";
            // 
            // discountProcentmyTextBox
            // 
            this.discountProcentmyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.discountProcentmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "DiscountProcent", true));
            this.discountProcentmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.discountProcentmyTextBox.Location = new System.Drawing.Point(132, 149);
            this.discountProcentmyTextBox.Name = "discountProcentmyTextBox";
            this.discountProcentmyTextBox.ReadOnly = true;
            this.discountProcentmyTextBox.Size = new System.Drawing.Size(26, 20);
            this.discountProcentmyTextBox.TabIndex = 17;
            this.discountProcentmyTextBox.TabStop = false;
            this.discountProcentmyTextBox.Tag = "Unlocked";
            this.discountProcentmyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = true;
            this.myLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel8.ForeColor = System.Drawing.Color.White;
            this.myLabel8.Location = new System.Drawing.Point(12, 153);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(114, 13);
            this.myLabel8.TabIndex = 18;
            this.myLabel8.Text = "Discount Client (%)";
            // 
            // ProductSalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlDisplayTypeOnEdit = MyControls.CustomControls.BaseControl.ControlDisplayTypeOnEdit.Alternative;
            this.DeleteMessage = "Vanzare produs stearsa!";
            this.FirstFocusControl = this.product_idmyComboBox;
            this.LastFocusControl = this.client_idmyComboBox;
            this.Name = "ProductSalesControl";
            this.ObjectName = "Vanzare produs";
            this.SaveMessage = "Vanzare produs salvata!";
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
            ((System.ComponentModel.ISupportInitialize)(this.productSalesMyDataGridViewRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dateFilterMonthCalendar;
        private MyControls.WindowsControls.myDataGridViewRO productSalesMyDataGridViewRO;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private MyControls.WindowsControls.myLabel myLabel5;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myComboBox client_idmyComboBox;
        private MyControls.WindowsControls.myDateTimePicker productSalesDatemyDateTimePicker;
        private MyControls.WindowsControls.myTextBox salesQuantitymyTextBox;
        private MyControls.WindowsControls.myTextBox salesPricemyTextBox;
        private MyControls.WindowsControls.myComboBox product_idmyComboBox;
        private MyControls.WindowsControls.myLabel myLabel7;
        private MyControls.WindowsControls.myLabel myLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSalesDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private MyControls.WindowsControls.myTextBox discountProcentmyTextBox;
        private MyControls.WindowsControls.myLabel myLabel8;
    }
}
