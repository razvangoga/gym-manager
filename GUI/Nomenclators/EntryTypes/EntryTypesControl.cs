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

namespace GUI.Nomenclators.EntryTypes
{
    public partial class EntryTypesControl : BaseControl
    {
        public EntryTypesControl()
        {
            InitializeComponent();
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();

            this.baseBindingSource.DataSource = Session.Entry_Types;
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                try
                {
                    EntryTypesLogic.CheckPrice(this.CurrentRow());
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
            NomenclatorsModelMethods.EntryTypeMethods.EditEntryType(this.CurrentRow());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            NomenclatorsModelMethods.EntryTypeMethods.AddEntryType(this.CurrentRow());
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                NomenclatorsModelMethods.EntryTypeMethods.DeleteEntryType(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected new Entry_Type CurrentRow()
        {
            return (Entry_Type)base.CurrentRow();
        }
    }
}
