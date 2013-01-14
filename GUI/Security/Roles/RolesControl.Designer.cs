namespace GUI.Security.Roles
{
    partial class RolesControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rolesAccessRightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.roleDetailsPanel = new System.Windows.Forms.Panel();
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.descriptionmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.roleNamemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.rolesAccessRightsPanel = new System.Windows.Forms.Panel();
            this.rolesAccessRightsMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.accessRightidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridAccessRightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hasNewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasEditDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasDeleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.rolesAccessRightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesMyDataGridViewRO)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.roleDetailsPanel.SuspendLayout();
            this.rolesAccessRightsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesAccessRightsMyDataGridViewRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessRightsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Security.Role);
            // 
            // detailsPannel
            // 
            this.detailsPannel.Controls.Add(this.tableLayoutPanel);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.rolesMyDataGridViewRO);
            // 
            // rolesAccessRightsBindingSource
            // 
            this.rolesAccessRightsBindingSource.DataMember = "Roles_Access_Rights";
            this.rolesAccessRightsBindingSource.DataSource = this.baseBindingSource;
            // 
            // rolesMyDataGridViewRO
            // 
            this.rolesMyDataGridViewRO.AllowUserToAddRows = false;
            this.rolesMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.rolesMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.rolesMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.rolesMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.rolesMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleNameDataGridViewTextBoxColumn});
            this.rolesMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rolesMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle7;
            this.rolesMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesMyDataGridViewRO.EditableGrid = false;
            this.rolesMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.rolesMyDataGridViewRO.MultiSelect = false;
            this.rolesMyDataGridViewRO.Name = "rolesMyDataGridViewRO";
            this.rolesMyDataGridViewRO.ReadOnly = true;
            this.rolesMyDataGridViewRO.RowHeadersVisible = false;
            this.rolesMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rolesMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesMyDataGridViewRO.Size = new System.Drawing.Size(228, 303);
            this.rolesMyDataGridViewRO.TabIndex = 0;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.roleDetailsPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.rolesAccessRightsPanel, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(370, 397);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // roleDetailsPanel
            // 
            this.roleDetailsPanel.Controls.Add(this.myLabel2);
            this.roleDetailsPanel.Controls.Add(this.myLabel1);
            this.roleDetailsPanel.Controls.Add(this.descriptionmyTextBox);
            this.roleDetailsPanel.Controls.Add(this.roleNamemyTextBox);
            this.roleDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleDetailsPanel.Location = new System.Drawing.Point(3, 3);
            this.roleDetailsPanel.Name = "roleDetailsPanel";
            this.roleDetailsPanel.Size = new System.Drawing.Size(364, 84);
            this.roleDetailsPanel.TabIndex = 0;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(13, 33);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(43, 13);
            this.myLabel2.TabIndex = 5;
            this.myLabel2.Text = "Detalii";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(30, 6);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(26, 13);
            this.myLabel1.TabIndex = 4;
            this.myLabel1.Text = "Rol";
            // 
            // descriptionmyTextBox
            // 
            this.descriptionmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.descriptionmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Description", true));
            this.descriptionmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionmyTextBox.Location = new System.Drawing.Point(62, 26);
            this.descriptionmyTextBox.Multiline = true;
            this.descriptionmyTextBox.Name = "descriptionmyTextBox";
            this.descriptionmyTextBox.Size = new System.Drawing.Size(285, 46);
            this.descriptionmyTextBox.TabIndex = 3;
            // 
            // roleNamemyTextBox
            // 
            this.roleNamemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roleNamemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "RoleName", true));
            this.roleNamemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.roleNamemyTextBox.Location = new System.Drawing.Point(63, 3);
            this.roleNamemyTextBox.Name = "roleNamemyTextBox";
            this.roleNamemyTextBox.Size = new System.Drawing.Size(284, 20);
            this.roleNamemyTextBox.TabIndex = 1;
            // 
            // rolesAccessRightsPanel
            // 
            this.rolesAccessRightsPanel.Controls.Add(this.rolesAccessRightsMyDataGridViewRO);
            this.rolesAccessRightsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesAccessRightsPanel.Location = new System.Drawing.Point(3, 93);
            this.rolesAccessRightsPanel.Name = "rolesAccessRightsPanel";
            this.rolesAccessRightsPanel.Size = new System.Drawing.Size(364, 301);
            this.rolesAccessRightsPanel.TabIndex = 1;
            // 
            // rolesAccessRightsMyDataGridViewRO
            // 
            this.rolesAccessRightsMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.rolesAccessRightsMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rolesAccessRightsMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesAccessRightsMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rolesAccessRightsMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesAccessRightsMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accessRightidDataGridViewTextBoxColumn,
            this.hasNewDataGridViewCheckBoxColumn,
            this.hasEditDataGridViewCheckBoxColumn,
            this.hasDeleteDataGridViewCheckBoxColumn});
            this.rolesAccessRightsMyDataGridViewRO.DataSource = this.rolesAccessRightsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rolesAccessRightsMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle3;
            this.rolesAccessRightsMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesAccessRightsMyDataGridViewRO.EditableGrid = true;
            this.rolesAccessRightsMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.rolesAccessRightsMyDataGridViewRO.MultiSelect = false;
            this.rolesAccessRightsMyDataGridViewRO.Name = "rolesAccessRightsMyDataGridViewRO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesAccessRightsMyDataGridViewRO.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.rolesAccessRightsMyDataGridViewRO.RowHeadersVisible = false;
            this.rolesAccessRightsMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rolesAccessRightsMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesAccessRightsMyDataGridViewRO.Size = new System.Drawing.Size(364, 301);
            this.rolesAccessRightsMyDataGridViewRO.TabIndex = 0;
            this.rolesAccessRightsMyDataGridViewRO.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesAccessRightsMyDataGridViewRO_CellValueChanged);
            this.rolesAccessRightsMyDataGridViewRO.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.rolesAccessRightsMyDataGridViewRO_DataError);
            this.rolesAccessRightsMyDataGridViewRO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rolesAccessRightsMyDataGridViewRO_KeyDown);
            // 
            // accessRightidDataGridViewTextBoxColumn
            // 
            this.accessRightidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accessRightidDataGridViewTextBoxColumn.DataPropertyName = "Access_Right_id";
            this.accessRightidDataGridViewTextBoxColumn.DataSource = this.dataGridAccessRightsBindingSource;
            this.accessRightidDataGridViewTextBoxColumn.DisplayMember = "Description";
            this.accessRightidDataGridViewTextBoxColumn.HeaderText = "Modul";
            this.accessRightidDataGridViewTextBoxColumn.Name = "accessRightidDataGridViewTextBoxColumn";
            this.accessRightidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accessRightidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accessRightidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // dataGridAccessRightsBindingSource
            // 
            this.dataGridAccessRightsBindingSource.DataSource = typeof(DAL.Models.Security.Access_Right);
            // 
            // hasNewDataGridViewCheckBoxColumn
            // 
            this.hasNewDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hasNewDataGridViewCheckBoxColumn.DataPropertyName = "HasNew";
            this.hasNewDataGridViewCheckBoxColumn.HeaderText = "Adaugare";
            this.hasNewDataGridViewCheckBoxColumn.Name = "hasNewDataGridViewCheckBoxColumn";
            this.hasNewDataGridViewCheckBoxColumn.Width = 67;
            // 
            // hasEditDataGridViewCheckBoxColumn
            // 
            this.hasEditDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hasEditDataGridViewCheckBoxColumn.DataPropertyName = "HasEdit";
            this.hasEditDataGridViewCheckBoxColumn.HeaderText = "Editare";
            this.hasEditDataGridViewCheckBoxColumn.Name = "hasEditDataGridViewCheckBoxColumn";
            this.hasEditDataGridViewCheckBoxColumn.Width = 53;
            // 
            // hasDeleteDataGridViewCheckBoxColumn
            // 
            this.hasDeleteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hasDeleteDataGridViewCheckBoxColumn.DataPropertyName = "HasDelete";
            this.hasDeleteDataGridViewCheckBoxColumn.HeaderText = "Stergere";
            this.hasDeleteDataGridViewCheckBoxColumn.Name = "hasDeleteDataGridViewCheckBoxColumn";
            this.hasDeleteDataGridViewCheckBoxColumn.Width = 61;
            // 
            // RolesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Rol sters!";
            this.FirstFocusControl = this.roleNamemyTextBox;
            this.LastFocusControl = this.descriptionmyTextBox;
            this.Name = "RolesControl";
            this.ObjectName = "Rol";
            this.SaveMessage = "Rol salvat!";
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.baseGroupBox.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.saveCancelPannel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.detailsPannel.ResumeLayout(false);
            this.listPannel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            this.detailsParentPanel.ResumeLayout(false);
            this.detailsGroupBox.ResumeLayout(false);
            this.listContainerPanel.ResumeLayout(false);
            this.listGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesAccessRightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesMyDataGridViewRO)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.roleDetailsPanel.ResumeLayout(false);
            this.roleDetailsPanel.PerformLayout();
            this.rolesAccessRightsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesAccessRightsMyDataGridViewRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessRightsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource rolesAccessRightsBindingSource;
        private MyControls.WindowsControls.myDataGridViewRO rolesMyDataGridViewRO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel roleDetailsPanel;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myTextBox descriptionmyTextBox;
        private MyControls.WindowsControls.myTextBox roleNamemyTextBox;
        private System.Windows.Forms.Panel rolesAccessRightsPanel;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myDataGridViewRO rolesAccessRightsMyDataGridViewRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn accessRightidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataGridAccessRightsBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasNewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasEditDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasDeleteDataGridViewCheckBoxColumn;
    }
}
