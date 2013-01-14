using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using BLL.Security;
using DAL.Logic;
using DAL.Reports.DailyWarnings;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Reports.DailyWarnings
{
    public partial class DailyWarningsHtmlReportControl : BaseHtmlViewerControl
    {
        private const string _xslFile = "GUI.Reports.DailyWarnings.DailyWarnings.xsl";
        private const string _outputFile = "DailyWarnings.html";

        public DailyWarningsHtmlReportControl()
        {
            InitializeComponent();
        }

        protected override void AfterLoad()
        {
            base.AfterLoad();

            try
            {
                // read xls transformation file
                Assembly _assembly = Assembly.GetAssembly(typeof(GUI.Properties.Resources));
                Stream _stream = _assembly.GetManifestResourceStream(_xslFile);

                this.dailyWarnings.PrepareReportData(SecurityLogic.GetLoggedUserNameAndRole(), DateTime.Now);

                this.RunReport(this.dailyWarnings, _stream, _outputFile);
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Error);
            }
        }
    }
}
