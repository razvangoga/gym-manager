using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL.Operations;
using BLL.RightsMangement;
using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Operations.FieldReservations
{
    public partial class FieldReservationsControl : BaseControl
    {
        private List<Field_Reservation> _dataSource = new List<Field_Reservation>();
        private Field _selectedField = null;
        private bool _bIsEdit = true;
        private DateTime _startDate;

        public FieldReservationsControl(Field_Reservation p_field_Reservation, Field p_field, DateTime p_startDate, ViewType p_viewType)
        {
            InitializeComponent();
            this._selectedField = p_field;
            this._startDate = p_startDate;
            if (p_viewType == ViewType.Edit)
            {
                this.baseCommandsControl.Visible = false;
                this.baseMyBindingNavigator.Visible = true;
            }
            else
            {
                this.baseCommandsControl.Visible = true;
                this.baseMyBindingNavigator.Visible = false;
                this._bIsEdit = false;
            }

            if (p_field_Reservation != null)
                this._dataSource.Add(p_field_Reservation);
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();

            this.clientsBindingSource.DataSource = NomenclatorsModelMethods.ClientMethods.GetActiveClients();
            this.fieldBindingSource.DataSource = NomenclatorsModelMethods.FieldMethods.GetActiveFields();
            this.fieldReservationsStatusBindingSource.DataSource = Session.Field_Reservation_Statuses;

            this.baseBindingSource.DataSource = this._dataSource;

            if (this._dataSource.Count == 0)
            {
                this.baseMyBindingNavigator.OnAddClick(new EventArgs());
                this.SetFieldAndDate();
            }
            else
            {
                if (this._bIsEdit)
                    this.baseMyBindingNavigator.OnEditClick(new EventArgs());
            }

            this.listPannel.Width = 0;
        }

        protected override void SaveEditAfterActions()
        {
            base.SaveEditAfterActions();
            OperationsModelMethods.FieldReservationsMethods.EditFieldReservation(this.CurrentRow());
            this.CloseWindow();
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            OperationsModelMethods.FieldReservationsMethods.AddFieldReservation(this.CurrentRow());
            this.CloseWindow();
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                OperationsModelMethods.FieldReservationsMethods.DeleteFieldReservation(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void CancelAfterActions()
        {
            this.CloseWindow();
        }

        protected new Field_Reservation CurrentRow()
        {
            return (Field_Reservation)base.CurrentRow();
        }

        private void field_idmyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetPriceOnFieldreservation();
        }

        private void client_idmyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetDiscountOnFieldReservation();
        }

        private void SetDiscountOnFieldReservation()
        {
            try
            {
                FieldReservationsLogic.SetDiscountOnFieldReservations(this.CurrentRow());
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                    ex.Message, MessageType.Warrning);
            }
        }

        private void SetPriceOnFieldreservation()
        {
            try
            {
                FieldReservationsLogic.SetPriceOnFieldReservations(this.CurrentRow());
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                    ex.Message, MessageType.Warrning);
            }
        }

        private void SetFieldAndDate()
        {
            FieldReservationsLogic.SetFieldandDate(this.CurrentRow(), this._selectedField, this._startDate);
        }

        private void CloseWindow()
        {
            this.baseCommandsControl.EnableCommandButtons(true);
            this.baseCommandsControl.OnCloseClick(new EventArgs());
        }

        public static void ShowDialog(Field_Reservation p_field_Reservation, Field p_field, DateTime p_startDate, Label p_messageStrip, ViewType p_viewType)
        {
            Form _form = new Form();
            _form.Size = new Size(800, 600);
            _form.StartPosition = FormStartPosition.CenterScreen;
            _form.FormBorderStyle = FormBorderStyle.None;

            FieldReservationsControl _fieldReservationsControl = new FieldReservationsControl(p_field_Reservation, p_field, p_startDate, p_viewType);
            _fieldReservationsControl.Dock = DockStyle.Fill;
            _fieldReservationsControl.AccessRights = new RightsManagementLogic(22);
            _fieldReservationsControl.baseCommandsControl.Close_ButtonClick += new Close_ButtonClick(baseCommandsControl_Close_ButtonClick);
            _fieldReservationsControl.MessageStrip = p_messageStrip;

            _form.Controls.Add(_fieldReservationsControl);
            _form.ShowDialog();
        }

        static void baseCommandsControl_Close_ButtonClick(object sender, EventArgs e)
        {
            ((Form)((UserControl)sender).Parent.Parent.Parent.Parent.Parent).Close();
        }
    }

    public enum ViewType
    {
        Edit = 1,
        View = 2
    }
}
