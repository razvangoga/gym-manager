using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models.Nomenclators
{
    public partial class Client
    {
        partial void OnCreated()
        {
            this._DiscountProcent = 0;
            this._IsActive = true;
        }
    }
}
