namespace MyControls.CustomControls
{
    partial class DatabaseSettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseSettingsControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errMsgMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.isConnectedPictureBox = new System.Windows.Forms.PictureBox();
            this.exitMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.testMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.saveMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.myLabel5 = new MyControls.WindowsControls.myLabel(this.components);
            this.settingsImageList = new System.Windows.Forms.ImageList(this.components);
            this.myLabel4 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel3 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.passRMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.passMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.userMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.databaseMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.serverMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.settingsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isConnectedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.errMsgMyTextBox);
            this.groupBox1.Controls.Add(this.isConnectedPictureBox);
            this.groupBox1.Controls.Add(this.exitMyRibbonMenuButton);
            this.groupBox1.Controls.Add(this.testMyRibbonMenuButton);
            this.groupBox1.Controls.Add(this.saveMyRibbonMenuButton);
            this.groupBox1.Controls.Add(this.myLabel5);
            this.groupBox1.Controls.Add(this.myLabel4);
            this.groupBox1.Controls.Add(this.myLabel3);
            this.groupBox1.Controls.Add(this.myLabel2);
            this.groupBox1.Controls.Add(this.myLabel1);
            this.groupBox1.Controls.Add(this.passRMyTextBox);
            this.groupBox1.Controls.Add(this.passMyTextBox);
            this.groupBox1.Controls.Add(this.userMyTextBox);
            this.groupBox1.Controls.Add(this.databaseMyTextBox);
            this.groupBox1.Controls.Add(this.serverMyTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // errMsgMyTextBox
            // 
            this.errMsgMyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.errMsgMyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errMsgMyTextBox.ForeColor = System.Drawing.Color.Navy;
            this.errMsgMyTextBox.Location = new System.Drawing.Point(18, 193);
            this.errMsgMyTextBox.Multiline = true;
            this.errMsgMyTextBox.Name = "errMsgMyTextBox";
            this.errMsgMyTextBox.ReadOnly = true;
            this.errMsgMyTextBox.Size = new System.Drawing.Size(256, 80);
            this.errMsgMyTextBox.TabIndex = 14;
            this.errMsgMyTextBox.TabStop = false;
            this.errMsgMyTextBox.Visible = false;
            // 
            // isConnectedPictureBox
            // 
            this.isConnectedPictureBox.BackgroundImage = global::MyControls.Properties.Resources.NetDrive_disconnect;
            this.isConnectedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.isConnectedPictureBox.Location = new System.Drawing.Point(291, 24);
            this.isConnectedPictureBox.Name = "isConnectedPictureBox";
            this.isConnectedPictureBox.Size = new System.Drawing.Size(319, 249);
            this.isConnectedPictureBox.TabIndex = 13;
            this.isConnectedPictureBox.TabStop = false;
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
            this.exitMyRibbonMenuButton.TabIndex = 7;
            this.exitMyRibbonMenuButton.Text = "Iesire";
            this.exitMyRibbonMenuButton.Title = "";
            this.exitMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.exitMyRibbonMenuButton.Click += new System.EventHandler(this.exitMyRibbonMenuButton_Click);
            // 
            // testMyRibbonMenuButton
            // 
            this.testMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.testMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.testMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.testMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.testMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.testMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.testMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.testMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.testMyRibbonMenuButton.FadingSpeed = 35;
            this.testMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.testMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testMyRibbonMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMyRibbonMenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.testMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.mobsync3;
            this.testMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.testMyRibbonMenuButton.ImageOffset = 3;
            this.testMyRibbonMenuButton.IsPressed = false;
            this.testMyRibbonMenuButton.KeepPress = false;
            this.testMyRibbonMenuButton.Location = new System.Drawing.Point(155, 154);
            this.testMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.testMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.testMyRibbonMenuButton.Name = "testMyRibbonMenuButton";
            this.testMyRibbonMenuButton.Radius = 6;
            this.testMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.testMyRibbonMenuButton.Size = new System.Drawing.Size(90, 23);
            this.testMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.testMyRibbonMenuButton.SplitDistance = 0;
            this.testMyRibbonMenuButton.TabIndex = 6;
            this.testMyRibbonMenuButton.Text = "Testeaza";
            this.testMyRibbonMenuButton.Title = "";
            this.testMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.testMyRibbonMenuButton.Click += new System.EventHandler(this.testMyRibbonMenuButton_Click);
            // 
            // saveMyRibbonMenuButton
            // 
            this.saveMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.saveMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.saveMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.saveMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.saveMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.saveMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.saveMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.saveMyRibbonMenuButton.FadingSpeed = 35;
            this.saveMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.saveMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMyRibbonMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMyRibbonMenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.saveMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.save1;
            this.saveMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.saveMyRibbonMenuButton.ImageOffset = 3;
            this.saveMyRibbonMenuButton.IsPressed = false;
            this.saveMyRibbonMenuButton.KeepPress = false;
            this.saveMyRibbonMenuButton.Location = new System.Drawing.Point(49, 154);
            this.saveMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.saveMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.saveMyRibbonMenuButton.Name = "saveMyRibbonMenuButton";
            this.saveMyRibbonMenuButton.Radius = 6;
            this.saveMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.saveMyRibbonMenuButton.Size = new System.Drawing.Size(90, 23);
            this.saveMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.saveMyRibbonMenuButton.SplitDistance = 0;
            this.saveMyRibbonMenuButton.TabIndex = 5;
            this.saveMyRibbonMenuButton.Text = "Salveaza";
            this.saveMyRibbonMenuButton.Title = "";
            this.saveMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.saveMyRibbonMenuButton.Click += new System.EventHandler(this.saveMyRibbonMenuButton_Click);
            // 
            // myLabel5
            // 
            this.myLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.White;
            this.myLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myLabel5.ImageKey = "unlock.ico";
            this.myLabel5.ImageList = this.settingsImageList;
            this.myLabel5.Location = new System.Drawing.Point(36, 131);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(113, 13);
            this.myLabel5.TabIndex = 9;
            this.myLabel5.Text = "Parola:";
            this.myLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settingsImageList
            // 
            this.settingsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("settingsImageList.ImageStream")));
            this.settingsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.settingsImageList.Images.SetKeyName(0, "data_server.ico");
            this.settingsImageList.Images.SetKeyName(1, "database_link.ico");
            this.settingsImageList.Images.SetKeyName(2, "user_edit.ico");
            this.settingsImageList.Images.SetKeyName(3, "unlock.ico");
            // 
            // myLabel4
            // 
            this.myLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.White;
            this.myLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myLabel4.ImageKey = "unlock.ico";
            this.myLabel4.ImageList = this.settingsImageList;
            this.myLabel4.Location = new System.Drawing.Point(36, 105);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(113, 13);
            this.myLabel4.TabIndex = 8;
            this.myLabel4.Text = "Parola:";
            this.myLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myLabel3
            // 
            this.myLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.White;
            this.myLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myLabel3.ImageIndex = 2;
            this.myLabel3.ImageList = this.settingsImageList;
            this.myLabel3.Location = new System.Drawing.Point(36, 79);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(113, 13);
            this.myLabel3.TabIndex = 7;
            this.myLabel3.Text = "User:";
            this.myLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myLabel2
            // 
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myLabel2.ImageIndex = 1;
            this.myLabel2.ImageList = this.settingsImageList;
            this.myLabel2.Location = new System.Drawing.Point(36, 53);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(113, 13);
            this.myLabel2.TabIndex = 6;
            this.myLabel2.Text = "Baza de date:";
            this.myLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myLabel1
            // 
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myLabel1.ImageKey = "data_server.ico";
            this.myLabel1.ImageList = this.settingsImageList;
            this.myLabel1.Location = new System.Drawing.Point(33, 22);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(116, 23);
            this.myLabel1.TabIndex = 5;
            this.myLabel1.Text = "Adresa Server:";
            this.myLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passRMyTextBox
            // 
            this.passRMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.passRMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.passRMyTextBox.Location = new System.Drawing.Point(155, 128);
            this.passRMyTextBox.Name = "passRMyTextBox";
            this.passRMyTextBox.PasswordChar = '*';
            this.passRMyTextBox.Size = new System.Drawing.Size(119, 20);
            this.passRMyTextBox.TabIndex = 4;
            // 
            // passMyTextBox
            // 
            this.passMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.passMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.passMyTextBox.Location = new System.Drawing.Point(155, 102);
            this.passMyTextBox.Name = "passMyTextBox";
            this.passMyTextBox.PasswordChar = '*';
            this.passMyTextBox.Size = new System.Drawing.Size(119, 20);
            this.passMyTextBox.TabIndex = 3;
            // 
            // userMyTextBox
            // 
            this.userMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.userMyTextBox.Location = new System.Drawing.Point(155, 76);
            this.userMyTextBox.Name = "userMyTextBox";
            this.userMyTextBox.Size = new System.Drawing.Size(119, 20);
            this.userMyTextBox.TabIndex = 2;
            // 
            // databaseMyTextBox
            // 
            this.databaseMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.databaseMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.databaseMyTextBox.Location = new System.Drawing.Point(155, 50);
            this.databaseMyTextBox.Name = "databaseMyTextBox";
            this.databaseMyTextBox.Size = new System.Drawing.Size(119, 20);
            this.databaseMyTextBox.TabIndex = 1;
            // 
            // serverMyTextBox
            // 
            this.serverMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.serverMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.serverMyTextBox.Location = new System.Drawing.Point(155, 24);
            this.serverMyTextBox.Name = "serverMyTextBox";
            this.serverMyTextBox.Size = new System.Drawing.Size(119, 20);
            this.serverMyTextBox.TabIndex = 0;
            // 
            // settingsErrorProvider
            // 
            this.settingsErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.settingsErrorProvider.ContainerControl = this;
            // 
            // DatabaseSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.groupBox1);
            this.Name = "DatabaseSettingsControl";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Size = new System.Drawing.Size(640, 320);
            this.Load += new System.EventHandler(this.DatabaseSettingsControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isConnectedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WindowsControls.myTextBox passRMyTextBox;
        private WindowsControls.myTextBox passMyTextBox;
        private WindowsControls.myTextBox userMyTextBox;
        private WindowsControls.myTextBox databaseMyTextBox;
        private WindowsControls.myTextBox serverMyTextBox;
        private WindowsControls.myLabel myLabel5;
        private WindowsControls.myLabel myLabel4;
        private WindowsControls.myLabel myLabel3;
        private WindowsControls.myLabel myLabel2;
        private WindowsControls.myLabel myLabel1;
        private System.Windows.Forms.ImageList settingsImageList;
        private System.Windows.Forms.PictureBox isConnectedPictureBox;
        private WindowsControls.myRibbonMenuButton exitMyRibbonMenuButton;
        private WindowsControls.myRibbonMenuButton testMyRibbonMenuButton;
        private WindowsControls.myRibbonMenuButton saveMyRibbonMenuButton;
        private MyControls.WindowsControls.myTextBox errMsgMyTextBox;
        private System.Windows.Forms.ErrorProvider settingsErrorProvider;
    }
}
