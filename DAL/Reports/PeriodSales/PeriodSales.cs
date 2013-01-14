using System;
using System.Data.SqlClient;

using DAL.Reports.PeriodSales.PeriodSalesTableAdapters;

namespace DAL.Reports.PeriodSales
{
    public partial class PeriodSales
    {
        partial class Report_PeriodSalesDataTable
        {
            private Report_PeriodSalesTableAdapter _tableAdapter = null;

            private Report_PeriodSalesTableAdapter TableAdapter
            {
                get
                {
                    if (_tableAdapter == null)
                        _tableAdapter = new Report_PeriodSalesTableAdapter();
                    return _tableAdapter;
                }
            }

            public void GetDataForReport(DateTime p_fromDate, DateTime p_toDate)
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
