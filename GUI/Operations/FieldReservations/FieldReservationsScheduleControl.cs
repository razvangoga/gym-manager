using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL.Operations;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;
using MyControls.CustomControls.BaseControl;

namespace GUI.Operations.FieldReservations
{
    public partial class FieldReservationsScheduleControl : BaseReportViewerContainerControl
    {
        public bool _canRefresh = true;

        #region Members
        private List<Field_Reservation> _displayedReservationList = new List<Field_Reservation>();
        #endregion

        #region Constructors
        public FieldReservationsScheduleControl()
        {
            InitializeComponent();
            this.baseCommandsControl.EnableFilter = true;
            this.baseCommandsControl.SetFilterButtonText("Refresh");
        }
        #endregion

        #region Event Handelers
        private void fieldsMyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.fieldsMyComboBox.Focused)
                this.LoadData();
        }

        private void currentDateMyDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.currentDateMyDateTimePicker.Focused)
                this.LoadData();
        }

        private void FieldReservationsScheduleControl_Load(object sender, EventArgs e)
        {
            this.fieldsBindingSource.DataSource = NomenclatorsModelMethods.FieldMethods.GetActiveFields();
            this.currentDateMyDateTimePicker.Value = DateTime.Today;
            this.GenerateCalendarEntries();
            this.fieldsBindingSource.MoveFirst();
            this.LoadData();
        }

        private void _calendarEventItemControl_RefreshEventsList(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void baseCommandsControl_Filter_ButtonClick(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void activeEntiriesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.activeEntiriesRadioButton.Checked)
                this.LoadData();
        }

        private void canceledRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.canceledRadioButton.Checked)
                this.LoadData();
        }

        private void updateStatusesJobTimer_Tick(object sender, EventArgs e)
        {
            if (_canRefresh)
            {
                OperationsModelMethods.FieldReservationsMethods.UpdateStatuses();
                this.LoadData();
            }
        }
        #endregion

        #region Load & Show Data
        private void LoadData()
        {
            this.ShowHideControlPanels(false);
            if (this.activeEntiriesRadioButton.Checked)
            {
                _displayedReservationList = OperationsModelMethods.FieldReservationsMethods.GetActiveDataForFieldInDay(this.CurrentField().id, this.CurrentDate());
            }
            else
            {
                _displayedReservationList = OperationsModelMethods.FieldReservationsMethods.GetCanceldDataForFieldInDay(this.CurrentField().id, this.CurrentDate());
            }
            this.GenerateCalendarEntries();
            this.GenerateCalendarEvents();
            this.ShowHideControlPanels(true);
        }

        private void GenerateCalendarEntries()
        {
            this.calendarPanel.Controls.Clear();
            this.calendarPanel.SuspendLayout();
            DateTime _calculsDate = new DateTime(2000, 01, 02, 04, 0, 0);

            CalendarPeriodItemControl _emptyCalendarPeriodItemControl = new CalendarPeriodItemControl();
            _emptyCalendarPeriodItemControl.BackColor = Color.LightGray;
            _emptyCalendarPeriodItemControl.Dock = DockStyle.Fill;
            this.calendarPanel.Controls.Add(_emptyCalendarPeriodItemControl);

            for (int i = 0; i < 28; i++)
            {
                if (i % (2 * this.CurrentField().MinimumRentHours) == 0 && i != 0)
                {
                    CalendarPeriodItemControl _spacer = new CalendarPeriodItemControl(Color.LightGray);
                    _spacer.Dock = DockStyle.Top;
                    this.calendarPanel.Controls.Add(_spacer);
                }

                CalendarPeriodItemControl _calendarPeriodItemControl = new CalendarPeriodItemControl(_calculsDate.AddMinutes(-30), _calculsDate);
                _calendarPeriodItemControl.Dock = DockStyle.Top;
                this.calendarPanel.Controls.Add(_calendarPeriodItemControl);

                _calculsDate = _calculsDate.AddMinutes(-30);
            }
            this.calendarPanel.ResumeLayout();
        }

        private void GenerateCalendarEvents()
        {
            this.calendarEntriesPanel.Controls.Clear();
            this.calendarEntriesPanel.SuspendLayout();

            CalendarPeriodItemControl _emptyCalendarPeriodItemControl = new CalendarPeriodItemControl();
            _emptyCalendarPeriodItemControl.BackColor = Color.LightGray;
            _emptyCalendarPeriodItemControl.Dock = DockStyle.Fill;
            this.calendarEntriesPanel.Controls.Add(_emptyCalendarPeriodItemControl);

            int _nLoadedFromDb = 0;
            int _currentHour = 14;
            CalendarEventItemControl _calendarEventItemControl = null;
            List<Control> _list = new List<Control>();

            while (_currentHour != 4)
            {
                if (this._displayedReservationList.Count == 0)
                {
                    _calendarEventItemControl = new CalendarEventItemControl(this.CurrentField().MinimumRentHours, this.MessageStrip, this.CurrentField(),
                                                _currentHour < 14 ? this.CurrentDate().AddDays(1).Date.AddHours(_currentHour) : this.CurrentDate().Date.AddHours(_currentHour),
                                                this.canceledRadioButton.Checked);
                    _calendarEventItemControl._FieldReservationsScheduleControl = this;
                }
                else
                {
                    if (_nLoadedFromDb < this._displayedReservationList.Count)
                    {
                        if (_currentHour < this._displayedReservationList[_nLoadedFromDb].ReservationFromDate.Hour)
                        {
                            _calendarEventItemControl = new CalendarEventItemControl(this.CurrentField().MinimumRentHours, this.MessageStrip, this.CurrentField(),
                                _currentHour < 14 ? this.CurrentDate().AddDays(1).Date.AddHours(_currentHour) : this.CurrentDate().Date.AddHours(_currentHour),
                                this.canceledRadioButton.Checked);
                            _calendarEventItemControl._FieldReservationsScheduleControl = this;
                        }
                        else
                        {
                            List<Field_Reservation> _listForCurrentHour = FieldReservationsLogic.GetReservationsForHour(_currentHour, this._displayedReservationList);

                            _calendarEventItemControl = new CalendarEventItemControl(_listForCurrentHour[0], this.MessageStrip, this.CurrentField(),
                                _currentHour < 14 ? this.CurrentDate().AddDays(1).Date.AddHours(_currentHour) : this.CurrentDate().Date.AddHours(_currentHour),
                                this.canceledRadioButton.Checked);
                            _calendarEventItemControl._FieldReservationsScheduleControl = this;
                            _nLoadedFromDb++;
                            for (int i = 1; i < _listForCurrentHour.Count; i++)
                            {
                                _calendarEventItemControl.AddFieldReservation(_listForCurrentHour[i], this);
                                _nLoadedFromDb++;
                            }
                        }
                    }
                    else
                    {
                        _calendarEventItemControl = new CalendarEventItemControl(this.CurrentField().MinimumRentHours, this.MessageStrip, this.CurrentField(),
                            _currentHour < 14 ? this.CurrentDate().AddDays(1).Date.AddHours(_currentHour) : this.CurrentDate().Date.AddHours(_currentHour),
                            this.canceledRadioButton.Checked);
                        _calendarEventItemControl._FieldReservationsScheduleControl = this;
                    }
                }
                _calendarEventItemControl.Dock = DockStyle.Top;
                _calendarEventItemControl.RefreshEventsList += new EventHandler(_calendarEventItemControl_RefreshEventsList);
                _list.Add(_calendarEventItemControl);

                if (_currentHour != (4 - this.CurrentField().MinimumRentHours))
                {
                    CalendarPeriodItemControl _spacer = new CalendarPeriodItemControl(Color.LightGray);
                    _spacer.Dock = DockStyle.Top;
                    _list.Add(_spacer);
                }

                _currentHour += this.CurrentField().MinimumRentHours;

                if (_currentHour == 24)
                    _currentHour = 0;
            }
            for (int i = _list.Count - 1; i >= 0; i--)
            {
                this.calendarEntriesPanel.Controls.Add(_list[i]);
            }
            this.calendarEntriesPanel.ResumeLayout();
        }

        private void ShowHideControlPanels(bool p_bVisible)
        {
            this.calendarPanel.Visible = p_bVisible;
            this.calendarEntriesPanel.Visible = p_bVisible;
        }
        #endregion

        #region Get Current Methods
        public Field CurrentField()
        {
            return (Field)this.fieldsMyComboBox.SelectedItem;
        }

        public DateTime CurrentDate()
        {
            return this.currentDateMyDateTimePicker.Value.Value;
        }
        #endregion
    }
}
