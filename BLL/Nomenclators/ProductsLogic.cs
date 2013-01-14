using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;

namespace BLL.Nomenclators
{
    public class ProductsLogic
    {
        public static void CheckPrice(Product p_product)
        {
            if (p_product.SalesPrice == 0)
                throw new Exception("Produsul are pretul de vanzare 0!");
        }
    }
}
