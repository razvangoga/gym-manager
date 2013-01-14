namespace GUI.Nomenclators.Products
{
    partial class ProductsControl
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
            this.productsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNamemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.descriptionmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.product_Type_idmyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.salesPricemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.lastPurchasePricemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.isActivemyCheckBox = new MyControls.WindowsControls.myCheckBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel6 = new MyControls.WindowsControls.myLabel(this.components);
            this.lastPurchaseDatemyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
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
            this.detailsParentPanel.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            this.listContainerPanel.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsMyDataGridViewRO)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Product);
            // 
            // detailsPannel
            // 
            this.detailsPannel.AutoScroll = true;
            this.detailsPannel.Controls.Add(this.lastPurchaseDatemyDateTimePicker);
            this.detailsPannel.Controls.Add(this.myLabel6);
            this.detailsPannel.Controls.Add(this.myLabel5);
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.myLabel1);
            this.detailsPannel.Controls.Add(this.isActivemyCheckBox);
            this.detailsPannel.Controls.Add(this.lastPurchasePricemyTextBox);
            this.detailsPannel.Controls.Add(this.salesPricemyTextBox);
            this.detailsPannel.Controls.Add(this.product_Type_idmyComboBox);
            this.detailsPannel.Controls.Add(this.descriptionmyTextBox);
            this.detailsPannel.Controls.Add(this.productNamemyTextBox);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.productsMyDataGridViewRO);
            // 
            // productsTypeBindingSource
            // 
            this.productsTypeBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Product_Type);
            // 
            // productsMyDataGridViewRO
            // 
            this.productsMyDataGridViewRO.AllowUserToAddRows = false;
            this.productsMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.productsMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.productsMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productsMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productsMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn});
            this.productsMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsMyDataGridViewRO.EditableGrid = false;
            this.productsMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.productsMyDataGridViewRO.MultiSelect = false;
            this.productsMyDataGridViewRO.Name = "productsMyDataGridViewRO";
            this.productsMyDataGridViewRO.ReadOnly = true;
            this.productsMyDataGridViewRO.RowHeadersVisible = false;
            this.productsMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productsMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsMyDataGridViewRO.Size = new System.Drawing.Size(228, 303);
            this.productsMyDataGridViewRO.TabIndex = 0;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Denumire Produs";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNamemyTextBox
            // 
            this.productNamemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.productNamemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "ProductName", true));
            this.productNamemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.productNamemyTextBox.Location = new System.Drawing.Point(149, 6);
            this.productNamemyTextBox.Name = "productNamemyTextBox";
            this.productNamemyTextBox.Size = new System.Drawing.Size(208, 20);
            this.productNamemyTextBox.TabIndex = 1;
            // 
            // descriptionmyTextBox
            // 
            this.descriptionmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.descriptionmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Description", true));
            this.descriptionmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionmyTextBox.Location = new System.Drawing.Point(149, 30);
            this.descriptionmyTextBox.Multiline = true;
            this.descriptionmyTextBox.Name = "descriptionmyTextBox";
            this.descriptionmyTextBox.Size = new System.Drawing.Size(208, 35);
            this.descriptionmyTextBox.TabIndex = 3;
            // 
            // product_Type_idmyComboBox
            // 
            this.product_Type_idmyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.product_Type_idmyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.product_Type_idmyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.product_Type_idmyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.baseBindingSource, "Product_Type_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.product_Type_idmyComboBox.DataSource = this.productsTypeBindingSource;
            this.product_Type_idmyComboBox.DisplayMember = "ProductType";
            this.product_Type_idmyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_Type_idmyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Type_idmyComboBox.ForeColor = System.Drawing.Color.Black;
            this.product_Type_idmyComboBox.FormattingEnabled = true;
            this.product_Type_idmyComboBox.Location = new System.Drawing.Point(150, 69);
            this.product_Type_idmyComboBox.MessageStrip = null;
            this.product_Type_idmyComboBox.Name = "product_Type_idmyComboBox";
            this.product_Type_idmyComboBox.ReadOnly = false;
            this.product_Type_idmyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.product_Type_idmyComboBox.Size = new System.Drawing.Size(207, 21);
            this.product_Type_idmyComboBox.TabIndex = 5;
            this.product_Type_idmyComboBox.ValueMember = "id";
            // 
            // salesPricemyTextBox
            // 
            this.salesPricemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.salesPricemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "SalesPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.salesPricemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.salesPricemyTextBox.Location = new System.Drawing.Point(149, 94);
            this.salesPricemyTextBox.Name = "salesPricemyTextBox";
            this.salesPricemyTextBox.Size = new System.Drawing.Size(65, 20);
            this.salesPricemyTextBox.TabIndex = 7;
            this.salesPricemyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lastPurchasePricemyTextBox
            // 
            this.lastPurchasePricemyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.lastPurchasePricemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "LastPurchasePrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.lastPurchasePricemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastPurchasePricemyTextBox.Location = new System.Drawing.Point(149, 118);
            this.lastPurchasePricemyTextBox.Name = "lastPurchasePricemyTextBox";
            this.lastPurchasePricemyTextBox.ReadOnly = true;
            this.lastPurchasePricemyTextBox.Size = new System.Drawing.Size(65, 20);
            this.lastPurchasePricemyTextBox.TabIndex = 9;
            this.lastPurchasePricemyTextBox.TabStop = false;
            this.lastPurchasePricemyTextBox.Tag = "Unlocked";
            this.lastPurchasePricemyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // isActivemyCheckBox
            // 
            this.isActivemyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActivemyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.baseBindingSource, "IsActive", true));
            this.isActivemyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActivemyCheckBox.ForeColor = System.Drawing.Color.White;
            this.isActivemyCheckBox.Location = new System.Drawing.Point(86, 168);
            this.isActivemyCheckBox.Name = "isActivemyCheckBox";
            this.isActivemyCheckBox.ReadOnly = false;
            this.isActivemyCheckBox.Size = new System.Drawing.Size(79, 24);
            this.isActivemyCheckBox.TabIndex = 13;
            this.isActivemyCheckBox.Text = "Activ";
            this.isActivemyCheckBox.UseVisualStyleBackColor = true;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(83, 9);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(60, 13);
            this.myLabel1.TabIndex = 14;
            this.myLabel1.Text = "Denumire";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(82, 33);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(61, 13);
            this.myLabel2.TabIndex = 15;
            this.myLabel2.Text = "Descriere";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(40, 72);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(103, 13);
            this.myLabel3.TabIndex = 16;
            this.myLabel3.Text = "Categorie produs";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(64, 97);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(79, 13);
            this.myLabel4.TabIndex = 17;
            this.myLabel4.Text = "Pret vanzare";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(3, 121);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(140, 13);
            this.myLabel5.TabIndex = 18;
            this.myLabel5.Text = "Ultimul pret de achizitie";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.White;
            this.myLabel6.Location = new System.Drawing.Point(3, 146);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(143, 13);
            this.myLabel6.TabIndex = 19;
            this.myLabel6.Text = "Ultimul data de achizitie";
            // 
            // lastPurchaseDatemyDateTimePicker
            // 
            this.lastPurchaseDatemyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lastPurchaseDatemyDateTimePicker.Checked = false;
            this.lastPurchaseDatemyDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.lastPurchaseDatemyDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.baseBindingSource, "LastPurchaseDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lastPurchaseDatemyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPurchaseDatemyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastPurchaseDatemyDateTimePicker.Location = new System.Drawing.Point(149, 142);
            this.lastPurchaseDatemyDateTimePicker.Name = "lastPurchaseDatemyDateTimePicker";
            this.lastPurchaseDatemyDateTimePicker.ReadOnly = true;
            this.lastPurchaseDatemyDateTimePicker.ShowCheckBox = true;
            this.lastPurchaseDatemyDateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.lastPurchaseDatemyDateTimePicker.TabIndex = 20;
            this.lastPurchaseDatemyDateTimePicker.TabStop = false;
            this.lastPurchaseDatemyDateTimePicker.Tag = "Unlocked";
            this.lastPurchaseDatemyDateTimePicker.Value = null;
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Produs sters!";
            this.FirstFocusControl = this.productNamemyTextBox;
            this.LastFocusControl = this.isActivemyCheckBox;
            this.Name = "ProductsControl";
            this.ObjectName = "Produs";
            this.SaveMessage = "Produs salvat!";
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
            this.detailsParentPanel.ResumeLayout(false);
            this.detailsGroupBox.ResumeLayout(false);
            this.listContainerPanel.ResumeLayout(false);
            this.listGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsMyDataGridViewRO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productsTypeBindingSource;
        private MyControls.WindowsControls.myCheckBox isActivemyCheckBox;
        private MyControls.WindowsControls.myTextBox lastPurchasePricemyTextBox;
        private MyControls.WindowsControls.myTextBox salesPricemyTextBox;
        private MyControls.WindowsControls.myComboBox product_Type_idmyComboBox;
        private MyControls.WindowsControls.myTextBox descriptionmyTextBox;
        private MyControls.WindowsControls.myTextBox productNamemyTextBox;
        private MyControls.WindowsControls.myDataGridViewRO productsMyDataGridViewRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private MyControls.WindowsControls.myLabel myLabel6;
        private MyControls.WindowsControls.myLabel myLabel5;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myDateTimePicker lastPurchaseDatemyDateTimePicker;
    }
}
