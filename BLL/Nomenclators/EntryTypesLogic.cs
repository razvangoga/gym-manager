using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;

namespace BLL.Nomenclators
{
    public class EntryTypesLogic
    {
        public static void CheckPrice(Entry_Type p_entryTypes)
        {
            if (p_entryTypes.Price == 0)
                throw new Exception("Tipul de intrare are pretul 0!");
        }
    }
}
