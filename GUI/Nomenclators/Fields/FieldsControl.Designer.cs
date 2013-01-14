namespace GUI.Nomenclators.Fields
{
    partial class FieldsControl
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
            this.fieldsMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.fieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldNamemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.descriptionmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.minimumRentHoursmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.pricemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.isActivemyCheckBox = new MyControls.WindowsControls.myCheckBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel6 = new MyControls.WindowsControls.myLabel(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.fieldsMyDataGridViewRO)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Field);
            // 
            // detailsPannel
            // 
            this.detailsPannel.Controls.Add(this.myLabel6);
            this.detailsPannel.Controls.Add(this.myLabel5);
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.myLabel1);
            this.detailsPannel.Controls.Add(this.isActivemyCheckBox);
            this.detailsPannel.Controls.Add(this.pricemyTextBox);
            this.detailsPannel.Controls.Add(this.minimumRentHoursmyTextBox);
            this.detailsPannel.Controls.Add(this.descriptionmyTextBox);
            this.detailsPannel.Controls.Add(this.fieldNamemyTextBox);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.fieldsMyDataGridViewRO);
            // 
            // fieldsMyDataGridViewRO
            // 
            this.fieldsMyDataGridViewRO.AllowUserToAddRows = false;
            this.fieldsMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.fieldsMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.fieldsMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fieldsMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fieldsMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fieldsMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldsMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldNameDataGridViewTextBoxColumn});
            this.fieldsMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fieldsMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle3;
            this.fieldsMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsMyDataGridViewRO.EditableGrid = false;
            this.fieldsMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.fieldsMyDataGridViewRO.MultiSelect = false;
            this.fieldsMyDataGridViewRO.Name = "fieldsMyDataGridViewRO";
            this.fieldsMyDataGridViewRO.ReadOnly = true;
            this.fieldsMyDataGridViewRO.RowHeadersVisible = false;
            this.fieldsMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fieldsMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fieldsMyDataGridViewRO.Size = new System.Drawing.Size(228, 303);
            this.fieldsMyDataGridViewRO.TabIndex = 0;
            // 
            // fieldNameDataGridViewTextBoxColumn
            // 
            this.fieldNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fieldNameDataGridViewTextBoxColumn.DataPropertyName = "FieldName";
            this.fieldNameDataGridViewTextBoxColumn.HeaderText = "Terenuri";
            this.fieldNameDataGridViewTextBoxColumn.Name = "fieldNameDataGridViewTextBoxColumn";
            this.fieldNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fieldNamemyTextBox
            // 
            this.fieldNamemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fieldNamemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "FieldName", true));
            this.fieldNamemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.fieldNamemyTextBox.Location = new System.Drawing.Point(136, 25);
            this.fieldNamemyTextBox.Name = "fieldNamemyTextBox";
            this.fieldNamemyTextBox.Size = new System.Drawing.Size(222, 20);
            this.fieldNamemyTextBox.TabIndex = 1;
            // 
            // descriptionmyTextBox
            // 
            this.descriptionmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.descriptionmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Description", true));
            this.descriptionmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionmyTextBox.Location = new System.Drawing.Point(136, 50);
            this.descriptionmyTextBox.Multiline = true;
            this.descriptionmyTextBox.Name = "descriptionmyTextBox";
            this.descriptionmyTextBox.Size = new System.Drawing.Size(222, 46);
            this.descriptionmyTextBox.TabIndex = 3;
            // 
            // minimumRentHoursmyTextBox
            // 
            this.minimumRentHoursmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.minimumRentHoursmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "MinimumRentHours", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.minimumRentHoursmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.minimumRentHoursmyTextBox.Location = new System.Drawing.Point(136, 100);
            this.minimumRentHoursmyTextBox.Name = "minimumRentHoursmyTextBox";
            this.minimumRentHoursmyTextBox.Size = new System.Drawing.Size(61, 20);
            this.minimumRentHoursmyTextBox.TabIndex = 5;
            this.minimumRentHoursmyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pricemyTextBox
            // 
            this.pricemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pricemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.pricemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.pricemyTextBox.Location = new System.Drawing.Point(136, 126);
            this.pricemyTextBox.Name = "pricemyTextBox";
            this.pricemyTextBox.Size = new System.Drawing.Size(61, 20);
            this.pricemyTextBox.TabIndex = 7;
            this.pricemyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // isActivemyCheckBox
            // 
            this.isActivemyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActivemyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.baseBindingSource, "IsActive", true));
            this.isActivemyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActivemyCheckBox.ForeColor = System.Drawing.Color.White;
            this.isActivemyCheckBox.Location = new System.Drawing.Point(93, 151);
            this.isActivemyCheckBox.Name = "isActivemyCheckBox";
            this.isActivemyCheckBox.ReadOnly = false;
            this.isActivemyCheckBox.Size = new System.Drawing.Size(60, 24);
            this.isActivemyCheckBox.TabIndex = 9;
            this.isActivemyCheckBox.Text = "Activ";
            this.isActivemyCheckBox.UseVisualStyleBackColor = true;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(90, 28);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(40, 13);
            this.myLabel1.TabIndex = 10;
            this.myLabel1.Text = "Teren";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(69, 53);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(61, 13);
            this.myLabel2.TabIndex = 11;
            this.myLabel2.Text = "Descriere";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(28, 103);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(102, 13);
            this.myLabel3.TabIndex = 12;
            this.myLabel3.Text = "Inchiriere minima";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(100, 129);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(30, 13);
            this.myLabel4.TabIndex = 13;
            this.myLabel4.Text = "Pret";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(203, 103);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(33, 13);
            this.myLabel5.TabIndex = 14;
            this.myLabel5.Text = "(ore)";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.White;
            this.myLabel6.Location = new System.Drawing.Point(203, 129);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(42, 13);
            this.myLabel6.TabIndex = 15;
            this.myLabel6.Text = "(RON)";
            // 
            // FieldsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Teren sters!";
            this.FirstFocusControl = this.fieldNamemyTextBox;
            this.LastFocusControl = this.isActivemyCheckBox;
            this.Name = "FieldsControl";
            this.ObjectName = "Teren";
            this.SaveMessage = "Teren salvat!";
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
            ((System.ComponentModel.ISupportInitialize)(this.fieldsMyDataGridViewRO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myDataGridViewRO fieldsMyDataGridViewRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
        private MyControls.WindowsControls.myLabel myLabel6;
        private MyControls.WindowsControls.myLabel myLabel5;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myCheckBox isActivemyCheckBox;
        private MyControls.WindowsControls.myTextBox pricemyTextBox;
        private MyControls.WindowsControls.myTextBox minimumRentHoursmyTextBox;
        private MyControls.WindowsControls.myTextBox descriptionmyTextBox;
        private MyControls.WindowsControls.myTextBox fieldNamemyTextBox;
    }
}
