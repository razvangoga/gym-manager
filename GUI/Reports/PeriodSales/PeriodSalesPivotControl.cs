using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DAL.Reports.PeriodStock;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;
using MyControls.WindowsControls.PivotTableColumns;

namespace GUI.Reports.PeriodSales
{
    public partial class PeriodSalesPivotControl : BasePivotControl
    {
        private string sReportTitle = string.Empty;
        List<PivotTableDataColumn> pivotTableDataColumns = new List<PivotTableDataColumn>();

        public PeriodSalesPivotControl()
        {
            InitializeComponent();
            this.fromDateMyDateTimePicker.Value = DateTime.Today.AddMonths(-1);
            this.toMyDateTimePicker.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
        }

        private void runReportMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sReportTitle = string.Format("Vanzari produse in perioada '{0}' - '{1}'",
                    this.fromDateMyDateTimePicker.Value.Value.ToString("dd MMM yyyy"),
                    this.toMyDateTimePicker.Value.Value.ToString("dd MMM yyyy"));

                this.periodSales.Report_PeriodSales.GetDataForReport(this.fromDateMyDateTimePicker.Value.Value, this.toMyDateTimePicker.Value.Value);

                this.reportAxPivotTable.Visible = false;
                this.RunReport();
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Error);
                return;
            }
        }

        protected override void LoadReportData(DoWorkEventArgs e)
        {
            base.LoadReportData(e);

            pivotTableDataColumns.Clear();

            pivotTableDataColumns.Add(new PivotTableDataColumn(this.periodSales.Report_PeriodSales.IncomeColumn, PivotTableDataColumn.PivotTableDataColumnType.DataAxis, "Vanzari", true, "0.00"));

            pivotTableDataColumns.Add(new PivotTableDataColumn(this.periodSales.Report_PeriodSales.ClientNameColumn, PivotTableDataColumn.PivotTableDataColumnType.RowAxis, "Client", true));
            pivotTableDataColumns.Add(new PivotTableDataColumn(this.periodSales.Report_PeriodSales.IncomeTypeColumn, PivotTableDataColumn.PivotTableDataColumnType.RowAxis, "Tip Venit", true));
            pivotTableDataColumns.Add(new PivotTableDataColumn(this.periodSales.Report_PeriodSales.CategoryColumn, PivotTableDataColumn.PivotTableDataColumnType.RowAxis, "Categorie", true));
            pivotTableDataColumns.Add(new PivotTableDataColumn(this.periodSales.Report_PeriodSales.IncomeNameColumn, PivotTableDataColumn.PivotTableDataColumnType.RowAxis, "Venit", true));

            this.reportAxPivotTable.DataSource = (msdatasrc.DataSource)PivotTableMiscelaneous.ConvertToRecordset(this.periodSales.Report_PeriodSales);

            this.GenerateReportFormat(pivotTableDataColumns);
        }

        protected override void AfterDataLoadWork(RunWorkerCompletedEventArgs e)
        {
            base.AfterDataLoadWork(e);
            this.ShowPivotTable(true);
            this.SetReportTitle(sReportTitle);
        }
    }
}
