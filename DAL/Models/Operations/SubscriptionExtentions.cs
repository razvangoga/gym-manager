using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Models.Nomenclators;

namespace DAL.Models.Operations
{
    partial class Subscription
    {
        private string _SubscriptionType = "n/a";
        private string _ClientName = "n/a";

        public string SubscriptionType
        {
            get
            {
                return this._SubscriptionType;
            }
            set
            {
                this._SubscriptionType = value;
            }
        }

        public string ClientName
        {
            get
            {
                return this._ClientName;
            }
            set
            {
                this._ClientName = value;
            }
        }

        partial void OnClient_idChanged()
        {
            this._ClientName = NomenclatorsModelMethods.ClientMethods.GetFKValue(this._Client_id);
        }

        partial void OnSubscription_Type_idChanged()
        {
            this._SubscriptionType = NomenclatorsModelMethods.SubscriptionTypeMethods.GetFKValue(this._Subscription_Type_id);
        }

        partial void OnCreated()
        {
            this._DiscountProcent = 0;
            this._Price = 0;
            this._HasUnilimitedEntries = true;
            this._EntryNumber = null;
            this._RemainingEntries = null;
            this._SubscriptionStartDate = DateTime.Now;
            this._SubscriptionEndDate = DateTime.Now.AddMonths(1);
            this._Client_id = -1;
        }

        partial void OnLoaded()
        {
            this._SubscriptionType = NomenclatorsModelMethods.SubscriptionTypeMethods.GetFKValue(this._Subscription_Type_id);
            this._ClientName = NomenclatorsModelMethods.ClientMethods.GetFKValue(this._Client_id);
        }
    }
}
