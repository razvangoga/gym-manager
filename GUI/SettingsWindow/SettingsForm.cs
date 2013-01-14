using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MyControls.Logic;

namespace GUI.SettingsWindow
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void databaseSettingsControl_event_Close(object sender)
        {
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            MessageStripFormatting.setMessageStrip(this.messageMyLabel);
            this.databaseSettingsControl.MessageStrip = this.messageMyLabel;
        }
    }
}