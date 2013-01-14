using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;

namespace DAL.Views.Operations
{
    public class OperationsViewMethods
    {
        public class ProductsStockViewMethods
        {
            public static double GetStocForProduct(int p_ProductId)
            {
                var _query = from psv in Session.OperationsView.Products_Stock_Views
                             where psv.ProductId == p_ProductId
                             select psv;

                Products_Stock_View _psv = _query.FirstOrDefault();

                if (_psv == null)
                {
                    return 0;
                }
                else
                {
                    return _psv.Stock.Value;
                }

            }
        }

    }
}
