using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models.Security
{
    public partial class User
    {
        partial void OnCreated()
        {
            this._IsActive = true;
        }
    }
}
