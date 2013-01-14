namespace GUI.Security.Users
{
    partial class UsersControl
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
            this.usersMyDataGridViewRO = new MyControls.WindowsControls.myDataGridViewRO(this.components);
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNamemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.isActivemyCheckBox = new MyControls.WindowsControls.myCheckBox(this.components);
            this.lastNamemyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.loginmyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.rolesMyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
            this.passMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.myLabel6 = new MyControls.WindowsControls.myLabel(this.components);
            this.rePassMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.usersMyDataGridViewRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = typeof(DAL.Models.Security.User);
            // 
            // detailsPannel
            // 
            this.detailsPannel.AutoScroll = true;
            this.detailsPannel.Controls.Add(this.rePassMyTextBox);
            this.detailsPannel.Controls.Add(this.myLabel6);
            this.detailsPannel.Controls.Add(this.passMyTextBox);
            this.detailsPannel.Controls.Add(this.myLabel5);
            this.detailsPannel.Controls.Add(this.myLabel4);
            this.detailsPannel.Controls.Add(this.myLabel3);
            this.detailsPannel.Controls.Add(this.myLabel2);
            this.detailsPannel.Controls.Add(this.myLabel1);
            this.detailsPannel.Controls.Add(this.rolesMyComboBox);
            this.detailsPannel.Controls.Add(this.loginmyTextBox);
            this.detailsPannel.Controls.Add(this.lastNamemyTextBox);
            this.detailsPannel.Controls.Add(this.isActivemyCheckBox);
            this.detailsPannel.Controls.Add(this.firstNamemyTextBox);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.usersMyDataGridViewRO);
            // 
            // usersMyDataGridViewRO
            // 
            this.usersMyDataGridViewRO.AllowUserToAddRows = false;
            this.usersMyDataGridViewRO.AllowUserToDeleteRows = false;
            this.usersMyDataGridViewRO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.usersMyDataGridViewRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersMyDataGridViewRO.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersMyDataGridViewRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersMyDataGridViewRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersMyDataGridViewRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn});
            this.usersMyDataGridViewRO.DataSource = this.baseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersMyDataGridViewRO.DefaultCellStyle = dataGridViewCellStyle3;
            this.usersMyDataGridViewRO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersMyDataGridViewRO.EditableGrid = false;
            this.usersMyDataGridViewRO.Location = new System.Drawing.Point(0, 0);
            this.usersMyDataGridViewRO.MultiSelect = false;
            this.usersMyDataGridViewRO.Name = "usersMyDataGridViewRO";
            this.usersMyDataGridViewRO.ReadOnly = true;
            this.usersMyDataGridViewRO.RowHeadersVisible = false;
            this.usersMyDataGridViewRO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usersMyDataGridViewRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersMyDataGridViewRO.Size = new System.Drawing.Size(228, 303);
            this.usersMyDataGridViewRO.TabIndex = 0;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNamemyTextBox
            // 
            this.firstNamemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.firstNamemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "FirstName", true));
            this.firstNamemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.firstNamemyTextBox.Location = new System.Drawing.Point(119, 36);
            this.firstNamemyTextBox.Name = "firstNamemyTextBox";
            this.firstNamemyTextBox.Size = new System.Drawing.Size(189, 20);
            this.firstNamemyTextBox.TabIndex = 0;
            // 
            // isActivemyCheckBox
            // 
            this.isActivemyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActivemyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.baseBindingSource, "IsActive", true));
            this.isActivemyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActivemyCheckBox.ForeColor = System.Drawing.Color.White;
            this.isActivemyCheckBox.Location = new System.Drawing.Point(77, 81);
            this.isActivemyCheckBox.Name = "isActivemyCheckBox";
            this.isActivemyCheckBox.ReadOnly = false;
            this.isActivemyCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isActivemyCheckBox.TabIndex = 2;
            this.isActivemyCheckBox.Text = "Activ";
            this.isActivemyCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastNamemyTextBox
            // 
            this.lastNamemyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lastNamemyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "LastName", true));
            this.lastNamemyTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNamemyTextBox.Location = new System.Drawing.Point(119, 58);
            this.lastNamemyTextBox.Name = "lastNamemyTextBox";
            this.lastNamemyTextBox.Size = new System.Drawing.Size(189, 20);
            this.lastNamemyTextBox.TabIndex = 1;
            // 
            // loginmyTextBox
            // 
            this.loginmyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loginmyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseBindingSource, "Login", true));
            this.loginmyTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginmyTextBox.Location = new System.Drawing.Point(119, 171);
            this.loginmyTextBox.Name = "loginmyTextBox";
            this.loginmyTextBox.Size = new System.Drawing.Size(189, 20);
            this.loginmyTextBox.TabIndex = 4;
            // 
            // rolesMyComboBox
            // 
            this.rolesMyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rolesMyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rolesMyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rolesMyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.baseBindingSource, "Role_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rolesMyComboBox.DataSource = this.rolesBindingSource;
            this.rolesMyComboBox.DisplayMember = "RoleName";
            this.rolesMyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolesMyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesMyComboBox.ForeColor = System.Drawing.Color.Black;
            this.rolesMyComboBox.FormattingEnabled = true;
            this.rolesMyComboBox.Location = new System.Drawing.Point(119, 111);
            this.rolesMyComboBox.MessageStrip = null;
            this.rolesMyComboBox.Name = "rolesMyComboBox";
            this.rolesMyComboBox.ReadOnly = false;
            this.rolesMyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.rolesMyComboBox.Size = new System.Drawing.Size(189, 21);
            this.rolesMyComboBox.TabIndex = 3;
            this.rolesMyComboBox.ValueMember = "id";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(DAL.Models.Security.Role);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(87, 114);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(26, 13);
            this.myLabel1.TabIndex = 9;
            this.myLabel1.Text = "Rol";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(57, 39);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(56, 13);
            this.myLabel2.TabIndex = 10;
            this.myLabel2.Text = "Prenume";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.Location = new System.Drawing.Point(74, 61);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(39, 13);
            this.myLabel3.TabIndex = 11;
            this.myLabel3.Text = "Nume";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.Location = new System.Drawing.Point(57, 174);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(57, 13);
            this.myLabel4.TabIndex = 12;
            this.myLabel4.Text = "Utilizator";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.Location = new System.Drawing.Point(71, 196);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(43, 13);
            this.myLabel5.TabIndex = 13;
            this.myLabel5.Text = "Parola";
            // 
            // passMyTextBox
            // 
            this.passMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.passMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.passMyTextBox.Location = new System.Drawing.Point(119, 193);
            this.passMyTextBox.Name = "passMyTextBox";
            this.passMyTextBox.PasswordChar = '*';
            this.passMyTextBox.Size = new System.Drawing.Size(189, 20);
            this.passMyTextBox.TabIndex = 5;
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.White;
            this.myLabel6.Location = new System.Drawing.Point(12, 218);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(101, 13);
            this.myLabel6.TabIndex = 15;
            this.myLabel6.Text = "Verificare Parola";
            // 
            // rePassMyTextBox
            // 
            this.rePassMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rePassMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.rePassMyTextBox.Location = new System.Drawing.Point(119, 215);
            this.rePassMyTextBox.Name = "rePassMyTextBox";
            this.rePassMyTextBox.PasswordChar = '*';
            this.rePassMyTextBox.Size = new System.Drawing.Size(189, 20);
            this.rePassMyTextBox.TabIndex = 6;
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DeleteMessage = "Utilizator sters!";
            this.FirstFocusControl = this.firstNamemyTextBox;
            this.LastFocusControl = this.rePassMyTextBox;
            this.Name = "UsersControl";
            this.ObjectName = "Utilizator";
            this.SaveMessage = "Utilizator salvat!";
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
            ((System.ComponentModel.ISupportInitialize)(this.usersMyDataGridViewRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myDataGridViewRO usersMyDataGridViewRO;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myComboBox rolesMyComboBox;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private MyControls.WindowsControls.myTextBox loginmyTextBox;
        private MyControls.WindowsControls.myTextBox lastNamemyTextBox;
        private MyControls.WindowsControls.myCheckBox isActivemyCheckBox;
        private MyControls.WindowsControls.myTextBox firstNamemyTextBox;
        private MyControls.WindowsControls.myLabel myLabel4;
        private MyControls.WindowsControls.myLabel myLabel3;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myTextBox rePassMyTextBox;
        private MyControls.WindowsControls.myLabel myLabel6;
        private MyControls.WindowsControls.myTextBox passMyTextBox;
        private MyControls.WindowsControls.myLabel myLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;

    }
}
