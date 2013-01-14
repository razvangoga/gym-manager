namespace GUI.Operations.FieldReservations
{
    partial class FieldReservationsScheduleControl
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
            this.fieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calendarEntriesPanel = new System.Windows.Forms.Panel();
            this.selectionsPanel = new System.Windows.Forms.Panel();
            this.canceledRadioButton = new System.Windows.Forms.RadioButton();
            this.activeEntiriesRadioButton = new System.Windows.Forms.RadioButton();
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.currentDateMyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.fieldsMyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.updateStatusesJobTimer = new System.Windows.Forms.Timer(this.components);
            this.commandsPanel.SuspendLayout();
            this.reportViewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.selectionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerPanel
            // 
            this.reportViewerPanel.Controls.Add(this.tableLayoutPanel);
            // 
            // baseCommandsControl
            // 
            this.baseCommandsControl.Filter_ButtonClick += new MyControls.CustomControls.BaseControl.Filter_ButtonClick(this.baseCommandsControl_Filter_ButtonClick);
            // 
            // fieldsBindingSource
            // 
            this.fieldsBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Field);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.calendarEntriesPanel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.selectionsPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.calendarPanel, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(700, 472);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // calendarEntriesPanel
            // 
            this.calendarEntriesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendarEntriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarEntriesPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calendarEntriesPanel.Location = new System.Drawing.Point(113, 43);
            this.calendarEntriesPanel.Name = "calendarEntriesPanel";
            this.calendarEntriesPanel.Size = new System.Drawing.Size(584, 426);
            this.calendarEntriesPanel.TabIndex = 2;
            // 
            // selectionsPanel
            // 
            this.selectionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel.SetColumnSpan(this.selectionsPanel, 2);
            this.selectionsPanel.Controls.Add(this.canceledRadioButton);
            this.selectionsPanel.Controls.Add(this.activeEntiriesRadioButton);
            this.selectionsPanel.Controls.Add(this.myLabel2);
            this.selectionsPanel.Controls.Add(this.currentDateMyDateTimePicker);
            this.selectionsPanel.Controls.Add(this.fieldsMyComboBox);
            this.selectionsPanel.Controls.Add(this.myLabel1);
            this.selectionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectionsPanel.Location = new System.Drawing.Point(3, 3);
            this.selectionsPanel.Name = "selectionsPanel";
            this.selectionsPanel.Size = new System.Drawing.Size(694, 34);
            this.selectionsPanel.TabIndex = 0;
            // 
            // canceledRadioButton
            // 
            this.canceledRadioButton.AutoSize = true;
            this.canceledRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.canceledRadioButton.ForeColor = System.Drawing.Color.White;
            this.canceledRadioButton.Location = new System.Drawing.Point(488, 7);
            this.canceledRadioButton.Name = "canceledRadioButton";
            this.canceledRadioButton.Size = new System.Drawing.Size(68, 17);
            this.canceledRadioButton.TabIndex = 5;
            this.canceledRadioButton.Text = "Anulate";
            this.canceledRadioButton.UseVisualStyleBackColor = true;
            this.canceledRadioButton.CheckedChanged += new System.EventHandler(this.canceledRadioButton_CheckedChanged);
            // 
            // activeEntiriesRadioButton
            // 
            this.activeEntiriesRadioButton.AutoSize = true;
            this.activeEntiriesRadioButton.Checked = true;
            this.activeEntiriesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.activeEntiriesRadioButton.ForeColor = System.Drawing.Color.White;
            this.activeEntiriesRadioButton.Location = new System.Drawing.Point(404, 7);
            this.activeEntiriesRadioButton.Name = "activeEntiriesRadioButton";
            this.activeEntiriesRadioButton.Size = new System.Drawing.Size(61, 17);
            this.activeEntiriesRadioButton.TabIndex = 4;
            this.activeEntiriesRadioButton.TabStop = true;
            this.activeEntiriesRadioButton.Text = "Active";
            this.activeEntiriesRadioButton.UseVisualStyleBackColor = true;
            this.activeEntiriesRadioButton.CheckedChanged += new System.EventHandler(this.activeEntiriesRadioButton_CheckedChanged);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(226, 9);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(34, 13);
            this.myLabel2.TabIndex = 3;
            this.myLabel2.Text = "Data";
            // 
            // currentDateMyDateTimePicker
            // 
            this.currentDateMyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.currentDateMyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.currentDateMyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.currentDateMyDateTimePicker.Location = new System.Drawing.Point(266, 5);
            this.currentDateMyDateTimePicker.Name = "currentDateMyDateTimePicker";
            this.currentDateMyDateTimePicker.ReadOnly = false;
            this.currentDateMyDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.currentDateMyDateTimePicker.TabIndex = 2;
            this.currentDateMyDateTimePicker.Value = new System.DateTime(2008, 5, 12, 22, 1, 59, 203);
            this.currentDateMyDateTimePicker.ValueChanged += new System.EventHandler(this.currentDateMyDateTimePicker_ValueChanged);
            // 
            // fieldsMyComboBox
            // 
            this.fieldsMyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fieldsMyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fieldsMyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fieldsMyComboBox.DataSource = this.fieldsBindingSource;
            this.fieldsMyComboBox.DisplayMember = "FieldName";
            this.fieldsMyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fieldsMyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldsMyComboBox.ForeColor = System.Drawing.Color.Black;
            this.fieldsMyComboBox.FormattingEnabled = true;
            this.fieldsMyComboBox.Location = new System.Drawing.Point(60, 6);
            this.fieldsMyComboBox.MessageStrip = null;
            this.fieldsMyComboBox.Name = "fieldsMyComboBox";
            this.fieldsMyComboBox.ReadOnly = false;
            this.fieldsMyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.fieldsMyComboBox.Size = new System.Drawing.Size(147, 21);
            this.fieldsMyComboBox.TabIndex = 1;
            this.fieldsMyComboBox.ValueMember = "id";
            this.fieldsMyComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldsMyComboBox_SelectedIndexChanged);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(14, 9);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(40, 13);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Teren";
            // 
            // calendarPanel
            // 
            this.calendarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel.Location = new System.Drawing.Point(3, 43);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(104, 426);
            this.calendarPanel.TabIndex = 1;
            // 
            // updateStatusesJobTimer
            // 
            this.updateStatusesJobTimer.Enabled = true;
            this.updateStatusesJobTimer.Interval = 15000;
            this.updateStatusesJobTimer.Tick += new System.EventHandler(this.updateStatusesJobTimer_Tick);
            // 
            // FieldReservationsScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FieldReservationsScheduleControl";
            this.Load += new System.EventHandler(this.FieldReservationsScheduleControl_Load);
            this.commandsPanel.ResumeLayout(false);
            this.reportViewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.selectionsPanel.ResumeLayout(false);
            this.selectionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource fieldsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel selectionsPanel;
        private MyControls.WindowsControls.myComboBox fieldsMyComboBox;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myDateTimePicker currentDateMyDateTimePicker;
        private System.Windows.Forms.Panel calendarEntriesPanel;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.RadioButton canceledRadioButton;
        private System.Windows.Forms.RadioButton activeEntiriesRadioButton;
        private System.Windows.Forms.Timer updateStatusesJobTimer;
    }
}
