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

namespace GUI.Operations.Subscriptions
{
    public partial class SubscriptionsControl : BaseControl
    {
        private bool _bCanSave = true;

        public SubscriptionsControl()
        {
            InitializeComponent();
            this.subscriptionStartDatemyDateTimePicker.Value = DateTime.Today;
            this.subscriptionEndDatemyDateTimePicker.Value = DateTime.Today.AddMonths(1);

            this.fromStartDateDateTimePicker.Value = DateTime.Today.AddMonths(-2).Date;
            this.toStartDateDateTimePicker.Value = DateTime.Today.AddMonths(-1).AddDays(1).Date.AddSeconds(-1);

            this.subscriptionsMyDataGridViewRO.ScrollBars = ScrollBars.Both;

            this.EnableFilterButton = true;

            this.subscriptionEntriesMyDataGridViewRO.EditableGrid = true;
            this.subscriptionEntriesMyDataGridViewRO.AllowUserToAddRows = true;
            this.subscriptionEntriesMyDataGridViewRO.AllowUserToDeleteRows = true;

            this.entryDateDataGridViewTextBoxColumn.ReadOnly = true;
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();

            this.subscriptionTypesBindingSource.DataSource = NomenclatorsModelMethods.SubscriptionTypeMethods.GetActiveSubscriptionTypes();
            this.clientsBindingSource.DataSource = NomenclatorsModelMethods.ClientMethods.GetActiveClients();

            this.LoadData();
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                if (!this._bCanSave)
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                        "Abonamentul nu poate si salvat! Verificati modificarile facute!", MessageType.Warrning);
                    return false;
                }

                try
                {
                    SubscriptionsLogic.CheckSubscription(this.CurrentRow());
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
            this.subscriptionEntriesBindingSource.EndEdit();
            Session.OperationsModel.SubmitChanges();
            this._bCanSave = true;
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            this.subscriptionEntriesBindingSource.EndEdit();
            Session.OperationsModel.SubmitChanges();
            this._bCanSave = true;
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                Session.OperationsModel.Subscriptions.DeleteOnSubmit(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void DeleteAfterActions()
        {
            base.DeleteAfterActions();
            Session.OperationsModel.SubmitChanges();
        }

        protected override bool EditBeforeActions()
        {
            if (base.EditBeforeActions())
            {
                if (SubscriptionsLogic.CanEditSubscription(this.CurrentRow()))
                {
                    return true;
                }
                else
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                        "Abonamentul a expirat sau numarul maxim de intrari a fost atins!", MessageType.Warrning);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        protected override void CancelAfterActions()
        {
            base.CancelAfterActions();
            this._bCanSave = true;
        }

        protected new Subscription CurrentRow()
        {
            return (Subscription)base.CurrentRow();
        }

        private Subscription_Entry CurrentSubscriptionEntryRow()
        {
            return (Subscription_Entry)this.subscriptionEntriesBindingSource.Current;
        }

        private void SetPriceOnSubscription()
        {
            try
            {
                SubscriptionsLogic.SetPriceEntryNumberOnSubscription(this.CurrentRow());
                this._bCanSave = true;
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                    ex.Message, MessageType.Warrning);
                this._bCanSave = false;
            }
        }

        private void SetDiscountOnSubscription()
        {
            try
            {
                SubscriptionsLogic.SetDiscountOnSubscription(this.CurrentRow());
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                    ex.Message, MessageType.Warrning);
            }
        }

        private void SetDateInterval(DateTime p_date)
        {
            SubscriptionsLogic.SetDateInterval(this.CurrentRow(), p_date);
            this.subscriptionEndDatemyDateTimePicker.DataBindings[0].ReadValue();
        }

        private void ShowDateSelectonControls(bool p_bShowControls)
        {
            this.fromStartDateDateTimePicker.Enabled = p_bShowControls;
            this.toStartDateDateTimePicker.Enabled = p_bShowControls;
            this.filterDateMyLabel1.Enabled = p_bShowControls;
            this.filterDateMyLabel2.Enabled = p_bShowControls;

            this.fromStartDateDateTimePicker.Visible = p_bShowControls;
            this.toStartDateDateTimePicker.Visible = p_bShowControls;
            this.filterDateMyLabel1.Visible = p_bShowControls;
            this.filterDateMyLabel2.Visible = p_bShowControls;
        }

        private void LoadData()
        {
            try
            {
                if (this.activeRadioButton.Checked)
                {
                    this.baseBindingSource.DataSource = SubscriptionsLogic.LoadSubscriptions(LoadType.ActiveSubscriptions, this.fromStartDateDateTimePicker.Value, this.toStartDateDateTimePicker.Value);
                }
                else
                {
                    this.baseBindingSource.DataSource = SubscriptionsLogic.LoadSubscriptions(LoadType.InactiveSubscriptions, this.fromStartDateDateTimePicker.Value, this.toStartDateDateTimePicker.Value);
                }
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Error);
            }
        }

        private void SetSubscriptionEntryDataGridViewAddNewItem()
        {
            if (this.CurrentRow() == null)
                return;

            if (this.CurrentRow().HasUnilimitedEntries)
                return;

            this.subscriptionEntriesMyDataGridViewRO.AllowUserToAddRows = !(this.CurrentRow().RemainingEntries == 0);
        }

        private void subscription_Type_idmyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CurrentRow() != null
                && this.subscription_Type_idmyComboBox.Focused
                && this.subscription_Type_idmyComboBox.SelectedValue != null)
                this.SetPriceOnSubscription();
        }

        private void client_idmyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CurrentRow() != null
                && this.client_idmyComboBox.Focused
                && this.client_idmyComboBox.SelectedValue != null)
                this.SetDiscountOnSubscription();
        }

        private void subscriptionEntriesMyDataGridViewRO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && this.CurrentSubscriptionEntryRow() != null)
            {
                DialogResult dr =
                    MessageBox.Show(string.Format("Stergere intrare din data {0} ?",
                            this.CurrentSubscriptionEntryRow().EntryDate.ToString("dd MM yyyy hh:mm:ss")), "Info...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (this.CurrentSubscriptionEntryRow().id != 0)
                        Session.OperationsModel.Subscription_Entries.DeleteOnSubmit(this.CurrentSubscriptionEntryRow());
                    SubscriptionsLogic.ChangeRemainingEntriesOnDeleteEntry(this.CurrentRow());
                    this.SetSubscriptionEntryDataGridViewAddNewItem();
                    this.baseBindingSource.ResetCurrentItem();
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void subscriptionEntriesMyDataGridViewRO_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.ToString());
        }

        private void inactiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.inactiveRadioButton.Checked)
            {
                this.ShowDateSelectonControls(true);
                this.LoadData();
            }
        }

        private void activeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.activeRadioButton.Checked)
            {
                this.ShowDateSelectonControls(false);
                this.LoadData();
            }
        }

        private void fromStartDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void toStartDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void subscriptionEntriesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (this.CurrentRow() != null)
            {
                if (this.CurrentRow().HasUnilimitedEntries)
                    return;

                SubscriptionsLogic.ChangeRemainingEntriesOnAddEntry(this.CurrentRow());
                this.SetSubscriptionEntryDataGridViewAddNewItem();
            }
            
        }
    }
}
