namespace GUI.Reports.DailyWarnings
{
    partial class DailyWarningsHtmlReportControl
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
            this.dailyWarnings = new DAL.Reports.DailyWarnings.DailyWarnings();
            ((System.ComponentModel.ISupportInitialize)(this.dailyWarnings)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.Size = new System.Drawing.Size(628, 30);
            // 
            // dailyWarnings
            // 
            this.dailyWarnings.DataSetName = "DailyWarnings";
            this.dailyWarnings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DailyWarningsHtmlReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DailyWarningsHtmlReportControl";
            ((System.ComponentModel.ISupportInitialize)(this.dailyWarnings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DAL.Reports.DailyWarnings.DailyWarnings dailyWarnings;
    }
}
