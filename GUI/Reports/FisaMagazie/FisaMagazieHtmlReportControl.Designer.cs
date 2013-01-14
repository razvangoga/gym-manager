namespace GUI.Reports.FisaMagazie
{
    partial class FisaMagazieHtmlReportControl
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
            this.runReportMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.productsMyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.fromDateMyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.toDateMyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fisaMagazie = new DAL.Reports.FisaMagazie.FisaMagazie();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisaMagazie)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.myLabel3);
            this.optionsPanel.Controls.Add(this.toDateMyDateTimePicker);
            this.optionsPanel.Controls.Add(this.myLabel2);
            this.optionsPanel.Controls.Add(this.runReportMyRibbonMenuButton);
            this.optionsPanel.Controls.Add(this.productsMyComboBox);
            this.optionsPanel.Controls.Add(this.myLabel1);
            this.optionsPanel.Controls.Add(this.fromDateMyDateTimePicker);
            this.optionsPanel.Size = new System.Drawing.Size(628, 82);
            this.optionsPanel.Controls.SetChildIndex(this.fromDateMyDateTimePicker, 0);
            this.optionsPanel.Controls.SetChildIndex(this.myLabel1, 0);
            this.optionsPanel.Controls.SetChildIndex(this.productsMyComboBox, 0);
            this.optionsPanel.Controls.SetChildIndex(this.runReportMyRibbonMenuButton, 0);
            this.optionsPanel.Controls.SetChildIndex(this.myLabel2, 0);
            this.optionsPanel.Controls.SetChildIndex(this.toDateMyDateTimePicker, 0);
            this.optionsPanel.Controls.SetChildIndex(this.myLabel3, 0);
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
            this.runReportMyRibbonMenuButton.Location = new System.Drawing.Point(276, 3);
            this.runReportMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.Name = "runReportMyRibbonMenuButton";
            this.runReportMyRibbonMenuButton.Radius = 6;
            this.runReportMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.runReportMyRibbonMenuButton.Size = new System.Drawing.Size(103, 23);
            this.runReportMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.runReportMyRibbonMenuButton.SplitDistance = 0;
            this.runReportMyRibbonMenuButton.TabIndex = 11;
            this.runReportMyRibbonMenuButton.Text = "Emite Raport";
            this.runReportMyRibbonMenuButton.Title = "";
            this.runReportMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.runReportMyRibbonMenuButton.Click += new System.EventHandler(this.runReportMyRibbonMenuButton_Click);
            // 
            // productsMyComboBox
            // 
            this.productsMyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productsMyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productsMyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.productsMyComboBox.DataSource = this.productBindingSource;
            this.productsMyComboBox.DisplayMember = "ProductName";
            this.productsMyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsMyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsMyComboBox.ForeColor = System.Drawing.Color.Black;
            this.productsMyComboBox.FormattingEnabled = true;
            this.productsMyComboBox.Location = new System.Drawing.Point(73, 3);
            this.productsMyComboBox.MessageStrip = null;
            this.productsMyComboBox.Name = "productsMyComboBox";
            this.productsMyComboBox.ReadOnly = false;
            this.productsMyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.productsMyComboBox.Size = new System.Drawing.Size(191, 21);
            this.productsMyComboBox.TabIndex = 10;
            this.productsMyComboBox.ValueMember = "id";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(10, 34);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(57, 13);
            this.myLabel1.TabIndex = 8;
            this.myLabel1.Text = "Din Data";
            // 
            // fromDateMyDateTimePicker
            // 
            this.fromDateMyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fromDateMyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.fromDateMyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateMyDateTimePicker.Location = new System.Drawing.Point(73, 30);
            this.fromDateMyDateTimePicker.Name = "fromDateMyDateTimePicker";
            this.fromDateMyDateTimePicker.ReadOnly = false;
            this.fromDateMyDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.fromDateMyDateTimePicker.TabIndex = 7;
            this.fromDateMyDateTimePicker.Value = new System.DateTime(2008, 5, 19, 22, 6, 3, 78);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(207, 34);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(49, 13);
            this.myLabel2.TabIndex = 12;
            this.myLabel2.Text = "In Data";
            // 
            // toDateMyDateTimePicker
            // 
            this.toDateMyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toDateMyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.toDateMyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateMyDateTimePicker.Location = new System.Drawing.Point(262, 30);
            this.toDateMyDateTimePicker.Name = "toDateMyDateTimePicker";
            this.toDateMyDateTimePicker.ReadOnly = false;
            this.toDateMyDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.toDateMyDateTimePicker.TabIndex = 13;
            this.toDateMyDateTimePicker.Value = new System.DateTime(2008, 5, 19, 22, 6, 3, 78);
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(21, 6);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(46, 13);
            this.myLabel3.TabIndex = 14;
            this.myLabel3.Text = "Produs";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Product);
            // 
            // fisaMagazie
            // 
            this.fisaMagazie.DataSetName = "FisaMagazie";
            this.fisaMagazie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FisaMagazieHtmlReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FisaMagazieHtmlReportControl";
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisaMagazie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myRibbonMenuButton runReportMyRibbonMenuButton;
        private MyControls.WindowsControls.myComboBox productsMyComboBox;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myDateTimePicker fromDateMyDateTimePicker;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myDateTimePicker toDateMyDateTimePicker;
        private MyControls.WindowsControls.myLabel myLabel3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DAL.Reports.FisaMagazie.FisaMagazie fisaMagazie;
    }
}
