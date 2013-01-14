using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

using DAL;
using DAL.Logic;

namespace DAL.Models.Security
{
    public partial class Roles_Access_Right
    {
        private bool _canSaveRow = true;

        public bool CanSaveRow
        {
            get
            {
                return this._canSaveRow;
            }
            set
            {
                this._canSaveRow = value;
            }
        }

        partial void OnCreated()
        {
            ModelLogic.AddAuditDataAdd(this, Session.LoggedUser.id);
            this._canSaveRow = true;
        }

        public void Detach()
        {
            this.PropertyChanged = null;
            this.PropertyChanging = null;
            this.Role = default(Role);
            this.Access_Right = default(Access_Right);
        }
    }
}
