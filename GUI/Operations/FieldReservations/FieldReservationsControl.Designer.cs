namespace GUI.Operations.FieldReservations
{
    partial class FieldReservationsControl
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
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldReservationsStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.field_idmyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.field_Reservation_Status_idmyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.reservationFromDatemyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.reservationToDatemyDateTimePicker = new MyControls.WindowsControls.myDateTimePicker(this.components);
            this.descriptionmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.client_idmyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.pricemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.discountProcentmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel6 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel7 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel8 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel9 = new MyControls.WindowsControls.myLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
            this.baseGroupBox.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.saveCancelPannel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.detailsPannel.SuspendLayout();
            this.listPannel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.detailsParentPanel.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            this.listContainerPanel.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldReservationsStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Operations.Field_Reservation);
            // 
            // baseGroupBox
            // 
            this.baseGroupBox.Size = new System.Drawing.Size(658, 477);
            // 
            // navigationPanel
            // 
            this.navigationPanel.Size = new System.Drawing.Size(652, 30);
            // 
            // saveCancelPannel
            // 
            this.saveCancelPannel.Size = new System.Drawing.Size(652, 30);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Size = new System.Drawing.Size(652, 428);
            // 
            // detailsPannel
            // 
            this.detailsPannel.AutoScroll = true;
            this.detailsPannel.Controls.Add(this.myLabel9);
            this.detailsPannel.Controls.Add(this.myLabel8);
            this.detailsPannel.Controls.Add(this.myLabel7);
            this.detailsPannel.Controls.Add(this.myLabel6);
            this.detailsPannel.Controls.Add(this.myLabel5);
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.myLabel1);
            this.detailsPannel.Controls.Add(this.discountProcentmyTextBox);
            this.detailsPannel.Controls.Add(this.pricemyTextBox);
            this.detailsPannel.Controls.Add(this.client_idmyComboBox);
            this.detailsPannel.Controls.Add(this.descriptionmyTextBox);
            this.detailsPannel.Controls.Add(this.reservationToDatemyDateTimePicker);
            this.detailsPannel.Controls.Add(this.reservationFromDatemyDateTimePicker);
            this.detailsPannel.Controls.Add(this.field_Reservation_Status_idmyComboBox);
            this.detailsPannel.Controls.Add(this.field_idmyComboBox);
            this.detailsPannel.Size = new System.Drawing.Size(640, 403);
            // 
            // listPannel
            // 
            this.listPannel.Size = new System.Drawing.Size(0, 428);
            // 
            // filterPanel
            // 
            this.filterPanel.Size = new System.Drawing.Size(0, 100);
            // 
            // gridPanel
            // 
            this.gridPanel.Size = new System.Drawing.Size(0, 303);
            // 
            // baseCommandsControl
            // 
            this.baseCommandsControl.Size = new System.Drawing.Size(650, 28);
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Size = new System.Drawing.Size(0, 94);
            // 
            // detailsParentPanel
            // 
            this.detailsParentPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsParentPanel.Size = new System.Drawing.Size(652, 428);
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Size = new System.Drawing.Size(646, 422);
            // 
            // listContainerPanel
            // 
            this.listContainerPanel.Size = new System.Drawing.Size(0, 328);
            // 
            // listGroupBox
            // 
            this.listGroupBox.Size = new System.Drawing.Size(0, 322);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Client);
            // 
            // fieldReservationsStatusBindingSource
            // 
            this.fieldReservationsStatusBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Field_Reservation_Status);
            // 
            // fieldBindingSource
            // 
            this.fieldBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Field);
            // 
            // field_idmyComboBox
            // 
            this.field_idmyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.field_idmyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.field_idmyComboBox.BackColor = System.Drawing.Color.LightGray;
            this.field_idmyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.baseBindingSource, "Field_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.field_idmyComboBox.DataSource = this.fieldBindingSource;
            this.field_idmyComboBox.DisplayMember = "FieldName";
            this.field_idmyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field_idmyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_idmyComboBox.ForeColor = System.Drawing.Color.Black;
            this.field_idmyComboBox.FormattingEnabled = true;
            this.field_idmyComboBox.Location = new System.Drawing.Point(78, 22);
            this.field_idmyComboBox.MessageStrip = null;
            this.field_idmyComboBox.Name = "field_idmyComboBox";
            this.field_idmyComboBox.ReadOnly = true;
            this.field_idmyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.field_idmyComboBox.Size = new System.Drawing.Size(239, 21);
            this.field_idmyComboBox.TabIndex = 1;
            this.field_idmyComboBox.Tag = "Unlocked";
            this.field_idmyComboBox.ValueMember = "id";
            this.field_idmyComboBox.SelectedIndexChanged += new System.EventHandler(this.field_idmyComboBox_SelectedIndexChanged);
            // 
            // field_Reservation_Status_idmyComboBox
            // 
            this.field_Reservation_Status_idmyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.field_Reservation_Status_idmyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.field_Reservation_Status_idmyComboBox.BackColor = System.Drawing.Color.LightGray;
            this.field_Reservation_Status_idmyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.baseBindingSource, "Field_Reservation_Status_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.field_Reservation_Status_idmyComboBox.DataSource = this.fieldReservationsStatusBindingSource;
            this.field_Reservation_Status_idmyComboBox.DisplayMember = "FieldReservationStatus";
            this.field_Reservation_Status_idmyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field_Reservation_Status_idmyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_Reservation_Status_idmyComboBox.ForeColor = System.Drawing.Color.Black;
            this.field_Reservation_Status_idmyComboBox.FormattingEnabled = true;
            this.field_Reservation_Status_idmyComboBox.Location = new System.Drawing.Point(389, 22);
            this.field_Reservation_Status_idmyComboBox.MessageStrip = null;
            this.field_Reservation_Status_idmyComboBox.Name = "field_Reservation_Status_idmyComboBox";
            this.field_Reservation_Status_idmyComboBox.ReadOnly = true;
            this.field_Reservation_Status_idmyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.field_Reservation_Status_idmyComboBox.Size = new System.Drawing.Size(214, 21);
            this.field_Reservation_Status_idmyComboBox.TabIndex = 3;
            this.field_Reservation_Status_idmyComboBox.Tag = "Unlocked";
            this.field_Reservation_Status_idmyComboBox.ValueMember = "id";
            // 
            // reservationFromDatemyDateTimePicker
            // 
            this.reservationFromDatemyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reservationFromDatemyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.reservationFromDatemyDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.baseBindingSource, "ReservationFromDate", true));
            this.reservationFromDatemyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationFromDatemyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reservationFromDatemyDateTimePicker.Location = new System.Drawing.Point(107, 49);
            this.reservationFromDatemyDateTimePicker.Name = "reservationFromDatemyDateTimePicker";
            this.reservationFromDatemyDateTimePicker.ReadOnly = true;
            this.reservationFromDatemyDateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.reservationFromDatemyDateTimePicker.TabIndex = 5;
            this.reservationFromDatemyDateTimePicker.Tag = "Unlocked";
            this.reservationFromDatemyDateTimePicker.Value = new System.DateTime(2008, 5, 11, 21, 19, 57, 906);
            // 
            // reservationToDatemyDateTimePicker
            // 
            this.reservationToDatemyDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reservationToDatemyDateTimePicker.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.reservationToDatemyDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.baseBindingSource, "ReservationToDate", true));
            this.reservationToDatemyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationToDatemyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reservationToDatemyDateTimePicker.Location = new System.Drawing.Point(389, 49);
            this.reservationToDatemyDateTimePicker.Name = "reservationToDatemyDateTimePicker";
            this.reservationToDatemyDateTimePicker.ReadOnly = true;
            this.reservationToDatemyDateTimePicker.Size = new System.Drawing.Size(214, 20);
            this.reservationToDatemyDateTimePicker.TabIndex = 7;
            this.reservationToDatemyDateTimePicker.Tag = "Unlocked";
            this.reservationToDatemyDateTimePicker.Value = new System.DateTime(2008, 5, 11, 21, 20, 0, 296);
            // 
            // descriptionmyTextBox
            // 
            this.descriptionmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.descriptionmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Description", true));
            this.descriptionmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionmyTextBox.Location = new System.Drawing.Point(78, 75);
            this.descriptionmyTextBox.Multiline = true;
            this.descriptionmyTextBox.Name = "descriptionmyTextBox";
            this.descriptionmyTextBox.Size = new System.Drawing.Size(525, 53);
            this.descriptionmyTextBox.TabIndex = 9;
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
            this.client_idmyComboBox.Location = new System.Drawing.Point(78, 134);
            this.client_idmyComboBox.MessageStrip = null;
            this.client_idmyComboBox.Name = "client_idmyComboBox";
            this.client_idmyComboBox.ReadOnly = false;
            this.client_idmyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.client_idmyComboBox.Size = new System.Drawing.Size(239, 21);
            this.client_idmyComboBox.TabIndex = 11;
            this.client_idmyComboBox.ValueMember = "id";
            this.client_idmyComboBox.SelectedIndexChanged += new System.EventHandler(this.client_idmyComboBox_SelectedIndexChanged);
            // 
            // pricemyTextBox
            // 
            this.pricemyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.pricemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Price", true));
            this.pricemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.pricemyTextBox.Location = new System.Drawing.Point(78, 161);
            this.pricemyTextBox.Name = "pricemyTextBox";
            this.pricemyTextBox.ReadOnly = true;
            this.pricemyTextBox.Size = new System.Drawing.Size(65, 20);
            this.pricemyTextBox.TabIndex = 13;
            this.pricemyTextBox.Tag = "Unlocked";
            this.pricemyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountProcentmyTextBox
            // 
            this.discountProcentmyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.discountProcentmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "DiscountProcent", true));
            this.discountProcentmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.discountProcentmyTextBox.Location = new System.Drawing.Point(342, 161);
            this.discountProcentmyTextBox.Name = "discountProcentmyTextBox";
            this.discountProcentmyTextBox.ReadOnly = true;
            this.discountProcentmyTextBox.Size = new System.Drawing.Size(41, 20);
            this.discountProcentmyTextBox.TabIndex = 15;
            this.discountProcentmyTextBox.Tag = "Unlocked";
            this.discountProcentmyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(16, 25);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(40, 13);
            this.myLabel1.TabIndex = 16;
            this.myLabel1.Text = "Teren";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(334, 25);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(43, 13);
            this.myLabel2.TabIndex = 17;
            this.myLabel2.Text = "Status";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(16, 53);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(85, 13);
            this.myLabel3.TabIndex = 18;
            this.myLabel3.Text = "Inchiriat de la";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(334, 53);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(49, 13);
            this.myLabel4.TabIndex = 19;
            this.myLabel4.Text = "pana la";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(16, 78);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(43, 13);
            this.myLabel5.TabIndex = 20;
            this.myLabel5.Text = "Detalii";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.White;
            this.myLabel6.Location = new System.Drawing.Point(16, 137);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(39, 13);
            this.myLabel6.TabIndex = 21;
            this.myLabel6.Text = "Client";
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.White;
            this.myLabel7.Location = new System.Drawing.Point(16, 164);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(30, 13);
            this.myLabel7.TabIndex = 22;
            this.myLabel7.Text = "Pret";
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = true;
            this.myLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel8.ForeColor = System.Drawing.Color.White;
            this.myLabel8.Location = new System.Drawing.Point(149, 164);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(42, 13);
            this.myLabel8.TabIndex = 23;
            this.myLabel8.Text = "(RON)";
            // 
            // myLabel9
            // 
            this.myLabel9.AutoSize = true;
            this.myLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel9.ForeColor = System.Drawing.Color.White;
            this.myLabel9.Location = new System.Drawing.Point(223, 164);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.Size = new System.Drawing.Size(113, 13);
            this.myLabel9.TabIndex = 24;
            this.myLabel9.Text = "Discount client (%)";
            // 
            // FieldReservationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Rezervare teren stearsa!";
            this.FirstFocusControl = this.field_idmyComboBox;
            this.LastFocusControl = this.client_idmyComboBox;
            this.Name = "FieldReservationsControl";
            this.ObjectName = "Rezervare";
            this.SaveMessage = "Rezervare teren salvata!";
            this.Size = new System.Drawing.Size(664, 480);
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
            this.detailsParentPanel.ResumeLayout(false);
            this.detailsGroupBox.ResumeLayout(false);
            this.listContainerPanel.ResumeLayout(false);
            this.listGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldReservationsStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource fieldReservationsStatusBindingSource;
        private System.Windows.Forms.BindingSource fieldBindingSource;
        private MyControls.WindowsControls.myDateTimePicker reservationToDatemyDateTimePicker;
        private MyControls.WindowsControls.myDateTimePicker reservationFromDatemyDateTimePicker;
        private MyControls.WindowsControls.myComboBox field_Reservation_Status_idmyComboBox;
        private MyControls.WindowsControls.myComboBox field_idmyComboBox;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myTextBox discountProcentmyTextBox;
        private MyControls.WindowsControls.myTextBox pricemyTextBox;
        private MyControls.WindowsControls.myComboBox client_idmyComboBox;
        private MyControls.WindowsControls.myTextBox descriptionmyTextBox;
        private MyControls.WindowsControls.myLabel myLabel7;
        private MyControls.WindowsControls.myLabel myLabel6;
        private MyControls.WindowsControls.myLabel myLabel5;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel9;
        private MyControls.WindowsControls.myLabel myLabel8;
    }
}
