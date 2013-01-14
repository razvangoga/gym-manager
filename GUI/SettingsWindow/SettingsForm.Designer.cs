namespace GUI.SettingsWindow
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.messageMyLabel = new MyControls.WindowsControls.myLabel(this.components);
            this.databaseSettingsControl = new MyControls.CustomControls.DatabaseSettingsControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.databaseSettingsControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.21447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.78553F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.messageMyLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 25);
            this.panel2.TabIndex = 3;
            // 
            // messageMyLabel
            // 
            this.messageMyLabel.BackColor = System.Drawing.Color.Red;
            this.messageMyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageMyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageMyLabel.ForeColor = System.Drawing.Color.White;
            this.messageMyLabel.Location = new System.Drawing.Point(0, 0);
            this.messageMyLabel.Name = "messageMyLabel";
            this.messageMyLabel.Size = new System.Drawing.Size(645, 23);
            this.messageMyLabel.TabIndex = 1;
            this.messageMyLabel.Text = "Datele de conectare sunt incorecte sau server-ul specificat nu este pornit...";
            this.messageMyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // databaseSettingsControl
            // 
            this.databaseSettingsControl.BackColor = System.Drawing.Color.LightGray;
            this.databaseSettingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseSettingsControl.Location = new System.Drawing.Point(3, 3);
            this.databaseSettingsControl.MessageStrip = this.messageMyLabel;
            this.databaseSettingsControl.Name = "databaseSettingsControl";
            this.databaseSettingsControl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.databaseSettingsControl.Size = new System.Drawing.Size(647, 311);
            this.databaseSettingsControl.TabIndex = 0;
            this.databaseSettingsControl.event_Close += new MyControls.CustomControls.Event_Close(this.databaseSettingsControl_event_Close);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(653, 348);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setare Conexiune cu Baza de Date";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private MyControls.WindowsControls.myLabel messageMyLabel;
        private MyControls.CustomControls.DatabaseSettingsControl databaseSettingsControl;
    }
}