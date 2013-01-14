using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using ADODB;

using BLL.RightsMangement;
using MyControls.Logic;
using MyControls.WindowsControls;
using MyControls.WindowsControls.PivotTableColumns;

namespace MyControls.CustomControls.BaseControl
{
    public partial class BasePivotControl : UserControl
    {
        private Label _MessageStrip = null;
        private RightsManagementLogic rightsManagementLogic = new RightsManagementLogic();
        public event Event_Close event_Close = null;

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
                this.SetComboMessageStrip();
            }
        }

        public BasePivotControl()
        {
            InitializeComponent();

            this.baseCommandsControl.EnableFilter = false;
            this.baseCommandsControl.EnableInfoAudit = false;
            this.baseCommandsControl.EnablePrint = false;
        }

        protected void ShowPivotTable(bool show)
        {
            this.reportAxPivotTable.Visible = show;
        }

        private void reportBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.LoadReportData(e);
        }

        private void reportBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.AfterDataLoadWork(e);

            this.Cursor = Cursors.Default;
            this.reportProgressBar.Visible = false;
            //this.reportAxPivotTable.Visible = true;
        }

        protected void RunReport()
        {
            this.Cursor = Cursors.WaitCursor;
            this.reportProgressBar.Visible = true;

            MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, "Raport in curs de rulare.. Va rugam asteptati...", MessageType.Message);

            try
            {
                this.reportBackgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Error);
            }
        }

        public void GenerateReportFormat(List<PivotTableDataColumn> pivotTableDataColumns)
        {
            PivotTableFormater.Format(this.reportAxPivotTable, pivotTableDataColumns);
        }

        protected virtual void LoadReportData(DoWorkEventArgs e)
        {
            return;
        }

        protected virtual void AfterDataLoadWork(RunWorkerCompletedEventArgs e)
        {
            return;
        }

        protected virtual void AfterLoadActions()
        {
            return;
        }

        protected void SetReportTitle(string sReportTitle)
        {
            this.reportAxPivotTable.ActiveView.TitleBar.Caption = sReportTitle;
        }

        private void BasePivotControl_Load(object sender, EventArgs e)
        {
            this.AfterLoadActions();
        }

        private void baseCommandsControl_Close_ButtonClick(object sender, EventArgs e)
        {
            if (event_Close != null)
                event_Close(this);
        }

        public void BasePivotControl_KeyUp(object sender, KeyEventArgs e)
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

        private void SetComboMessageStrip()
        {
            foreach (Control c in this.controlsPanel.Controls)
            {
                if (c is myComboBox)
                {
                    ((myComboBox)c).MessageStrip = this._MessageStrip;
                }
            }
        }

    }
}
