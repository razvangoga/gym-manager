using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models.Nomenclators
{
    public partial class Product_Type
    {
        partial void OnCreated()
        {
            this._IsActive = true;
        }
    }
}
