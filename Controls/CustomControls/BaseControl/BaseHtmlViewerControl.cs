  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

using BLL.RightsMangement;
using Helpers.GeneralOperations;
using MyControls.Logic;

namespace MyControls.CustomControls.BaseControl
{
    public partial class BaseHtmlViewerControl : UserControl
    {
        private Label _MessageStrip = null;
        private RightsManagementLogic rightsManagementLogic = new RightsManagementLogic();
        public event Event_Close event_Close = null;
        private string _sOutputPath;
        private string _sReportRootPath = string.Format("{0}/Reports", Application.StartupPath);

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
            set { this._MessageStrip = value; }
        }

        public BaseHtmlViewerControl()
        {
            InitializeComponent();

            this.baseCommandsControl.EnableFilter = false;
            this.baseCommandsControl.EnableInfoAudit = false;
            this.baseCommandsControl.EnablePrint = false;
        }

        private void baseCommandsControl_Close_ButtonClick(object sender, EventArgs e)
        {
            if (event_Close != null)
                event_Close(this);
        }

        private void baseBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                XsltTransformWorker.Transform((DataSet)((object[])e.Argument)[0],
                    (Stream)(((object[])e.Argument)[1]),
                    Convert.ToString(((object[])e.Argument)[2]));
            }
            catch (Exception ex)
            {
                FileOperations.WriteToExceptionLog(string.Format("{0} Html Report Generation Error.", this.GetType().ToString()), ex.Message, Convert.ToString(((object[])e.Argument)[1]),Convert.ToString(((object[])e.Argument)[2]));
                baseBackgroundWorker.ReportProgress(0, ex.Message);
                baseBackgroundWorker.CancelAsync();
            }
        }

        private void baseBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.reportWebBrowser.Url = new Uri(string.Format("file://{0}/{1}", this._sReportRootPath,this._sOutputPath));

            this.reportProgressBar.Visible = false;
            this.reportWebBrowser.Visible = true;
        }

        private void baseBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                e.UserState.ToString(), MessageType.Error);
        }

        protected void RunReport(DataSet dsDataSource, Stream sXslTemplatePath, string sOutputFilePath)
        {
            MessageStripFormatting.setMessageStrip(this.MessageStrip);

            this._sOutputPath = sOutputFilePath;

            this.reportProgressBar.Visible = true;
            this.reportWebBrowser.Visible = false;

            object[] oArgument = new object[3];

            oArgument[0] = dsDataSource;
            oArgument[1] = sXslTemplatePath;
            oArgument[2] = sOutputFilePath;

            this.baseBackgroundWorker.RunWorkerAsync(oArgument);
        }

        private void BaseHtmlViewerControl_Load(object sender, EventArgs e)
        {
            this.AfterLoad();
        }

        protected void LoadHtmlHelp()
        {
            this.reportWebBrowser.Url = new Uri(string.Format("file://{0}/{1}", Application.StartupPath, XsltTransformWorker._HelpIndexPage));
        }

        protected virtual void AfterLoad()
        {
            return;
        }

        public void BaseHtmlViewerControl_KeyUp(object sender, KeyEventArgs e)
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
