namespace GUI.Nomenclators.OrganizationDetails
{
    partial class OrganizationDetailsControl
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
            this.organizationNamemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.fiscalCodemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.tradeCodemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.addressmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.phonemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.bankmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.bankAccountmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel6 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel7 = new MyControls.WindowsControls.myLabel(this.components);
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
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Organization_Detail);
            // 
            // detailsPannel
            // 
            this.detailsPannel.Controls.Add(this.myLabel7);
            this.detailsPannel.Controls.Add(this.myLabel6);
            this.detailsPannel.Controls.Add(this.myLabel5);
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.myLabel1);
            this.detailsPannel.Controls.Add(this.bankAccountmyTextBox);
            this.detailsPannel.Controls.Add(this.bankmyTextBox);
            this.detailsPannel.Controls.Add(this.phonemyTextBox);
            this.detailsPannel.Controls.Add(this.addressmyTextBox);
            this.detailsPannel.Controls.Add(this.tradeCodemyTextBox);
            this.detailsPannel.Controls.Add(this.fiscalCodemyTextBox);
            this.detailsPannel.Controls.Add(this.organizationNamemyTextBox);
            this.detailsPannel.Size = new System.Drawing.Size(616, 403);
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
            // filtersGroupBox
            // 
            this.filtersGroupBox.Size = new System.Drawing.Size(0, 94);
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
            this.listContainerPanel.Size = new System.Drawing.Size(0, 328);
            // 
            // listGroupBox
            // 
            this.listGroupBox.Size = new System.Drawing.Size(0, 322);
            // 
            // organizationNamemyTextBox
            // 
            this.organizationNamemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.organizationNamemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "OrganizationName", true));
            this.organizationNamemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.organizationNamemyTextBox.Location = new System.Drawing.Point(232, 22);
            this.organizationNamemyTextBox.Name = "organizationNamemyTextBox";
            this.organizationNamemyTextBox.Size = new System.Drawing.Size(261, 20);
            this.organizationNamemyTextBox.TabIndex = 1;
            // 
            // fiscalCodemyTextBox
            // 
            this.fiscalCodemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fiscalCodemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "FiscalCode", true));
            this.fiscalCodemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.fiscalCodemyTextBox.Location = new System.Drawing.Point(232, 48);
            this.fiscalCodemyTextBox.Name = "fiscalCodemyTextBox";
            this.fiscalCodemyTextBox.Size = new System.Drawing.Size(129, 20);
            this.fiscalCodemyTextBox.TabIndex = 3;
            // 
            // tradeCodemyTextBox
            // 
            this.tradeCodemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tradeCodemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "TradeCode", true));
            this.tradeCodemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.tradeCodemyTextBox.Location = new System.Drawing.Point(232, 74);
            this.tradeCodemyTextBox.Name = "tradeCodemyTextBox";
            this.tradeCodemyTextBox.Size = new System.Drawing.Size(129, 20);
            this.tradeCodemyTextBox.TabIndex = 5;
            // 
            // addressmyTextBox
            // 
            this.addressmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addressmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Address", true));
            this.addressmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressmyTextBox.Location = new System.Drawing.Point(232, 100);
            this.addressmyTextBox.Multiline = true;
            this.addressmyTextBox.Name = "addressmyTextBox";
            this.addressmyTextBox.Size = new System.Drawing.Size(261, 43);
            this.addressmyTextBox.TabIndex = 7;
            // 
            // phonemyTextBox
            // 
            this.phonemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.phonemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Phone", true));
            this.phonemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.phonemyTextBox.Location = new System.Drawing.Point(232, 149);
            this.phonemyTextBox.Name = "phonemyTextBox";
            this.phonemyTextBox.Size = new System.Drawing.Size(129, 20);
            this.phonemyTextBox.TabIndex = 9;
            // 
            // bankmyTextBox
            // 
            this.bankmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bankmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Bank", true));
            this.bankmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.bankmyTextBox.Location = new System.Drawing.Point(232, 175);
            this.bankmyTextBox.Name = "bankmyTextBox";
            this.bankmyTextBox.Size = new System.Drawing.Size(261, 20);
            this.bankmyTextBox.TabIndex = 11;
            // 
            // bankAccountmyTextBox
            // 
            this.bankAccountmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bankAccountmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "BankAccount", true));
            this.bankAccountmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.bankAccountmyTextBox.Location = new System.Drawing.Point(232, 201);
            this.bankAccountmyTextBox.Name = "bankAccountmyTextBox";
            this.bankAccountmyTextBox.Size = new System.Drawing.Size(261, 20);
            this.bankAccountmyTextBox.TabIndex = 13;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(119, 25);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(105, 13);
            this.myLabel1.TabIndex = 14;
            this.myLabel1.Text = "Nume organizatie";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(161, 51);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(63, 13);
            this.myLabel2.TabIndex = 15;
            this.myLabel2.Text = "Cod fiscal";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(106, 77);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(118, 13);
            this.myLabel3.TabIndex = 16;
            this.myLabel3.Text = "Nr. Reg. Comertului";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(178, 103);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(46, 13);
            this.myLabel4.TabIndex = 17;
            this.myLabel4.Text = "Adresa";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(178, 152);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(50, 13);
            this.myLabel5.TabIndex = 18;
            this.myLabel5.Text = "Telefon";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.White;
            this.myLabel6.Location = new System.Drawing.Point(185, 178);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(43, 13);
            this.myLabel6.TabIndex = 19;
            this.myLabel6.Text = "Banca";
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.White;
            this.myLabel7.Location = new System.Drawing.Point(148, 204);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(76, 13);
            this.myLabel7.TabIndex = 20;
            this.myLabel7.Text = "Cont bancar";
            // 
            // OrganizationDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Detalii Organizatie sterse!";
            this.FirstFocusControl = this.organizationNamemyTextBox;
            this.HasCustomDisplaySettings = true;
            this.LastFocusControl = this.bankAccountmyTextBox;
            this.Name = "OrganizationDetailsControl";
            this.ObjectName = "Detalii Organizatie";
            this.SaveMessage = "Detalii Organizatie salvate!";
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
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myTextBox fiscalCodemyTextBox;
        private MyControls.WindowsControls.myTextBox organizationNamemyTextBox;
        private MyControls.WindowsControls.myLabel myLabel7;
        private MyControls.WindowsControls.myLabel myLabel6;
        private MyControls.WindowsControls.myLabel myLabel5;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myTextBox bankAccountmyTextBox;
        private MyControls.WindowsControls.myTextBox bankmyTextBox;
        private MyControls.WindowsControls.myTextBox phonemyTextBox;
        private MyControls.WindowsControls.myTextBox addressmyTextBox;
        private MyControls.WindowsControls.myTextBox tradeCodemyTextBox;
    }
}
