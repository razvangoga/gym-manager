using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;

namespace BLL.Nomenclators
{
    public class FieldsLogic
    {
        public static void CheckPrice(Field p_fields)
        {
            if (p_fields.Price == 0)
                throw new Exception("Terenul are pretul de inchiriere 0!");
        }
    }
}
