using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;
using DAL.Views.Operations;

namespace BLL.Operations
{
    public class ProductSalesLogic
    {
        public static void SetPriceOnProductSale(Product_Sale p_productSale)
        {
            Product _product = NomenclatorsModelMethods.ProductMethods.GetProductById(p_productSale.Product_id);

            if (_product == null)
                throw new Exception("Produsul selectat nu a fost gasit in baza de date!");

            if (_product.SalesPrice == 0)
                throw new Exception("Produsul selectat are pretul 0!");

            p_productSale.SalesPrice = _product.SalesPrice;
        }

        public static void SetDiscountOnProductSale(Product_Sale p_productSale)
        {
            Client _client = NomenclatorsModelMethods.ClientMethods.GetClientById(p_productSale.Client_id);

            if (_client == null)
                throw new Exception("Clientul selectat nu a fost gasit in baza de date!");


            p_productSale.DiscountProcent = _client.DiscountProcent;
        }

        public static void CheckProductSale(Product_Sale p_productSale)
        {
            if (p_productSale.SalesPrice == 0)
                throw new Exception("Pretul de vazare nu poate fi 0!");

            if (p_productSale.SalesQuantity == 0)
                throw new Exception("Cantitatea nu poate fi 0!");
        }

        public static void CheckProductStock(Product_Sale p_productSale)
        {
            double _stock = OperationsViewMethods.ProductsStockViewMethods.GetStocForProduct(p_productSale.Product_id);

            if (_stock < p_productSale.SalesQuantity)
                throw new Exception(string.Format("Stoc insuficient pentu produsul selectat! Incercati sa vindeti {0} buc dintr-un stoc de {1} buc",
                    p_productSale.SalesQuantity,
                    _stock));
        }
    }
}
