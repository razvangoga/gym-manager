namespace GUI.MainWindow
{
    partial class MainWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Definire Produse");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Categorii de Produse", 19, 19);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Produse", 10, 10, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tipuri Intrari", 17, 17);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tipuri Abonamente", 17, 17);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Terenuri", 17, 17);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Operational", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Clienti", 11, 11);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Detalii Organizatie", 9, 9);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nomenclatoare si definitii", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Intrari Individuale");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Abonamente");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Inchirieri Terenuri");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Servicii", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Achizitii Produse");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Vanzari Produse");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Vanzari", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Emitere Facturi");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Facturare", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Introducere Documente", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode17,
            treeNode19});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Vanzari in Perioada");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Detalii Abonamente");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Stocuri");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Fisa de Magazie");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Avertizari Zilnice");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Rapoarte", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Definire Utilizatori", 6, 6);
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Roluri", 13, 13);
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Securitate", 14, 14, new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Conexiune cu Baza de Date", 5, 5);
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Obiecte Blocate", 1, 1);
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Setari Aplicatie", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31});
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.workAreaFaTabStrip = new FarsiLibrary.Win.FATabStrip();
            this.workAreaPictureBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuMainPanel = new BSE.Windows.Forms.Panel();
            this.menuXPanderPanelList = new BSE.Windows.Forms.XPanderPanelList();
            this.dataEntryXPanderPanel = new BSE.Windows.Forms.XPanderPanel();
            this.dataEntryModulesMyTreeView = new MyControls.WindowsControls.myTreeView(this.components);
            this.treeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.reportsXPanderPanel = new BSE.Windows.Forms.XPanderPanel();
            this.reportsMyTreeView = new MyControls.WindowsControls.myTreeView(this.components);
            this.settingsXPanderPanel = new BSE.Windows.Forms.XPanderPanel();
            this.settingsMyTreeView = new MyControls.WindowsControls.myTreeView(this.components);
            this.ColapseExpandMenuMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.helpMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.reautentificareMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.minimizeMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.maximizeMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.exitMyRibbonMenuButton = new MyControls.WindowsControls.myRibbonMenuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logoMyLabel = new MyControls.WindowsControls.myLabel(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.userMyLabel = new MyControls.WindowsControls.myLabel(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.messageMyLabel = new MyControls.WindowsControls.myLabel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dsModulesList = new GUI.ModuleAccess.ModulesList();
            this.mainTableLayoutPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workAreaFaTabStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workAreaPictureBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.menuMainPanel.SuspendLayout();
            this.menuXPanderPanelList.SuspendLayout();
            this.dataEntryXPanderPanel.SuspendLayout();
            this.reportsXPanderPanel.SuspendLayout();
            this.settingsXPanderPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsModulesList)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.Gray;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.panel6, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.panel5, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.panel4, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel3, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.panel2, 1, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 13);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(990, 680);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.workAreaFaTabStrip);
            this.panel6.Controls.Add(this.workAreaPictureBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(253, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(734, 609);
            this.panel6.TabIndex = 6;
            // 
            // workAreaFaTabStrip
            // 
            this.workAreaFaTabStrip.AlwaysShowClose = false;
            this.workAreaFaTabStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workAreaFaTabStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workAreaFaTabStrip.Location = new System.Drawing.Point(0, 0);
            this.workAreaFaTabStrip.Name = "workAreaFaTabStrip";
            this.workAreaFaTabStrip.Size = new System.Drawing.Size(732, 607);
            this.workAreaFaTabStrip.TabIndex = 0;
            this.workAreaFaTabStrip.Text = "workAreaTabStrip";
            this.workAreaFaTabStrip.Visible = false;
            this.workAreaFaTabStrip.TabStripItemClosed += new System.EventHandler(this.workAreaFaTabStrip_TabStripItemClosed);
            this.workAreaFaTabStrip.TabStripItemClosing += new FarsiLibrary.Win.TabStripItemClosingHandler(this.workAreaFaTabStrip_TabStripItemClosing);
            // 
            // workAreaPictureBox
            // 
            this.workAreaPictureBox.BackgroundImage = global::GUI.Properties.Resources.My_Documents2;
            this.workAreaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.workAreaPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workAreaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.workAreaPictureBox.Name = "workAreaPictureBox";
            this.workAreaPictureBox.Size = new System.Drawing.Size(732, 607);
            this.workAreaPictureBox.TabIndex = 0;
            this.workAreaPictureBox.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.menuMainPanel);
            this.panel5.Controls.Add(this.ColapseExpandMenuMyRibbonMenuButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 609);
            this.panel5.TabIndex = 5;
            // 
            // menuMainPanel
            // 
            this.menuMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuMainPanel.BorderColor = System.Drawing.Color.Empty;
            this.menuMainPanel.CaptionFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuMainPanel.CaptionForeColor = System.Drawing.Color.White;
            this.menuMainPanel.ColorCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(217)))));
            this.menuMainPanel.ColorCaptionGradientEnd = System.Drawing.Color.Gray;
            this.menuMainPanel.ColorCaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(206)))));
            this.menuMainPanel.ColorContentPanelGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.menuMainPanel.ColorContentPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.menuMainPanel.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.menuMainPanel.Controls.Add(this.menuXPanderPanelList);
            this.menuMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuMainPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuMainPanel.Image = global::GUI.Properties.Resources.PIE_DIAGRAM;
            this.menuMainPanel.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.menuMainPanel.Location = new System.Drawing.Point(0, 0);
            this.menuMainPanel.Name = "menuMainPanel";
            this.menuMainPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.menuMainPanel.PanelStyle = BSE.Windows.Forms.PanelStyle.Default;
            this.menuMainPanel.Size = new System.Drawing.Size(242, 584);
            this.menuMainPanel.TabIndex = 2;
            this.menuMainPanel.Text = "Module Aplicatie";
            // 
            // menuXPanderPanelList
            // 
            this.menuXPanderPanelList.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.menuXPanderPanelList.Controls.Add(this.dataEntryXPanderPanel);
            this.menuXPanderPanelList.Controls.Add(this.reportsXPanderPanel);
            this.menuXPanderPanelList.Controls.Add(this.settingsXPanderPanel);
            this.menuXPanderPanelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuXPanderPanelList.GradientBackground = System.Drawing.Color.Empty;
            this.menuXPanderPanelList.Location = new System.Drawing.Point(0, 25);
            this.menuXPanderPanelList.Name = "menuXPanderPanelList";
            this.menuXPanderPanelList.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.menuXPanderPanelList.ShowExpandIcon = true;
            this.menuXPanderPanelList.Size = new System.Drawing.Size(242, 559);
            this.menuXPanderPanelList.TabIndex = 0;
            this.menuXPanderPanelList.Text = "xPanderPanelList1";
            // 
            // dataEntryXPanderPanel
            // 
            this.dataEntryXPanderPanel.BackColor = System.Drawing.Color.Transparent;
            this.dataEntryXPanderPanel.BorderColor = System.Drawing.Color.Empty;
            this.dataEntryXPanderPanel.CaptionFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.dataEntryXPanderPanel.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataEntryXPanderPanel.CloseIconForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataEntryXPanderPanel.ColorCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(217)))));
            this.dataEntryXPanderPanel.ColorCaptionGradientEnd = System.Drawing.SystemColors.ButtonShadow;
            this.dataEntryXPanderPanel.ColorCaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(206)))));
            this.dataEntryXPanderPanel.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.dataEntryXPanderPanel.Controls.Add(this.dataEntryModulesMyTreeView);
            this.dataEntryXPanderPanel.Expand = true;
            this.dataEntryXPanderPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataEntryXPanderPanel.Image = global::GUI.Properties.Resources.wi0054_32;
            this.dataEntryXPanderPanel.Name = "dataEntryXPanderPanel";
            this.dataEntryXPanderPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.dataEntryXPanderPanel.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.dataEntryXPanderPanel.TabIndex = 0;
            this.dataEntryXPanderPanel.Text = "Introducere Date ( CTRL + I )";
            // 
            // dataEntryModulesMyTreeView
            // 
            this.dataEntryModulesMyTreeView.BackColor = System.Drawing.Color.LightGray;
            this.dataEntryModulesMyTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataEntryModulesMyTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEntryModulesMyTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEntryModulesMyTreeView.ImageIndex = 0;
            this.dataEntryModulesMyTreeView.ImageList = this.treeViewImageList;
            this.dataEntryModulesMyTreeView.Location = new System.Drawing.Point(0, 25);
            this.dataEntryModulesMyTreeView.Name = "dataEntryModulesMyTreeView";
            treeNode1.ImageKey = "rect_green.ico";
            treeNode1.Name = "nodeProductDefinition";
            treeNode1.SelectedImageKey = "rect_green.ico";
            treeNode1.Tag = "10";
            treeNode1.Text = "Definire Produse";
            treeNode1.ToolTipText = "Dublu click pentru deschiderea nomenclatorului de Produse";
            treeNode2.ImageIndex = 19;
            treeNode2.Name = "nodeProductTypes";
            treeNode2.SelectedImageIndex = 19;
            treeNode2.Tag = "11";
            treeNode2.Text = "Categorii de Produse";
            treeNode2.ToolTipText = "Dublu click pentru deschiderea nomenclatorului de categorii de produse";
            treeNode3.ImageIndex = 10;
            treeNode3.Name = "nodeProducts";
            treeNode3.SelectedImageIndex = 10;
            treeNode3.Tag = "Module";
            treeNode3.Text = "Produse";
            treeNode4.ImageIndex = 17;
            treeNode4.Name = "nodeEntries";
            treeNode4.SelectedImageIndex = 17;
            treeNode4.Tag = "12";
            treeNode4.Text = "Tipuri Intrari";
            treeNode4.ToolTipText = "Dublu click pentru deschiderea nomenclatorului de tipuri intrari";
            treeNode5.ImageIndex = 17;
            treeNode5.Name = "nodeSubscriptions";
            treeNode5.SelectedImageIndex = 17;
            treeNode5.Tag = "13";
            treeNode5.Text = "Tipuri Abonamente";
            treeNode5.ToolTipText = "Dublu click pentru deschiderea nomenclatorului de tipuri abonamente";
            treeNode6.ImageIndex = 17;
            treeNode6.Name = "nodeFields";
            treeNode6.SelectedImageIndex = 17;
            treeNode6.Tag = "14";
            treeNode6.Text = "Terenuri";
            treeNode6.ToolTipText = "Dublu click pentru deschiderea nomenclatorului de terenuri";
            treeNode7.ImageIndex = 8;
            treeNode7.Name = "nodeOperational";
            treeNode7.SelectedImageIndex = 8;
            treeNode7.Tag = "Module";
            treeNode7.Text = "Operational";
            treeNode8.ImageIndex = 11;
            treeNode8.Name = "nodeClients";
            treeNode8.SelectedImageIndex = 11;
            treeNode8.Tag = "15";
            treeNode8.Text = "Clienti";
            treeNode8.ToolTipText = "Dublu click pentru deschiderea nomenclatorului de Clienti";
            treeNode9.ImageIndex = 9;
            treeNode9.Name = "nodeOrganizationDetails";
            treeNode9.SelectedImageIndex = 9;
            treeNode9.Tag = "16";
            treeNode9.Text = "Detalii Organizatie";
            treeNode9.ToolTipText = "Dublu click pentru deschiderea definitiilor generale ale unitatii comerciale";
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "nodeDefinitions";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Tag = "Module";
            treeNode10.Text = "Nomenclatoare si definitii";
            treeNode11.Name = "entriesNode";
            treeNode11.Tag = "20";
            treeNode11.Text = "Intrari Individuale";
            treeNode11.ToolTipText = "Dublu click pentru deschiderea modului de introducere Intrari individuale";
            treeNode12.Name = "nodeSubscriptions";
            treeNode12.Tag = "21";
            treeNode12.Text = "Abonamente";
            treeNode12.ToolTipText = "Dublu click pentru deschiderea modului de introducere Abonamente";
            treeNode13.Name = "nodeFieldReservations";
            treeNode13.Tag = "22";
            treeNode13.Text = "Inchirieri Terenuri";
            treeNode13.ToolTipText = "Dublu click pentru deschiderea modului de introducere Inchirieri Terenuri";
            treeNode14.Name = "nodeServicii";
            treeNode14.Tag = "Module";
            treeNode14.Text = "Servicii";
            treeNode15.Name = "nodeProductEntries";
            treeNode15.Tag = "23";
            treeNode15.Text = "Achizitii Produse";
            treeNode15.ToolTipText = "Dublu click pentru deschiderea modului de introducere Achizitii Produse";
            treeNode16.Name = "nodeProductSales";
            treeNode16.Tag = "24";
            treeNode16.Text = "Vanzari Produse";
            treeNode16.ToolTipText = "Dublu click pentru deschiderea modului de introducere Vanzari Produse";
            treeNode17.Name = "nodeSales";
            treeNode17.Tag = "Module";
            treeNode17.Text = "Vanzari";
            treeNode18.Name = "nodePrintInvoice";
            treeNode18.Tag = "30";
            treeNode18.Text = "Emitere Facturi";
            treeNode18.ToolTipText = "Dublu click pentru deschiderea modului de Emitere Facturi";
            treeNode19.Name = "nodeInvoiceIng";
            treeNode19.Tag = "Module";
            treeNode19.Text = "Facturare";
            treeNode20.ImageIndex = 0;
            treeNode20.Name = "nodeDocuments";
            treeNode20.SelectedImageIndex = 0;
            treeNode20.Tag = "Module";
            treeNode20.Text = "Introducere Documente";
            this.dataEntryModulesMyTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode20});
            this.dataEntryModulesMyTreeView.SelectedImageIndex = 0;
            this.dataEntryModulesMyTreeView.ShowNodeToolTips = true;
            this.dataEntryModulesMyTreeView.ShowPlusMinus = false;
            this.dataEntryModulesMyTreeView.ShowRootLines = false;
            this.dataEntryModulesMyTreeView.Size = new System.Drawing.Size(242, 484);
            this.dataEntryModulesMyTreeView.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.dataEntryModulesMyTreeView, "Modulele Aplicatiei");
            this.dataEntryModulesMyTreeView.DoubleClick += new System.EventHandler(this.dataEntryModulesMyTreeView_DoubleClick);
            this.dataEntryModulesMyTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.dataEntryModulesMyTreeView_BeforeCollapse);
            this.dataEntryModulesMyTreeView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataEntryModulesMyTreeView_KeyUp);
            // 
            // treeViewImageList
            // 
            this.treeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImageList.ImageStream")));
            this.treeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewImageList.Images.SetKeyName(0, "");
            this.treeViewImageList.Images.SetKeyName(1, "");
            this.treeViewImageList.Images.SetKeyName(2, "");
            this.treeViewImageList.Images.SetKeyName(3, "");
            this.treeViewImageList.Images.SetKeyName(4, "");
            this.treeViewImageList.Images.SetKeyName(5, "");
            this.treeViewImageList.Images.SetKeyName(6, "");
            this.treeViewImageList.Images.SetKeyName(7, "point_yellow.ico");
            this.treeViewImageList.Images.SetKeyName(8, "point_blue.ico");
            this.treeViewImageList.Images.SetKeyName(9, "point_cyan.ico");
            this.treeViewImageList.Images.SetKeyName(10, "point_green.ico");
            this.treeViewImageList.Images.SetKeyName(11, "point_red.ico");
            this.treeViewImageList.Images.SetKeyName(12, "doc_edit.ico");
            this.treeViewImageList.Images.SetKeyName(13, "user_edit.ico");
            this.treeViewImageList.Images.SetKeyName(14, "105.ico");
            this.treeViewImageList.Images.SetKeyName(15, "copy.ico");
            this.treeViewImageList.Images.SetKeyName(16, "rect_yellow.ico");
            this.treeViewImageList.Images.SetKeyName(17, "rect_blue.ico");
            this.treeViewImageList.Images.SetKeyName(18, "rect_cyan.ico");
            this.treeViewImageList.Images.SetKeyName(19, "rect_green.ico");
            this.treeViewImageList.Images.SetKeyName(20, "rect_red.ico");
            this.treeViewImageList.Images.SetKeyName(21, "triang_yellow.ico");
            this.treeViewImageList.Images.SetKeyName(22, "triang_cyan.ico");
            this.treeViewImageList.Images.SetKeyName(23, "triang_green.ico");
            this.treeViewImageList.Images.SetKeyName(24, "triang_red.ico");
            this.treeViewImageList.Images.SetKeyName(25, "boxinto.ico");
            // 
            // reportsXPanderPanel
            // 
            this.reportsXPanderPanel.BorderColor = System.Drawing.Color.Empty;
            this.reportsXPanderPanel.CaptionFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.reportsXPanderPanel.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.reportsXPanderPanel.CloseIconForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reportsXPanderPanel.ColorCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(217)))));
            this.reportsXPanderPanel.ColorCaptionGradientEnd = System.Drawing.SystemColors.ButtonShadow;
            this.reportsXPanderPanel.ColorCaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(206)))));
            this.reportsXPanderPanel.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.reportsXPanderPanel.Controls.Add(this.reportsMyTreeView);
            this.reportsXPanderPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reportsXPanderPanel.Image = global::GUI.Properties.Resources.copy;
            this.reportsXPanderPanel.Name = "reportsXPanderPanel";
            this.reportsXPanderPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.reportsXPanderPanel.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.reportsXPanderPanel.TabIndex = 1;
            this.reportsXPanderPanel.Text = "Rapoarte ( CTRL + R )";
            // 
            // reportsMyTreeView
            // 
            this.reportsMyTreeView.BackColor = System.Drawing.Color.LightGray;
            this.reportsMyTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportsMyTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsMyTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsMyTreeView.ImageIndex = 0;
            this.reportsMyTreeView.ImageList = this.treeViewImageList;
            this.reportsMyTreeView.Location = new System.Drawing.Point(0, 25);
            this.reportsMyTreeView.Name = "reportsMyTreeView";
            treeNode21.Name = "nodePeriodSales";
            treeNode21.Tag = "31";
            treeNode21.Text = "Vanzari in Perioada";
            treeNode21.ToolTipText = "Dublu click pentru rularea raportului Vanzari in Perioada";
            treeNode22.Name = "nodeSubscriptionDetails";
            treeNode22.Tag = "32";
            treeNode22.Text = "Detalii Abonamente";
            treeNode22.ToolTipText = "Dublu click pentru rularea raportului Detalii Abonamente";
            treeNode23.Name = "nodeStock";
            treeNode23.Tag = "33";
            treeNode23.Text = "Stocuri";
            treeNode23.ToolTipText = "Dublu click pentru rularea raportului Stocuri";
            treeNode24.Name = "nodeFisaMagazie";
            treeNode24.Tag = "34";
            treeNode24.Text = "Fisa de Magazie";
            treeNode24.ToolTipText = "Dublu click pentru rularea raportului Fisa de Magazie";
            treeNode25.Name = "nodeDailyWarnings";
            treeNode25.Tag = "35";
            treeNode25.Text = "Avertizari Zilnice";
            treeNode25.ToolTipText = "Dublu click pentru rularea raportului Avertizari Zilnice";
            treeNode26.ImageIndex = 1;
            treeNode26.Name = "nodeReports";
            treeNode26.SelectedImageIndex = 1;
            treeNode26.Tag = "Module";
            treeNode26.Text = "Rapoarte";
            this.reportsMyTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.reportsMyTreeView.SelectedImageIndex = 0;
            this.reportsMyTreeView.ShowNodeToolTips = true;
            this.reportsMyTreeView.ShowPlusMinus = false;
            this.reportsMyTreeView.ShowRootLines = false;
            this.reportsMyTreeView.Size = new System.Drawing.Size(242, 0);
            this.reportsMyTreeView.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.reportsMyTreeView, "Modulele Aplicatiei");
            this.reportsMyTreeView.DoubleClick += new System.EventHandler(this.menuMyTreeView_DoubleClick);
            this.reportsMyTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.menuMyTreeView_BeforeCollapse);
            this.reportsMyTreeView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.menuMyTreeView_KeyUp);
            // 
            // settingsXPanderPanel
            // 
            this.settingsXPanderPanel.BorderColor = System.Drawing.Color.Empty;
            this.settingsXPanderPanel.CaptionFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.settingsXPanderPanel.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.settingsXPanderPanel.CloseIconForeColor = System.Drawing.Color.Empty;
            this.settingsXPanderPanel.ColorCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(217)))));
            this.settingsXPanderPanel.ColorCaptionGradientEnd = System.Drawing.SystemColors.ButtonShadow;
            this.settingsXPanderPanel.ColorCaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(206)))));
            this.settingsXPanderPanel.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.settingsXPanderPanel.Controls.Add(this.settingsMyTreeView);
            this.settingsXPanderPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingsXPanderPanel.Image = ((System.Drawing.Image)(resources.GetObject("settingsXPanderPanel.Image")));
            this.settingsXPanderPanel.Name = "settingsXPanderPanel";
            this.settingsXPanderPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.settingsXPanderPanel.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.settingsXPanderPanel.TabIndex = 2;
            this.settingsXPanderPanel.Text = "Setari Aplicatie ( CTRL + S )";
            // 
            // settingsMyTreeView
            // 
            this.settingsMyTreeView.BackColor = System.Drawing.Color.LightGray;
            this.settingsMyTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.settingsMyTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsMyTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsMyTreeView.ImageIndex = 0;
            this.settingsMyTreeView.ImageList = this.treeViewImageList;
            this.settingsMyTreeView.Location = new System.Drawing.Point(0, 25);
            this.settingsMyTreeView.Name = "settingsMyTreeView";
            treeNode27.ImageIndex = 6;
            treeNode27.Name = "nodeUsers";
            treeNode27.SelectedImageIndex = 6;
            treeNode27.Tag = "41";
            treeNode27.Text = "Definire Utilizatori";
            treeNode27.ToolTipText = "Dublu click pentru deschiderea modului de definire utilizatori";
            treeNode28.ImageIndex = 13;
            treeNode28.Name = "nodeRoles";
            treeNode28.SelectedImageIndex = 13;
            treeNode28.Tag = "42";
            treeNode28.Text = "Roluri";
            treeNode28.ToolTipText = "Dublu click pentru deschiderea modului de roluri pentru utilizatori";
            treeNode29.ImageIndex = 14;
            treeNode29.Name = "nodeSecurity";
            treeNode29.SelectedImageIndex = 14;
            treeNode29.Tag = "Module";
            treeNode29.Text = "Securitate";
            treeNode30.ImageIndex = 5;
            treeNode30.Name = "nodeDBConnection";
            treeNode30.SelectedImageIndex = 5;
            treeNode30.Tag = "43";
            treeNode30.Text = "Conexiune cu Baza de Date";
            treeNode30.ToolTipText = "Dublu click pentru deschiderea modului de configurare a conexiunii cu baza de dat" +
                "e";
            treeNode31.ImageIndex = 1;
            treeNode31.Name = "nodeLockedObjects";
            treeNode31.SelectedImageIndex = 1;
            treeNode31.Tag = "44";
            treeNode31.Text = "Obiecte Blocate";
            treeNode31.ToolTipText = "Dublu click pentru deschiderea modului de vizualizare a obiectelor blocate";
            treeNode32.ImageIndex = 3;
            treeNode32.Name = "nodeSettings";
            treeNode32.SelectedImageIndex = 3;
            treeNode32.Tag = "Module";
            treeNode32.Text = "Setari Aplicatie";
            this.settingsMyTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32});
            this.settingsMyTreeView.SelectedImageIndex = 0;
            this.settingsMyTreeView.ShowNodeToolTips = true;
            this.settingsMyTreeView.ShowPlusMinus = false;
            this.settingsMyTreeView.ShowRootLines = false;
            this.settingsMyTreeView.Size = new System.Drawing.Size(242, 0);
            this.settingsMyTreeView.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.settingsMyTreeView, "Modulele Aplicatiei");
            this.settingsMyTreeView.DoubleClick += new System.EventHandler(this.settingsMyTreeView_DoubleClick);
            this.settingsMyTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.settingsMyTreeView_BeforeCollapse);
            this.settingsMyTreeView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.settingsMyTreeView_KeyUp);
            // 
            // ColapseExpandMenuMyRibbonMenuButton
            // 
            this.ColapseExpandMenuMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.ColapseExpandMenuMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.ColapseExpandMenuMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ColapseExpandMenuMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.ColapseExpandMenuMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.ColapseExpandMenuMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.ColapseExpandMenuMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.ColapseExpandMenuMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.ColapseExpandMenuMyRibbonMenuButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColapseExpandMenuMyRibbonMenuButton.FadingSpeed = 35;
            this.ColapseExpandMenuMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.ColapseExpandMenuMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColapseExpandMenuMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.ColapseExpandMenuMyRibbonMenuButton.Image = global::GUI.Properties.Resources.Back32;
            this.ColapseExpandMenuMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.ColapseExpandMenuMyRibbonMenuButton.ImageOffset = 0;
            this.ColapseExpandMenuMyRibbonMenuButton.IsPressed = false;
            this.ColapseExpandMenuMyRibbonMenuButton.KeepPress = false;
            this.ColapseExpandMenuMyRibbonMenuButton.Location = new System.Drawing.Point(0, 584);
            this.ColapseExpandMenuMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.ColapseExpandMenuMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.ColapseExpandMenuMyRibbonMenuButton.Name = "ColapseExpandMenuMyRibbonMenuButton";
            this.ColapseExpandMenuMyRibbonMenuButton.Radius = 6;
            this.ColapseExpandMenuMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.ColapseExpandMenuMyRibbonMenuButton.Size = new System.Drawing.Size(242, 23);
            this.ColapseExpandMenuMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.ColapseExpandMenuMyRibbonMenuButton.SplitDistance = 0;
            this.ColapseExpandMenuMyRibbonMenuButton.TabIndex = 1;
            this.ColapseExpandMenuMyRibbonMenuButton.Text = "Restrange Meniu";
            this.ColapseExpandMenuMyRibbonMenuButton.Title = "";
            this.mainToolTip.SetToolTip(this.ColapseExpandMenuMyRibbonMenuButton, "Restrange Meniu");
            this.ColapseExpandMenuMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.ColapseExpandMenuMyRibbonMenuButton.Click += new System.EventHandler(this.ColapseExpandMenuMyRibbonMenuButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.helpMyRibbonMenuButton);
            this.panel4.Controls.Add(this.reautentificareMyRibbonMenuButton);
            this.panel4.Controls.Add(this.minimizeMyRibbonMenuButton);
            this.panel4.Controls.Add(this.maximizeMyRibbonMenuButton);
            this.panel4.Controls.Add(this.exitMyRibbonMenuButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(253, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(734, 34);
            this.panel4.TabIndex = 4;
            // 
            // helpMyRibbonMenuButton
            // 
            this.helpMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.helpMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.helpMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.helpMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.helpMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.helpMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.helpMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.helpMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.helpMyRibbonMenuButton.FadingSpeed = 35;
            this.helpMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.helpMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.helpMyRibbonMenuButton.Image = global::GUI.Properties.Resources.Help32;
            this.helpMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.helpMyRibbonMenuButton.ImageOffset = 0;
            this.helpMyRibbonMenuButton.IsPressed = false;
            this.helpMyRibbonMenuButton.KeepPress = false;
            this.helpMyRibbonMenuButton.Location = new System.Drawing.Point(50, 3);
            this.helpMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.helpMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.helpMyRibbonMenuButton.Name = "helpMyRibbonMenuButton";
            this.helpMyRibbonMenuButton.Radius = 6;
            this.helpMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.helpMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.helpMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.helpMyRibbonMenuButton.SplitDistance = 0;
            this.helpMyRibbonMenuButton.TabIndex = 4;
            this.helpMyRibbonMenuButton.TabStop = false;
            this.helpMyRibbonMenuButton.Title = "";
            this.mainToolTip.SetToolTip(this.helpMyRibbonMenuButton, "Ajutor - pornire manual ( CTRL + H )");
            this.helpMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.helpMyRibbonMenuButton.Click += new System.EventHandler(this.helpMyRibbonMenuButton_Click);
            // 
            // reautentificareMyRibbonMenuButton
            // 
            this.reautentificareMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.reautentificareMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.reautentificareMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reautentificareMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.reautentificareMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.reautentificareMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.reautentificareMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.reautentificareMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.reautentificareMyRibbonMenuButton.FadingSpeed = 35;
            this.reautentificareMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.reautentificareMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reautentificareMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.reautentificareMyRibbonMenuButton.Image = global::GUI.Properties.Resources.Refresh32;
            this.reautentificareMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.reautentificareMyRibbonMenuButton.ImageOffset = 0;
            this.reautentificareMyRibbonMenuButton.IsPressed = false;
            this.reautentificareMyRibbonMenuButton.KeepPress = false;
            this.reautentificareMyRibbonMenuButton.Location = new System.Drawing.Point(20, 3);
            this.reautentificareMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.reautentificareMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.reautentificareMyRibbonMenuButton.Name = "reautentificareMyRibbonMenuButton";
            this.reautentificareMyRibbonMenuButton.Radius = 6;
            this.reautentificareMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.reautentificareMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.reautentificareMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.reautentificareMyRibbonMenuButton.SplitDistance = 0;
            this.reautentificareMyRibbonMenuButton.TabIndex = 3;
            this.reautentificareMyRibbonMenuButton.TabStop = false;
            this.reautentificareMyRibbonMenuButton.Title = "";
            this.mainToolTip.SetToolTip(this.reautentificareMyRibbonMenuButton, "Schimbare utilizator ( CTRL + U )");
            this.reautentificareMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.reautentificareMyRibbonMenuButton.Click += new System.EventHandler(this.reautentificareMyRibbonMenuButton_Click);
            // 
            // minimizeMyRibbonMenuButton
            // 
            this.minimizeMyRibbonMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.minimizeMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.minimizeMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.minimizeMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.minimizeMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.minimizeMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.minimizeMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.minimizeMyRibbonMenuButton.FadingSpeed = 35;
            this.minimizeMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.minimizeMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.minimizeMyRibbonMenuButton.Image = global::GUI.Properties.Resources.Down32;
            this.minimizeMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.minimizeMyRibbonMenuButton.ImageOffset = 0;
            this.minimizeMyRibbonMenuButton.IsPressed = false;
            this.minimizeMyRibbonMenuButton.KeepPress = false;
            this.minimizeMyRibbonMenuButton.Location = new System.Drawing.Point(646, 3);
            this.minimizeMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.minimizeMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.minimizeMyRibbonMenuButton.Name = "minimizeMyRibbonMenuButton";
            this.minimizeMyRibbonMenuButton.Radius = 6;
            this.minimizeMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.minimizeMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.minimizeMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.minimizeMyRibbonMenuButton.SplitDistance = 0;
            this.minimizeMyRibbonMenuButton.TabIndex = 2;
            this.minimizeMyRibbonMenuButton.TabStop = false;
            this.minimizeMyRibbonMenuButton.Title = "";
            this.mainToolTip.SetToolTip(this.minimizeMyRibbonMenuButton, "Minimizare fereastra");
            this.minimizeMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.minimizeMyRibbonMenuButton.Click += new System.EventHandler(this.minimizeMyRibbonMenuButton_Click);
            // 
            // maximizeMyRibbonMenuButton
            // 
            this.maximizeMyRibbonMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeMyRibbonMenuButton.Arrow = MyControls.WindowsControls.myRibbonMenuButton.e_arrow.None;
            this.maximizeMyRibbonMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeMyRibbonMenuButton.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.maximizeMyRibbonMenuButton.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.maximizeMyRibbonMenuButton.ColorOn = System.Drawing.Color.Coral;
            this.maximizeMyRibbonMenuButton.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.maximizeMyRibbonMenuButton.ColorPress = System.Drawing.Color.LightSlateGray;
            this.maximizeMyRibbonMenuButton.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(38)))));
            this.maximizeMyRibbonMenuButton.FadingSpeed = 35;
            this.maximizeMyRibbonMenuButton.FlatAppearance.BorderSize = 0;
            this.maximizeMyRibbonMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.maximizeMyRibbonMenuButton.Image = global::GUI.Properties.Resources.app;
            this.maximizeMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.maximizeMyRibbonMenuButton.ImageOffset = 0;
            this.maximizeMyRibbonMenuButton.IsPressed = false;
            this.maximizeMyRibbonMenuButton.KeepPress = false;
            this.maximizeMyRibbonMenuButton.Location = new System.Drawing.Point(675, 3);
            this.maximizeMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.maximizeMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.maximizeMyRibbonMenuButton.Name = "maximizeMyRibbonMenuButton";
            this.maximizeMyRibbonMenuButton.Radius = 6;
            this.maximizeMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.maximizeMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.maximizeMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.maximizeMyRibbonMenuButton.SplitDistance = 0;
            this.maximizeMyRibbonMenuButton.TabIndex = 1;
            this.maximizeMyRibbonMenuButton.TabStop = false;
            this.maximizeMyRibbonMenuButton.Title = "";
            this.mainToolTip.SetToolTip(this.maximizeMyRibbonMenuButton, "Maximizare fereastra");
            this.maximizeMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.maximizeMyRibbonMenuButton.Click += new System.EventHandler(this.maximizeMyRibbonMenuButton_Click);
            // 
            // exitMyRibbonMenuButton
            // 
            this.exitMyRibbonMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.exitMyRibbonMenuButton.GroupPos = MyControls.WindowsControls.myRibbonMenuButton.e_groupPos.None;
            this.exitMyRibbonMenuButton.Image = global::GUI.Properties.Resources.Stop32;
            this.exitMyRibbonMenuButton.ImageLocation = MyControls.WindowsControls.myRibbonMenuButton.e_imagelocation.Left;
            this.exitMyRibbonMenuButton.ImageOffset = 0;
            this.exitMyRibbonMenuButton.IsPressed = false;
            this.exitMyRibbonMenuButton.KeepPress = false;
            this.exitMyRibbonMenuButton.Location = new System.Drawing.Point(705, 3);
            this.exitMyRibbonMenuButton.MaxImageSize = new System.Drawing.Point(0, 0);
            this.exitMyRibbonMenuButton.MenuPos = new System.Drawing.Point(0, 0);
            this.exitMyRibbonMenuButton.Name = "exitMyRibbonMenuButton";
            this.exitMyRibbonMenuButton.Radius = 6;
            this.exitMyRibbonMenuButton.ShowBase = MyControls.WindowsControls.myRibbonMenuButton.e_showbase.Yes;
            this.exitMyRibbonMenuButton.Size = new System.Drawing.Size(24, 24);
            this.exitMyRibbonMenuButton.SplitButton = MyControls.WindowsControls.myRibbonMenuButton.e_splitbutton.No;
            this.exitMyRibbonMenuButton.SplitDistance = 0;
            this.exitMyRibbonMenuButton.TabIndex = 0;
            this.exitMyRibbonMenuButton.TabStop = false;
            this.exitMyRibbonMenuButton.Title = "";
            this.mainToolTip.SetToolTip(this.exitMyRibbonMenuButton, "Iesire din aplicatie");
            this.exitMyRibbonMenuButton.UseVisualStyleBackColor = true;
            this.exitMyRibbonMenuButton.Click += new System.EventHandler(this.exitMyRibbonMenuButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.logoMyLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(244, 34);
            this.panel3.TabIndex = 3;
            // 
            // logoMyLabel
            // 
            this.logoMyLabel.BackColor = System.Drawing.Color.Gray;
            this.logoMyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoMyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoMyLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.logoMyLabel.Location = new System.Drawing.Point(2, 2);
            this.logoMyLabel.Name = "logoMyLabel";
            this.logoMyLabel.Size = new System.Drawing.Size(238, 28);
            this.logoMyLabel.TabIndex = 0;
            this.logoMyLabel.Text = "Gym Manager";
            this.logoMyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.userMyLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 658);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 19);
            this.panel1.TabIndex = 0;
            // 
            // userMyLabel
            // 
            this.userMyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userMyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMyLabel.ForeColor = System.Drawing.Color.White;
            this.userMyLabel.Location = new System.Drawing.Point(0, 0);
            this.userMyLabel.Name = "userMyLabel";
            this.userMyLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userMyLabel.Size = new System.Drawing.Size(242, 17);
            this.userMyLabel.TabIndex = 0;
            this.userMyLabel.Text = "Autentificat ca :";
            this.userMyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.messageMyLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(253, 658);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 19);
            this.panel2.TabIndex = 2;
            // 
            // messageMyLabel
            // 
            this.messageMyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageMyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageMyLabel.ForeColor = System.Drawing.Color.White;
            this.messageMyLabel.Location = new System.Drawing.Point(0, 0);
            this.messageMyLabel.Name = "messageMyLabel";
            this.messageMyLabel.Size = new System.Drawing.Size(732, 17);
            this.messageMyLabel.TabIndex = 1;
            this.messageMyLabel.Text = "mesaje diverse";
            this.messageMyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.mainTableLayoutPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(996, 696);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // mainToolTip
            // 
            this.mainToolTip.IsBalloon = true;
            // 
            // dsModulesList
            // 
            this.dsModulesList.DataSetName = "ModulesList";
            this.dsModulesList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Manger";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workAreaFaTabStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workAreaPictureBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.menuMainPanel.ResumeLayout(false);
            this.menuXPanderPanelList.ResumeLayout(false);
            this.dataEntryXPanderPanel.ResumeLayout(false);
            this.reportsXPanderPanel.ResumeLayout(false);
            this.settingsXPanderPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsModulesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private MyControls.WindowsControls.myLabel userMyLabel;
        private System.Windows.Forms.Panel panel2;
        private MyControls.WindowsControls.myLabel messageMyLabel;
        private MyControls.WindowsControls.myLabel logoMyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private MyControls.WindowsControls.myRibbonMenuButton exitMyRibbonMenuButton;
        private System.Windows.Forms.ToolTip mainToolTip;
        private MyControls.WindowsControls.myRibbonMenuButton maximizeMyRibbonMenuButton;
        private MyControls.WindowsControls.myRibbonMenuButton minimizeMyRibbonMenuButton;
        private MyControls.WindowsControls.myRibbonMenuButton reautentificareMyRibbonMenuButton;
        private MyControls.WindowsControls.myRibbonMenuButton helpMyRibbonMenuButton;
        private System.Windows.Forms.ImageList treeViewImageList;
        private MyControls.WindowsControls.myTreeView reportsMyTreeView;
        private FarsiLibrary.Win.FATabStrip workAreaFaTabStrip;
        private System.Windows.Forms.PictureBox workAreaPictureBox;
        private GUI.ModuleAccess.ModulesList dsModulesList;
        private MyControls.WindowsControls.myRibbonMenuButton ColapseExpandMenuMyRibbonMenuButton;
        private BSE.Windows.Forms.Panel menuMainPanel;
        private BSE.Windows.Forms.XPanderPanelList menuXPanderPanelList;
        private BSE.Windows.Forms.XPanderPanel dataEntryXPanderPanel;
        private BSE.Windows.Forms.XPanderPanel reportsXPanderPanel;
        private MyControls.WindowsControls.myTreeView dataEntryModulesMyTreeView;
        private BSE.Windows.Forms.XPanderPanel settingsXPanderPanel;
        private MyControls.WindowsControls.myTreeView settingsMyTreeView;
    }
}