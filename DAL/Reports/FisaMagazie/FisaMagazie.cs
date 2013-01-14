using System;
using System.Globalization;
using System.Data.SqlClient;

using DAL.Reports.FisaMagazie.FisaMagazieTableAdapters;

namespace DAL.Reports.FisaMagazie
{
    public partial class FisaMagazie
    {
        public void PrepareReportData(string p_sUserName,string p_sProductName, int p_nProductId, DateTime p_fromDate, DateTime p_toDate)
        {
            this.Parameters.GetDataForReport(p_sUserName, p_sProductName, p_fromDate, p_toDate);
            this.Report_FisaMagazie.GetDataForReport(p_nProductId, p_fromDate, p_toDate);
            this.InitialStock.GetDataForReport(p_nProductId, p_fromDate);
            this.FinalStock.GetDataForReport(p_nProductId, p_toDate);
        }

        partial class FinalStockDataTable
        {
            private FinalStockTableAdapter _tableAdapter = null;

            private FinalStockTableAdapter TableAdapter
            {
                get
                {
                    if (_tableAdapter == null)
                        _tableAdapter = new FinalStockTableAdapter();
                    return _tableAdapter;
                }
            }

            internal void GetDataForReport(int p_nProductId, DateTime p_atDate)
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

        partial class InitialStockDataTable
        {
            private InitialStockTableAdapter _tableAdapter = null;

            private InitialStockTableAdapter TableAdapter
            {
                get
                {
                    if (_tableAdapter == null)
                        _tableAdapter = new InitialStockTableAdapter();
                    return _tableAdapter;
                }
            }

            internal void GetDataForReport(int p_nProductId, DateTime p_atDate)
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

        partial class ParametersDataTable
        {
            internal void GetDataForReport(string p_sUserName, string p_sProductName, DateTime p_fromDate, DateTime p_toDate)
            {
                this.Rows.Clear();

                ParametersRow _row = this.NewParametersRow();
                _row.LoggedUser = p_sUserName;
                _row.ReportName = "Fisa de Magazie";
                _row.FromDate = p_fromDate.ToString("dd MMM yyyy", new CultureInfo("ro-Ro"));
                _row.ToDate = p_toDate.ToString("dd MMM yyyy", new CultureInfo("ro-Ro"));
                _row.ProductName = p_sProductName;

                this.AddParametersRow(_row);
            }
        }

        partial class Report_FisaMagazieDataTable
        {
            private Report_FisaMagazieTableAdapter _tableAdapter = null;

            private Report_FisaMagazieTableAdapter TableAdapter
            {
                get
                {
                    if (_tableAdapter == null)
                        _tableAdapter = new Report_FisaMagazieTableAdapter();
                    return _tableAdapter;
                }
            }

            internal void GetDataForReport(int p_nProductId, DateTime p_fromDate, DateTime p_toDate)
            {
                try
                {
                    this.TableAdapter.ClearBeforeFill = true;
                    this.TableAdapter.Fill(this, p_nProductId, p_fromDate, p_toDate);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }
        }
    }
}
