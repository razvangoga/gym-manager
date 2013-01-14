using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL.Security;
using DAL.Logic;
using DAL.Models.Nomenclators;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Nomenclators.Clients
{
    public partial class ClientsControl : BaseControl
    {
        public ClientsControl()
        {
            InitializeComponent();
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();
            this.baseBindingSource.DataSource = Session.Clients;
        }

        protected override void SaveEditAfterActions()
        {
            base.SaveEditAfterActions();
            NomenclatorsModelMethods.ClientMethods.EditClient(this.CurrentRow());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            NomenclatorsModelMethods.ClientMethods.AddClient(this.CurrentRow());
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                NomenclatorsModelMethods.ClientMethods.DeleteClient(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected new Client CurrentRow()
        {
            return (Client)base.CurrentRow();
        }
    }
}
