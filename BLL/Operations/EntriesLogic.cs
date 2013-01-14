using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;

namespace BLL.Operations
{
    public class EntriesLogic
    {
        public static void SetPriceOnEntry(Entry p_entry)
        {
            if (p_entry == null)
                return;

            Entry_Type _entryType = NomenclatorsModelMethods.EntryTypeMethods.GetEntryTypeById(p_entry.Entry_Type_id);

            if (_entryType == null)
                throw new Exception("Tipul de intrare selectat nu a fost gasit in baza de date!");

            if (_entryType.Price == 0)
                throw new Exception("Tipul de intrare selectat are pretul 0!");

            p_entry.Price = _entryType.Price;
        }

        public static void SetDiscountOnEntry(Entry p_entry)
        {
            if (p_entry == null)
                return;

            Client _client = NomenclatorsModelMethods.ClientMethods.GetClientById(p_entry.Client_id);

            if (_client == null)
                throw new Exception("Clientul selectat nu a fost gasit in baza de date!");

            p_entry.DiscountProcent = _client.DiscountProcent;
        }

        public static void CheckPrice(Entry p_entry)
        {
            if (p_entry == null)
                return;

            if (p_entry.Price == 0)
                throw new Exception("Intrarea are pretul 0!");
        }
    }
}
