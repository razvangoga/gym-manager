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

namespace GUI.Security.Roles
{
    public partial class RolesControl : BaseControl
    {
        private bool _bLoadComplete = false;

        public RolesControl()
        {
            InitializeComponent();

            this.rolesAccessRightsMyDataGridViewRO.EditableGrid = true;
            this.rolesAccessRightsMyDataGridViewRO.AllowUserToAddRows = true;
            this.rolesAccessRightsMyDataGridViewRO.AllowUserToDeleteRows = true;

            this.accessRightidDataGridViewTextBoxColumn.ReadOnly = false;
            this.hasNewDataGridViewCheckBoxColumn.ReadOnly = false;
            this.hasEditDataGridViewCheckBoxColumn.ReadOnly = false;
            this.hasDeleteDataGridViewCheckBoxColumn.ReadOnly = false;
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();

            this.dataGridAccessRightsBindingSource.DataSource = from ar in Session.SecurityModel.Access_Rights
                                                                orderby ar.Description
                                                                select ar;
            
            this.baseBindingSource.DataSource = Session.SecurityModel.Roles;

            this._bLoadComplete = true;
        }

        protected override void SaveEditAfterActions()
        {
            base.SaveEditAfterActions();
            this.rolesAccessRightsBindingSource.EndEdit();
            Session.SecurityModel.SubmitChanges();
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            this.rolesAccessRightsBindingSource.EndEdit();
            Session.SecurityModel.SubmitChanges();
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                bool _canSave = SecurityLogic.CanSaveRole(this.CurrentRow());

                if (!_canSave)
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                        "Exista un drept de access dublat pentru acest rol! Salvare anulata!", MessageType.Warrning);
                }

                return _canSave;
            }
            else
            {
                return false;
            }
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                Session.SecurityModel.Roles.DeleteOnSubmit(this.CurrentRow());
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
            Session.SecurityModel.SubmitChanges();
        }

        protected new Role CurrentRow()
        {
            return (Role)base.CurrentRow();
        }

        private Roles_Access_Right CurrentRowRoleAccessRight()
        {
            return (Roles_Access_Right)this.rolesAccessRightsBindingSource.Current;
        }

        private void rolesAccessRightsMyDataGridViewRO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && this.CurrentRowRoleAccessRight() != null)
            {
                DialogResult dr =
                    MessageBox.Show(string.Format("Stergere drept de access la modulul '{0}' ?",
                            SecurityModelMethods.AccessRightsMethods.GetAccessRightDescription(this.CurrentRowRoleAccessRight().Access_Right_id)), "Info...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if(this.CurrentRowRoleAccessRight().id != 0)
                        Session.SecurityModel.Roles_Access_Rights.DeleteOnSubmit(this.CurrentRowRoleAccessRight());
                    this.baseBindingSource.ResetCurrentItem();
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void rolesAccessRightsMyDataGridViewRO_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.ToString());
        }

        private void rolesAccessRightsMyDataGridViewRO_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!this._bLoadComplete)
                return;

            if (e.ColumnIndex == 0)
            {
                try
                {
                    int _nAccessRightId = Convert.ToInt32(this.rolesAccessRightsMyDataGridViewRO[e.ColumnIndex, e.RowIndex].Value);
                    SecurityLogic.CheckIfRoleAlreadyHasAccessRight(this.CurrentRow(), SecurityModelMethods.AccessRightsMethods.GetAccessRightById(_nAccessRightId));
                    this.CurrentRowRoleAccessRight().CanSaveRow = true;
                }
                catch (Exception ex)
                {
                    this.CurrentRowRoleAccessRight().CanSaveRow = false;
                    MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip, ex.Message, MessageType.Warrning);
                }
            }
            else
            {
                SecurityLogic.SetUpdateMarkers(this.CurrentRowRoleAccessRight());
            }
        }
    }
}
