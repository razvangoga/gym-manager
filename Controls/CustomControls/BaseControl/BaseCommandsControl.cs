using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MyControls.CustomControls.BaseControl
{
    public delegate void Close_ButtonClick(object sender, EventArgs e);
    public delegate void Filter_ButtonClick(object sender, EventArgs e);
    public delegate void Info_ButtonClick(object sender, EventArgs e);
    public delegate void Print_ButtonClick(object sender, EventArgs e);

    public partial class BaseCommandsControl : UserControl
    {
        #region public members
        public event Close_ButtonClick Close_ButtonClick = null;
        public event Filter_ButtonClick Filter_ButtonClick = null;
        public event Info_ButtonClick Info_ButtonClick = null;
        public event Print_ButtonClick Print_ButtonClick = null; 
        #endregion

        public BaseCommandsControl()
        {
            InitializeComponent();
        }

        #region enable / disable buttons
        public bool EnablePrint
        {
            set
            {
                this.printMyRibbonMenuButton.Enabled = value;
                this.printMyRibbonMenuButton.Visible = value;
            }
        }

        public bool EnableInfoAudit
        {
            set
            {
                this.infoAuditMyRibbonMenuButton.Enabled = value;
                this.infoAuditMyRibbonMenuButton.Visible = value;
            }
        }

        public bool EnableFilter
        {
            set
            {
                this.filterMyRibbonMenuButton.Enabled = value;
                this.filterMyRibbonMenuButton.Visible = value;
            }
        }

        public void EnableCommandButtons(bool bIsEnabled)
        {
            this.closeMyRibbonMenuButton.Enabled = bIsEnabled;
            this.infoAuditMyRibbonMenuButton.Enabled = bIsEnabled;
            this.printMyRibbonMenuButton.Enabled = bIsEnabled;
            this.filterMyRibbonMenuButton.Enabled = bIsEnabled;
        }

        public void SetFilterButtonText(string p_sFilterButtonText)
        {
            this.filterMyRibbonMenuButton.Text = p_sFilterButtonText;
            this.commandsToolTip.SetToolTip(this.filterMyRibbonMenuButton, p_sFilterButtonText);
        }
        #endregion

        #region button click events
        private void closeMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnCloseClick(e);
        }

        private void infoAuditMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnInfoClick(e);
        }

        private void printMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnPrintClick(e);
        }

        private void filterMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnFilterClick(e);
        } 
        #endregion

        #region on button click methods
        public void OnCloseClick(EventArgs e)
        {
            if (this.closeMyRibbonMenuButton.Enabled)
            {
                if (this.Close_ButtonClick != null)
                {
                    Close_ButtonClick(this, e);
                }
            }
        }

        public void OnInfoClick(EventArgs e)
        {
            if (this.infoAuditMyRibbonMenuButton.Enabled)
            {
                if (this.Info_ButtonClick != null)
                {
                    Info_ButtonClick(this, e);
                }
            }
        }

        public void OnPrintClick(EventArgs e)
        {
            if (this.printMyRibbonMenuButton.Enabled)
            {
                if (this.Print_ButtonClick != null)
                {
                    Print_ButtonClick(this, e);
                }
            }
        }

        public void OnFilterClick(EventArgs e)
        {
            if (this.filterMyRibbonMenuButton.Enabled)
            {
                if (this.Filter_ButtonClick != null)
                {
                    Filter_ButtonClick(this, e);
                }
            }
        } 
        #endregion
    }
}
