using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Models.Nomenclators;

namespace DAL.Models.Operations
{
    public partial class Entry
    {
        private string _EntryType = "n/a";
        private string _ClientName = "n/a";

        public string EntryType
        {
            get
            {
                return this._EntryType;
            }
            set
            {
                this._EntryType = value;
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

        partial void OnEntry_Type_idChanged()
        {
            this._EntryType = NomenclatorsModelMethods.EntryTypeMethods.GetFKValue(this._Entry_Type_id);
        }

        partial void OnClient_idChanged()
        {
            this._ClientName = NomenclatorsModelMethods.ClientMethods.GetFKValue(this._Client_id);
        }

        partial void OnCreated()
        {
            this._DiscountProcent = 0;
            this._EntryDate = DateTime.Now;
            this._Client_id = -1;
            this._Price = 0;
        }

        partial void OnLoaded()
        {
            this._EntryType = NomenclatorsModelMethods.EntryTypeMethods.GetFKValue(this._Entry_Type_id);
            this._ClientName = NomenclatorsModelMethods.ClientMethods.GetFKValue(this._Client_id);            
        }
    }
}
