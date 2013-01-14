using System;
using System.Globalization;
using System.Data.SqlClient;

using DAL.Reports.DailyWarnings.DailyWarningsTableAdapters;

namespace DAL.Reports.DailyWarnings 
{
       
    public partial class DailyWarnings 
    {
        public void PrepareReportData(string p_sUserName, DateTime p_atDate)
        {
            this.Parameters.GetDataForReport(p_sUserName);
            this.ProductsWithNoStock.GetDataForReport();
            this.Report_DailySubscriptionWarnings.GetDataForReport(p_atDate);
        }

        partial class ParametersDataTable
        {
            internal void GetDataForReport(string p_sUserName)
            {
                this.Rows.Clear();

                ParametersRow _row = this.NewParametersRow();
                _row.LoggedUser = p_sUserName;
                _row.ReportName = "Avertizari Zilnice";
                _row.CurrentDate = DateTime.Now.ToString("dd MMM yyyy", new CultureInfo("ro-Ro"));

                this.AddParametersRow(_row);
            }
        }
    
        partial class ProductsWithNoStockDataTable
        {
            private ProductsWithNoStockTableAdapter _tableAdapter = null;

            private ProductsWithNoStockTableAdapter TableAdapter
            {
                get
                {
                    if (_tableAdapter == null)
                        _tableAdapter = new ProductsWithNoStockTableAdapter();
                    return _tableAdapter;
                }
            }

            internal void GetDataForReport()
            {
                try
                {
                    this.TableAdapter.ClearBeforeFill = true;
                    this.TableAdapter.Fill(this);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }
        }
    
        partial class Report_DailySubscriptionWarningsDataTable
        {
            private Report_DailySubscriptionWarningsTableAdapter _tableAdapter = null;

            private Report_DailySubscriptionWarningsTableAdapter TableAdapter
            {
                get
                {
                    if (_tableAdapter == null)
                        _tableAdapter = new Report_DailySubscriptionWarningsTableAdapter();
                    return _tableAdapter;
                }
            }

            internal void GetDataForReport(DateTime p_atDate)
            {
                try
                {
                    this.TableAdapter.ClearBeforeFill = true;
                    this.TableAdapter.Fill(this, p_atDate);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }
        }
    }
}
