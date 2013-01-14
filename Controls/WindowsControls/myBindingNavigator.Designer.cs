namespace MyControls.WindowsControls
{
    partial class myBindingNavigator
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
            this.bindingNavigatorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addNewMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.deleteMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.editMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.saveMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.cancelMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.previousMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.firstMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.nextMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.lastMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.navigationPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigatorToolTip
            // 
            this.bindingNavigatorToolTip.AutoPopDelay = 5000;
            this.bindingNavigatorToolTip.InitialDelay = 250;
            this.bindingNavigatorToolTip.IsBalloon = true;
            this.bindingNavigatorToolTip.ReshowDelay = 100;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.previousMyRibbonMenuButton);
            this.navigationPanel.Controls.Add(this.firstMyRibbonMenuButton);
            this.navigationPanel.Controls.Add(this.nextMyRibbonMenuButton);
            this.navigationPanel.Controls.Add(this.lastMyRibbonMenuButton);
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(127, 31);
            this.navigationPanel.TabIndex = 9;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.editMyRibbonMenuButton);
            this.editPanel.Controls.Add(this.saveMyRibbonMenuButton);
            this.editPanel.Controls.Add(this.cancelMyRibbonMenuButton);
            this.editPanel.Location = new System.Drawing.Point(200, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(92, 30);
            this.editPanel.TabIndex = 10;
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addNewMyRibbonMenuButton);
            this.addPanel.Controls.Add(this.deleteMyRibbonMenuButton);
            this.addPanel.Location = new System.Drawing.Point(133, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(61, 31);
            this.addPanel.TabIndex = 11;
            // 
            // addNewMyRibbonMenuButton
            // 
            this.addNewMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.addNewMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.addNewMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addNewMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.addNewMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.addNewMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.addNewMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.addNewMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.addNewMyRibbonMenuButton.Enabled = false;
            this.addNewMyRibbonMenuButton.FadingSpeed = 35;
            this.addNewMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.addNewMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.addNewMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.add11;
            this.addNewMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.addNewMyRibbonMenuButton.ImageOffset = 0;
            this.addNewMyRibbonMenuButton.IsPressed = false;
            this.addNewMyRibbonMenuButton.KeepPress = false;
            this.addNewMyRibbonMenuButton.Location = new System.Drawing.Point(3, 3);
            this.addNewMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.addNewMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.addNewMyRibbonMenuButton.Name = "addNewMyRibbonMenuButton";
            this.addNewMyRibbonMenuButton.Radius = 6;
            this.addNewMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.addNewMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.addNewMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.addNewMyRibbonMenuButton.SplitDistance = 0;
            this.addNewMyRibbonMenuButton.TabIndex = 4;
            this.addNewMyRibbonMenuButton.Title = "";
            this.bindingNavigatorToolTip.SetToolTip(this.addNewMyRibbonMenuButton, "Inregistrare noua ( F5 )");
            this.addNewMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.addNewMyRibbonMenuButton.Click += new System.EventHandler(this.addNewMyRibbonMenuButton_Click);
            // 
            // deleteMyRibbonMenuButton
            // 
            this.deleteMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.deleteMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deleteMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.deleteMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.deleteMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.deleteMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.deleteMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.deleteMyRibbonMenuButton.Enabled = false;
            this.deleteMyRibbonMenuButton.FadingSpeed = 35;
            this.deleteMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.deleteMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.deleteMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.no;
            this.deleteMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.deleteMyRibbonMenuButton.ImageOffset = 0;
            this.deleteMyRibbonMenuButton.IsPressed = false;
            this.deleteMyRibbonMenuButton.KeepPress = false;
            this.deleteMyRibbonMenuButton.Location = new System.Drawing.Point(33, 3);
            this.deleteMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.deleteMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.deleteMyRibbonMenuButton.Name = "deleteMyRibbonMenuButton";
            this.deleteMyRibbonMenuButton.Radius = 6;
            this.deleteMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.deleteMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.deleteMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.deleteMyRibbonMenuButton.SplitDistance = 0;
            this.deleteMyRibbonMenuButton.TabIndex = 5;
            this.deleteMyRibbonMenuButton.Title = "";
            this.bindingNavigatorToolTip.SetToolTip(this.deleteMyRibbonMenuButton, "Sterge inregistrarea ( F6 )");
            this.deleteMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.deleteMyRibbonMenuButton.Click += new System.EventHandler(this.deleteMyRibbonMenuButton_Click);
            // 
            // editMyRibbonMenuButton
            // 
            this.editMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.editMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.editMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.editMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.editMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.editMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.editMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.editMyRibbonMenuButton.Enabled = false;
            this.editMyRibbonMenuButton.FadingSpeed = 35;
            this.editMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.editMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.editMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.wi0062_24;
            this.editMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.editMyRibbonMenuButton.ImageOffset = 0;
            this.editMyRibbonMenuButton.IsPressed = false;
            this.editMyRibbonMenuButton.KeepPress = false;
            this.editMyRibbonMenuButton.Location = new System.Drawing.Point(4, 3);
            this.editMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.editMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.editMyRibbonMenuButton.Name = "editMyRibbonMenuButton";
            this.editMyRibbonMenuButton.Radius = 6;
            this.editMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.editMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.editMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.editMyRibbonMenuButton.SplitDistance = 0;
            this.editMyRibbonMenuButton.TabIndex = 7;
            this.editMyRibbonMenuButton.Title = "";
            this.bindingNavigatorToolTip.SetToolTip(this.editMyRibbonMenuButton, "Editeaza Inregistrarea ( F7 )");
            this.editMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.editMyRibbonMenuButton.Click += new System.EventHandler(this.editMyRibbonMenuButton_Click);
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
            this.saveMyRibbonMenuButton.Enabled = false;
            this.saveMyRibbonMenuButton.FadingSpeed = 35;
            this.saveMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.saveMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.saveMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.save1;
            this.saveMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.saveMyRibbonMenuButton.ImageOffset = 0;
            this.saveMyRibbonMenuButton.IsPressed = false;
            this.saveMyRibbonMenuButton.KeepPress = false;
            this.saveMyRibbonMenuButton.Location = new System.Drawing.Point(34, 3);
            this.saveMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.saveMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.saveMyRibbonMenuButton.Name = "saveMyRibbonMenuButton";
            this.saveMyRibbonMenuButton.Radius = 6;
            this.saveMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.saveMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.saveMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.saveMyRibbonMenuButton.SplitDistance = 0;
            this.saveMyRibbonMenuButton.TabIndex = 6;
            this.saveMyRibbonMenuButton.Title = "";
            this.bindingNavigatorToolTip.SetToolTip(this.saveMyRibbonMenuButton, "Salveaza inregistrarea ( F8 )");
            this.saveMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.saveMyRibbonMenuButton.Click += new System.EventHandler(this.saveMyRibbonMenuButton_Click);
            // 
            // cancelMyRibbonMenuButton
            // 
            this.cancelMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.cancelMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelMyRibbonMenuButton.CausesValidation = false;
            this.cancelMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cancelMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.cancelMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.cancelMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.cancelMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.cancelMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.cancelMyRibbonMenuButton.Enabled = false;
            this.cancelMyRibbonMenuButton.FadingSpeed = 35;
            this.cancelMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.cancelMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.cancelMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.cancel;
            this.cancelMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.cancelMyRibbonMenuButton.ImageOffset = 0;
            this.cancelMyRibbonMenuButton.IsPressed = false;
            this.cancelMyRibbonMenuButton.KeepPress = false;
            this.cancelMyRibbonMenuButton.Location = new System.Drawing.Point(64, 3);
            this.cancelMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.cancelMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.cancelMyRibbonMenuButton.Name = "cancelMyRibbonMenuButton";
            this.cancelMyRibbonMenuButton.Radius = 6;
            this.cancelMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.cancelMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.cancelMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.cancelMyRibbonMenuButton.SplitDistance = 0;
            this.cancelMyRibbonMenuButton.TabIndex = 8;
            this.cancelMyRibbonMenuButton.Title = "";
            this.bindingNavigatorToolTip.SetToolTip(this.cancelMyRibbonMenuButton, "Anuleaza modificarile ( F9 )");
            this.cancelMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.cancelMyRibbonMenuButton.Click += new System.EventHandler(this.cancelMyRibbonMenuButton_Click);
            // 
            // previousMyRibbonMenuButton
            // 
            this.previousMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.previousMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.previousMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.previousMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.previousMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.previousMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.previousMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.previousMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.previousMyRibbonMenuButton.FadingSpeed = 35;
            this.previousMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.previousMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.previousMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.back;
            this.previousMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.previousMyRibbonMenuButton.ImageOffset = 0;
            this.previousMyRibbonMenuButton.IsPressed = false;
            this.previousMyRibbonMenuButton.KeepPress = false;
            this.previousMyRibbonMenuButton.Location = new System.Drawing.Point(33, 3);
            this.previousMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.previousMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.previousMyRibbonMenuButton.Name = "previousMyRibbonMenuButton";
            this.previousMyRibbonMenuButton.Radius = 6;
            this.previousMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.previousMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.previousMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.previousMyRibbonMenuButton.SplitDistance = 0;
            this.previousMyRibbonMenuButton.TabIndex = 1;
            this.previousMyRibbonMenuButton.Title = "";
            this.bindingNavigatorToolTip.SetToolTip(this.previousMyRibbonMenuButton, "Inregistrarea anterioara ( F2 )");
            this.previousMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.previousMyRibbonMenuButton.Click += new System.EventHandler(this.previousMyRibbonMenuButton_Click);
            // 
            // firstMyRibbonMenuButton
            // 
            this.firstMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.firstMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.firstMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.firstMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.firstMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.firstMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.firstMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.firstMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.firstMyRibbonMenuButton.FadingSpeed = 35;
            this.firstMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.firstMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.firstMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.go_first;
            this.firstMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.firstMyRibbonMenuButton.ImageOffset = 0;
            this.firstMyRibbonMenuButton.IsPressed = false;
            this.firstMyRibbonMenuButton.KeepPress = false;
            this.firstMyRibbonMenuButton.Location = new System.Drawing.Point(3, 3);
            this.firstMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.firstMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.firstMyRibbonMenuButton.Name = "firstMyRibbonMenuButton";
            this.firstMyRibbonMenuButton.Radius = 6;
            this.firstMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.firstMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.firstMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.firstMyRibbonMenuButton.SplitDistance = 0;
            this.firstMyRibbonMenuButton.TabIndex = 0;
            this.firstMyRibbonMenuButton.Title = "";
            this.bindingNavigatorToolTip.SetToolTip(this.firstMyRibbonMenuButton, "Prima inregistrare ( F1 )");
            this.firstMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.firstMyRibbonMenuButton.Click += new System.EventHandler(this.firstMyRibbonMenuButton_Click);
            // 
            // nextMyRibbonMenuButton
            // 
            this.nextMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.nextMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.nextMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nextMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.nextMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.nextMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.nextMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.nextMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.nextMyRibbonMenuButton.FadingSpeed = 35;
            this.nextMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.nextMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.nextMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.forward;
            this.nextMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.nextMyRibbonMenuButton.ImageOffset = 0;
            this.nextMyRibbonMenuButton.IsPressed = false;
            this.nextMyRibbonMenuButton.KeepPress = false;
            this.nextMyRibbonMenuButton.Location = new System.Drawing.Point(69, 3);
            this.nextMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.nextMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.nextMyRibbonMenuButton.Name = "nextMyRibbonMenuButton";
            this.nextMyRibbonMenuButton.Radius = 6;
            this.nextMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.nextMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.nextMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.nextMyRibbonMenuButton.SplitDistance = 0;
            this.nextMyRibbonMenuButton.TabIndex = 2;
            this.nextMyRibbonMenuButton.Title = "";
            this.bindingNavigatorToolTip.SetToolTip(this.nextMyRibbonMenuButton, "Inregistrarea urmatoare ( F3 )");
            this.nextMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.nextMyRibbonMenuButton.Click += new System.EventHandler(this.nextMyRibbonMenuButton_Click);
            // 
            // lastMyRibbonMenuButton
            // 
            this.lastMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.lastMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.lastMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lastMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.lastMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.lastMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.lastMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.lastMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.lastMyRibbonMenuButton.FadingSpeed = 35;
            this.lastMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.lastMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.lastMyRibbonMenuButton.Image = global::MyControls.Properties.Resources.finish;
            this.lastMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.lastMyRibbonMenuButton.ImageOffset = 0;
            this.lastMyRibbonMenuButton.IsPressed = false;
            this.lastMyRibbonMenuButton.KeepPress = false;
            this.lastMyRibbonMenuButton.Location = new System.Drawing.Point(99, 3);
            this.lastMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.lastMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.lastMyRibbonMenuButton.Name = "lastMyRibbonMenuButton";
            this.lastMyRibbonMenuButton.Radius = 6;
            this.lastMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.lastMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.lastMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.lastMyRibbonMenuButton.SplitDistance = 0;
            this.lastMyRibbonMenuButton.TabIndex = 3;
            this.lastMyRibbonMenuButton.Title = "";
            this.bindingNavigatorToolTip.SetToolTip(this.lastMyRibbonMenuButton, "Ultima inregistrare ( F4 )");
            this.lastMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.lastMyRibbonMenuButton.Click += new System.EventHandler(this.lastMyRibbonMenuButton_Click);
            // 
            // myBindingNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.navigationPanel);
            this.Name = "myBindingNavigator";
            this.Size = new System.Drawing.Size(300, 30);
            this.navigationPanel.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private myRibbonMenuButton firstMyRibbonMenuButton;
        private System.Windows.Forms.ToolTip bindingNavigatorToolTip;
        private myRibbonMenuButton previousMyRibbonMenuButton;
        private myRibbonMenuButton nextMyRibbonMenuButton;
        private myRibbonMenuButton lastMyRibbonMenuButton;
        private myRibbonMenuButton addNewMyRibbonMenuButton;
        private myRibbonMenuButton deleteMyRibbonMenuButton;
        private myRibbonMenuButton saveMyRibbonMenuButton;
        private myRibbonMenuButton editMyRibbonMenuButton;
        private myRibbonMenuButton cancelMyRibbonMenuButton;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Panel addPanel;
    }
}
