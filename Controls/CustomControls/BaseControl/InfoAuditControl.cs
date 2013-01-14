using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using BLL.InfoAudit;

namespace MyControls.CustomControls.BaseControl
{
    public partial class InfoAuditControl : UserControl
    {
        public InfoAuditControl()
        {
            InitializeComponent();
        }

        public void SetAuditData(InfoAudit ia)
        {
            this.pkIdMyTextBox.Text = string.Format("Identificator unic : {0}",
                ia.PkId);

            this.createdMyTextBox.Text = string.Format("Creat de '{0}' in data de '{1}'",
                ia.CreatedByUser, ia.CreateDate.ToString("dd/MM/yyyy HH:mm:ss"));

            if (ia.WasUpdated)
            {
                this.updatedMyTextBox.Text = string.Format("Actualizat ultima data de '{0}' in data de '{1}'",
                    ia.UpdatedByUser, ia.UpdateDate.ToString("dd/MM/yyyy HH:mm:ss"));
            }
        }

        public static void ShowAuditInfo(InfoAudit ia)
        {
            Form infoAuditForm = new Form();
            infoAuditForm.Size = new Size(540, 150);
            infoAuditForm.StartPosition = FormStartPosition.CenterParent;
            infoAuditForm.FormBorderStyle = FormBorderStyle.None;
            infoAuditForm.ShowInTaskbar = false;
            infoAuditForm.KeyPreview = true;
            infoAuditForm.KeyUp += new KeyEventHandler(infoAuditForm_KeyUp);

            InfoAuditControl infoAuditControl = new InfoAuditControl();
            infoAuditControl.Dock = DockStyle.Fill;

            infoAuditForm.Controls.Add(infoAuditControl);
            infoAuditControl.SetAuditData(ia);

            infoAuditForm.ShowDialog();
        }

        static void infoAuditForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                ((InfoAuditControl)((Form)sender).Controls[0]).OnCloseClick();
            }
        }

        private void closeMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnCloseClick();
        }

        public void OnCloseClick()
        {
            if (this.Parent != null)
                if (this.Parent is Form)
                    ((Form)this.Parent).Close();
        }
    }
}
