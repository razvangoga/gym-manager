using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MyControls.Logic;
using DAL.Logic;
using DAL.Models;
using BLL.LoginLogic;
using BLL.Security;
using GUI.SettingsWindow;

namespace GUI.LoginWindow
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.userMyTextBox.Focus();
            this.Text += string.Format(" {0} vers. {1}", Application.ProductName, Application.ProductVersion);
            MessageStripFormatting.setMessageStrip(loginToolStripStatusLabel);
        }

        private void exitMyButton_Click(object sender, EventArgs e)
        {
            LoginLogic.ExitApplication = true;
            LoginLogic.LoginComplete = false;
            this.Close();
        }

        private void loginMyButton_Click(object sender, EventArgs e)
        {
            MessageStripFormatting.setMessageStrip(this.loginToolStripStatusLabel);

            #region verify credential completion
            if (this.userMyTextBox.Text.Trim().Length == 0)
            {
                loginErrorProvider.SetError(this.userMyTextBox, "Camp obligatoriu...");
            }
            else
            {
                loginErrorProvider.SetError(this.userMyTextBox, string.Empty);
            }

            if (this.passMyTextBox.Text.Trim().Length == 0)
            {
                loginErrorProvider.SetError(this.passMyTextBox, "Camp obligatoriu...");
            }
            else
            {
                loginErrorProvider.SetError(this.passMyTextBox, string.Empty);
            }
            #endregion

            #region verify credential corectness
            try
            {
                if (SecurityLogic.DoLogin(userMyTextBox.Text.Trim(), passMyTextBox.Text.Trim()))
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.loginToolStripStatusLabel, "Autentificare realizata...", MessageType.Ok);
                    this.LoadStaticData();
                }
                else
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.loginToolStripStatusLabel, "Date de autentificare incorecte...", MessageType.Warrning);
                    this.userMyTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.loginToolStripStatusLabel, "Eroare la conectarea cu baza de date...", MessageType.Error);
            }
            #endregion
        }

        private void setariMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            SettingsWindow.SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void loadStaticDataBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Session.LoadStaticData();
        }

        private void loadStaticDataBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            #region continue to main application
            LoginLogic.LoginComplete = true;
            this.Close();
            #endregion
        }

        private void LoadStaticData()
        {
            MessageStripFormatting.setMessageStripCustomMessage(this.loginToolStripStatusLabel, "Incarcare Date...", MessageType.Message);
            this.loginToolStripStatusLabel.Width -= 100;
            this.toolStripProgressBar.Enabled = true;
            this.toolStripProgressBar.Visible = true;
            this.loadStaticDataBackgroundWorker.RunWorkerAsync();
        }
    }
}