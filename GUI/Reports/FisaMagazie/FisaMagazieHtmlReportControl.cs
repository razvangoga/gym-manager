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

namespace GUI.Reports.FisaMagazie
{
    public partial class FisaMagazieHtmlReportControl : BaseHtmlViewerControl
    {
        private const string _xslFile = "GUI.Reports.FisaMagazie.FisaMagazie.xsl";
        private const string _outputFile = "FisaMagazie.html";

        public FisaMagazieHtmlReportControl()
        {
            InitializeComponent();
            this.fromDateMyDateTimePicker.Value = DateTime.Today.AddMonths(-1);
            this.toDateMyDateTimePicker.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
            this.productBindingSource.DataSource = NomenclatorsModelMethods.ProductMethods.GetActiveProducts();
        }

        private void runReportMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.fisaMagazie = new DAL.Reports.FisaMagazie.FisaMagazie();
                // read xls transformation file
                Assembly _assembly = Assembly.GetAssembly(typeof(GUI.Properties.Resources));
                Stream _stream = _assembly.GetManifestResourceStream(_xslFile);

                this.fisaMagazie.PrepareReportData(SecurityLogic.GetLoggedUserNameAndRole(),
                    this.CurrentRow().ProductName, this.CurrentRow().id,
                    this.fromDateMyDateTimePicker.Value.Value, this.toDateMyDateTimePicker.Value.Value);

                FisaMagazieLogic.CalculateRunningStock(this.fisaMagazie);

                this.RunReport(this.fisaMagazie, _stream, _outputFile);
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Error);
            }
        }

        private Product CurrentRow()
        {
            return (Product)this.productBindingSource.Current;
        }
    }
}
