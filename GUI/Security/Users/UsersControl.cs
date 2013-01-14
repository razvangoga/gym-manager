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
using DAL.Models.Security;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Security.Users
{
    public partial class UsersControl : BaseControl
    {
        public UsersControl()
        {
            InitializeComponent();
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();
            
            this.baseMyBindingNavigator.PanelDeleteing = false;

            this.rolesBindingSource.DataSource = Session.Roles;
            this.baseBindingSource.DataSource = Session.Users;
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                if (SecurityLogic.CheckIfPassWordsMatch(this.passMyTextBox.Text.Trim(), this.rePassMyTextBox.Text.Trim()))
                {
                    return true;
                }
                else
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, "Parolele nu coincid!", MessageType.Warrning);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        protected override void SaveEditAfterActions()
        {
            base.SaveEditAfterActions();
            SecurityModelMethods.UserMethods.EditUser(this.CurrentRow(), this.passMyTextBox.Text.Trim());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            SecurityModelMethods.UserMethods.AddUser(this.CurrentRow(), this.passMyTextBox.Text.Trim());
        }

        protected new User CurrentRow()
        {
            return (User)base.CurrentRow();
        }
    }
}
