namespace MyControls.CustomControls.BaseControl
{
    partial class InfoAuditControl
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.pkIdMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.updatedMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.createdMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.infoAuditToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.pkIdMyTextBox);
            this.groupBoxInfo.Controls.Add(this.pictureBox1);
            this.groupBoxInfo.Controls.Add(this.closeMyRibbonMenuButton);
            this.groupBoxInfo.Controls.Add(this.updatedMyTextBox);
            this.groupBoxInfo.Controls.Add(this.createdMyTextBox);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.ForeColor = System.Drawing.Color.White;
            this.groupBoxInfo.Location = new System.Drawing.Point(3, 0);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(532, 145);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info Audit";
            // 
            // pkIdMyTextBox
            // 
            this.pkIdMyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.pkIdMyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pkIdMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.pkIdMyTextBox.Location = new System.Drawing.Point(183, 115);
            this.pkIdMyTextBox.Name = "pkIdMyTextBox";
            this.pkIdMyTextBox.ReadOnly = true;
            this.pkIdMyTextBox.Size = new System.Drawing.Size(243, 20);
            this.pkIdMyTextBox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyControls.Properties.Resources.Info__Aqua_;
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // closeMyRibbonMenuButton
            // 
            this.closeMyRibbonMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.closeMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.closeMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.closeMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.closeMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.closeMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.closeMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.closeMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.closeMyRibbonMenuButton.FadingSpeed = 35;
            this.closeMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.closeMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeMyRibbonMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMyRibbonMenuButton.ForeColor = System.Drawing.Color.Black;
            this.closeMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.closeMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.yes;
            this.closeMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.closeMyRibbonMenuButton.ImageOffset = 0;
            this.closeMyRibbonMenuButton.IsPressed = false;
            this.closeMyRibbonMenuButton.KeepPress = false;
            this.closeMyRibbonMenuButton.Location = new System.Drawing.Point(432, 113);
            this.closeMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.closeMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.closeMyRibbonMenuButton.Name = "closeMyRibbonMenuButton";
            this.closeMyRibbonMenuButton.Radius = 6;
            this.closeMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.closeMyRibbonMenuButton.Size = new System.Drawing.Size(85, 23);
            this.closeMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.closeMyRibbonMenuButton.SplitDistance = 0;
            this.closeMyRibbonMenuButton.TabIndex = 3;
            this.closeMyRibbonMenuButton.Text = "Iesire";
            this.closeMyRibbonMenuButton.Title = "";
            this.infoAuditToolTip.SetToolTip(this.closeMyRibbonMenuButton, "Iesire ( CTRL + X )");
            this.closeMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.closeMyRibbonMenuButton.Click += new System.EventHandler(this.closeMyRibbonMenuButton_Click);
            // 
            // updatedMyTextBox
            // 
            this.updatedMyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.updatedMyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatedMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.updatedMyTextBox.Location = new System.Drawing.Point(183, 66);
            this.updatedMyTextBox.Multiline = true;
            this.updatedMyTextBox.Name = "updatedMyTextBox";
            this.updatedMyTextBox.ReadOnly = true;
            this.updatedMyTextBox.Size = new System.Drawing.Size(333, 41);
            this.updatedMyTextBox.TabIndex = 2;
            // 
            // createdMyTextBox
            // 
            this.createdMyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.createdMyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createdMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.createdMyTextBox.Location = new System.Drawing.Point(183, 19);
            this.createdMyTextBox.Multiline = true;
            this.createdMyTextBox.Name = "createdMyTextBox";
            this.createdMyTextBox.ReadOnly = true;
            this.createdMyTextBox.Size = new System.Drawing.Size(333, 41);
            this.createdMyTextBox.TabIndex = 1;
            // 
            // infoAuditToolTip
            // 
            this.infoAuditToolTip.IsBalloon = true;
            // 
            // InfoAuditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "InfoAuditControl";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Size = new System.Drawing.Size(538, 148);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private MyControls.WindowsControls.myTextBox updatedMyTextBox;
        private MyControls.WindowsControls.myTextBox createdMyTextBox;
        protected MyControls.WindowsControls.myRibbonMenuButton closeMyRibbonMenuButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyControls.WindowsControls.myTextBox pkIdMyTextBox;
        private System.Windows.Forms.ToolTip infoAuditToolTip;

    }
}
