namespace GUI.Reports.PeriodStock
{
    partial class PeriodStockPivotControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodStockPivotControl));
            this.atDateMyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.allProductsMyCheckBox = new MyControls.WindowsControls.myCheckBox(this.components);
            this.productsMyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runReportMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.periodStock = new DAL.Reports.PeriodStock.PeriodStock();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportAxPivotTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodStock)).BeginInit();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.runReportMyRibbonMenuButton);
            this.controlsPanel.Controls.Add(this.productsMyComboBox);
            this.controlsPanel.Controls.Add(this.allProductsMyCheckBox);
            this.controlsPanel.Controls.Add(this.myLabel1);
            this.controlsPanel.Controls.Add(this.atDateMyDateTimePicker);
            this.controlsPanel.Size = new System.Drawing.Size(662, 67);
            this.controlsPanel.Controls.SetChildIndex(this.atDateMyDateTimePicker, 0);
            this.controlsPanel.Controls.SetChildIndex(this.myLabel1, 0);
            this.controlsPanel.Controls.SetChildIndex(this.allProductsMyCheckBox, 0);
            this.controlsPanel.Controls.SetChildIndex(this.productsMyComboBox, 0);
            this.controlsPanel.Controls.SetChildIndex(this.runReportMyRibbonMenuButton, 0);
            // 
            // reportAxPivotTable
            // 
            this.reportAxPivotTable.Location = new System.Drawing.Point(3, 83);
            this.reportAxPivotTable.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reportAxPivotTable.OcxState")));
            this.reportAxPivotTable.Size = new System.Drawing.Size(662, 366);
            // 
            // atDateMyDateTimePicker
            // 
            this.atDateMyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.atDateMyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.atDateMyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atDateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.atDateMyDateTimePicker.Location = new System.Drawing.Point(422, 12);
            this.atDateMyDateTimePicker.Name = "atDateMyDateTimePicker";
            this.atDateMyDateTimePicker.ReadOnly = false;
            this.atDateMyDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.atDateMyDateTimePicker.TabIndex = 1;
            this.atDateMyDateTimePicker.Value = new System.DateTime(2008, 5, 19, 22, 6, 3, 78);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(338, 16);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(78, 13);
            this.myLabel1.TabIndex = 2;
            this.myLabel1.Text = "Stoc la Data";
            // 
            // allProductsMyCheckBox
            // 
            this.allProductsMyCheckBox.AutoSize = true;
            this.allProductsMyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allProductsMyCheckBox.Checked = true;
            this.allProductsMyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allProductsMyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProductsMyCheckBox.ForeColor = System.Drawing.Color.White;
            this.allProductsMyCheckBox.Location = new System.Drawing.Point(16, 13);
            this.allProductsMyCheckBox.Name = "allProductsMyCheckBox";
            this.allProductsMyCheckBox.ReadOnly = false;
            this.allProductsMyCheckBox.Size = new System.Drawing.Size(119, 17);
            this.allProductsMyCheckBox.TabIndex = 3;
            this.allProductsMyCheckBox.Text = "Toate Produsele";
            this.allProductsMyCheckBox.UseVisualStyleBackColor = true;
            this.allProductsMyCheckBox.CheckedChanged += new System.EventHandler(this.allProductsMyCheckBox_CheckedChanged);
            // 
            // productsMyComboBox
            // 
            this.productsMyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productsMyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productsMyComboBox.BackColor = System.Drawing.Color.LightGray;
            this.productsMyComboBox.DataSource = this.productBindingSource;
            this.productsMyComboBox.DisplayMember = "ProductName";
            this.productsMyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsMyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsMyComboBox.ForeColor = System.Drawing.Color.Black;
            this.productsMyComboBox.FormattingEnabled = true;
            this.productsMyComboBox.Location = new System.Drawing.Point(141, 11);
            this.productsMyComboBox.MessageStrip = null;
            this.productsMyComboBox.Name = "productsMyComboBox";
            this.productsMyComboBox.ReadOnly = true;
            this.productsMyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.productsMyComboBox.Size = new System.Drawing.Size(191, 21);
            this.productsMyComboBox.TabIndex = 4;
            this.productsMyComboBox.ValueMember = "id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Product);
            // 
            // runReportMyRibbonMenuButton
            // 
            this.runReportMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.runReportMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.runReportMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.runReportMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.runReportMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.runReportMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.runReportMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.runReportMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.runReportMyRibbonMenuButton.FadingSpeed = 35;
            this.runReportMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.runReportMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runReportMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.runReportMyRibbonMenuButton.Image = global::GUI.Properties.Resources.Properties24;
            this.runReportMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.runReportMyRibbonMenuButton.ImageOffset = 2;
            this.runReportMyRibbonMenuButton.IsPressed = false;
            this.runReportMyRibbonMenuButton.KeepPress = false;
            this.runReportMyRibbonMenuButton.Location = new System.Drawing.Point(545, 11);
            this.runReportMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.Name = "runReportMyRibbonMenuButton";
            this.runReportMyRibbonMenuButton.Radius = 6;
            this.runReportMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.runReportMyRibbonMenuButton.Size = new System.Drawing.Size(103, 23);
            this.runReportMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.runReportMyRibbonMenuButton.SplitDistance = 0;
            this.runReportMyRibbonMenuButton.TabIndex = 6;
            this.runReportMyRibbonMenuButton.Text = "Emite Raport";
            this.runReportMyRibbonMenuButton.Title = "";
            this.runReportMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.runReportMyRibbonMenuButton.Click += new System.EventHandler(this.runReportMyRibbonMenuButton_Click);
            // 
            // periodStock
            // 
            this.periodStock.DataSetName = "PeriodStock";
            this.periodStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PeriodStockPivotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PeriodStockPivotControl";
            this.Size = new System.Drawing.Size(668, 480);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportAxPivotTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myComboBox productsMyComboBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MyControls.WindowsControls.myCheckBox allProductsMyCheckBox;
        private MyControls.WindowsControls.myDateTimePicker atDateMyDateTimePicker;
        private MyControls.WindowsControls.myRibbonMenuButton runReportMyRibbonMenuButton;
        private DAL.Reports.PeriodStock.PeriodStock periodStock;
    }
}
