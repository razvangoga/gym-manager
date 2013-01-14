using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models.Nomenclators
{
    public partial class Field
    {
        partial void OnCreated()
        {
            this._IsActive = true;
            this._Price = 0;
            this._MinimumRentHours = 2;
        }
    }
}
