using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using BLL.RightsMangement;
using MyControls.Logic;

namespace MyControls.CustomControls
{
    public partial class OtherSettingsControl : UserControl
    {
        #region events
        public event Event_Close event_Close = null;  
        #endregion

        #region private members
        private Label _MessageStrip = null;
        private RightsManagementLogic rightsManagementLogic = new RightsManagementLogic();
        #endregion

        #region public members
        public RightsManagementLogic AccessRights
        {
            set
            {
                rightsManagementLogic = value;
            }
        }

        public Label MessageStrip
        {
            get { return this._MessageStrip; }
            set
            {
                this._MessageStrip = value;
            }
        } 
        #endregion

        public OtherSettingsControl()
        {
            InitializeComponent();
        }

        #region control events
        private void exitMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            if (event_Close != null)
                event_Close(this);
        }

        private void OtherSettingsControl_Load(object sender, EventArgs e)
        {
            this.GetPrinters();
        }

        private void printersMyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (printersMyComboBox.SelectedItem != null && printersMyComboBox.Focused)
                this.SaveNewPrinter(printersMyComboBox.SelectedItem.ToString());
        } 
        #endregion

        #region miscelaneous methods
        private void SaveNewPrinter(string sPrinterName)
        {
            Properties.Settings.Default.SelectedPrinter = sPrinterName;
            Properties.Settings.Default.Save();
        }

        private void GetPrinters()
        {
            printersMyComboBox.Items.Clear();

            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                printersMyComboBox.Items.Add(PrinterSettings.InstalledPrinters[i]);
            }

            if (printersMyComboBox.Items.Contains(Properties.Settings.Default.SelectedPrinter))
            {
                printersMyComboBox.SelectedItem = Properties.Settings.Default.SelectedPrinter;
            }
            else
            {
                if (printersMyComboBox.Items.Count > 0)
                {
                    printersMyComboBox.SelectedIndex = 0;
                    this.SaveNewPrinter(printersMyComboBox.SelectedItem.ToString());
                }
                else
                {
                    this.SaveNewPrinter(string.Empty);
                }
            }
        } 
        #endregion
    }
}
