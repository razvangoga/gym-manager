using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models.Nomenclators
{
    public partial class Entry_Type
    {
        partial void OnCreated()
        {
            this._IsActive = true;
            this._Price = 0;
        }
    }
}
