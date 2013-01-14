namespace GUI.Operations.FieldReservations
{
    partial class CalendarEventItemControl
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
            this.editContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.anuleazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // editContextMenuStrip
            // 
            this.editContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.veziToolStripMenuItem,
            this.toolStripSeparator1,
            this.anuleazaToolStripMenuItem});
            this.editContextMenuStrip.Name = "editContextMenuStrip";
            this.editContextMenuStrip.Size = new System.Drawing.Size(130, 120);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // veziToolStripMenuItem
            // 
            this.veziToolStripMenuItem.Name = "veziToolStripMenuItem";
            this.veziToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.veziToolStripMenuItem.Text = "Vezi";
            this.veziToolStripMenuItem.Click += new System.EventHandler(this.veziToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // anuleazaToolStripMenuItem
            // 
            this.anuleazaToolStripMenuItem.Name = "anuleazaToolStripMenuItem";
            this.anuleazaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.anuleazaToolStripMenuItem.Text = "Anuleaza";
            this.anuleazaToolStripMenuItem.Click += new System.EventHandler(this.anuleazaToolStripMenuItem_Click);
            // 
            // CalendarEventItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "CalendarEventItemControl";
            this.Size = new System.Drawing.Size(100, 60);
            this.editContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip editContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem anuleazaToolStripMenuItem;

    }
}
