using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;

namespace BLL.Operations
{
    public class SubscriptionsLogic
    {
        public static void SetPriceEntryNumberOnSubscription(Subscription p_subscription)
        {
            Subscription_Type _subscriptionType = NomenclatorsModelMethods.SubscriptionTypeMethods.GetSubscriptionTypeById(p_subscription.Subscription_Type_id);

            if (_subscriptionType == null)
                throw new Exception("Tipul de abonament selectat nu a fost gasit in baza de date!");

            if (_subscriptionType.Price == 0)
                throw new Exception("Tipul de abonament selectat are pretul 0!");

            if (!_subscriptionType.HasUnilimitedEntries && _subscriptionType.EntryNumber == 0)
                throw new Exception("Abonamentul are intrari limitate, dar numarul de intrari este 0!");

            if (_subscriptionType.HasUnilimitedEntries)
            {
                p_subscription.Price = _subscriptionType.Price;
                p_subscription.HasUnilimitedEntries = true;
                p_subscription.EntryNumber = null;
                p_subscription.RemainingEntries = null;
            }
            else
            {
                if (p_subscription.RemainingEntries.HasValue && p_subscription.RemainingEntries > _subscriptionType.EntryNumber)
                    throw new Exception("Tipul de abonament nou selectat are mai putin intrari decat numarul de intrari ramase!");

                p_subscription.Price = _subscriptionType.Price;
                p_subscription.HasUnilimitedEntries = false;
                p_subscription.EntryNumber = _subscriptionType.EntryNumber;
                if (!p_subscription.RemainingEntries.HasValue)
                    p_subscription.RemainingEntries = _subscriptionType.EntryNumber;
            }
        }

        public static void SetDiscountOnSubscription(Subscription p_subscription)
        {
            Client _client = NomenclatorsModelMethods.ClientMethods.GetClientById(p_subscription.Client_id);

            if (_client == null)
                throw new Exception("Clientul selectat nu a fost gasit in baza de date!");

            p_subscription.DiscountProcent = _client.DiscountProcent;
        }

        public static void SetDateInterval(Subscription p_subscription, DateTime p_startDate)
        {
            p_subscription.SubscriptionEndDate = p_startDate.AddMonths(1);
        }

        public static void CheckSubscription(Subscription p_subscription)
        {
            if (p_subscription.Price == 0)
                throw new Exception("Pretul abonamenului nu poate fi 0!");

            if (p_subscription.SubscriptionStartDate.CompareTo(p_subscription.SubscriptionEndDate) > 0)
                throw new Exception("Intervalul de valabilitate al abonamentului nu este corect!");
        }

        public static ISingleResult<Subscription> LoadSubscriptions(LoadType p_loadType, DateTime p_fromDate, DateTime p_toDate)
        {
            if (p_loadType == LoadType.ActiveSubscriptions)
            {
                return Session.OperationsModel.Subscriptions_GetActive();
            }
            else
            {
                return Session.OperationsModel.Subscriptions_GetInactive(p_fromDate, p_toDate);
            }
        }

        public static bool CanEditSubscription(Subscription p_subscription)
        {
            if (p_subscription == null)
                return false;

            if (p_subscription.SubscriptionStartDate.CompareTo(DateTime.Now) > 0 ||
                p_subscription.SubscriptionEndDate.CompareTo(DateTime.Now) < 0)
                return false;

            if (p_subscription.HasUnilimitedEntries)
                return true;

            if (!p_subscription.HasUnilimitedEntries && p_subscription.RemainingEntries > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ChangeRemainingEntriesOnAddEntry(Subscription p_subscription)
        {
            if (p_subscription == null)
                return;

            if (p_subscription.HasUnilimitedEntries || !p_subscription.RemainingEntries.HasValue)
                return;

            try
            {
                p_subscription.RemainingEntries--;
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        public static void ChangeRemainingEntriesOnDeleteEntry(Subscription p_subscription)
        {
            if (p_subscription == null)
                return;

            if (p_subscription.HasUnilimitedEntries || !p_subscription.RemainingEntries.HasValue)
                return;

            p_subscription.RemainingEntries++;
        }
    }

    public enum LoadType
    {
        ActiveSubscriptions,
        InactiveSubscriptions
    }
}
