namespace MyControls.CustomControls.BaseControl
{
    partial class BaseReportViewerControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baseReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.baseErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.baseImageList = new System.Windows.Forms.ImageList(this.components);
            this.printBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.baseReportViewer);
            this.groupBox1.Controls.Add(this.controlsPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // baseReportViewer
            // 
            this.baseReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseReportViewer.Location = new System.Drawing.Point(3, 116);
            this.baseReportViewer.Name = "baseReportViewer";
            this.baseReportViewer.ShowDocumentMapButton = false;
            this.baseReportViewer.Size = new System.Drawing.Size(634, 361);
            this.baseReportViewer.TabIndex = 1;
            this.baseReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.baseReportViewer.Print += new System.ComponentModel.CancelEventHandler(this.baseReportViewer_Print);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsPanel.Location = new System.Drawing.Point(3, 16);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(634, 100);
            this.controlsPanel.TabIndex = 0;
            // 
            // baseErrorProvider
            // 
            this.baseErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.baseErrorProvider.ContainerControl = this;
            // 
            // baseImageList
            // 
            this.baseImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.baseImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.baseImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // printBackgroundWorker
            // 
            this.printBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.printBackgroundWorker_DoWork);
            // 
            // BaseReportViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseReportViewerControl";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.BaseReportViewerControl_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox1;
        protected Microsoft.Reporting.WinForms.ReportViewer baseReportViewer;
        protected System.Windows.Forms.Panel controlsPanel;
        protected System.Windows.Forms.ErrorProvider baseErrorProvider;
        protected System.Windows.Forms.ImageList baseImageList;
        private System.ComponentModel.BackgroundWorker printBackgroundWorker;

    }
}
