using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models.Operations
{
    partial class Field_Reservation
    {
        partial void OnCreated()
        {
            this._Client_id = -1;
            this._DiscountProcent = 0;
            this._Price = 0;
            this.Field_Reservation_Status_id = 1;
        }
    }
}
