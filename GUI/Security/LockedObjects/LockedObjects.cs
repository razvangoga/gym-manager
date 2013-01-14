using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BLL.Security;
using DAL.Logic;
using DAL.Views.Security;
using MyControls.Logic;

namespace GUI.Security.LockedObjects
{
    public partial class LockedObjects : MyControls.CustomControls.BaseControl.BaseControl
    {
        public LockedObjects()
        {
            InitializeComponent();

            this.EnableFilterButton = false;
            this.EnableInfoAuditButton = false;
        }

        protected override void AfterControlLoad()
        {
            if (!Miscelanious.IsDesignMode())
            {
                base.baseMyBindingNavigator.PanelAdd = false;
                base.baseMyBindingNavigator.PanelEditing = false;

                base.AfterControlLoad();

                this.baseBindingSource.DataSource = SecurityViewMethods.LockedObjectsViewMethods.GetCurrentLockedObjects();
            }
        }

        protected new Locked_Objects_View CurrentRow()
        {
            return (Locked_Objects_View)base.CurrentRow();
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                try
                {
                    SecurityLogic.LockedObjectsLogis.RemoveLockFromObject(this.CurrentRow().ModuleCode, this.CurrentRow().User_id, this.CurrentRow().Pk_Id);
                }
                catch (Exception ex)
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Error);
                }
                return true;
            }
            return false;
        }

        protected override void DeleteAfterActions()
        {
            base.DeleteAfterActions();

            base.baseMyBindingNavigator.PanelAdd = false;
            base.baseMyBindingNavigator.PanelEditing = false;
        }

        protected override bool AddBeforeActions()
        {
            return false;
        }
    }
}

