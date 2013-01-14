using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using BLL.InfoAudit;
using BLL.RightsMangement;
using BLL.Security;
using DAL;
using DAL.Logic;
using Helpers.GeneralOperations;
using MyControls.Logic;
using MyControls.WindowsControls;
using MyControls.CustomControls;

namespace MyControls.CustomControls.BaseControl
{
    public partial class BaseControl : UserControl
    {
        #region global declarations
        private Label lblMessageStrip = null;
        private Control firstFocusControl = null;
        private Control lastFocusControl = null;
        private bool bIsDefinitionControl = true;
        protected bool bIsAdd = false;
        protected bool bIsEdit = false;

        private string sSuccessFullSaveMessage = null;
        private string sSuccessFullDeleteMessage = null;

        private string sObjectName = null;

        private RightsManagementLogic rightsManagementLogic = new RightsManagementLogic();

        public event Event_Close event_Close = null;
        public event Event_Start_Edit event_Start_Edit = null;
        public event Event_Finish_Edit event_Finish_Edit = null;

        private bool bIsFirstLoad = true;

        private ControlDisplayTypeOnEdit _controlDisplayTypeOnEdit = ControlDisplayTypeOnEdit.SideBySide;
        private CurrentShowStatus _nextShowStatus = CurrentShowStatus.ListVisible;
        private bool _bHasCustomDisplaySettings = false;
        #endregion

        #region public get / set
        public Label MessageStrip
        {
            get
            {
                return this.lblMessageStrip;
            }
            set
            {
                this.lblMessageStrip = value;
            }
        }

        public RightsManagementLogic AccessRights
        {
            get
            {
                return this.rightsManagementLogic;
            }
            set
            {
                this.rightsManagementLogic = value;
                EnableNavigationButtonsByAccessRights(value);
            }
        }

        public Control FirstFocusControl
        {
            get
            {
                return this.firstFocusControl;
            }
            set
            {
                this.firstFocusControl = value;
            }
        }

        public Control LastFocusControl
        {
            get
            {
                return this.lastFocusControl;
            }
            set
            {
                this.lastFocusControl = value;
            }
        }

        public bool DefinitionControl
        {
            get { return this.bIsDefinitionControl; }
            set { this.bIsDefinitionControl = value; }
        }

        public string SaveMessage
        {
            get
            {
                return this.sSuccessFullSaveMessage;
            }
            set
            {
                this.sSuccessFullSaveMessage = value;
            }
        }

        public string DeleteMessage
        {
            get
            {
                return this.sSuccessFullDeleteMessage;
            }
            set
            {
                this.sSuccessFullDeleteMessage = value;
            }
        }

        public string ObjectName
        {
            get { return sObjectName; }
            set
            {
                sObjectName = value;
            }
        }

        public bool EnableFilterButton
        {
            set
            {
                this.baseCommandsControl.EnableFilter = value;
            }
        }
        public bool EnableInfoAuditButton
        {
            set
            {
                this.baseCommandsControl.EnableInfoAudit = value;
            }
        }

        public bool EnablePrintButton
        {
            set
            {
                this.baseCommandsControl.EnablePrint = value;
            }
        }

        public ControlDisplayTypeOnEdit ControlDisplayTypeOnEdit
        {
            get
            {
                return this._controlDisplayTypeOnEdit;
            }
            set
            {
                this._controlDisplayTypeOnEdit = value;
                if (Miscelanious.IsDesignMode())
                    this.ChangeVisualizationMode(this._nextShowStatus);
            }
        }

        public bool HasCustomDisplaySettings
        {
            get
            {
                return this._bHasCustomDisplaySettings;
            }
            set
            {
                this._bHasCustomDisplaySettings = value;
            }
        }
        #endregion

        #region constructor
        public BaseControl()
        {
            InitializeComponent();
            EnableNavigationButtonsByAccessRights(this.rightsManagementLogic);
            this.baseCommandsControl.EnablePrint = false;
            this.baseCommandsControl.EnableFilter = false;
        }
        #endregion

        #region binding navigator events
        protected void baseMyBindingNavigator_AddNewItem_ButtonClick(object sender, NavigatorArgs e)
        {
            if (!AddBeforeActions())
            {
                e.Cancel = true;
            }
            else
            {
                if (event_Start_Edit != null)
                    event_Start_Edit(this);

                this.bIsAdd = true;
                this.LockUnlockDetailControls(true);

                MessageStripFormatting.setMessageStrip(MessageStrip);

                this.ChangeVisualizationMode(CurrentShowStatus.DetailsVisible);
                if (this.firstFocusControl != null)
                    this.firstFocusControl.Select();

                try
                {
                    this.baseBindingSource.AddNew();
                    ModelLogic.AddAuditDataAdd(this.CurrentRow(), Session.LoggedUser.id);
                }
                catch (Exception ex)
                {
                    FileOperations.WriteToExceptionLog(string.Format("{0} Custom Control Add Item.", this.GetPrimaryKeyValue().ToString()), ex.Message);
                    throw ex;
                }

                AddAfterActions();
            }
        }

        protected void baseMyBindingNavigator_CancelItem_ButtonClick(object sender, NavigatorArgs e)
        {
            if (this.CurrentRow() != null)
            {
                if (event_Finish_Edit != null)
                    event_Finish_Edit(this);

                DialogResult askOnCancel = MessageBox.Show("Doriti anularea modificarilor facute pana acum ?", "Atentie...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (askOnCancel == DialogResult.Yes)
                {
                    if (!CancelBeforeActions())
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        try
                        {
                            SecurityLogic.LockedObjectsLogis.RemoveLockFromObject(this.rightsManagementLogic.ModuleId,
                                this.GetPrimaryKeyValue());
                        }
                        catch (Exception ex)
                        {
                            e.Cancel = true;
                            MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, ex.Message, MessageType.Error);
                            return;
                        }

                        MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, string.Format("{0} anulata.",
                            this.bIsEdit ? "Editare" : "Adaugare"),
                            MessageType.Message);

                        this.baseBindingSource.CancelEdit();
                        if(this.CurrentRow() != null)
                            ModelLogic.CancelModifications(this.CurrentRow());

                        LockUnlockDetailControls(false);
                        this.bIsAdd = false;
                        this.bIsEdit = false;
                        CancelAfterActions();
                        
                        if(this.CurrentRow() != null)
                            this.baseBindingSource.ResetCurrentItem();

                        this.ChangeVisualizationMode(CurrentShowStatus.ListVisible);
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }

        }

        protected void baseMyBindingNavigator_DeleteItem_ButtonClick(object sender, NavigatorArgs e)
        {
            if (this.CurrentRow() != null)
            {
                DialogResult askOnDelete = MessageBox.Show("Doriti stergerea obiectului selectat ?", "Atentie...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (askOnDelete == DialogResult.Yes)
                {

                    if (!DeleteBeforeActions())
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        try
                        {
                            //((DataRowView)this.baseBindingSource.Current).Row.Delete();
                            this.baseBindingSource.Remove(this.CurrentRow());
                        }
                        catch (Exception ex)
                        {
                            FileOperations.WriteToExceptionLog(string.Format("{0} Custom Control Delete Item.", this.GetType().ToString()), ex.Message, this.GetPrimaryKeyValue().ToString());
                            throw;
                        }
                        DeleteAfterActions();

                        if (sSuccessFullDeleteMessage != null)
                            MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, this.sSuccessFullDeleteMessage, MessageType.Ok);
                    }
                }
                else
                {
                    MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, "Stergere anulata!", MessageType.Ok);
                }

            }
            else
            {
                MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, string.Format("Nu exista '{0}' pentru stergere!", (sObjectName == null ? "Obiectul" : sObjectName)), MessageType.Message);
                e.Cancel = true;
            }
        }

        protected void baseMyBindingNavigator_EditItem_ButtonClick(object sender, NavigatorArgs e)
        {
            if (CurrentRow() != null)
            {
                if (!EditBeforeActions())
                {
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        SecurityLogic.LockedObjectsLogis.CheckLockOnObject(this.rightsManagementLogic.ModuleId, this.GetPrimaryKeyValue());
                        SecurityLogic.LockedObjectsLogis.SetLockOnObject(this.rightsManagementLogic.ModuleId, this.GetPrimaryKeyValue());
                    }
                    catch (Exception ex)
                    {
                        e.Cancel = true;
                        MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, ex.Message, MessageType.Error);
                        return;
                    }

                    if (event_Start_Edit != null)
                        event_Start_Edit(this);

                    if (this.baseBindingSource.Current != null)
                    {
                        this.bIsEdit = true;
                        this.LockUnlockDetailControls(true);
                        MessageStripFormatting.setMessageStrip(MessageStrip);

                        this.ChangeVisualizationMode(CurrentShowStatus.DetailsVisible);
                        if (this.firstFocusControl != null)
                            this.firstFocusControl.Select();

                        ModelLogic.AddAuditDataEdit(this.CurrentRow(), Session.LoggedUser.id);
                        EditAfterActions();
                    }
                }
            }
            else
            {
                MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, string.Format("Nu exista '{0}' pentru editare!", (sObjectName == null ? "Obiectul" : sObjectName)), MessageType.Message);
                e.Cancel = true;
            }
        }

        protected void baseMyBindingNavigator_SaveItem_ButtonClick(object sender, NavigatorArgs e)
        {
            if (this.CurrentRow() != null)
            {
                if (event_Finish_Edit != null)
                    event_Finish_Edit(this);

                if (!SaveBeforeActions())
                {
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        this.baseBindingSource.EndEdit();
                        SecurityLogic.LockedObjectsLogis.RemoveLockFromObject(this.rightsManagementLogic.ModuleId, this.GetPrimaryKeyValue());
                    }
                    catch (Exception ex)
                    {
                        e.Cancel = true;
                        FileOperations.WriteToExceptionLog(string.Format("{0} Custom Control Save Item.", this.GetType().ToString()), ex.Message, this.GetPrimaryKeyValue().ToString());
                        MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, ex.Message, MessageType.Error);
                        return;
                    }

                    if(this.bIsAdd)
                        SaveNewAfterActions();

                    if (this.bIsEdit)
                        SaveEditAfterActions();

                    FinalizingActions();
                    this.LockUnlockDetailControls(false);
                    this.bIsAdd = false;
                    this.bIsEdit = false;

                    if (sSuccessFullSaveMessage != null)
                        MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, this.sSuccessFullSaveMessage, MessageType.Ok);

                    this.ChangeVisualizationMode(CurrentShowStatus.ListVisible);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region virtual after / before and other actions
        protected virtual bool SaveBeforeActions()
        {
            try
            {
                if (!Miscelanious.IsDesignMode())
                    ModelLogic.VerifyRowValues(this.CurrentRow());
            }
            catch (Exception)
            {
                this.baseErrorProvider.UpdateBinding();
                return false;
            }

            try
            {
                return ModelLogic.CheckUnique(this.CurrentRow());
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Warrning);
                return false;
            }

            return true;
        }

        protected virtual void SaveNewAfterActions()
        {
            return;
        }

        protected virtual void SaveEditAfterActions()
        {
            return;
        }

        protected virtual void FinalizingActions()
        {
            return;
        }

        protected virtual bool DeleteBeforeActions()
        {
            try
            {
                return ModelLogic.CanDelete(this.CurrentRow());
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Warrning);
                return false;
            }
        }

        protected virtual void DeleteAfterActions()
        {
            return;
        }

        protected virtual bool CancelBeforeActions()
        {
            return true;
        }

        protected virtual void CancelAfterActions()
        {
            this.baseBindingSource.ResetCurrentItem();
            return;
        }

        protected virtual bool EditBeforeActions()
        {
            return true;
        }

        protected virtual void EditAfterActions()
        {
            return;
        }

        protected virtual bool AddBeforeActions()
        {
            return true;
        }

        protected virtual void AddAfterActions()
        {
            return;
        }

        protected virtual void AfterControlLoad()
        {
            this.ChangeVisualizationMode(this._nextShowStatus);
            return;
        }

        protected virtual void OnPrintButtonClickActions()
        {
            return;
        }

        protected virtual void OnFilterClickActions()
        {
            return;
        }
        #endregion

        #region rights management
        private void EnableNavigationButtonsByAccessRights(RightsManagementLogic moduleAccessRights)
        {
            this.baseMyBindingNavigator.PanelAdd = moduleAccessRights.UserHasNew;
            this.baseMyBindingNavigator.PanelEditing = moduleAccessRights.UserHasEdit;
            this.baseMyBindingNavigator.PanelDeleteing = moduleAccessRights.UserHasDelete;
        }
        #endregion

        #region lock / unlock controls
        /// <summary>
        /// lock all detail controls for data integrity
        /// </summary>
        /// <param name="bLockControls">true to unlock controls, false to lock them</param>
        private void LockUnlockDetailControls(bool bLockControls)
        {
            if (bIsDefinitionControl)
            {
                this.LockPannelControls(bLockControls, this.detailsPannel);

                if (this.bIsAdd || this.bIsEdit)
                {
                    this.LockPannelControls(!bLockControls, this.filterPanel);
                    this.LockPannelControls(!bLockControls, this.gridPanel);
                }
            }
            else
            {
                foreach (Control c in baseGroupBox.Controls)
                {
                    if (c != this.navigationPanel && (c is Panel || c is GroupBox))
                        this.LockPannelControls(bLockControls, c);
                }
            }
        }

        private void LockPannelControls(bool bLockControls, Control containerControl)
        {

            foreach (Control c in containerControl.Controls)
            {
                if (c is Panel || c is GroupBox)
                {
                    LockPannelControls(bLockControls, c);
                    continue;
                }

                if ((c is myLabel) || (c.Tag != null ? c.Tag.ToString() : string.Empty) == MyControls.Properties.Resources.Unlocked)
                {
                    if (c is myComboBox && ((myComboBox)c).MessageStrip == null)
                        ((myComboBox)c).MessageStrip = this.MessageStrip;
                    continue;
                }

                if (c is FarsiLibrary.Win.FATabStrip)
                {
                    for (int i = 0; i < ((FarsiLibrary.Win.FATabStrip)c).Items.Count; i++)
                    {
                        FarsiLibrary.Win.FATabStripItem itm = ((FarsiLibrary.Win.FATabStrip)c).Items[i];
                        if ((itm.Tag != null ? itm.Tag.ToString() : string.Empty) != MyControls.Properties.Resources.Unlocked)
                        {
                            foreach (Control cc in itm.Controls)
                            {
                                if (cc is Panel || cc is GroupBox)
                                {
                                    LockPannelControls(bLockControls, cc);
                                    continue;
                                }

                                if ((cc is myLabel) || (cc.Tag != null ? cc.Tag.ToString() : string.Empty) == MyControls.Properties.Resources.Unlocked)
                                    continue;

                                if (cc is myComboBox)
                                {
                                    ((myComboBox)cc).ReadOnly = !bLockControls;
                                    if (((myComboBox)cc).MessageStrip == null)
                                        ((myComboBox)cc).MessageStrip = this.MessageStrip;
                                    continue;
                                }

                                if (cc is myTextBox)
                                { ((myTextBox)cc).ReadOnly = !bLockControls; continue; }

                                if (cc is myCheckBox)
                                { ((myCheckBox)cc).ReadOnly = !bLockControls; continue; }

                                if (cc is myDateTimePicker)
                                { ((myDateTimePicker)cc).ReadOnly = !bLockControls; continue; }

                                cc.Enabled = bLockControls;

                            }
                        }
                    }
                    continue;
                }

                if (c is myComboBox)
                {
                    ((myComboBox)c).ReadOnly = !bLockControls;
                    if (((myComboBox)c).MessageStrip == null)
                        ((myComboBox)c).MessageStrip = this.MessageStrip;
                    continue;
                }

                if (c is myTextBox)
                { ((myTextBox)c).ReadOnly = !bLockControls; continue; }

                if (c is myCheckBox)
                { ((myCheckBox)c).ReadOnly = !bLockControls; continue; }

                if (c is myDateTimePicker)
                { ((myDateTimePicker)c).ReadOnly = !bLockControls; continue; }

                c.Enabled = bLockControls;
            }
        }

        private void ChangeVisualizationMode(CurrentShowStatus p_nextShowStatus)
        {
            if (this._controlDisplayTypeOnEdit == ControlDisplayTypeOnEdit.Alternative)
            {
                if (p_nextShowStatus == CurrentShowStatus.DetailsVisible)
                {
                    this.detailsParentPanel.Dock = DockStyle.Fill;
                    this.listPannel.Visible = false;
                    this.detailsParentPanel.Visible = true;
                    this._nextShowStatus = CurrentShowStatus.ListVisible;
                    this.baseCommandsControl.SetFilterButtonText("Lista");
                }
                else
                {
                    this.listPannel.Dock = DockStyle.Fill;
                    this.listPannel.Visible = true;
                    this.detailsParentPanel.Visible = false;
                    this._nextShowStatus = CurrentShowStatus.DetailsVisible;
                    this.baseCommandsControl.SetFilterButtonText("Detalii");
                }
            }
            else
            {
                if (!this._bHasCustomDisplaySettings)
                {
                    this.listPannel.Dock = DockStyle.Left;
                    this.listPannel.Width = 240;
                    this.listPannel.Visible = true;
                    this.detailsParentPanel.Visible = true;

                    this._nextShowStatus = CurrentShowStatus.ListVisible;
                }
            }
            if (Miscelanious.IsDesignMode())
                this.Refresh();
        }
        #endregion

        #region get special objects
        /// <summary>
        /// virtual method for returning current binding source row
        /// </summary>
        /// <returns>binding source current item</returns>
        protected virtual object CurrentRow()
        {
            return this.baseBindingSource.Current;
        }

        protected int GetPrimaryKeyValue()
        {
            if (this.CurrentRow() == null)
                throw new Exception("Current row does not exist!");

            if (this.CurrentRow().GetType().GetProperty("id") != null)
            {
                return Convert.ToInt32(this.CurrentRow().GetType().GetProperty("id").GetValue(this.CurrentRow(), null));
            }
            else
            {
                return -1;
            }
        } 
        #endregion

        #region control events
        private void BaseControl_Load(object sender, EventArgs e)
        {
            if (!Miscelanious.IsDesignMode())
            {
                if (bIsFirstLoad)
                {
                    if (this.firstFocusControl != null)
                        this.firstFocusControl.Select();

                    if (this.lastFocusControl != null)
                        this.lastFocusControl.Leave += new EventHandler(lastFocusControl_Leave);
                    bIsFirstLoad = false;
                    LockUnlockDetailControls(false);
                    AfterControlLoad();
                }
            }
        }

        public void BaseControl_KeyUp(object sender, KeyEventArgs e)
        {
            //commnd buttons
            if (e.Control && e.KeyCode == Keys.P)
                this.baseCommandsControl.OnPrintClick(new EventArgs());
            if (e.Control && e.KeyCode == Keys.D)
                this.baseCommandsControl.OnFilterClick(new EventArgs());
            if (e.Control && e.KeyCode == Keys.A)
                this.baseCommandsControl.OnInfoClick(new EventArgs());
            if (e.Control && e.KeyCode == Keys.X)
                this.baseCommandsControl.OnCloseClick(new EventArgs());

            // navigation
            if (e.KeyCode == Keys.F1)
                this.baseMyBindingNavigator.OnFirstClick();
            if (e.KeyCode == Keys.F2)
                this.baseMyBindingNavigator.OnPreviousClick();
            if (e.KeyCode == Keys.F3)
                this.baseMyBindingNavigator.OnNextClick();
            if (e.KeyCode == Keys.F4)
                this.baseMyBindingNavigator.OnLastClick();

            // operations
            if (e.KeyCode == Keys.F5)
                this.baseMyBindingNavigator.OnAddClick(new EventArgs());
            if (e.KeyCode == Keys.F6)
                this.baseMyBindingNavigator.OnDeleteClick(new EventArgs());
            if (e.KeyCode == Keys.F7)
                this.baseMyBindingNavigator.OnEditClick(new EventArgs());
            if (e.KeyCode == Keys.F8)
                this.baseMyBindingNavigator.OnSaveClick(new EventArgs());
            if (e.KeyCode == Keys.F9)
                this.baseMyBindingNavigator.OnCancelClick(new EventArgs());

            //others
            if (e.KeyCode == Keys.F10 && (this.bIsAdd || this.bIsEdit))
                this.OnF10KeyPress();
            if (e.KeyCode == Keys.F11 && (this.bIsAdd || this.bIsEdit))
                this.OnF11KeyPress();
            if (e.KeyCode == Keys.F12 && (this.bIsAdd || this.bIsEdit))
                this.OnF12KeyPress();
        }

        private void lastFocusControl_Leave(object sender, EventArgs e)
        {
            if (this.firstFocusControl != null)
                this.firstFocusControl.Select();
        }

        private void baseCommandsControl_Close_ButtonClick(object sender, EventArgs e)
        {
            if (event_Close != null)
                event_Close(this);
        }

        private void baseCommandsControl_Info_ButtonClick(object sender, EventArgs e)
        {
            if (this.CurrentRow() != null)
            {
                InfoAuditControl.ShowAuditInfo(InfoAudit.ExtractAuditInfoFromRow(this.CurrentRow()));
            }
            else
            {
                MessageStripFormatting.setMessageStripCustomMessage(MessageStrip, string.Format("Nu exista '{0}' pentru vizualizarea informatiilor!", (sObjectName == null ? "Obiectul" : sObjectName)), MessageType.Warrning);
            }
        }

        private void baseCommandsControl_Print_ButtonClick(object sender, EventArgs e)
        {
            this.OnPrintButtonClickActions();
        }

        private void baseCommandsControl_Filter_ButtonClick(object sender, EventArgs e)
        {
            this.ChangeVisualizationMode(this._nextShowStatus);
            this.OnFilterClickActions();
        }

        private void baseBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            this.listGroupBox.Text = string.Format("Lista : {0} Randuri", this.baseBindingSource.Count);
        }
        #endregion

        #region on key press actions
        public virtual void OnF10KeyPress()
        {
            return;
        }

        public virtual void OnF11KeyPress()
        {
            return;
        }

        public virtual void OnF12KeyPress()
        {
            return;
        }
        #endregion
    }

    public class ClosingArgs : EventArgs
    {

    }

    public delegate void Event_Close(object sender);
    public delegate void Event_Start_Edit(object sender);
    public delegate void Event_Finish_Edit(object sender);

    public enum ControlDisplayTypeOnEdit
    {
        SideBySide,
        Alternative
    }

    public enum CurrentShowStatus
    {
        ListVisible,
        DetailsVisible
    }
}