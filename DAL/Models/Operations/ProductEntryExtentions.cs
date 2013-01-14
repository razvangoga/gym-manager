using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Models.Nomenclators;

namespace DAL.Models.Operations
{
    partial class Product_Entry
    {
        private string _ProductName = "n/a";

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

        partial void OnProduct_idChanged()
        {
            this._ProductName = NomenclatorsModelMethods.ProductMethods.GetFKValue(this._Product_id);
        }

        partial void OnCreated()
        {
            this._EntryPrice = 0;
            this._EntryQuantity = 0;
            this._ProductEntryDate = DateTime.Now;
        }

        partial void OnLoaded()
        {
            this._ProductName = NomenclatorsModelMethods.ProductMethods.GetFKValue(this._Product_id);            
        }
    }
}
