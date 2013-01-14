using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models.Nomenclators
{
    public partial class Product
    {
        partial void OnCreated()
        {
            this._IsActive = true;
            this._SalesPrice = 0;
        }
    }
}
