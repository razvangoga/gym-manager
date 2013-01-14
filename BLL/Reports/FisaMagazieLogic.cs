using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Reports.FisaMagazie;

namespace BLL.Reports
{
    public class FisaMagazieLogic
    {
        public static void CalculateRunningStock(FisaMagazie p_fisaMagazie)
        {
            double _nInitialStock = 0;

            if (p_fisaMagazie.InitialStock.Rows.Count > 0)
                _nInitialStock = p_fisaMagazie.InitialStock[0].Stock;

            for (int i = 0; i < p_fisaMagazie.Report_FisaMagazie.Rows.Count; i++)
            {
                FisaMagazie.Report_FisaMagazieRow _crrRow = p_fisaMagazie.Report_FisaMagazie[i];

                _crrRow.StockAfterTransaction = _nInitialStock + _crrRow.EntryQuantity - _crrRow.SalesQuantity;
                _nInitialStock = _crrRow.StockAfterTransaction;
            }
        }
    }
}
