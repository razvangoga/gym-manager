using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;

namespace DAL.Models.Operations
{
    partial class Subscription_Entry 
    {
        partial void OnCreated()
        {
            ModelLogic.AddAuditDataAdd(this, Session.LoggedUser.id);
            this._EntryDate = DateTime.Now;
        }

        public void Detach()
        {
            this.PropertyChanged = null;
            this.PropertyChanging = null;
            this.Subscription = default(Subscription);
        }
    }
}
