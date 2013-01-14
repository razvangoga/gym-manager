namespace GUI.Reports.SubscriptionDetails
{
    partial class SubscriptionDetailsHtmlReportControl
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
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.fromDateMyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.subscriptionDetails = new DAL.Reports.SubscriptionDetails.SubscriptionDetails();
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.toDateMyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.myLabel2);
            this.optionsPanel.Controls.Add(this.toDateMyDateTimePicker);
            this.optionsPanel.Controls.Add(this.runReportMyRibbonMenuButton);
            this.optionsPanel.Controls.Add(this.myLabel1);
            this.optionsPanel.Controls.Add(this.fromDateMyDateTimePicker);
            this.optionsPanel.Size = new System.Drawing.Size(628, 63);
            this.optionsPanel.Controls.SetChildIndex(this.fromDateMyDateTimePicker, 0);
            this.optionsPanel.Controls.SetChildIndex(this.myLabel1, 0);
            this.optionsPanel.Controls.SetChildIndex(this.runReportMyRibbonMenuButton, 0);
            this.optionsPanel.Controls.SetChildIndex(this.toDateMyDateTimePicker, 0);
            this.optionsPanel.Controls.SetChildIndex(this.myLabel2, 0);
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
            this.runReportMyRibbonMenuButton.Location = new System.Drawing.Point(411, 6);
            this.runReportMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.runReportMyRibbonMenuButton.Name = "runReportMyRibbonMenuButton";
            this.runReportMyRibbonMenuButton.Radius = 6;
            this.runReportMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.runReportMyRibbonMenuButton.Size = new System.Drawing.Size(103, 23);
            this.runReportMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.runReportMyRibbonMenuButton.SplitDistance = 0;
            this.runReportMyRibbonMenuButton.TabIndex = 9;
            this.runReportMyRibbonMenuButton.Text = "Emite Raport";
            this.runReportMyRibbonMenuButton.Title = "";
            this.runReportMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.runReportMyRibbonMenuButton.Click += new System.EventHandler(this.runReportMyRibbonMenuButton_Click);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(16, 11);
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
            this.fromDateMyDateTimePicker.Location = new System.Drawing.Point(79, 7);
            this.fromDateMyDateTimePicker.Name = "fromDateMyDateTimePicker";
            this.fromDateMyDateTimePicker.ReadOnly = false;
            this.fromDateMyDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.fromDateMyDateTimePicker.TabIndex = 7;
            this.fromDateMyDateTimePicker.Value = new System.DateTime(2008, 5, 19, 22, 6, 3, 78);
            // 
            // subscriptionDetails
            // 
            this.subscriptionDetails.DataSetName = "SubscriptionDetails";
            this.subscriptionDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(213, 11);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(49, 13);
            this.myLabel2.TabIndex = 11;
            this.myLabel2.Text = "In Data";
            // 
            // toDateMyDateTimePicker
            // 
            this.toDateMyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toDateMyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.toDateMyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateMyDateTimePicker.Location = new System.Drawing.Point(268, 7);
            this.toDateMyDateTimePicker.Name = "toDateMyDateTimePicker";
            this.toDateMyDateTimePicker.ReadOnly = false;
            this.toDateMyDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.toDateMyDateTimePicker.TabIndex = 10;
            this.toDateMyDateTimePicker.Value = new System.DateTime(2008, 5, 19, 22, 6, 3, 78);
            // 
            // SubscriptionDetailsHtmlReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SubscriptionDetailsHtmlReportControl";
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myRibbonMenuButton runReportMyRibbonMenuButton;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myDateTimePicker fromDateMyDateTimePicker;
        private DAL.Reports.SubscriptionDetails.SubscriptionDetails subscriptionDetails;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myDateTimePicker toDateMyDateTimePicker;
    }
}
