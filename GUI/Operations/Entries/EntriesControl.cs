using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL.Operations;
using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Operations.Entries
{
    public partial class EntriesControl : BaseControl
    {
        public EntriesControl()
        {
            InitializeComponent();

            this.EnableFilterButton = true;
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();

            this.clientsBindingSource.DataSource = NomenclatorsModelMethods.ClientMethods.GetActiveClients();
            this.entryTypesBindingSource.DataSource = NomenclatorsModelMethods.EntryTypeMethods.GetActiveEntryTypes();
            LoadData(DateTime.Now);
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                try
                {
                    EntriesLogic.CheckPrice(this.CurrentRow());
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
            OperationsModelMethods.EntriesMethods.EditEntry(this.CurrentRow());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            OperationsModelMethods.EntriesMethods.AddEntry(this.CurrentRow());
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                OperationsModelMethods.EntriesMethods.DeleteEntry(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected new Entry CurrentRow()
        {
            return (Entry)base.CurrentRow();
        }

        private void dateFilterMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadData(e.Start);
        }

        private void entry_Type_idmyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.CurrentRow() != null 
                && this.entry_Type_idmyComboBox.Focused
                && this.entry_Type_idmyComboBox.SelectedValue != null)
                this.SetPriceOnEntry();
        }

        private void client_idmyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CurrentRow() != null
                && this.client_idmyComboBox.Focused
                && this.client_idmyComboBox.SelectedValue != null)
                this.SetDiscountOnEntry();
        }

        private void LoadData(DateTime p_date)
        {
            OperationsModelMethods.EntriesMethods.GetDataByDay(p_date);
            this.baseBindingSource.DataSource = Session.Entries;
            MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                string.Format("Intrari din data : {0}", p_date.ToString("dd MMM yyyy")),
                MessageType.Message);
        }

        private void SetPriceOnEntry()
        {
            try
            {
                EntriesLogic.SetPriceOnEntry(this.CurrentRow());
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                    ex.Message, MessageType.Warrning);
            }
        }

        private void SetDiscountOnEntry()
        {
            try
            {
                EntriesLogic.SetDiscountOnEntry(this.CurrentRow());
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                    ex.Message, MessageType.Warrning);
            }
        }
    }
}
