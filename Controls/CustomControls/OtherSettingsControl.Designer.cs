namespace MyControls.CustomControls
{
    partial class OtherSettingsControl
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
            this.dataImportGroupBox = new System.Windows.Forms.GroupBox();
            this.printersMyComboBox = new MyControls.WindowsControls.myComboBox(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.exitMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.dataImportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataImportGroupBox
            // 
            this.dataImportGroupBox.BackColor = System.Drawing.Color.Gray;
            this.dataImportGroupBox.Controls.Add(this.printersMyComboBox);
            this.dataImportGroupBox.Controls.Add(this.myLabel1);
            this.dataImportGroupBox.Controls.Add(this.label1);
            this.dataImportGroupBox.Controls.Add(this.exitMyRibbonMenuButton);
            this.dataImportGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataImportGroupBox.Location = new System.Drawing.Point(3, 0);
            this.dataImportGroupBox.Name = "dataImportGroupBox";
            this.dataImportGroupBox.Size = new System.Drawing.Size(634, 317);
            this.dataImportGroupBox.TabIndex = 0;
            this.dataImportGroupBox.TabStop = false;
            // 
            // printersMyComboBox
            // 
            this.printersMyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.printersMyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.printersMyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.printersMyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printersMyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printersMyComboBox.ForeColor = System.Drawing.Color.Black;
            this.printersMyComboBox.FormattingEnabled = true;
            this.printersMyComboBox.Location = new System.Drawing.Point(33, 41);
            this.printersMyComboBox.MessageStrip = null;
            this.printersMyComboBox.Name = "printersMyComboBox";
            this.printersMyComboBox.ReadOnly = false;
            this.printersMyComboBox.SearchType = MyControls.CustomControls.BaseControl.SearchType.FaraCautare;
            this.printersMyComboBox.Size = new System.Drawing.Size(325, 21);
            this.printersMyComboBox.TabIndex = 45;
            this.printersMyComboBox.SelectedIndexChanged += new System.EventHandler(this.printersMyComboBox_SelectedIndexChanged);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(18, 25);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(177, 13);
            this.myLabel1.TabIndex = 44;
            this.myLabel1.Text = "Imprimanta tiparire documente";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 1);
            this.label1.TabIndex = 43;
            // 
            // exitMyRibbonMenuButton
            // 
            this.exitMyRibbonMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.exitMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.exitMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.exitMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.exitMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.exitMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.exitMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.exitMyRibbonMenuButton.FadingSpeed = 35;
            this.exitMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.exitMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitMyRibbonMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMyRibbonMenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.exitMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.yes;
            this.exitMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.exitMyRibbonMenuButton.ImageOffset = 0;
            this.exitMyRibbonMenuButton.IsPressed = false;
            this.exitMyRibbonMenuButton.KeepPress = false;
            this.exitMyRibbonMenuButton.Location = new System.Drawing.Point(528, 286);
            this.exitMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.exitMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.exitMyRibbonMenuButton.Name = "exitMyRibbonMenuButton";
            this.exitMyRibbonMenuButton.Radius = 6;
            this.exitMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.exitMyRibbonMenuButton.Size = new System.Drawing.Size(82, 23);
            this.exitMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.exitMyRibbonMenuButton.SplitDistance = 0;
            this.exitMyRibbonMenuButton.TabIndex = 8;
            this.exitMyRibbonMenuButton.Text = "Iesire";
            this.exitMyRibbonMenuButton.Title = "";
            this.exitMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.exitMyRibbonMenuButton.Click += new System.EventHandler(this.exitMyRibbonMenuButton_Click);
            // 
            // OtherSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.dataImportGroupBox);
            this.Name = "OtherSettingsControl";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Size = new System.Drawing.Size(640, 320);
            this.Load += new System.EventHandler(this.OtherSettingsControl_Load);
            this.dataImportGroupBox.ResumeLayout(false);
            this.dataImportGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataImportGroupBox;
        private MyControls.WindowsControls.myRibbonMenuButton exitMyRibbonMenuButton;
        private System.Windows.Forms.Label label1;
        private MyControls.WindowsControls.myLabel myLabel1;
        private MyControls.WindowsControls.myComboBox printersMyComboBox;
    }
}
