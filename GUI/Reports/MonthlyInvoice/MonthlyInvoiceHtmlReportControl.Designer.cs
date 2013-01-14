namespace GUI.Reports.MonthlyInvoice
{
    partial class MonthlyInvoiceHtmlReportControl
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
            this.invoiceDateMyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.runReportMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsMyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.monthlyInvoice = new DAL.Reports.MonthlyInvoice.MonthlyInvoice();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.myLabel1);
            this.optionsPanel.Controls.Add(this.clientsMyComboBox);
            this.optionsPanel.Controls.Add(this.invoiceDateMyDateTimePicker);
            this.optionsPanel.Controls.Add(this.myLabel2);
            this.optionsPanel.Controls.Add(this.runReportMyRibbonMenuButton);
            this.optionsPanel.Size = new System.Drawing.Size(683, 56);
            this.optionsPanel.Controls.SetChildIndex(this.runReportMyRibbonMenuButton, 0);
            this.optionsPanel.Controls.SetChildIndex(this.myLabel2, 0);
            this.optionsPanel.Controls.SetChildIndex(this.invoiceDateMyDateTimePicker, 0);
            this.optionsPanel.Controls.SetChildIndex(this.clientsMyComboBox, 0);
            this.optionsPanel.Controls.SetChildIndex(this.myLabel1, 0);
            // 
            // invoiceDateMyDateTimePicker
            // 
            this.invoiceDateMyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.invoiceDateMyDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.invoiceDateMyDateTimePicker.CustomFormat = "MMMM - yyyy    ";
            this.invoiceDateMyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDateMyDateTimePicker.Location = new System.Drawing.Point(397, 5);
            this.invoiceDateMyDateTimePicker.Name = "invoiceDateMyDateTimePicker";
            this.invoiceDateMyDateTimePicker.ReadOnly = false;
            this.invoiceDateMyDateTimePicker.Size = new System.Drawing.Size(170, 20);
            this.invoiceDateMyDateTimePicker.TabIndex = 1;
            this.invoiceDateMyDateTimePicker.Value = new System.DateTime(2008, 5, 19, 22, 6, 3, 78);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(18, 9);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(135, 13);
            this.myLabel2.TabIndex = 15;
            this.myLabel2.Text = "Factura pentru clientul";
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
            this.runReportMyRibbonMenuButton.Location = new System.Drawing.Point(573, 4);
            this.runReportMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.Name = "runReportMyRibbonMenuButton";
            this.runReportMyRibbonMenuButton.Radius = 6;
            this.runReportMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.runReportMyRibbonMenuButton.Size = new System.Drawing.Size(103, 23);
            this.runReportMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.runReportMyRibbonMenuButton.SplitDistance = 0;
            this.runReportMyRibbonMenuButton.TabIndex = 2;
            this.runReportMyRibbonMenuButton.Text = "Emite Factura";
            this.runReportMyRibbonMenuButton.Title = "";
            this.runReportMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.runReportMyRibbonMenuButton.Click += new System.EventHandler(this.runReportMyRibbonMenuButton_Click);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Client);
            // 
            // clientsMyComboBox
            // 
            this.clientsMyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.clientsMyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.clientsMyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clientsMyComboBox.DataSource = this.clientsBindingSource;
            this.clientsMyComboBox.DisplayMember = "ClientName";
            this.clientsMyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsMyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsMyComboBox.ForeColor = System.Drawing.Color.Black;
            this.clientsMyComboBox.FormattingEnabled = true;
            this.clientsMyComboBox.Location = new System.Drawing.Point(159, 6);
            this.clientsMyComboBox.MessageStrip = null;
            this.clientsMyComboBox.Name = "clientsMyComboBox";
            this.clientsMyComboBox.ReadOnly = false;
            this.clientsMyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.clientsMyComboBox.Size = new System.Drawing.Size(181, 21);
            this.clientsMyComboBox.TabIndex = 0;
            this.clientsMyComboBox.ValueMember = "id";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(346, 9);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(45, 13);
            this.myLabel1.TabIndex = 18;
            this.myLabel1.Text = "in luna";
            // 
            // monthlyInvoice
            // 
            this.monthlyInvoice.DataSetName = "MonthlyInvoice";
            this.monthlyInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MonthlyInvoiceHtmlReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MonthlyInvoiceHtmlReportControl";
            this.Size = new System.Drawing.Size(695, 480);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myDateTimePicker invoiceDateMyDateTimePicker;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myRibbonMenuButton runReportMyRibbonMenuButton;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myComboBox clientsMyComboBox;
        private DAL.Reports.MonthlyInvoice.MonthlyInvoice monthlyInvoice;
    }
}
