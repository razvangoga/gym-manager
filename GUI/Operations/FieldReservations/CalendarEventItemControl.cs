using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL.Nomenclators;
using BLL.RightsMangement;
using BLL.Operations;
using DAL.Models.Operations;
using DAL.Models.Nomenclators;
using MyControls.Logic;
using MyControls.WindowsControls;

namespace GUI.Operations.FieldReservations
{
    public partial class CalendarEventItemControl : UserControl
    {
        public event EventHandler RefreshEventsList;
        public FieldReservationsScheduleControl _FieldReservationsScheduleControl;

        #region Members
        private List<Field_Reservation> _fieldReservations = new List<Field_Reservation>();
        private Field _field = null;
        private DateTime _startDate;
        private int _nHourNumber = 1;
        private Label _messageStrip = null;
        RightsManagementLogic _accessRights = new RightsManagementLogic(22);
        private bool _bIsCanceledEventList = false;
        #endregion

        #region Constructors
        public CalendarEventItemControl()
        {
            InitializeComponent();
            this.Height = 60;
        }

        public CalendarEventItemControl(Label p_messageStrip, Field p_field, DateTime p_startDate, bool p_bIsCanceledEventList)
            : this()
        {
            this._messageStrip = p_messageStrip;
            this._field = p_field;
            this._startDate = p_startDate;
            this._bIsCanceledEventList = p_bIsCanceledEventList;
        }

        public CalendarEventItemControl(int p_nHourNumber, Label p_messageStrip, Field p_field, DateTime p_startDate, bool p_bIsCanceledEventList)
            : this(p_messageStrip, p_field, p_startDate, p_bIsCanceledEventList)
        {
            this._nHourNumber = p_nHourNumber;
            this.FormattingActions();
        }

        public CalendarEventItemControl(Field_Reservation p_fieldReservation, Label p_messageStrip, Field p_field, DateTime p_startDate, bool p_bIsCanceledEventList)
            : this(p_messageStrip, p_field, p_startDate, p_bIsCanceledEventList)
        {
            this._fieldReservations.Add(p_fieldReservation);
            this.FormattingActions();
        } 
        #endregion

        public void AddFieldReservation(Field_Reservation p_fieldReservation, FieldReservationsScheduleControl p_FieldReservationsScheduleControl)
        {
            this._fieldReservations.Add(p_fieldReservation);
            this._FieldReservationsScheduleControl = p_FieldReservationsScheduleControl;
            this.FormattingActions();
        }

        #region Event Handlers
        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._FieldReservationsScheduleControl != null)
                this._FieldReservationsScheduleControl._canRefresh = false;
            this.NewObject();
            if (this._FieldReservationsScheduleControl != null)
                this._FieldReservationsScheduleControl._canRefresh = true;
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._FieldReservationsScheduleControl != null)
                this._FieldReservationsScheduleControl._canRefresh = false;
            this.EditObject((Field_Reservation)((myLabel)((ToolStripMenuItem)sender).Owner.Tag).Tag);
            if (this._FieldReservationsScheduleControl != null)
                this._FieldReservationsScheduleControl._canRefresh = true;
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._FieldReservationsScheduleControl != null)
                this._FieldReservationsScheduleControl._canRefresh = false;
            this.DeleteObject((Field_Reservation)((myLabel)sender).Tag, (myLabel)((ToolStripMenuItem)sender).Tag);
            if (this._FieldReservationsScheduleControl != null)
                this._FieldReservationsScheduleControl._canRefresh = true;
        }

        private void veziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._FieldReservationsScheduleControl != null)
                this._FieldReservationsScheduleControl._canRefresh = false;
            this.ViewObject((Field_Reservation)((myLabel)((ToolStripMenuItem)sender).Owner.Tag).Tag);
            if (this._FieldReservationsScheduleControl != null)
                this._FieldReservationsScheduleControl._canRefresh = true;

        }

        private void anuleazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetCancelStatus((Field_Reservation)((myLabel)((ToolStripMenuItem)sender).Owner.Tag).Tag);
        }

        private void Label_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                editContextMenuStrip.Tag = sender;
                editContextMenuStrip.Show(this.PointToScreen(e.Location));
            }
        }
        #endregion

        #region Formatting Methods
        private void FormattingActions()
        {
            this.SetHeight();
            this.SetMenuItems();

            this.SuspendLayout();
            this.Controls.Clear();
            if (this._fieldReservations.Count == 0)
            {
                myLabel _label = new myLabel();
                _label.BorderStyle = BorderStyle.FixedSingle;
                _label.Size = new Size(100, 20);
                _label.Dock = DockStyle.Fill;
                _label.Visible = true;
                _label.TextAlign = ContentAlignment.MiddleCenter;
                _label.MouseClick += new MouseEventHandler(Label_MouseClick);
                this.SetDesctriptionText(null, _label);
                this.FormatLabelByReservationStatus(null, _label);
                this.Controls.Add(_label);
            }
            else
            {
                for (int i = 0; i < this._fieldReservations.Count; i++)
                {
                    myLabel _label = new myLabel();
                    _label.BorderStyle = BorderStyle.FixedSingle;
                    _label.Size = new Size(100, 20);
                    _label.Dock = this._fieldReservations.Count == 1 ? DockStyle.Fill : DockStyle.Top;
                    _label.Tag = this._fieldReservations[i];
                    _label.Visible = true;
                    _label.TextAlign = ContentAlignment.MiddleCenter;
                    _label.MouseClick += new MouseEventHandler(Label_MouseClick);
                    this.SetDesctriptionText(this._fieldReservations[i], _label);
                    this.FormatLabelByReservationStatus(this._fieldReservations[i], _label);
                    this.Controls.Add(_label);
                }
            }
            this.ResumeLayout();
        }

        private void SetDesctriptionText(Field_Reservation p_fieldReservation, myLabel p_label)
        {
            if (p_fieldReservation != null)
            {
                p_label.Text = FieldReservationsLogic.GetDescriptionText(p_fieldReservation);
            }
            else
            {
                p_label.Text = "Nerezervat";
            }
        }

        private void SetHeight()
        {
            if (this._fieldReservations.Count > 0)
            {
                this.Height = 30 * FieldReservationsLogic.GetHourNumberForFieldReservation(this._fieldReservations[0]);
            }
            else
            {
                this.Height = 30 * this._nHourNumber;
            }
        }

        private void SetMenuItems()
        {
            if (this._bIsCanceledEventList)
            {
                this.adaugaToolStripMenuItem.Enabled = false;
                this.editeazaToolStripMenuItem.Enabled = false;
                this.stergeToolStripMenuItem.Enabled = false;
                this.veziToolStripMenuItem.Enabled = (this._fieldReservations.Count == 0 ? false : true);
                this.anuleazaToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (this._fieldReservations.Count == 0)
                {
                    this.adaugaToolStripMenuItem.Enabled = true;
                    this.editeazaToolStripMenuItem.Enabled = false;
                    this.stergeToolStripMenuItem.Enabled = false;
                    this.veziToolStripMenuItem.Enabled = false;
                    this.anuleazaToolStripMenuItem.Enabled = false;
                }
                else
                {
                    this.adaugaToolStripMenuItem.Enabled = false;
                    this.editeazaToolStripMenuItem.Enabled = true;
                    this.stergeToolStripMenuItem.Enabled = true;
                    this.veziToolStripMenuItem.Enabled = true;
                    this.anuleazaToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void FormatLabelByReservationStatus(Field_Reservation p_fieldReservation, myLabel p_label)
        {
            FieldReservationStatus _fieldReservationStatus = FieldReservationsLogic.GetFieldReservationStatus(p_fieldReservation);

            switch (Convert.ToInt32(_fieldReservationStatus))
            {
                case 1: { MessageStripFormatting.setMessageStripCustomMessage(p_label, p_label.Text, MessageType.Warrning); break; }
                case 2: { MessageStripFormatting.setMessageStripCustomMessage(p_label, p_label.Text, MessageType.Ok); break; }
                case 3: { MessageStripFormatting.setMessageStripCustomMessage(p_label, p_label.Text, MessageType.Message); break; }
                case 4: { MessageStripFormatting.setMessageStripCustomMessage(p_label, p_label.Text, MessageType.Error); break; }
                default: { break; }
            }
        } 
        #endregion

        #region Event Triggers
        public void OnRefreshEventsList()
        {
            if (RefreshEventsList != null)
                RefreshEventsList(this, new EventArgs());
        } 
        #endregion

        #region New/Edit/Delete/View/Cancel Methods
        private void NewObject()
        {
            if (_accessRights.UserHasNew)
            {
                FieldReservationsControl.ShowDialog(null, this._field, this._startDate, this._messageStrip, ViewType.Edit);
                this.OnRefreshEventsList();
            }
            else
            {
                MessageStripFormatting.setMessageStripCustomMessage(this._messageStrip, "Nu aveti drept de adaugare!", MessageType.Warrning);
            }
        }

        private void EditObject(Field_Reservation p_fieldReservation)
        {
            if (_accessRights.UserHasEdit)
            {
                FieldReservationsControl.ShowDialog(p_fieldReservation, this._field, this._startDate, this._messageStrip, ViewType.Edit);
                this.OnRefreshEventsList();
            }
            else
            {
                MessageStripFormatting.setMessageStripCustomMessage(this._messageStrip, "Nu aveti drept de editare!", MessageType.Warrning);
            }

        }

        private void DeleteObject(Field_Reservation p_fieldReservation, myLabel p_label)
        {
            if (_accessRights.UserHasDelete)
            {
                DialogResult dr = MessageBox.Show(string.Format("Stergere rezervare {0} ?", p_label.Text.Trim()),
                    "Info...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dr == DialogResult.Yes)
                {
                    OperationsModelMethods.FieldReservationsMethods.DeleteFieldReservation(p_fieldReservation);
                    this.OnRefreshEventsList();
                }
            }
            else
            {
                MessageStripFormatting.setMessageStripCustomMessage(this._messageStrip, "Nu aveti drept de stergere!", MessageType.Warrning);
            }
        }

        private void ViewObject(Field_Reservation p_fieldReservation)
        {
            FieldReservationsControl.ShowDialog(p_fieldReservation, this._field, this._startDate, this._messageStrip, ViewType.View);
        }

        private void SetCancelStatus(Field_Reservation p_fieldReservation)
        {
            FieldReservationsLogic.SetCancelStatus(p_fieldReservation);
            OperationsModelMethods.FieldReservationsMethods.EditFieldReservation(p_fieldReservation);
        }
        #endregion
    }
}
