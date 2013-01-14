using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models.Nomenclators
{
    partial class Subscription_Type
    {
        partial void OnCreated()
        {
            this._HasUnilimitedEntries = true;
            this._Price = 0;
            this._EntryNumber = null;
            this._IsActive = true;
        }
    }
}
