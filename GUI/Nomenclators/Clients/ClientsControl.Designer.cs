namespace GUI.Nomenclators.Clients
{
    partial class ClientsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientsMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNamemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.fiscalCodemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.tradeCodemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.addressmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.phonemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.bankmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.bankAccountmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.isActivemyCheckBox = new MyControls.WindowsControls.myCheckBox(this.components);
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
            this.detailsParentPanel.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            this.listContainerPanel.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsMyDataGridViewRO)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Client);
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
            this.detailsPannel.Controls.Add(this.isActivemyCheckBox);
            this.detailsPannel.Controls.Add(this.bankAccountmyTextBox);
            this.detailsPannel.Controls.Add(this.bankmyTextBox);
            this.detailsPannel.Controls.Add(this.phonemyTextBox);
            this.detailsPannel.Controls.Add(this.addressmyTextBox);
            this.detailsPannel.Controls.Add(this.tradeCodemyTextBox);
            this.detailsPannel.Controls.Add(this.fiscalCodemyTextBox);
            this.detailsPannel.Controls.Add(this.clientNamemyTextBox);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.clientsMyDataGridViewRO);
            // 
            // clientsMyDataGridViewRO
            // 
            this.clientsMyDataGridViewRO.AllowUserToAddRows = false;
            this.clientsMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.clientsMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.clientsMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.clientsMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.clientsMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNameDataGridViewTextBoxColumn});
            this.clientsMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle6;
            this.clientsMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsMyDataGridViewRO.EditableGrid = false;
            this.clientsMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.clientsMyDataGridViewRO.MultiSelect = false;
            this.clientsMyDataGridViewRO.Name = "clientsMyDataGridViewRO";
            this.clientsMyDataGridViewRO.ReadOnly = true;
            this.clientsMyDataGridViewRO.RowHeadersVisible = false;
            this.clientsMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientsMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsMyDataGridViewRO.Size = new System.Drawing.Size(228, 303);
            this.clientsMyDataGridViewRO.TabIndex = 0;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Denumire Client";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNamemyTextBox
            // 
            this.clientNamemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clientNamemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "ClientName", true));
            this.clientNamemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.clientNamemyTextBox.Location = new System.Drawing.Point(139, 21);
            this.clientNamemyTextBox.Name = "clientNamemyTextBox";
            this.clientNamemyTextBox.Size = new System.Drawing.Size(220, 20);
            this.clientNamemyTextBox.TabIndex = 1;
            // 
            // fiscalCodemyTextBox
            // 
            this.fiscalCodemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fiscalCodemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "FiscalCode", true));
            this.fiscalCodemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.fiscalCodemyTextBox.Location = new System.Drawing.Point(139, 46);
            this.fiscalCodemyTextBox.Name = "fiscalCodemyTextBox";
            this.fiscalCodemyTextBox.Size = new System.Drawing.Size(220, 20);
            this.fiscalCodemyTextBox.TabIndex = 3;
            // 
            // tradeCodemyTextBox
            // 
            this.tradeCodemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tradeCodemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "TradeCode", true));
            this.tradeCodemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.tradeCodemyTextBox.Location = new System.Drawing.Point(139, 71);
            this.tradeCodemyTextBox.Name = "tradeCodemyTextBox";
            this.tradeCodemyTextBox.Size = new System.Drawing.Size(220, 20);
            this.tradeCodemyTextBox.TabIndex = 5;
            // 
            // addressmyTextBox
            // 
            this.addressmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addressmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Address", true));
            this.addressmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressmyTextBox.Location = new System.Drawing.Point(139, 96);
            this.addressmyTextBox.Multiline = true;
            this.addressmyTextBox.Name = "addressmyTextBox";
            this.addressmyTextBox.Size = new System.Drawing.Size(220, 40);
            this.addressmyTextBox.TabIndex = 7;
            // 
            // phonemyTextBox
            // 
            this.phonemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.phonemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Phone", true));
            this.phonemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.phonemyTextBox.Location = new System.Drawing.Point(139, 141);
            this.phonemyTextBox.Name = "phonemyTextBox";
            this.phonemyTextBox.Size = new System.Drawing.Size(220, 20);
            this.phonemyTextBox.TabIndex = 9;
            // 
            // bankmyTextBox
            // 
            this.bankmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bankmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Bank", true));
            this.bankmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.bankmyTextBox.Location = new System.Drawing.Point(139, 166);
            this.bankmyTextBox.Name = "bankmyTextBox";
            this.bankmyTextBox.Size = new System.Drawing.Size(220, 20);
            this.bankmyTextBox.TabIndex = 11;
            // 
            // bankAccountmyTextBox
            // 
            this.bankAccountmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bankAccountmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "BankAccount", true));
            this.bankAccountmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.bankAccountmyTextBox.Location = new System.Drawing.Point(139, 191);
            this.bankAccountmyTextBox.Name = "bankAccountmyTextBox";
            this.bankAccountmyTextBox.Size = new System.Drawing.Size(220, 20);
            this.bankAccountmyTextBox.TabIndex = 13;
            // 
            // isActivemyCheckBox
            // 
            this.isActivemyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActivemyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.baseBindingSource, "IsActive", true));
            this.isActivemyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActivemyCheckBox.ForeColor = System.Drawing.Color.White;
            this.isActivemyCheckBox.Location = new System.Drawing.Point(90, 239);
            this.isActivemyCheckBox.Name = "isActivemyCheckBox";
            this.isActivemyCheckBox.ReadOnly = false;
            this.isActivemyCheckBox.Size = new System.Drawing.Size(63, 24);
            this.isActivemyCheckBox.TabIndex = 16;
            this.isActivemyCheckBox.Text = "Activ";
            this.isActivemyCheckBox.UseVisualStyleBackColor = true;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(73, 24);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(60, 13);
            this.myLabel1.TabIndex = 16;
            this.myLabel1.Text = "Denumire";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(67, 49);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(66, 13);
            this.myLabel2.TabIndex = 17;
            this.myLabel2.Text = "Cod Fiscal";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(15, 74);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(118, 13);
            this.myLabel3.TabIndex = 18;
            this.myLabel3.Text = "Nr. Reg. Comertului";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(87, 99);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(46, 13);
            this.myLabel4.TabIndex = 19;
            this.myLabel4.Text = "Adresa";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(83, 144);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(50, 13);
            this.myLabel5.TabIndex = 20;
            this.myLabel5.Text = "Telefon";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.White;
            this.myLabel6.Location = new System.Drawing.Point(90, 169);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(43, 13);
            this.myLabel6.TabIndex = 21;
            this.myLabel6.Text = "Banca";
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.White;
            this.myLabel7.Location = new System.Drawing.Point(56, 194);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(77, 13);
            this.myLabel7.TabIndex = 22;
            this.myLabel7.Text = "Cont Bancar";
            // 
            // discountProcentmyTextBox
            // 
            this.discountProcentmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.discountProcentmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "DiscountProcent", true));
            this.discountProcentmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.discountProcentmyTextBox.Location = new System.Drawing.Point(139, 217);
            this.discountProcentmyTextBox.Name = "discountProcentmyTextBox";
            this.discountProcentmyTextBox.Size = new System.Drawing.Size(44, 20);
            this.discountProcentmyTextBox.TabIndex = 15;
            this.discountProcentmyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = true;
            this.myLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel8.ForeColor = System.Drawing.Color.White;
            this.myLabel8.Location = new System.Drawing.Point(19, 220);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(114, 13);
            this.myLabel8.TabIndex = 24;
            this.myLabel8.Text = "Discount Client (%)";
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Client sters!";
            this.FirstFocusControl = this.clientNamemyTextBox;
            this.LastFocusControl = this.isActivemyCheckBox;
            this.Name = "ClientsControl";
            this.ObjectName = "Client";
            this.SaveMessage = "Client salvat!";
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
            ((System.ComponentModel.ISupportInitialize)(this.clientsMyDataGridViewRO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myDataGridViewRO clientsMyDataGridViewRO;
        private MyControls.WindowsControls.myCheckBox isActivemyCheckBox;
        private MyControls.WindowsControls.myTextBox bankAccountmyTextBox;
        private MyControls.WindowsControls.myTextBox bankmyTextBox;
        private MyControls.WindowsControls.myTextBox phonemyTextBox;
        private MyControls.WindowsControls.myTextBox addressmyTextBox;
        private MyControls.WindowsControls.myTextBox tradeCodemyTextBox;
        private MyControls.WindowsControls.myTextBox fiscalCodemyTextBox;
        private MyControls.WindowsControls.myTextBox clientNamemyTextBox;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel7;
        private MyControls.WindowsControls.myLabel myLabel6;
        private MyControls.WindowsControls.myLabel myLabel5;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel8;
        private MyControls.WindowsControls.myTextBox discountProcentmyTextBox;
    }
}
