using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using BLL.RightsMangement;
using Helpers.GeneralOperations;

namespace MyControls.CustomControls.BaseControl
{
    public partial class BaseReportViewerContainerControl : UserControl
    {
        private Label _MessageStrip = null;
        private string _ReportViewerControlType = string.Empty;
        private RightsManagementLogic rightsManagementLogic = new RightsManagementLogic();
        public event Event_Close event_Close = null;
        private BaseReportViewerControl _baseReportViewerControl;

        public RightsManagementLogic AccessRights
        {
            set
            {
                rightsManagementLogic = value;
            }
        }

        public Label MessageStrip
        {
            get { return this._MessageStrip; }
            set
            {
                this._MessageStrip = value;
                if (this._baseReportViewerControl != null)
                    this._baseReportViewerControl.MessageStrip = this._MessageStrip;
            }
        }

        public string ReportViewerControlType
        {
            get
            {
                return this._ReportViewerControlType;
            }
            set
            {
                this._ReportViewerControlType = value;
            }

        }

        public BaseReportViewerContainerControl()
        {
            InitializeComponent();

            this.baseCommandsControl.EnableFilter = false;
            this.baseCommandsControl.EnableInfoAudit = false;
            this.baseCommandsControl.EnablePrint = false;
        }

        public void AddReportViewerControl(BaseReportViewerControl baseReportViewerControl)
        {
            this._baseReportViewerControl = baseReportViewerControl;
            baseReportViewerControl.Dock = DockStyle.Fill;

            this.reportViewerPanel.Controls.Clear();
            this.reportViewerPanel.Controls.Add(baseReportViewerControl);
        }

        private void baseCommandsControl_Close_ButtonClick(object sender, EventArgs e)
        {
            if (event_Close != null)
                event_Close(this);
        }

        private static void ShowReportOnScreen(BaseReportViewerControl baseReportViewerControl, Label messageStrip)
        {
            Form frm = new Form();
            frm.Size = new Size(950, 640);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ShowInTaskbar = false;

            BaseReportViewerContainerControl container = new BaseReportViewerContainerControl();
            container.Dock = DockStyle.Fill;
            container.event_Close += new Event_Close(container_event_Close);

            container.AddReportViewerControl(baseReportViewerControl);
            container.MessageStrip = messageStrip;
            frm.Controls.Add(container);

            frm.ShowDialog();
        }

        public static void ShowReport(BaseReportViewerControl baseReportViewerControl, Label messageStrip)
        {
            DialogResult dr = MessageBox.Show("Tiparire direct la imprimanta?", "Alegeti stilul de tiparire...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                PrintDirectlyToPrinter(baseReportViewerControl, messageStrip);
            }
            else
            {
                ShowReportOnScreen(baseReportViewerControl, messageStrip);
            }
        }

        private static void PrintDirectlyToPrinter(BaseReportViewerControl baseReportViewerControl, Label messageStrip)
        {
            baseReportViewerControl.PrintReportToPrinterAsinc();
        }

        static void container_event_Close(object sender)
        {
            if (((Control)sender).Parent != null)
                if (((Control)sender).Parent is Form)
                    ((Form)((Control)sender).Parent).Close();
        }

        public void BaseReportViewerContainerControl_KeyUp(object sender, KeyEventArgs e)
        {
            //commnd buttons
            if (e.Control && e.KeyCode == Keys.P)
                this.baseCommandsControl.OnPrintClick(new EventArgs());
            if (e.Control && e.KeyCode == Keys.C)
                this.baseCommandsControl.OnFilterClick(new EventArgs());
            if (e.Control && e.KeyCode == Keys.A)
                this.baseCommandsControl.OnInfoClick(new EventArgs());
            if (e.Control && e.KeyCode == Keys.X)
                this.baseCommandsControl.OnCloseClick(new EventArgs());
        }
    }
}
