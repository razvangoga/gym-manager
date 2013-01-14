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

namespace GUI.Nomenclators.Fields
{
    public partial class FieldsControl : BaseControl
    {
        public FieldsControl()
        {
            InitializeComponent();
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();
            this.baseBindingSource.DataSource = Session.Fields;
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                try
                {
                    FieldsLogic.CheckPrice(this.CurrentRow());
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
            NomenclatorsModelMethods.FieldMethods.EditField(this.CurrentRow());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            NomenclatorsModelMethods.FieldMethods.AddField(this.CurrentRow());
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                NomenclatorsModelMethods.FieldMethods.DeleteField(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected new Field CurrentRow()
        {
            return (Field)base.CurrentRow();
        }
    }
}
