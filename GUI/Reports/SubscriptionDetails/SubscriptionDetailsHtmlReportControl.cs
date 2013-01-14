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
using DAL.Reports.SubscriptionDetails;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Reports.SubscriptionDetails
{
    public partial class SubscriptionDetailsHtmlReportControl : BaseHtmlViewerControl
    {
        private const string _xslFile = "GUI.Reports.SubscriptionDetails.SubscriptionDetails.xsl";
        private const string _outputFile = "SubscriptionDetails.html";

        public SubscriptionDetailsHtmlReportControl()
        {
            InitializeComponent();
            this.fromDateMyDateTimePicker.Value = DateTime.Today.AddMonths(-1);
            this.toDateMyDateTimePicker.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
        }

        private void runReportMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.subscriptionDetails = new DAL.Reports.SubscriptionDetails.SubscriptionDetails();
                // read xls transformation file
                Assembly _assembly = Assembly.GetAssembly(typeof(GUI.Properties.Resources));
                Stream _stream = _assembly.GetManifestResourceStream(_xslFile);

                this.subscriptionDetails.PrepareReportData(SecurityLogic.GetLoggedUserNameAndRole(), this.fromDateMyDateTimePicker.Value.Value, this.toDateMyDateTimePicker.Value.Value);

                this.RunReport(this.subscriptionDetails, _stream, _outputFile);
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Error);
            }
        }
    }
}
