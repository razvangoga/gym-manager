namespace MyControls.CustomControls.BaseControl
{
    partial class BaseControl
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
            this.baseGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.detailsParentPanel = new System.Windows.Forms.Panel();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.detailsPannel = new System.Windows.Forms.Panel();
            this.listPannel = new System.Windows.Forms.Panel();
            this.listContainerPanel = new System.Windows.Forms.Panel();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.baseMyBindingNavigator = new MyControls.WindowsControls.myBindingNavigator();
            this.baseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseCommandsControl = new MyControls.CustomControls.BaseControl.BaseCommandsControl();
            this.saveCancelPannel = new System.Windows.Forms.Panel();
            this.baseImageList = new System.Windows.Forms.ImageList(this.components);
            this.baseErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.baseGroupBox.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.detailsParentPanel.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            this.listPannel.SuspendLayout();
            this.listContainerPanel.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
            this.saveCancelPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // baseGroupBox
            // 
            this.baseGroupBox.BackColor = System.Drawing.Color.Gray;
            this.baseGroupBox.Controls.Add(this.controlsPanel);
            this.baseGroupBox.Controls.Add(this.navigationPanel);
            this.baseGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseGroupBox.ForeColor = System.Drawing.Color.Black;
            this.baseGroupBox.Location = new System.Drawing.Point(3, 0);
            this.baseGroupBox.Name = "baseGroupBox";
            this.baseGroupBox.Size = new System.Drawing.Size(676, 477);
            this.baseGroupBox.TabIndex = 0;
            this.baseGroupBox.TabStop = false;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.detailsParentPanel);
            this.controlsPanel.Controls.Add(this.listPannel);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(3, 16);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(670, 428);
            this.controlsPanel.TabIndex = 4;
            // 
            // detailsParentPanel
            // 
            this.detailsParentPanel.Controls.Add(this.detailsGroupBox);
            this.detailsParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsParentPanel.ForeColor = System.Drawing.Color.Black;
            this.detailsParentPanel.Location = new System.Drawing.Point(240, 0);
            this.detailsParentPanel.Name = "detailsParentPanel";
            this.detailsParentPanel.Padding = new System.Windows.Forms.Padding(3);
            this.detailsParentPanel.Size = new System.Drawing.Size(430, 428);
            this.detailsParentPanel.TabIndex = 3;
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Controls.Add(this.detailsPannel);
            this.detailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsGroupBox.ForeColor = System.Drawing.Color.White;
            this.detailsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(424, 422);
            this.detailsGroupBox.TabIndex = 2;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Detalii";
            // 
            // detailsPannel
            // 
            this.detailsPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsPannel.ForeColor = System.Drawing.Color.Black;
            this.detailsPannel.Location = new System.Drawing.Point(3, 16);
            this.detailsPannel.Name = "detailsPannel";
            this.detailsPannel.Padding = new System.Windows.Forms.Padding(3);
            this.detailsPannel.Size = new System.Drawing.Size(418, 403);
            this.detailsPannel.TabIndex = 1;
            // 
            // listPannel
            // 
            this.listPannel.Controls.Add(this.listContainerPanel);
            this.listPannel.Controls.Add(this.filterPanel);
            this.listPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listPannel.Location = new System.Drawing.Point(0, 0);
            this.listPannel.Name = "listPannel";
            this.listPannel.Size = new System.Drawing.Size(240, 428);
            this.listPannel.TabIndex = 0;
            // 
            // listContainerPanel
            // 
            this.listContainerPanel.Controls.Add(this.listGroupBox);
            this.listContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContainerPanel.ForeColor = System.Drawing.Color.Black;
            this.listContainerPanel.Location = new System.Drawing.Point(0, 100);
            this.listContainerPanel.Name = "listContainerPanel";
            this.listContainerPanel.Padding = new System.Windows.Forms.Padding(3);
            this.listContainerPanel.Size = new System.Drawing.Size(240, 328);
            this.listContainerPanel.TabIndex = 2;
            // 
            // listGroupBox
            // 
            this.listGroupBox.Controls.Add(this.gridPanel);
            this.listGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGroupBox.ForeColor = System.Drawing.Color.White;
            this.listGroupBox.Location = new System.Drawing.Point(3, 3);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Size = new System.Drawing.Size(234, 322);
            this.listGroupBox.TabIndex = 1;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "Lista";
            // 
            // gridPanel
            // 
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.ForeColor = System.Drawing.Color.Black;
            this.gridPanel.Location = new System.Drawing.Point(3, 16);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(228, 303);
            this.gridPanel.TabIndex = 1;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.filtersGroupBox);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.ForeColor = System.Drawing.Color.Black;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(3);
            this.filterPanel.Size = new System.Drawing.Size(240, 100);
            this.filterPanel.TabIndex = 0;
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersGroupBox.ForeColor = System.Drawing.Color.White;
            this.filtersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(234, 94);
            this.filtersGroupBox.TabIndex = 0;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filtre";
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.baseMyBindingNavigator);
            this.navigationPanel.Controls.Add(this.saveCancelPannel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigationPanel.Location = new System.Drawing.Point(3, 444);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(670, 30);
            this.navigationPanel.TabIndex = 5;
            // 
            // baseMyBindingNavigator
            // 
            this.baseMyBindingNavigator.BackColor = System.Drawing.Color.Gray;
            this.baseMyBindingNavigator.BindingSource = this.baseBindingSource;
            this.baseMyBindingNavigator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseMyBindingNavigator.CommandsControl = this.baseCommandsControl;
            this.baseMyBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.baseMyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.baseMyBindingNavigator.Name = "baseMyBindingNavigator";
            this.baseMyBindingNavigator.PanelAdd = true;
            this.baseMyBindingNavigator.PanelDeleteing = true;
            this.baseMyBindingNavigator.PanelEditing = true;
            this.baseMyBindingNavigator.PanelNavigation = true;
            this.baseMyBindingNavigator.Size = new System.Drawing.Size(298, 30);
            this.baseMyBindingNavigator.TabIndex = 2;
            this.baseMyBindingNavigator.DeleteItem_ButtonClick += new MyControls.WindowsControls.DeleteItem_ButtonClick(this.baseMyBindingNavigator_DeleteItem_ButtonClick);
            this.baseMyBindingNavigator.SaveItem_ButtonClick += new MyControls.WindowsControls.SaveItem_ButtonClick(this.baseMyBindingNavigator_SaveItem_ButtonClick);
            this.baseMyBindingNavigator.EditItem_ButtonClick += new MyControls.WindowsControls.EditItem_ButtonClick(this.baseMyBindingNavigator_EditItem_ButtonClick);
            this.baseMyBindingNavigator.CancelItem_ButtonClick += new MyControls.WindowsControls.CancelItem_ButtonClick(this.baseMyBindingNavigator_CancelItem_ButtonClick);
            this.baseMyBindingNavigator.AddNewItem_ButtonClick += new MyControls.WindowsControls.AddNewItem_ButtonClick(this.baseMyBindingNavigator_AddNewItem_ButtonClick);
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.baseBindingSource_ListChanged);
            // 
            // baseCommandsControl
            // 
            this.baseCommandsControl.BackColor = System.Drawing.Color.Gray;
            this.baseCommandsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseCommandsControl.Location = new System.Drawing.Point(0, 0);
            this.baseCommandsControl.Name = "baseCommandsControl";
            this.baseCommandsControl.Size = new System.Drawing.Size(668, 28);
            this.baseCommandsControl.TabIndex = 0;
            this.baseCommandsControl.Info_ButtonClick += new MyControls.CustomControls.BaseControl.Info_ButtonClick(this.baseCommandsControl_Info_ButtonClick);
            this.baseCommandsControl.Close_ButtonClick += new MyControls.CustomControls.BaseControl.Close_ButtonClick(this.baseCommandsControl_Close_ButtonClick);
            this.baseCommandsControl.Print_ButtonClick += new MyControls.CustomControls.BaseControl.Print_ButtonClick(this.baseCommandsControl_Print_ButtonClick);
            this.baseCommandsControl.Filter_ButtonClick += new MyControls.CustomControls.BaseControl.Filter_ButtonClick(this.baseCommandsControl_Filter_ButtonClick);
            // 
            // saveCancelPannel
            // 
            this.saveCancelPannel.BackColor = System.Drawing.Color.Gray;
            this.saveCancelPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveCancelPannel.Controls.Add(this.baseCommandsControl);
            this.saveCancelPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveCancelPannel.Location = new System.Drawing.Point(0, 0);
            this.saveCancelPannel.Name = "saveCancelPannel";
            this.saveCancelPannel.Size = new System.Drawing.Size(670, 30);
            this.saveCancelPannel.TabIndex = 4;
            // 
            // baseImageList
            // 
            this.baseImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.baseImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.baseImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // baseErrorProvider
            // 
            this.baseErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.baseErrorProvider.ContainerControl = this;
            this.baseErrorProvider.DataSource = this.baseBindingSource;
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.baseGroupBox);
            this.Name = "BaseControl";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Size = new System.Drawing.Size(682, 480);
            this.Load += new System.EventHandler(this.BaseControl_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BaseControl_KeyUp);
            this.baseGroupBox.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.detailsParentPanel.ResumeLayout(false);
            this.detailsGroupBox.ResumeLayout(false);
            this.listPannel.ResumeLayout(false);
            this.listContainerPanel.ResumeLayout(false);
            this.listGroupBox.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.saveCancelPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ImageList baseImageList;
        protected System.Windows.Forms.ErrorProvider baseErrorProvider;
        protected System.Windows.Forms.BindingSource baseBindingSource;
        protected System.Windows.Forms.GroupBox baseGroupBox;
        protected System.Windows.Forms.Panel navigationPanel;
        protected System.Windows.Forms.Panel saveCancelPannel;
        protected MyControls.WindowsControls.myBindingNavigator baseMyBindingNavigator;
        protected System.Windows.Forms.Panel controlsPanel;
        protected System.Windows.Forms.Panel detailsPannel;
        protected System.Windows.Forms.Panel listPannel;
        protected System.Windows.Forms.Panel filterPanel;
        protected System.Windows.Forms.Panel gridPanel;
        protected BaseCommandsControl baseCommandsControl;
        protected System.Windows.Forms.GroupBox filtersGroupBox;
        protected System.Windows.Forms.Panel detailsParentPanel;
        protected System.Windows.Forms.GroupBox detailsGroupBox;
        protected System.Windows.Forms.Panel listContainerPanel;
        protected System.Windows.Forms.GroupBox listGroupBox;
    }
}
