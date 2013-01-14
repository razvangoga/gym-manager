using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DAL.Models.Nomenclators;
using DAL.Reports.PeriodStock;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;
using MyControls.WindowsControls.PivotTableColumns;

namespace GUI.Reports.PeriodStock
{
    public partial class PeriodStockPivotControl : BasePivotControl
    {
        private string sReportTitle = string.Empty;
        List<PivotTableDataColumn> pivotTableDataColumns = new List<PivotTableDataColumn>();

        public PeriodStockPivotControl()
        {
            InitializeComponent();

            this.atDateMyDateTimePicker.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
            this.allProductsMyCheckBox.CheckAlign = ContentAlignment.MiddleLeft;
            this.productBindingSource.DataSource = NomenclatorsModelMethods.ProductMethods.GetActiveProducts();
        }

        private void runReportMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            int _nProductId = this.allProductsMyCheckBox.Checked ? 0 : this.CurrentRow().id;

            try
            {
                if (this.allProductsMyCheckBox.Checked)
                {
                    this.sReportTitle = string.Format("Stoc produse la data '{0}'",
                        this.atDateMyDateTimePicker.Value.Value.ToString("dd MMM yyyy"));
                }
                else
                {
                    this.sReportTitle = string.Format("Stoc produs '{1}'la data '{0}'",
                        this.atDateMyDateTimePicker.Value.Value.ToString("dd MMM yyyy"),
                        this.CurrentRow().ProductName);
                }

                this.periodStock.Report_ProductStock.GetDataForReport(_nProductId, this.atDateMyDateTimePicker.Value.Value);

                this.reportAxPivotTable.Visible = false;
                this.RunReport();
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Error);
                return;
            }
        }

        private void allProductsMyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.allProductsMyCheckBox.Focused)
                this.productsMyComboBox.ReadOnly = this.allProductsMyCheckBox.Checked;
        }

        protected override void LoadReportData(DoWorkEventArgs e)
        {
            base.LoadReportData(e);

            pivotTableDataColumns.Clear();

            pivotTableDataColumns.Add(new PivotTableDataColumn(this.periodStock.Report_ProductStock.StockColumn, PivotTableDataColumn.PivotTableDataColumnType.DataAxis, "Stoc", true, "0.00"));

            pivotTableDataColumns.Add(new PivotTableDataColumn(this.periodStock.Report_ProductStock.ProductTypeColumn, PivotTableDataColumn.PivotTableDataColumnType.RowAxis, "Categorie", true));
            pivotTableDataColumns.Add(new PivotTableDataColumn(this.periodStock.Report_ProductStock.ProductNameColumn, PivotTableDataColumn.PivotTableDataColumnType.RowAxis, "Produs", true));

            this.reportAxPivotTable.DataSource = (msdatasrc.DataSource)PivotTableMiscelaneous.ConvertToRecordset(this.periodStock.Report_ProductStock);

            this.GenerateReportFormat(pivotTableDataColumns);
        }

        protected override void AfterDataLoadWork(RunWorkerCompletedEventArgs e)
        {
            base.AfterDataLoadWork(e);
            this.ShowPivotTable(true);
            this.SetReportTitle(sReportTitle);
        }

        private Product CurrentRow()
        {
            return (Product)this.productBindingSource.Current;
        }
    }
}
