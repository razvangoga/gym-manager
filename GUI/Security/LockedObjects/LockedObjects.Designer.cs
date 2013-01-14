namespace GUI.Security.LockedObjects
{
    partial class LockedObjects
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

        #region Windows Form Designer generated code

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lockedObjectsMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.lockedObjectsMyDataGridViewRO)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Views.Security.Locked_Objects_View);
            // 
            // detailsPannel
            // 
            this.detailsPannel.Controls.Add(this.lockedObjectsMyDataGridViewRO);
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
            // lockedObjectsMyDataGridViewRO
            // 
            this.lockedObjectsMyDataGridViewRO.AllowUserToAddRows = false;
            this.lockedObjectsMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.lockedObjectsMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.lockedObjectsMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lockedObjectsMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lockedObjectsMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lockedObjectsMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lockedObjectsMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.pkIdDataGridViewTextBoxColumn,
            this.lockDateDataGridViewTextBoxColumn});
            this.lockedObjectsMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lockedObjectsMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle3;
            this.lockedObjectsMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lockedObjectsMyDataGridViewRO.EditableGrid = false;
            this.lockedObjectsMyDataGridViewRO.Location = new System.Drawing.Point(3, 3);
            this.lockedObjectsMyDataGridViewRO.MultiSelect = false;
            this.lockedObjectsMyDataGridViewRO.Name = "lockedObjectsMyDataGridViewRO";
            this.lockedObjectsMyDataGridViewRO.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lockedObjectsMyDataGridViewRO.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lockedObjectsMyDataGridViewRO.RowHeadersVisible = false;
            this.lockedObjectsMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lockedObjectsMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lockedObjectsMyDataGridViewRO.Size = new System.Drawing.Size(610, 397);
            this.lockedObjectsMyDataGridViewRO.TabIndex = 0;
            this.lockedObjectsMyDataGridViewRO.Tag = "Unlocked";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Modul Blocat";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "De Catre";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // pkIdDataGridViewTextBoxColumn
            // 
            this.pkIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pkIdDataGridViewTextBoxColumn.DataPropertyName = "Pk_Id";
            this.pkIdDataGridViewTextBoxColumn.HeaderText = "Cheie Unica";
            this.pkIdDataGridViewTextBoxColumn.Name = "pkIdDataGridViewTextBoxColumn";
            this.pkIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdDataGridViewTextBoxColumn.Width = 93;
            // 
            // lockDateDataGridViewTextBoxColumn
            // 
            this.lockDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lockDateDataGridViewTextBoxColumn.DataPropertyName = "LockDate";
            this.lockDateDataGridViewTextBoxColumn.HeaderText = "Blocat La";
            this.lockDateDataGridViewTextBoxColumn.Name = "lockDateDataGridViewTextBoxColumn";
            this.lockDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lockDateDataGridViewTextBoxColumn.Width = 79;
            // 
            // LockedObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.HasCustomDisplaySettings = true;
            this.Name = "LockedObjects";
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.baseGroupBox.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.saveCancelPannel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.detailsPannel.ResumeLayout(false);
            this.listPannel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.detailsParentPanel.ResumeLayout(false);
            this.detailsGroupBox.ResumeLayout(false);
            this.listContainerPanel.ResumeLayout(false);
            this.listGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lockedObjectsMyDataGridViewRO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myDataGridViewRO lockedObjectsMyDataGridViewRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn loPKIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loLockDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockDateDataGridViewTextBoxColumn;
    }
}
