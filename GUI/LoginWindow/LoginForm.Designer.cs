namespace GUI.LoginWindow
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loginStatusStrip = new System.Windows.Forms.StatusStrip();
            this.loginToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.loginImageList = new System.Windows.Forms.ImageList(this.components);
            this.loginMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.setariMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.myLabel2 = new MyControls.WindowsControls.myLabel(this.components);
            this.myLabel1 = new MyControls.WindowsControls.myLabel(this.components);
            this.passMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.userMyTextBox = new MyControls.WindowsControls.myTextBox(this.components);
            this.loginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.loadStaticDataBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.loginStatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.loginStatusStrip, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 133);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // loginStatusStrip
            // 
            this.loginStatusStrip.BackColor = System.Drawing.Color.Gray;
            this.loginStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripStatusLabel,
            this.toolStripProgressBar});
            this.loginStatusStrip.Location = new System.Drawing.Point(0, 111);
            this.loginStatusStrip.Name = "loginStatusStrip";
            this.loginStatusStrip.Size = new System.Drawing.Size(293, 22);
            this.loginStatusStrip.SizingGrip = false;
            this.loginStatusStrip.TabIndex = 9;
            // 
            // loginToolStripStatusLabel
            // 
            this.loginToolStripStatusLabel.AutoSize = false;
            this.loginToolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.loginToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.loginToolStripStatusLabel.Name = "loginToolStripStatusLabel";
            this.loginToolStripStatusLabel.Size = new System.Drawing.Size(287, 17);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Enabled = false;
            this.toolStripProgressBar.ForeColor = System.Drawing.Color.White;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitMyRibbonMenuButton);
            this.panel1.Controls.Add(this.loginMyRibbonMenuButton);
            this.panel1.Controls.Add(this.setariMyRibbonMenuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 24);
            this.panel1.TabIndex = 8;
            // 
            // exitMyRibbonMenuButton
            // 
            this.exitMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.exitMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.exitMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.exitMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.exitMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.exitMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.exitMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.exitMyRibbonMenuButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitMyRibbonMenuButton.FadingSpeed = 35;
            this.exitMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.exitMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.exitMyRibbonMenuButton.ImageKey = "stop.ico";
            this.exitMyRibbonMenuButton.ImageList = this.loginImageList;
            this.exitMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.exitMyRibbonMenuButton.ImageOffset = 1;
            this.exitMyRibbonMenuButton.IsPressed = false;
            this.exitMyRibbonMenuButton.KeepPress = false;
            this.exitMyRibbonMenuButton.Location = new System.Drawing.Point(99, 0);
            this.exitMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.exitMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.exitMyRibbonMenuButton.Name = "exitMyRibbonMenuButton";
            this.exitMyRibbonMenuButton.Radius = 6;
            this.exitMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.exitMyRibbonMenuButton.Size = new System.Drawing.Size(90, 23);
            this.exitMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.exitMyRibbonMenuButton.SplitDistance = 0;
            this.exitMyRibbonMenuButton.TabIndex = 2;
            this.exitMyRibbonMenuButton.Text = "Iesire";
            this.exitMyRibbonMenuButton.Title = "";
            this.exitMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.exitMyRibbonMenuButton.Click += new System.EventHandler(this.exitMyButton_Click);
            // 
            // loginImageList
            // 
            this.loginImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("loginImageList.ImageStream")));
            this.loginImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.loginImageList.Images.SetKeyName(0, "ok.ico");
            this.loginImageList.Images.SetKeyName(1, "stop.ico");
            this.loginImageList.Images.SetKeyName(2, "setari32+.ico");
            // 
            // loginMyRibbonMenuButton
            // 
            this.loginMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.loginMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.loginMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loginMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.loginMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.loginMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.loginMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.loginMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.loginMyRibbonMenuButton.FadingSpeed = 35;
            this.loginMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.loginMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.loginMyRibbonMenuButton.ImageKey = "ok.ico";
            this.loginMyRibbonMenuButton.ImageList = this.loginImageList;
            this.loginMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.loginMyRibbonMenuButton.ImageOffset = 1;
            this.loginMyRibbonMenuButton.IsPressed = false;
            this.loginMyRibbonMenuButton.KeepPress = false;
            this.loginMyRibbonMenuButton.Location = new System.Drawing.Point(3, 0);
            this.loginMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.loginMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.loginMyRibbonMenuButton.Name = "loginMyRibbonMenuButton";
            this.loginMyRibbonMenuButton.Radius = 6;
            this.loginMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.loginMyRibbonMenuButton.Size = new System.Drawing.Size(90, 23);
            this.loginMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.loginMyRibbonMenuButton.SplitDistance = 0;
            this.loginMyRibbonMenuButton.TabIndex = 1;
            this.loginMyRibbonMenuButton.Text = "Autentifica";
            this.loginMyRibbonMenuButton.Title = "";
            this.loginMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.loginMyRibbonMenuButton.Click += new System.EventHandler(this.loginMyButton_Click);
            // 
            // setariMyRibbonMenuButton
            // 
            this.setariMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.setariMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.setariMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.setariMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.setariMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.setariMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.setariMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.setariMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.setariMyRibbonMenuButton.FadingSpeed = 35;
            this.setariMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.setariMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setariMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.setariMyRibbonMenuButton.ImageIndex = 2;
            this.setariMyRibbonMenuButton.ImageList = this.loginImageList;
            this.setariMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.setariMyRibbonMenuButton.ImageOffset = 1;
            this.setariMyRibbonMenuButton.IsPressed = false;
            this.setariMyRibbonMenuButton.KeepPress = false;
            this.setariMyRibbonMenuButton.Location = new System.Drawing.Point(194, 0);
            this.setariMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.setariMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.setariMyRibbonMenuButton.Name = "setariMyRibbonMenuButton";
            this.setariMyRibbonMenuButton.Radius = 6;
            this.setariMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.setariMyRibbonMenuButton.Size = new System.Drawing.Size(90, 23);
            this.setariMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.setariMyRibbonMenuButton.SplitDistance = 0;
            this.setariMyRibbonMenuButton.TabIndex = 3;
            this.setariMyRibbonMenuButton.Text = "Setari";
            this.setariMyRibbonMenuButton.Title = "";
            this.setariMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.setariMyRibbonMenuButton.Click += new System.EventHandler(this.setariMyRibbonMenuButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.myLabel2);
            this.groupBox1.Controls.Add(this.myLabel1);
            this.groupBox1.Controls.Add(this.passMyTextBox);
            this.groupBox1.Controls.Add(this.userMyTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 72);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.White;
            this.myLabel2.Location = new System.Drawing.Point(58, 48);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(47, 13);
            this.myLabel2.TabIndex = 3;
            this.myLabel2.Text = "Parola:";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.White;
            this.myLabel1.Location = new System.Drawing.Point(44, 22);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(61, 13);
            this.myLabel1.TabIndex = 2;
            this.myLabel1.Text = "Utilizator:";
            // 
            // passMyTextBox
            // 
            this.passMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.passMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.passMyTextBox.Location = new System.Drawing.Point(111, 45);
            this.passMyTextBox.Name = "passMyTextBox";
            this.passMyTextBox.PasswordChar = '*';
            this.passMyTextBox.Size = new System.Drawing.Size(139, 20);
            this.passMyTextBox.TabIndex = 1;
            // 
            // userMyTextBox
            // 
            this.userMyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userMyTextBox.ForeColor = System.Drawing.Color.Black;
            this.userMyTextBox.Location = new System.Drawing.Point(111, 19);
            this.userMyTextBox.Name = "userMyTextBox";
            this.userMyTextBox.Size = new System.Drawing.Size(139, 20);
            this.userMyTextBox.TabIndex = 0;
            // 
            // loginErrorProvider
            // 
            this.loginErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.loginErrorProvider.ContainerControl = this;
            // 
            // loadStaticDataBackgroundWorker
            // 
            this.loadStaticDataBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadStaticDataBackgroundWorker_DoWork);
            this.loadStaticDataBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadStaticDataBackgroundWorker_RunWorkerCompleted);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginMyRibbonMenuButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.exitMyRibbonMenuButton;
            this.ClientSize = new System.Drawing.Size(293, 133);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.loginStatusStrip.ResumeLayout(false);
            this.loginStatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip loginStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel loginToolStripStatusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MyControls.WindowsControls.myTextBox passMyTextBox;
        private MyControls.WindowsControls.myTextBox userMyTextBox;
        private MyControls.WindowsControls.myLabel myLabel2;
        private MyControls.WindowsControls.myLabel myLabel1;
        private System.Windows.Forms.ErrorProvider loginErrorProvider;
        private System.Windows.Forms.ImageList loginImageList;
        private MyControls.WindowsControls.myRibbonMenuButton setariMyRibbonMenuButton;
        private MyControls.WindowsControls.myRibbonMenuButton exitMyRibbonMenuButton;
        private MyControls.WindowsControls.myRibbonMenuButton loginMyRibbonMenuButton;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.ComponentModel.BackgroundWorker loadStaticDataBackgroundWorker;
    }
}