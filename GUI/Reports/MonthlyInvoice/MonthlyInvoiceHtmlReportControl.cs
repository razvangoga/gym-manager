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

using BLL.Reports;
using BLL.Security;
using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Reports.DailyWarnings;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Reports.MonthlyInvoice
{
    public partial class MonthlyInvoiceHtmlReportControl : BaseHtmlViewerControl
    {
        private const string _xslFile = "GUI.Reports.MonthlyInvoice.MonthlyInvoice.xsl";
        private const string _outputFile = "MonthlyInvoice.html";

        public MonthlyInvoiceHtmlReportControl()
        {
            InitializeComponent();

            this.invoiceDateMyDateTimePicker.Value = DateTime.Today;
            this.clientsBindingSource.DataSource = NomenclatorsModelMethods.ClientMethods.GetActiveInvoicebleClients();
        }

        private void runReportMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.monthlyInvoice = new DAL.Reports.MonthlyInvoice.MonthlyInvoice();
                // read xls transformation file
                Assembly _assembly = Assembly.GetAssembly(typeof(GUI.Properties.Resources));
                Stream _stream = _assembly.GetManifestResourceStream(_xslFile);

                this.monthlyInvoice.PrepareReportData( SecurityLogic.GetLoggedUserNameAndRole(),
                    MonthlyInvoiceLogic.CheckIfInvoiceExists(this.CurrentRow(), this.invoiceDateMyDateTimePicker.Value.Value), 
                    this.CurrentRow(), NomenclatorsModelMethods.OrganizationDetailsMethods.GetOrganizationDetails(),
                    this.invoiceDateMyDateTimePicker.Value.Value.Year, this.invoiceDateMyDateTimePicker.Value.Value.Month);

                this.RunReport(this.monthlyInvoice, _stream, _outputFile);
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Error);
            }
               
        }

        public Client CurrentRow()
        {
            return (Client)this.clientsBindingSource.Current;
        }
    }
}
