using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Helpers.GeneralOperations;
using Microsoft.Reporting.WinForms;
using MyControls.WindowsControls;

namespace MyControls.CustomControls.BaseControl
{
    public partial class BaseReportViewerControl : UserControl
    {
        #region private members & constants
        private const string _printReportShortSide = "8.27in";
        private const string _printReportLongSide = "11.69in";

        protected Label messageStrip = null;
        protected ReportPageOrientation _reportPageOrientation = ReportPageOrientation.Portret; 
        #endregion

        #region public memebers
        public Label MessageStrip
        {
            get { return this.messageStrip; }
            set
            {
                this.messageStrip = value;
                this.SetComboMessageStrip();
            }
        }

        public ReportPageOrientation ReportPageOrientation
        {
            get { return _reportPageOrientation; }
            set { _reportPageOrientation = value; }
        }

        public ReportViewer BaseReportViewer
        {
            get
            {
                return this.baseReportViewer;
            }
        } 
        #endregion

        public BaseReportViewerControl()
        {
            InitializeComponent();
        }

        private void BaseReportViewerControl_Load(object sender, EventArgs e)
        {
            this.AfterLoadActions();
        }

        protected virtual void AfterLoadActions()
        {
            return;
        }

        private void SetComboMessageStrip()
        {
            foreach (Control c in this.controlsPanel.Controls)
            {
                if (c is myComboBox)
                {
                    ((myComboBox)c).MessageStrip = this.messageStrip;
                }
            }
        }

        #region Report Custom Printing

        #region Public Events

        public EventHandler PrintingEnded;

        #endregion

        #region Protected members

        protected int printCurrentPageIndex;
        protected IList<Stream> printStreams;
        protected string printerName = Properties.Settings.Default.SelectedPrinter;
        protected PrintDocument printDocument;

        #endregion

        private Stream CreatePrintStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            this.printStreams.Add(stream);
            return stream;
        }

        private void ExportReport(LocalReport report)
        {
            string sWidth = string.Empty;
            string sHeight = string.Empty;

            if(this._reportPageOrientation == ReportPageOrientation.Portret)
            {
                sWidth = _printReportShortSide;
                sHeight = _printReportLongSide;
            }
            else
            {
                sWidth = _printReportLongSide;
                sHeight = _printReportShortSide;
            }

            string deviceInfo =
              string.Format("<DeviceInfo>" +
              "  <OutputFormat>PNG</OutputFormat>" +
              "  <PageWidth>{0}</PageWidth>" +
              "  <PageHeight>{1}</PageHeight>" +
              "  <MarginTop>0.0in</MarginTop>" +
              "  <MarginLeft>0.0in</MarginLeft>" +
              "  <MarginRight>0.0in</MarginRight>" +
              "  <MarginBottom>0.0in</MarginBottom>" +
              "  <DpiX>100</DpiX>" +
              "  <DpiY>100</DpiY>" +
              "</DeviceInfo>", sWidth, sHeight);

            Warning[] warnings;
            printStreams = new List<Stream>();
            report.Render("Image", deviceInfo, CreatePrintStream, out warnings);

            foreach (Stream stream in printStreams)
                stream.Position = 0;
            this.printCurrentPageIndex = 0;
        }
        private bool PrintPrepare()
        {
            PrintDialog printDialog = new PrintDialog();

            this.printDocument = new PrintDocument();
            this.printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            this.printDocument.EndPrint += new PrintEventHandler(printDocument_EndPrint);

            printDialog.Document = printDocument;

            printDialog.PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            printDialog.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;
            printDialog.PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            printDialog.PrinterSettings.DefaultPageSettings.Margins.Right = 0;

            if (this._reportPageOrientation == ReportPageOrientation.Portret)
            {
                printDialog.Document.DefaultPageSettings.PaperSize = new PaperSize("A4 Portret", 827, 1169);
            }
            else
            {
                printDialog.Document.DefaultPageSettings.PaperSize = new PaperSize("A4 LandScape", 1169, 827);
            }

            if (printerName == null || printerName.Length == 0)
                throw new Exception("Selectati imprimanta la care se va face tiparirea!");

            printDialog.PrinterSettings.PrinterName = printerName;

            if (!this.printDocument.PrinterSettings.IsValid)
            {
                string msg = String.Format("Can't find printer \"{0}\".",
                  printerName);
                System.Diagnostics.Debug.WriteLine(msg);
                return false;
            }
            return true;
        }
        private void PrintReport()
        {

            if (this.printStreams == null || this.printStreams.Count == 0)
                return;

            if (!this.printDocument.PrinterSettings.IsValid)
            {
                string msg = String.Format("Can't find printer \"{0}\".", printerName);
                System.Diagnostics.Debug.WriteLine(msg);
                return;
            }
            this.printDocument.Print();
        }

        protected void printDocument_PrintPage(object sender, PrintPageEventArgs ev)
        {
            Image pageImage = Image.FromStream(printStreams[printCurrentPageIndex]);
            ev.Graphics.DrawImage(pageImage, 0, 0);

            this.printCurrentPageIndex++;
            ev.HasMorePages = (printCurrentPageIndex < printStreams.Count);
        }
        protected virtual void printDocument_EndPrint(object sender, PrintEventArgs e)
        {
            if (this.PrintingEnded != null)
            {
                this.PrintingEnded(this, null);
            }
        }

        private void baseReportViewer_Print(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.printBackgroundWorker.RunWorkerAsync();
        }

        private void printBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.PrintReportToPrinterSinc();
        }

        public void PrintReportToPrinterAsinc()
        {
            this.printBackgroundWorker.RunWorkerAsync();
        }

        public void PrintReportToPrinterSinc()
        {
            try
            {
                if (!this.PrintPrepare())
                    return;
                this.ExportReport(this.BaseReportViewer.LocalReport);
                this.PrintReport();
            }
            catch (Exception ex)
            {
                FileOperations.WriteToExceptionLog(string.Format("{0} Control Print", this.GetType()), ex.Message);
                throw ex;
            }
        }

        #endregion
    }

    public enum ReportPageOrientation
    {
        Portret,
        LandScape
    }
}
