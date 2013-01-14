using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using BLL.RightsMangement;
using DAL.Logic;
using MyControls.Logic;


namespace MyControls.CustomControls
{
    public partial class DatabaseSettingsControl : UserControl
    {
        #region global declarations
        private Label lblMessageStrip = null;
        private Control firstFocusControl = null;
        private Control lastFocusControl = null;

        private string sCnnString = string.Empty;

        public event Event_Close event_Close = null;
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
        #endregion

        #region constructor
        public DatabaseSettingsControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Read/Test/Write Connection string
        /// <summary>
        /// Reads stored connection string and fills textboxes with relevan data
        /// </summary>
        private void ReadConnectionString()
        {
            Match match;
            Regex regEx;


            Settings.Load();
            sCnnString = Settings.Gray_GymManagerConnectionString;

            regEx = new Regex("Data Source=([^;]*)");
            match = regEx.Match(this.sCnnString);
            if (match.Value != null)
                this.serverMyTextBox.Text = match.Value.Substring(match.Value.IndexOf("=") + 1);

            regEx = new Regex("Initial Catalog=([^;]*)");
            match = regEx.Match(this.sCnnString);
            if (match.Value != null)
                this.databaseMyTextBox.Text = match.Value.Substring(match.Value.IndexOf("=") + 1);

            regEx = new Regex("User ID=([^;]*)");
            match = regEx.Match(this.sCnnString);
            if (match.Value != null)
                this.userMyTextBox.Text = match.Value.Substring(match.Value.IndexOf("=") + 1);

            regEx = new Regex("Password=([^;]*)");
            match = regEx.Match(this.sCnnString);
            if (match.Value != null)
            {
                this.passMyTextBox.Text = match.Value.Substring(match.Value.IndexOf("=") + 1);
                this.passRMyTextBox.Text = this.passMyTextBox.Text;
            }
        }

        /// <summary>
        /// tests the connection with current settings
        /// </summary>
        private bool TestConnectionString()
        {
            string sErrorMsg = null;
            this.errMsgMyTextBox.Visible = false;

            if (!Settings.TestConnection(string.Format(Settings.BareConnectionString,
                 serverMyTextBox.Text.Trim(), userMyTextBox.Text.Trim(), passMyTextBox.Text.Trim(), databaseMyTextBox.Text.Trim()), out sErrorMsg))
            {
                this.errMsgMyTextBox.Text = sErrorMsg;
                MyControls.Logic.MessageStripFormatting.setMessageStripCustomMessage(lblMessageStrip, "Datele de conectare sunt incorecte sau server-ul specificat nu este pornit...", MessageType.Error);
                this.errMsgMyTextBox.Visible = true;
                this.isConnectedPictureBox.BackgroundImage = MyControls.Properties.Resources.NetDrive_disconnect;
                return false;
            }
            else
            {
                MyControls.Logic.MessageStripFormatting.setMessageStripCustomMessage(lblMessageStrip, "Datele de conectare sunt corecte. Puteti salva conexiunea noua...", MessageType.Ok);
                this.errMsgMyTextBox.Visible = false;
                this.isConnectedPictureBox.BackgroundImage = MyControls.Properties.Resources.Netdrive_Connected;
                return true;
            }
        }

        /// <summary>
        /// Writes new connection data to program connection settings
        /// </summary>
        private void WriteNewConnectionString()
        {
            if (verifyFieldCompletion())
            {
                Settings.Gray_GymManagerConnectionString = string.Format(Settings.BareConnectionString,
                    this.serverMyTextBox.Text.Trim(), this.userMyTextBox.Text.Trim(), this.passMyTextBox.Text.Trim(), this.databaseMyTextBox.Text.Trim());
                Settings.Save();
                MyControls.Logic.MessageStripFormatting.setMessageStripCustomMessage(lblMessageStrip, "Datele de conectare au fost salvate...", MessageType.Ok);
            }
        }
        #endregion

        #region controls events methods
        private void testMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            if (verifyFieldCompletion())
                TestConnectionString();
        }

        private void saveMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            if (TestConnectionString())
            {
                WriteNewConnectionString();
            }
        }

        private void exitMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            if (event_Close != null)
                event_Close(this);
        }

        private void DatabaseSettingsControl_Load(object sender, EventArgs e)
        {
            ReadConnectionString();

            this.firstFocusControl = this.serverMyTextBox;
            this.lastFocusControl = this.exitMyRibbonMenuButton;

            if (this.firstFocusControl != null)
                this.firstFocusControl.Select();

            if (this.lastFocusControl != null)
                this.lastFocusControl.Leave += new EventHandler(lastFocusControl_Leave);
        }

        private void lastFocusControl_Leave(object sender, EventArgs e)
        {
            this.firstFocusControl.Select();
        } 
        #endregion

        #region misc methods
        private bool verifyFieldCompletion()
        {
            settingsErrorProvider.Clear();

            bool bNoError = true;

            if (this.serverMyTextBox.Text.Trim().Length == 0)
            {
                settingsErrorProvider.SetError(this.serverMyTextBox, "Camp obligatoriu");
                bNoError = false;
            }

            if (this.databaseMyTextBox.Text.Trim().Length == 0)
            {
                settingsErrorProvider.SetError(this.databaseMyTextBox, "Camp obligatoriu");
                bNoError = false;
            }

            if (this.userMyTextBox.Text.Trim().Length == 0)
            {
                settingsErrorProvider.SetError(this.userMyTextBox, "Camp obligatoriu");
                bNoError = false;
            }

            if (this.passMyTextBox.Text.Trim().Length == 0)
            {
                settingsErrorProvider.SetError(this.passMyTextBox, "Camp obligatoriu");
                bNoError = false;
            }

            if (this.passRMyTextBox.Text.Trim().Length == 0)
            {
                settingsErrorProvider.SetError(this.passRMyTextBox, "Camp obligatoriu");
                bNoError = false;
            }

            if (this.passMyTextBox.Text.Length > 0 && this.passRMyTextBox.Text.Length > 0 && this.passMyTextBox.Text.Trim() != this.passRMyTextBox.Text.Trim())
            {
                this.settingsErrorProvider.SetError(this.passMyTextBox, "Parolele nu sunt identice...");
                this.settingsErrorProvider.SetError(this.passRMyTextBox, "Parolele nu sunt identice...");
                bNoError = false;
            }

            if (!bNoError)
                MyControls.Logic.MessageStripFormatting.setMessageStripCustomMessage(lblMessageStrip, "Completati toate campurile...", MessageType.Warrning);

            return bNoError;
        } 
        #endregion
    }

    public class ClosingArgs : EventArgs
    {

    }

    public delegate void Event_Close(object sender);
}
