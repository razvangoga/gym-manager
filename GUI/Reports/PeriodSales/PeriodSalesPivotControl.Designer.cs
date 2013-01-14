namespace GUI.Reports.PeriodSales
{
    partial class PeriodSalesPivotControl
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
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.fromDateMyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.toMyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.runReportMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.periodSales = new DAL.Reports.PeriodSales.PeriodSales();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportAxPivotTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodSales)).BeginInit();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.runReportMyRibbonMenuButton);
            this.controlsPanel.Controls.Add(this.myLabel2);
            this.controlsPanel.Controls.Add(this.toMyDateTimePicker);
            this.controlsPanel.Controls.Add(this.fromDateMyDateTimePicker);
            this.controlsPanel.Controls.Add(this.myLabel1);
            this.controlsPanel.Size = new System.Drawing.Size(634, 65);
            this.controlsPanel.Controls.SetChildIndex(this.myLabel1, 0);
            this.controlsPanel.Controls.SetChildIndex(this.fromDateMyDateTimePicker, 0);
            this.controlsPanel.Controls.SetChildIndex(this.toMyDateTimePicker, 0);
            this.controlsPanel.Controls.SetChildIndex(this.myLabel2, 0);
            this.controlsPanel.Controls.SetChildIndex(this.runReportMyRibbonMenuButton, 0);
            // 
            // reportAxPivotTable
            // 
            this.reportAxPivotTable.Location = new System.Drawing.Point(3, 81);
            this.reportAxPivotTable.Size = new System.Drawing.Size(634, 368);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(25, 14);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(57, 13);
            this.myLabel1.TabIndex = 1;
            this.myLabel1.Text = "Din Data";
            // 
            // fromDateMyDateTimePicker
            // 
            this.fromDateMyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fromDateMyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.fromDateMyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateMyDateTimePicker.Location = new System.Drawing.Point(88, 10);
            this.fromDateMyDateTimePicker.Name = "fromDateMyDateTimePicker";
            this.fromDateMyDateTimePicker.ReadOnly = false;
            this.fromDateMyDateTimePicker.Size = new System.Drawing.Size(104, 20);
            this.fromDateMyDateTimePicker.TabIndex = 2;
            this.fromDateMyDateTimePicker.Value = new System.DateTime(2008, 5, 19, 0, 55, 37, 734);
            // 
            // toMyDateTimePicker
            // 
            this.toMyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toMyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.toMyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toMyDateTimePicker.Location = new System.Drawing.Point(269, 10);
            this.toMyDateTimePicker.Name = "toMyDateTimePicker";
            this.toMyDateTimePicker.ReadOnly = false;
            this.toMyDateTimePicker.Size = new System.Drawing.Size(104, 20);
            this.toMyDateTimePicker.TabIndex = 3;
            this.toMyDateTimePicker.Value = new System.DateTime(2008, 5, 19, 0, 55, 37, 734);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(210, 14);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(53, 13);
            this.myLabel2.TabIndex = 4;
            this.myLabel2.Text = "In  Data";
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
            this.runReportMyRibbonMenuButton.Location = new System.Drawing.Point(402, 9);
            this.runReportMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.Name = "runReportMyRibbonMenuButton";
            this.runReportMyRibbonMenuButton.Radius = 6;
            this.runReportMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.runReportMyRibbonMenuButton.Size = new System.Drawing.Size(103, 23);
            this.runReportMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.runReportMyRibbonMenuButton.SplitDistance = 0;
            this.runReportMyRibbonMenuButton.TabIndex = 5;
            this.runReportMyRibbonMenuButton.Text = "Emite Raport";
            this.runReportMyRibbonMenuButton.Title = "";
            this.runReportMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.runReportMyRibbonMenuButton.Click += new System.EventHandler(this.runReportMyRibbonMenuButton_Click);
            // 
            // periodSales
            // 
            this.periodSales.DataSetName = "PeriodSales";
            this.periodSales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PeriodSalesPivotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PeriodSalesPivotControl";
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportAxPivotTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myDateTimePicker fromDateMyDateTimePicker;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myDateTimePicker toMyDateTimePicker;
        private MyControls.WindowsControls.myRibbonMenuButton runReportMyRibbonMenuButton;
        private DAL.Reports.PeriodSales.PeriodSales periodSales;
    }
}
