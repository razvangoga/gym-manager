using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL.Nomenclators;
using DAL.Logic;
using DAL.Models.Nomenclators;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Nomenclators.SubscriptionTypes
{
    public partial class SubscriptionTypesControl : BaseControl
    {
        public SubscriptionTypesControl()
        {
            InitializeComponent();
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();
            this.baseBindingSource.DataSource = Session.Subscription_Types;
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                try
                {
                    SubscriptionTypesLogic.CheckPrice(this.CurrentRow());
                    return true;
                }
                catch (Exception ex)
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                        ex.Message, MessageType.Warrning);
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
            NomenclatorsModelMethods.SubscriptionTypeMethods.EditSubscriptionType(this.CurrentRow());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            NomenclatorsModelMethods.SubscriptionTypeMethods.AddSubscriptionType(this.CurrentRow());
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                NomenclatorsModelMethods.SubscriptionTypeMethods.DeleteSubscriptionType(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected new Subscription_Type CurrentRow()
        {
            return (Subscription_Type)base.CurrentRow();
        }

        private void SetEntryNumberTextboxReadOnly(bool p_bIsReadOnly)
        {
            this.entryNumbermyTextBox.ReadOnly = p_bIsReadOnly;
            this.entryNumbermyTextBox.TabStop = !p_bIsReadOnly;
        }

        private void hasUnilimitedEntriesmyCheckBox_OnCheckChangedActions(object sender, EventArgs e)
        {
            if (this.hasUnilimitedEntriesmyCheckBox.Focused)
            {
                this.SetEntryNumberTextboxReadOnly(this.hasUnilimitedEntriesmyCheckBox.Checked);
                SubscriptionTypesLogic.SetEntryNumber(this.CurrentRow(), this.hasUnilimitedEntriesmyCheckBox.Checked);
            }
        }
    }
}
