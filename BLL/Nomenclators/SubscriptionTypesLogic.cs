using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;

namespace BLL.Nomenclators
{
    public class SubscriptionTypesLogic
    {
        public static void CheckPrice(Subscription_Type p_subscriptionType)
        {
            if (p_subscriptionType.Price == 0)
                throw new Exception("Abonamentul are pretul 0!");
        }

        public static void CheckEntryNumber(Subscription_Type p_subscriptionType)
        {
            if (!p_subscriptionType.HasUnilimitedEntries && p_subscriptionType.EntryNumber == 0)
                throw new Exception("Abonamentul are intrari limitate, dar numarul de intrari este 0!");
        }

        public static void SetEntryNumber(Subscription_Type p_subscriptionType, bool p_bHasUnlimitedEntries)
        {
            byte? _nEntryNumber = null;

            if (!p_bHasUnlimitedEntries)
                _nEntryNumber = 0;

            p_subscriptionType.EntryNumber = _nEntryNumber;
        }
    }
}
