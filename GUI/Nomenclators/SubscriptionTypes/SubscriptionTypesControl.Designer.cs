namespace GUI.Nomenclators.SubscriptionTypes
{
    partial class SubscriptionTypesControl
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
            this.subscriptionsMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.subscriptionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.subscriptionTypemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.descriptionmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.entryNumbermyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.hasUnilimitedEntriesmyCheckBox = new MyControls.WindowsControls.myCheckBox(this.components);
            this.pricemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.isActivemyCheckBox = new MyControls.WindowsControls.myCheckBox(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsMyDataGridViewRO)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Subscription_Type);
            // 
            // detailsPannel
            // 
            this.detailsPannel.Controls.Add(this.myLabel5);
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.isActivemyCheckBox);
            this.detailsPannel.Controls.Add(this.pricemyTextBox);
            this.detailsPannel.Controls.Add(this.hasUnilimitedEntriesmyCheckBox);
            this.detailsPannel.Controls.Add(this.entryNumbermyTextBox);
            this.detailsPannel.Controls.Add(this.descriptionmyTextBox);
            this.detailsPannel.Controls.Add(this.subscriptionTypemyTextBox);
            this.detailsPannel.Controls.Add(this.myLabel1);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.subscriptionsMyDataGridViewRO);
            // 
            // subscriptionsMyDataGridViewRO
            // 
            this.subscriptionsMyDataGridViewRO.AllowUserToAddRows = false;
            this.subscriptionsMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.subscriptionsMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.subscriptionsMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.subscriptionsMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subscriptionsMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.subscriptionsMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subscriptionsMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscriptionTypeDataGridViewTextBoxColumn});
            this.subscriptionsMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subscriptionsMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle3;
            this.subscriptionsMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subscriptionsMyDataGridViewRO.EditableGrid = false;
            this.subscriptionsMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.subscriptionsMyDataGridViewRO.MultiSelect = false;
            this.subscriptionsMyDataGridViewRO.Name = "subscriptionsMyDataGridViewRO";
            this.subscriptionsMyDataGridViewRO.ReadOnly = true;
            this.subscriptionsMyDataGridViewRO.RowHeadersVisible = false;
            this.subscriptionsMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.subscriptionsMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subscriptionsMyDataGridViewRO.Size = new System.Drawing.Size(228, 303);
            this.subscriptionsMyDataGridViewRO.TabIndex = 0;
            // 
            // subscriptionTypeDataGridViewTextBoxColumn
            // 
            this.subscriptionTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subscriptionTypeDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionType";
            this.subscriptionTypeDataGridViewTextBoxColumn.HeaderText = "Tip Abonament";
            this.subscriptionTypeDataGridViewTextBoxColumn.Name = "subscriptionTypeDataGridViewTextBoxColumn";
            this.subscriptionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(32, 23);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(92, 13);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Tip Abonament";
            // 
            // subscriptionTypemyTextBox
            // 
            this.subscriptionTypemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.subscriptionTypemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "SubscriptionType", true));
            this.subscriptionTypemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.subscriptionTypemyTextBox.Location = new System.Drawing.Point(130, 20);
            this.subscriptionTypemyTextBox.Name = "subscriptionTypemyTextBox";
            this.subscriptionTypemyTextBox.Size = new System.Drawing.Size(222, 20);
            this.subscriptionTypemyTextBox.TabIndex = 2;
            // 
            // descriptionmyTextBox
            // 
            this.descriptionmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.descriptionmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Description", true));
            this.descriptionmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionmyTextBox.Location = new System.Drawing.Point(130, 45);
            this.descriptionmyTextBox.Multiline = true;
            this.descriptionmyTextBox.Name = "descriptionmyTextBox";
            this.descriptionmyTextBox.Size = new System.Drawing.Size(222, 44);
            this.descriptionmyTextBox.TabIndex = 4;
            // 
            // entryNumbermyTextBox
            // 
            this.entryNumbermyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.entryNumbermyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "EntryNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.entryNumbermyTextBox.ForeColor = System.Drawing.Color.Black;
            this.entryNumbermyTextBox.Location = new System.Drawing.Point(303, 97);
            this.entryNumbermyTextBox.Name = "entryNumbermyTextBox";
            this.entryNumbermyTextBox.Size = new System.Drawing.Size(49, 20);
            this.entryNumbermyTextBox.TabIndex = 8;
            this.entryNumbermyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hasUnilimitedEntriesmyCheckBox
            // 
            this.hasUnilimitedEntriesmyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hasUnilimitedEntriesmyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.baseBindingSource, "HasUnilimitedEntries", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hasUnilimitedEntriesmyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasUnilimitedEntriesmyCheckBox.ForeColor = System.Drawing.Color.White;
            this.hasUnilimitedEntriesmyCheckBox.Location = new System.Drawing.Point(23, 95);
            this.hasUnilimitedEntriesmyCheckBox.Name = "hasUnilimitedEntriesmyCheckBox";
            this.hasUnilimitedEntriesmyCheckBox.ReadOnly = false;
            this.hasUnilimitedEntriesmyCheckBox.Size = new System.Drawing.Size(121, 24);
            this.hasUnilimitedEntriesmyCheckBox.TabIndex = 6;
            this.hasUnilimitedEntriesmyCheckBox.Text = "Intrari Nelimitate";
            this.hasUnilimitedEntriesmyCheckBox.UseVisualStyleBackColor = true;
            this.hasUnilimitedEntriesmyCheckBox.OnCheckChangedActions += new System.EventHandler(this.hasUnilimitedEntriesmyCheckBox_OnCheckChangedActions);
            // 
            // pricemyTextBox
            // 
            this.pricemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pricemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Price", true));
            this.pricemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.pricemyTextBox.Location = new System.Drawing.Point(130, 123);
            this.pricemyTextBox.Name = "pricemyTextBox";
            this.pricemyTextBox.Size = new System.Drawing.Size(58, 20);
            this.pricemyTextBox.TabIndex = 10;
            this.pricemyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // isActivemyCheckBox
            // 
            this.isActivemyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActivemyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.baseBindingSource, "IsActive", true));
            this.isActivemyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActivemyCheckBox.ForeColor = System.Drawing.Color.White;
            this.isActivemyCheckBox.Location = new System.Drawing.Point(83, 149);
            this.isActivemyCheckBox.Name = "isActivemyCheckBox";
            this.isActivemyCheckBox.ReadOnly = false;
            this.isActivemyCheckBox.Size = new System.Drawing.Size(61, 24);
            this.isActivemyCheckBox.TabIndex = 12;
            this.isActivemyCheckBox.Text = "Activ";
            this.isActivemyCheckBox.UseVisualStyleBackColor = true;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(63, 48);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(61, 13);
            this.myLabel2.TabIndex = 13;
            this.myLabel2.Text = "Descriere";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(223, 100);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(61, 13);
            this.myLabel3.TabIndex = 14;
            this.myLabel3.Text = "Nr. Intrari";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(94, 126);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(30, 13);
            this.myLabel4.TabIndex = 15;
            this.myLabel4.Text = "Pret";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(194, 126);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(42, 13);
            this.myLabel5.TabIndex = 16;
            this.myLabel5.Text = "(RON)";
            // 
            // SubscriptionTypesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Tip abonament sters!";
            this.FirstFocusControl = this.subscriptionTypemyTextBox;
            this.LastFocusControl = this.isActivemyCheckBox;
            this.Name = "SubscriptionTypesControl";
            this.ObjectName = "Tip abonament";
            this.SaveMessage = "Tip abonament salvat!";
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
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsMyDataGridViewRO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myDataGridViewRO subscriptionsMyDataGridViewRO;
        private MyControls.WindowsControls.myLabel myLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionTypeDataGridViewTextBoxColumn;
        private MyControls.WindowsControls.myCheckBox isActivemyCheckBox;
        private MyControls.WindowsControls.myTextBox pricemyTextBox;
        private MyControls.WindowsControls.myCheckBox hasUnilimitedEntriesmyCheckBox;
        private MyControls.WindowsControls.myTextBox entryNumbermyTextBox;
        private MyControls.WindowsControls.myTextBox descriptionmyTextBox;
        private MyControls.WindowsControls.myTextBox subscriptionTypemyTextBox;
        private MyControls.WindowsControls.myLabel myLabel5;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel2;
    }
}
