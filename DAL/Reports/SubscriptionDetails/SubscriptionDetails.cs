using System;
using System.Globalization;
using System.Data.SqlClient;

using DAL.Reports.SubscriptionDetails.SubscriptionDetailsTableAdapters;

namespace DAL.Reports.SubscriptionDetails
{
    public partial class SubscriptionDetails
    {
        public void PrepareReportData(string p_sUserName, DateTime p_fromDate, DateTime p_toDate)
        {
            this.Parameters.GetDataForReport(p_sUserName, p_fromDate, p_toDate);
            this.Report_SubscriptionDetails.GetDataForReport(p_fromDate, p_toDate);
        }

        partial class ParametersDataTable
        {
            internal void GetDataForReport(string p_sUserName, DateTime p_fromDate, DateTime p_toDate)
            {
                this.Rows.Clear();

                ParametersRow _row = this.NewParametersRow();
                _row.LoggedUser = p_sUserName;
                _row.ReportName = "Detalii Abonamente";
                _row.FromDate = p_fromDate.ToString("dd MMM yyyy", new CultureInfo("ro-Ro"));
                _row.ToDate = p_toDate.ToString("dd MMM yyyy", new CultureInfo("ro-Ro"));

                this.AddParametersRow(_row);
            }
        }
    
        partial class Report_SubscriptionDetailsDataTable
        {
            private Report_SubscriptionDetailsTableAdapter _tableAdapter = null;

            private Report_SubscriptionDetailsTableAdapter TableAdapter
            {
                get
                {
                    if (_tableAdapter == null)
                        _tableAdapter = new Report_SubscriptionDetailsTableAdapter();
                    return _tableAdapter;
                }
            }

            internal void GetDataForReport(DateTime p_fromDate, DateTime p_toDate)
            {
                try
                {
                    this.TableAdapter.ClearBeforeFill = true;
                    this.TableAdapter.Fill(this, p_fromDate, p_toDate);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }
        }
    }
}
