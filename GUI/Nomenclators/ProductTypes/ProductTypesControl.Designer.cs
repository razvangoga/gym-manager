namespace GUI.Nomenclators.ProductTypes
{
    partial class ProductTypesControl
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
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.productTypesMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.productTypemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.isActivemyCheckBox = new MyControls.WindowsControls.myCheckBox(this.components);
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.productTypesMyDataGridViewRO)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Nomenclators.Product_Type);
            // 
            // detailsPannel
            // 
            this.detailsPannel.Controls.Add(this.isActivemyCheckBox);
            this.detailsPannel.Controls.Add(this.productTypemyTextBox);
            this.detailsPannel.Controls.Add(this.myLabel1);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.productTypesMyDataGridViewRO);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(15, 27);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(104, 13);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Categorie Produs";
            // 
            // productTypesMyDataGridViewRO
            // 
            this.productTypesMyDataGridViewRO.AllowUserToAddRows = false;
            this.productTypesMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.productTypesMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.productTypesMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.productTypesMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTypesMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.productTypesMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTypesMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productTypeDataGridViewTextBoxColumn});
            this.productTypesMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productTypesMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle6;
            this.productTypesMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTypesMyDataGridViewRO.EditableGrid = false;
            this.productTypesMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.productTypesMyDataGridViewRO.MultiSelect = false;
            this.productTypesMyDataGridViewRO.Name = "productTypesMyDataGridViewRO";
            this.productTypesMyDataGridViewRO.ReadOnly = true;
            this.productTypesMyDataGridViewRO.RowHeadersVisible = false;
            this.productTypesMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productTypesMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTypesMyDataGridViewRO.Size = new System.Drawing.Size(228, 303);
            this.productTypesMyDataGridViewRO.TabIndex = 0;
            // 
            // productTypemyTextBox
            // 
            this.productTypemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.productTypemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "ProductType", true));
            this.productTypemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.productTypemyTextBox.Location = new System.Drawing.Point(125, 24);
            this.productTypemyTextBox.Name = "productTypemyTextBox";
            this.productTypemyTextBox.Size = new System.Drawing.Size(217, 20);
            this.productTypemyTextBox.TabIndex = 2;
            // 
            // isActivemyCheckBox
            // 
            this.isActivemyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActivemyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.baseBindingSource, "IsActive", true));
            this.isActivemyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActivemyCheckBox.ForeColor = System.Drawing.Color.White;
            this.isActivemyCheckBox.Location = new System.Drawing.Point(79, 47);
            this.isActivemyCheckBox.Name = "isActivemyCheckBox";
            this.isActivemyCheckBox.ReadOnly = false;
            this.isActivemyCheckBox.Size = new System.Drawing.Size(59, 24);
            this.isActivemyCheckBox.TabIndex = 4;
            this.isActivemyCheckBox.Text = "Activ";
            this.isActivemyCheckBox.UseVisualStyleBackColor = true;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "Categorie Produs";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductTypesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Categorie produs stearsa!";
            this.FirstFocusControl = this.productTypemyTextBox;
            this.LastFocusControl = this.isActivemyCheckBox;
            this.Name = "ProductTypesControl";
            this.ObjectName = "Categorie produs";
            this.SaveMessage = "Categorie produs salvata!";
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
            ((System.ComponentModel.ISupportInitialize)(this.productTypesMyDataGridViewRO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myDataGridViewRO productTypesMyDataGridViewRO;
        private MyControls.WindowsControls.myCheckBox isActivemyCheckBox;
        private MyControls.WindowsControls.myTextBox productTypemyTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
    }
}
