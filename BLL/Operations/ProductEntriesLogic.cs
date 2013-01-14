using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;
using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;

namespace BLL.Operations
{
    public class ProductEntriesLogic
    {
        public static void CheckProductEntry(Product_Entry p_productEntry)
        {
            if (p_productEntry.EntryPrice <= 0)
                throw new Exception("Pretul de achizitie nu poate fi 0 sau negativ!");
            if (p_productEntry.EntryQuantity == 0)
                throw new Exception("Cantitatea de intrare nu poate fi 0!");
        }

        public static void SaveEntryDataOnProduct(Product_Entry p_productEntry)
        {
            Product _product = NomenclatorsModelMethods.ProductMethods.GetProductById(p_productEntry.Product_id);

            if (_product.LastPurchaseDate.HasValue
                && _product.LastPurchaseDate.Value.CompareTo(p_productEntry.ProductEntryDate) > 0)
            return;

            _product.LastPurchaseDate = p_productEntry.ProductEntryDate;
            _product.LastPurchasePrice = p_productEntry.EntryPrice;

            ModelLogic.AddAuditDataEdit(_product, Session.LoggedUser.id);

            NomenclatorsModelMethods.ProductMethods.EditProduct(_product);
        }
    }
}
