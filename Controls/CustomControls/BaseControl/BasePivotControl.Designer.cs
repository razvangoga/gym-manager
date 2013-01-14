namespace MyControls.CustomControls.BaseControl
{
    partial class BasePivotControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePivotControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportAxPivotTable = new AxMicrosoft.Office.Interop.Owc11.AxPivotTable();
            this.commandsPanel = new System.Windows.Forms.Panel();
            this.baseCommandsControl = new MyControls.CustomControls.BaseControl.BaseCommandsControl();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportProgressBar = new System.Windows.Forms.ProgressBar();
            this.reportBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportAxPivotTable)).BeginInit();
            this.commandsPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportAxPivotTable);
            this.groupBox1.Controls.Add(this.commandsPanel);
            this.groupBox1.Controls.Add(this.controlsPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // reportAxPivotTable
            // 
            this.reportAxPivotTable.DataSource = null;
            this.reportAxPivotTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportAxPivotTable.Enabled = true;
            this.reportAxPivotTable.Location = new System.Drawing.Point(3, 136);
            this.reportAxPivotTable.Name = "reportAxPivotTable";
            this.reportAxPivotTable.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reportAxPivotTable.OcxState")));
            this.reportAxPivotTable.Size = new System.Drawing.Size(634, 313);
            this.reportAxPivotTable.TabIndex = 3;
            // 
            // commandsPanel
            // 
            this.commandsPanel.Controls.Add(this.baseCommandsControl);
            this.commandsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commandsPanel.Location = new System.Drawing.Point(3, 449);
            this.commandsPanel.Name = "commandsPanel";
            this.commandsPanel.Size = new System.Drawing.Size(634, 28);
            this.commandsPanel.TabIndex = 2;
            // 
            // baseCommandsControl
            // 
            this.baseCommandsControl.BackColor = System.Drawing.Color.Gray;
            this.baseCommandsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseCommandsControl.Location = new System.Drawing.Point(0, 0);
            this.baseCommandsControl.Name = "baseCommandsControl";
            this.baseCommandsControl.Size = new System.Drawing.Size(634, 28);
            this.baseCommandsControl.TabIndex = 0;
            this.baseCommandsControl.Close_ButtonClick += new MyControls.CustomControls.BaseControl.Close_ButtonClick(this.baseCommandsControl_Close_ButtonClick);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.panel2);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsPanel.Location = new System.Drawing.Point(3, 16);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(634, 120);
            this.controlsPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportProgressBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(634, 26);
            this.panel2.TabIndex = 0;
            // 
            // reportProgressBar
            // 
            this.reportProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportProgressBar.ForeColor = System.Drawing.Color.White;
            this.reportProgressBar.Location = new System.Drawing.Point(5, 5);
            this.reportProgressBar.Name = "reportProgressBar";
            this.reportProgressBar.Size = new System.Drawing.Size(624, 16);
            this.reportProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.reportProgressBar.TabIndex = 0;
            this.reportProgressBar.Visible = false;
            // 
            // reportBackgroundWorker
            // 
            this.reportBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.reportBackgroundWorker_DoWork);
            this.reportBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.reportBackgroundWorker_RunWorkerCompleted);
            // 
            // BasePivotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.groupBox1);
            this.Name = "BasePivotControl";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.BasePivotControl_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BasePivotControl_KeyUp);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportAxPivotTable)).EndInit();
            this.commandsPanel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Panel controlsPanel;
        private System.ComponentModel.BackgroundWorker reportBackgroundWorker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar reportProgressBar;
        private System.Windows.Forms.Panel commandsPanel;
        protected AxMicrosoft.Office.Interop.Owc11.AxPivotTable reportAxPivotTable;
        private BaseCommandsControl baseCommandsControl;
    }
}
