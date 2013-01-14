namespace GUI.Operations.FieldReservations
{
    partial class CalendarPeriodItemControl
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
            this.periodMyLabel = new MyControls.WindowsControls.myLabel(this.components);
            this.SuspendLayout();
            // 
            // periodMyLabel
            // 
            this.periodMyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodMyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodMyLabel.ForeColor = System.Drawing.Color.White;
            this.periodMyLabel.Location = new System.Drawing.Point(0, 0);
            this.periodMyLabel.Name = "periodMyLabel";
            this.periodMyLabel.Size = new System.Drawing.Size(100, 15);
            this.periodMyLabel.TabIndex = 0;
            this.periodMyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalendarPeriodItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.periodMyLabel);
            this.Name = "CalendarPeriodItemControl";
            this.Size = new System.Drawing.Size(100, 15);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.WindowsControls.myLabel periodMyLabel;
    }
}
