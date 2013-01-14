namespace MyControls.CustomControls.BaseControl
{
    partial class BaseReportViewerContainerControl
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
            this.commandsPanel = new System.Windows.Forms.Panel();
            this.baseCommandsControl = new MyControls.CustomControls.BaseControl.BaseCommandsControl();
            this.reportViewerPanel = new System.Windows.Forms.Panel();
            this.commandsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandsPanel
            // 
            this.commandsPanel.Controls.Add(this.baseCommandsControl);
            this.commandsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commandsPanel.Location = new System.Drawing.Point(0, 472);
            this.commandsPanel.Name = "commandsPanel";
            this.commandsPanel.Size = new System.Drawing.Size(700, 28);
            this.commandsPanel.TabIndex = 0;
            // 
            // baseCommandsControl
            // 
            this.baseCommandsControl.BackColor = System.Drawing.Color.Gray;
            this.baseCommandsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseCommandsControl.Location = new System.Drawing.Point(0, 0);
            this.baseCommandsControl.Name = "baseCommandsControl";
            this.baseCommandsControl.Size = new System.Drawing.Size(700, 28);
            this.baseCommandsControl.TabIndex = 0;
            this.baseCommandsControl.Close_ButtonClick += new MyControls.CustomControls.BaseControl.Close_ButtonClick(this.baseCommandsControl_Close_ButtonClick);
            // 
            // reportViewerPanel
            // 
            this.reportViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPanel.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPanel.Name = "reportViewerPanel";
            this.reportViewerPanel.Size = new System.Drawing.Size(700, 472);
            this.reportViewerPanel.TabIndex = 1;
            // 
            // BaseReportViewerContainerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.reportViewerPanel);
            this.Controls.Add(this.commandsPanel);
            this.Name = "BaseReportViewerContainerControl";
            this.Size = new System.Drawing.Size(700, 500);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BaseReportViewerContainerControl_KeyUp);
            this.commandsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel commandsPanel;
        protected System.Windows.Forms.Panel reportViewerPanel;
        protected BaseCommandsControl baseCommandsControl;

    }
}
