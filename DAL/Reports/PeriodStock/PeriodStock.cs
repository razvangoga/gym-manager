using System;
using System.Data.SqlClient;

using DAL.Reports.PeriodStock.PeriodStockTableAdapters;

namespace DAL.Reports.PeriodStock
{
    public partial class PeriodStock
    {
        partial class Report_ProductStockDataTable
        {
            private Report_ProductStockTableAdapter _tableAdapter = null;

            private Report_ProductStockTableAdapter TableAdapter
            {
                get
                {
                    if (_tableAdapter == null)
                        _tableAdapter = new Report_ProductStockTableAdapter();
                    return _tableAdapter;
                }
            }

            public void GetDataForReport(int p_nProductId, DateTime p_atDate)
            {
                try
                {
                    this.TableAdapter.ClearBeforeFill = true;
                    this.TableAdapter.Fill(this, p_nProductId, p_atDate);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }
        }
    }
}
