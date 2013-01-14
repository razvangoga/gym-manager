namespace MyControls.CustomControls.BaseControl
{
    partial class BaseHtmlViewerControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.reportWebBrowser = new System.Windows.Forms.WebBrowser();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.progressBarPanel = new System.Windows.Forms.Panel();
            this.reportProgressBar = new System.Windows.Forms.ProgressBar();
            this.commandsPanel = new System.Windows.Forms.Panel();
            this.baseCommandsControl = new MyControls.CustomControls.BaseControl.BaseCommandsControl();
            this.baseBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.progressBarPanel.SuspendLayout();
            this.commandsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportPanel);
            this.groupBox1.Controls.Add(this.optionsPanel);
            this.groupBox1.Controls.Add(this.commandsPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // reportPanel
            // 
            this.reportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportPanel.Controls.Add(this.reportWebBrowser);
            this.reportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPanel.Location = new System.Drawing.Point(3, 116);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(628, 330);
            this.reportPanel.TabIndex = 2;
            // 
            // reportWebBrowser
            // 
            this.reportWebBrowser.AllowWebBrowserDrop = false;
            this.reportWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.reportWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.reportWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.reportWebBrowser.Name = "reportWebBrowser";
            this.reportWebBrowser.Size = new System.Drawing.Size(626, 328);
            this.reportWebBrowser.TabIndex = 0;
            this.reportWebBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.progressBarPanel);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsPanel.Location = new System.Drawing.Point(3, 16);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(628, 100);
            this.optionsPanel.TabIndex = 1;
            // 
            // progressBarPanel
            // 
            this.progressBarPanel.Controls.Add(this.reportProgressBar);
            this.progressBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarPanel.Location = new System.Drawing.Point(0, 74);
            this.progressBarPanel.Name = "progressBarPanel";
            this.progressBarPanel.Padding = new System.Windows.Forms.Padding(5);
            this.progressBarPanel.Size = new System.Drawing.Size(628, 26);
            this.progressBarPanel.TabIndex = 0;
            // 
            // reportProgressBar
            // 
            this.reportProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportProgressBar.ForeColor = System.Drawing.Color.White;
            this.reportProgressBar.Location = new System.Drawing.Point(5, 5);
            this.reportProgressBar.Name = "reportProgressBar";
            this.reportProgressBar.Size = new System.Drawing.Size(618, 16);
            this.reportProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.reportProgressBar.TabIndex = 2;
            this.reportProgressBar.Visible = false;
            // 
            // commandsPanel
            // 
            this.commandsPanel.Controls.Add(this.baseCommandsControl);
            this.commandsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commandsPanel.Location = new System.Drawing.Point(3, 446);
            this.commandsPanel.Name = "commandsPanel";
            this.commandsPanel.Size = new System.Drawing.Size(628, 28);
            this.commandsPanel.TabIndex = 0;
            // 
            // baseCommandsControl
            // 
            this.baseCommandsControl.BackColor = System.Drawing.Color.Gray;
            this.baseCommandsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseCommandsControl.Location = new System.Drawing.Point(0, 0);
            this.baseCommandsControl.Name = "baseCommandsControl";
            this.baseCommandsControl.Size = new System.Drawing.Size(628, 28);
            this.baseCommandsControl.TabIndex = 0;
            this.baseCommandsControl.Close_ButtonClick += new MyControls.CustomControls.BaseControl.Close_ButtonClick(this.baseCommandsControl_Close_ButtonClick);
            // 
            // baseBackgroundWorker
            // 
            this.baseBackgroundWorker.WorkerReportsProgress = true;
            this.baseBackgroundWorker.WorkerSupportsCancellation = true;
            this.baseBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.baseBackgroundWorker_DoWork);
            this.baseBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.baseBackgroundWorker_RunWorkerCompleted);
            this.baseBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.baseBackgroundWorker_ProgressChanged);
            // 
            // BaseHtmlViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseHtmlViewerControl";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.BaseHtmlViewerControl_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BaseHtmlViewerControl_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.reportPanel.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.progressBarPanel.ResumeLayout(false);
            this.commandsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel commandsPanel;
        private BaseCommandsControl baseCommandsControl;
        private System.Windows.Forms.Panel progressBarPanel;
        private System.Windows.Forms.ProgressBar reportProgressBar;
        private System.Windows.Forms.Panel reportPanel;
        private System.ComponentModel.BackgroundWorker baseBackgroundWorker;
        protected System.Windows.Forms.Panel optionsPanel;
        protected System.Windows.Forms.WebBrowser reportWebBrowser;
    }
}
