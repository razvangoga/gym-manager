using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Models.Nomenclators;

namespace DAL.Models.Operations
{
    partial class Product_Sale
    {
        private string _ProductName = "n/a";
        private string _ClientName = "n/a";

        public string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this._ProductName = value;
            }
        }

        public string ClientName
        {
            get
            {
                return this._ClientName;
            }
            set
            {
                this._ClientName = value;
            }
        }

        partial void OnProduct_idChanged()
        {
            this._ProductName = NomenclatorsModelMethods.ProductMethods.GetFKValue(this._Product_id);
        }

        partial void OnClient_idChanged()
        {
            this._ClientName = NomenclatorsModelMethods.ClientMethods.GetFKValue(this._Client_id);
        }

        partial void OnCreated()
        {
            this._DiscountProcent = 0;
            this._Client_id = -1;
            this._SalesPrice = 0;
            this._SalesQuantity = 0;
            this._ProductSalesDate = DateTime.Now;
        }

        partial void OnLoaded()
        {
            this._ProductName = NomenclatorsModelMethods.ProductMethods.GetFKValue(this._Product_id);
            this._ClientName = NomenclatorsModelMethods.ClientMethods.GetFKValue(this._Client_id);
        }
    }
}
