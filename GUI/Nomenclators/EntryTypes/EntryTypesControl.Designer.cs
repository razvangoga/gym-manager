namespace GUI.Nomenclators.EntryTypes
{
    partial class EntryTypesControl
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
            this.entryTypesMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.entryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTypemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.descriptionmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.pricemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.isActivemyCheckBox = new MyControls.WindowsControls.myCheckBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.entryTypesMyDataGridViewRO)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Entry_Type);
            // 
            // detailsPannel
            // 
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.myLabel1);
            this.detailsPannel.Controls.Add(this.isActivemyCheckBox);
            this.detailsPannel.Controls.Add(this.pricemyTextBox);
            this.detailsPannel.Controls.Add(this.descriptionmyTextBox);
            this.detailsPannel.Controls.Add(this.entryTypemyTextBox);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.entryTypesMyDataGridViewRO);
            // 
            // entryTypesMyDataGridViewRO
            // 
            this.entryTypesMyDataGridViewRO.AllowUserToAddRows = false;
            this.entryTypesMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.entryTypesMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.entryTypesMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.entryTypesMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.entryTypesMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.entryTypesMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entryTypesMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryTypeDataGridViewTextBoxColumn});
            this.entryTypesMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.entryTypesMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle3;
            this.entryTypesMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryTypesMyDataGridViewRO.EditableGrid = false;
            this.entryTypesMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.entryTypesMyDataGridViewRO.MultiSelect = false;
            this.entryTypesMyDataGridViewRO.Name = "entryTypesMyDataGridViewRO";
            this.entryTypesMyDataGridViewRO.ReadOnly = true;
            this.entryTypesMyDataGridViewRO.RowHeadersVisible = false;
            this.entryTypesMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.entryTypesMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entryTypesMyDataGridViewRO.Size = new System.Drawing.Size(228, 303);
            this.entryTypesMyDataGridViewRO.TabIndex = 0;
            // 
            // entryTypeDataGridViewTextBoxColumn
            // 
            this.entryTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.entryTypeDataGridViewTextBoxColumn.DataPropertyName = "EntryType";
            this.entryTypeDataGridViewTextBoxColumn.HeaderText = "Tip Intrare";
            this.entryTypeDataGridViewTextBoxColumn.Name = "entryTypeDataGridViewTextBoxColumn";
            this.entryTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryTypemyTextBox
            // 
            this.entryTypemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.entryTypemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "EntryType", true));
            this.entryTypemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.entryTypemyTextBox.Location = new System.Drawing.Point(93, 21);
            this.entryTypemyTextBox.Name = "entryTypemyTextBox";
            this.entryTypemyTextBox.Size = new System.Drawing.Size(241, 20);
            this.entryTypemyTextBox.TabIndex = 1;
            // 
            // descriptionmyTextBox
            // 
            this.descriptionmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.descriptionmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Description", true));
            this.descriptionmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionmyTextBox.Location = new System.Drawing.Point(93, 44);
            this.descriptionmyTextBox.Multiline = true;
            this.descriptionmyTextBox.Name = "descriptionmyTextBox";
            this.descriptionmyTextBox.Size = new System.Drawing.Size(241, 38);
            this.descriptionmyTextBox.TabIndex = 3;
            // 
            // pricemyTextBox
            // 
            this.pricemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pricemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.pricemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.pricemyTextBox.Location = new System.Drawing.Point(93, 85);
            this.pricemyTextBox.Name = "pricemyTextBox";
            this.pricemyTextBox.Size = new System.Drawing.Size(58, 20);
            this.pricemyTextBox.TabIndex = 5;
            this.pricemyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // isActivemyCheckBox
            // 
            this.isActivemyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActivemyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.baseBindingSource, "IsActive", true));
            this.isActivemyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActivemyCheckBox.ForeColor = System.Drawing.Color.White;
            this.isActivemyCheckBox.Location = new System.Drawing.Point(47, 108);
            this.isActivemyCheckBox.Name = "isActivemyCheckBox";
            this.isActivemyCheckBox.ReadOnly = false;
            this.isActivemyCheckBox.Size = new System.Drawing.Size(65, 24);
            this.isActivemyCheckBox.TabIndex = 7;
            this.isActivemyCheckBox.Text = "Activ";
            this.isActivemyCheckBox.UseVisualStyleBackColor = true;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(21, 24);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(66, 13);
            this.myLabel1.TabIndex = 8;
            this.myLabel1.Text = "Tip Intrare";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(26, 47);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(61, 13);
            this.myLabel2.TabIndex = 9;
            this.myLabel2.Text = "Descriere";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(51, 88);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(36, 13);
            this.myLabel3.TabIndex = 10;
            this.myLabel3.Text = "Price";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(157, 88);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(42, 13);
            this.myLabel4.TabIndex = 11;
            this.myLabel4.Text = "(RON)";
            // 
            // EntryTypesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Tip Intrare sters!";
            this.FirstFocusControl = this.entryTypemyTextBox;
            this.LastFocusControl = this.isActivemyCheckBox;
            this.Name = "EntryTypesControl";
            this.ObjectName = "Tip Intrare";
            this.SaveMessage = "Tip Intrare salvat!";
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
            ((System.ComponentModel.ISupportInitialize)(this.entryTypesMyDataGridViewRO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myDataGridViewRO entryTypesMyDataGridViewRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTypeDataGridViewTextBoxColumn;
        private MyControls.WindowsControls.myCheckBox isActivemyCheckBox;
        private MyControls.WindowsControls.myTextBox pricemyTextBox;
        private MyControls.WindowsControls.myTextBox descriptionmyTextBox;
        private MyControls.WindowsControls.myTextBox entryTypemyTextBox;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myLabel myLabel4;
    }
}
