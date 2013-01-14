using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.Operations.FieldReservations
{
    public partial class CalendarPeriodItemControl : UserControl
    {
        public CalendarPeriodItemControl()
        {
            InitializeComponent();
            this.periodMyLabel.Text = string.Empty;
            this.BorderStyle = BorderStyle.None;
            this.Height = 15;
        }

        public CalendarPeriodItemControl(DateTime p_fromDate, DateTime p_toDate)
            : this()
        {

            this.periodMyLabel.Text = string.Format("{0} - {1}",
                p_fromDate.ToString("HH:mm"),
                p_toDate.ToString("HH:mm"));
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public CalendarPeriodItemControl(Color p_spacerColor)
            : this()
        {
            this.BackColor = p_spacerColor;
            this.Height = 2;
        }


    }
}
