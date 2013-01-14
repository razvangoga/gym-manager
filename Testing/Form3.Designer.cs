namespace Testing
{
    partial class Form3
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
            this.fieldReservationsScheduleControl1 = new GUI.Operations.FieldReservations.FieldReservationsScheduleControl();
            this.SuspendLayout();
            // 
            // fieldReservationsScheduleControl1
            // 
            this.fieldReservationsScheduleControl1.BackColor = System.Drawing.Color.Gray;
            this.fieldReservationsScheduleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldReservationsScheduleControl1.Location = new System.Drawing.Point(0, 0);
            this.fieldReservationsScheduleControl1.MessageStrip = null;
            this.fieldReservationsScheduleControl1.Name = "fieldReservationsScheduleControl1";
            this.fieldReservationsScheduleControl1.ReportViewerControlType = "";
            this.fieldReservationsScheduleControl1.Size = new System.Drawing.Size(792, 573);
            this.fieldReservationsScheduleControl1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.fieldReservationsScheduleControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.Operations.FieldReservations.FieldReservationsScheduleControl fieldReservationsScheduleControl1;
    }
}