using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using BLL.LoginLogic;
using BLL.RightsMangement;
using BLL.Security;
using DAL.Logic;
using Helpers.GeneralOperations;
using MyControls;
using MyControls.Logic;
using MyControls.CustomControls;
using MyControls.CustomControls.BaseControl;
using MyControls.WindowsControls;

namespace GUI.MainWindow
{
    public partial class MainWindow : Form
    {
        #region global variables
        private bool bIsMaximized = false;
        private bool bIsMenuExpanded = true;
        #endregion

        #region constructor
        public MainWindow()
        {
            InitializeComponent();
        } 
        #endregion

        #region form controls events

        private void exitMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Doriti inchiderea aplicatiei?", "Inchidere aplicatie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                CloseWindow(true);
        }

        private void maximizeMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            if (bIsMaximized)
            {
                maximizeMyRibbonMenuButton.Image = GUI.Properties.Resources.app;
                bIsMaximized = !bIsMaximized;
                this.mainToolTip.SetToolTip(maximizeMyRibbonMenuButton, GUI.Properties.Resources.MaximizeToolTip);
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                maximizeMyRibbonMenuButton.Image = GUI.Properties.Resources.Undo32;
                bIsMaximized = !bIsMaximized;
                this.mainToolTip.SetToolTip(maximizeMyRibbonMenuButton, GUI.Properties.Resources.MinimizeTooltip);
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reautentificareMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnLogoutClick();
        }

        private void ColapseExpandMenuMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            if (bIsMenuExpanded)
            {
                this.ColapseExpandMenuMyRibbonMenuButton.Image = GUI.Properties.Resources.Forward32;
                this.ColapseExpandMenuMyRibbonMenuButton.Text = "Mareste Meniu";
                this.mainToolTip.SetToolTip(this.ColapseExpandMenuMyRibbonMenuButton, "Mareste Meniu");
                this.menuMainPanel.Enabled = false;
                this.menuMainPanel.Visible = false;
                this.mainTableLayoutPanel.ColumnStyles[0].Width = 32;
                this.userMyLabel.Text = string.Empty;
            }
            else
            {
                this.ColapseExpandMenuMyRibbonMenuButton.Image = GUI.Properties.Resources.Back32;
                this.ColapseExpandMenuMyRibbonMenuButton.Text = "Restrange Meniu";
                this.mainToolTip.SetToolTip(this.ColapseExpandMenuMyRibbonMenuButton, "Restrange Meniu");
                this.menuMainPanel.Enabled = true;
                this.menuMainPanel.Visible = true;
                this.mainTableLayoutPanel.ColumnStyles[0].Width = 275;
                BuildUserDetails();
            }

            bIsMenuExpanded = !bIsMenuExpanded;
        }

        #region tree views events
        private void dataEntryModulesMyTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataEntryModulesMyTreeView_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedModule(((myTreeView)sender).SelectedNode);
        }

        private void dataEntryModulesMyTreeView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenSelectedModule(((myTreeView)sender).SelectedNode);
            }
        }

        private void settingsMyTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void settingsMyTreeView_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedModule(((myTreeView)sender).SelectedNode);
        }

        private void settingsMyTreeView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenSelectedModule(((myTreeView)sender).SelectedNode);
            }
        }

        private void menuMyTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void menuMyTreeView_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedModule(((myTreeView)sender).SelectedNode);
        }

        private void menuMyTreeView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenSelectedModule(((myTreeView)sender).SelectedNode);
            }
        } 
        #endregion

        private void workAreaFaTabStrip_TabStripItemClosed(object sender, EventArgs e)
        {
            ChangeTabStripVisibility(false);
        }

        private void workAreaFaTabStrip_TabStripItemClosing(FarsiLibrary.Win.TabStripItemClosingEventArgs e)
        {
            CloseModule(e.Item, e.Item.Controls[0], false);
        }

        protected void newControl_event_Close(object sender)
        {
            CloseModule(((FarsiLibrary.Win.FATabStripItem)((UserControl)sender).Parent), sender, true);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ApplyStylingToForm();
            this.dsModulesList.Modules.LoadModules(); //load module table

            // show daily report on load
            this.workAreaFaTabStrip.Visible = true;
            AddNewTabStrip(35);
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
            {
                menuXPanderPanelList.XPanderPanels[0].Expand = true;
                menuXPanderPanelList.XPanderPanels[1].Expand = false;
                menuXPanderPanelList.XPanderPanels[2].Expand = false;

                this.dataEntryModulesMyTreeView.Focus();
                this.dataEntryModulesMyTreeView.SelectedNode = this.dataEntryModulesMyTreeView.Nodes[0];

                return;
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                menuXPanderPanelList.XPanderPanels[0].Expand = false;
                menuXPanderPanelList.XPanderPanels[1].Expand = true;
                menuXPanderPanelList.XPanderPanels[2].Expand = false;

                this.reportsMyTreeView.Focus();
                this.reportsMyTreeView.SelectedNode = this.reportsMyTreeView.Nodes[0];

                return;
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                menuXPanderPanelList.XPanderPanels[0].Expand = false;
                menuXPanderPanelList.XPanderPanels[1].Expand = false;
                menuXPanderPanelList.XPanderPanels[2].Expand = true;

                this.settingsMyTreeView.Focus();
                this.settingsMyTreeView.SelectedNode = this.settingsMyTreeView.Nodes[0];

                return;
            }

            if (e.Control && e.KeyCode == Keys.U)
            {
                this.OnLogoutClick();
                return;
            }

            if (e.Control && e.KeyCode == Keys.H)
            {
                this.OnHelpClick();
                return;
            }

            if (this.workAreaFaTabStrip.SelectedItem == null)
                return;

            if (this.workAreaFaTabStrip.SelectedItem.Controls[0] is BaseControl)
            {
                ((BaseControl)this.workAreaFaTabStrip.SelectedItem.Controls[0]).BaseControl_KeyUp((BaseControl)this.workAreaFaTabStrip.SelectedItem.Controls[0], e);
            }

            if (this.workAreaFaTabStrip.SelectedItem.Controls[0] is BaseHtmlViewerControl)
            {
                ((BaseHtmlViewerControl)this.workAreaFaTabStrip.SelectedItem.Controls[0]).BaseHtmlViewerControl_KeyUp((BaseHtmlViewerControl)this.workAreaFaTabStrip.SelectedItem.Controls[0], e);
            }

            if (this.workAreaFaTabStrip.SelectedItem.Controls[0] is BasePivotControl)
            {
                ((BasePivotControl)this.workAreaFaTabStrip.SelectedItem.Controls[0]).BasePivotControl_KeyUp((BasePivotControl)this.workAreaFaTabStrip.SelectedItem.Controls[0], e);
            }

            if (this.workAreaFaTabStrip.SelectedItem.Controls[0] is BaseReportViewerContainerControl)
            {
                ((BaseReportViewerContainerControl)this.workAreaFaTabStrip.SelectedItem.Controls[0]).BaseReportViewerContainerControl_KeyUp((BaseReportViewerContainerControl)this.workAreaFaTabStrip.SelectedItem.Controls[0], e);
            }
        }

        private void helpMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnHelpClick();
        }

        void MainWindow_event_Finish_Edit(object sender)
        {
            this.exitMyRibbonMenuButton.Enabled = true;
        }

        void MainWindow_event_Start_Edit(object sender)
        {
            this.exitMyRibbonMenuButton.Enabled = false;
        }
        #endregion

        #region misc form action methods
        /// <summary>
        /// applies initial stiling to the form
        /// </summary>
        private void ApplyStylingToForm()
        {
            BuildUserDetails();
            MessageStripFormatting.setMessageStrip(messageMyLabel);
            this.workAreaFaTabStrip.Visible = false;
            this.reportsMyTreeView.ExpandAll();
            this.dataEntryModulesMyTreeView.ExpandAll();
            this.settingsMyTreeView.ExpandAll();

            this.dataEntryModulesMyTreeView.Focus();
            this.dataEntryModulesMyTreeView.SelectedNode = this.dataEntryModulesMyTreeView.Nodes[0];
        }

        /// <summary>
        /// builds user name string
        /// </summary>
        public void BuildUserDetails()
        {
            MessageStripFormatting.setMessageStrip(SecurityLogic.GetLoggedUserNameAndRole(), userMyLabel);
        }

        /// <summary>
        /// closes window 
        /// </summary>
        /// <param name="bExitApplication">true app closes, false login window loads</param>
        private void CloseWindow(bool bExitApplication)
        {
            LoginLogic.ExitApplication = bExitApplication;
            this.Close();
        } 

        /// <summary>
        /// change work area tab stip visibility value
        /// true if tabpages count > 0
        /// false if tabpages count = 0
        /// </summary>
        /// <param name="bIsVisible">visibility value</param>
        private void ChangeTabStripVisibility(bool bIsVisible)
        {
            if (workAreaFaTabStrip.Items.Count == 0)
            {
                this.workAreaFaTabStrip.Visible = bIsVisible;
            }
        }

        /// <summary>
        /// add a new tab page to the work area tab strip
        /// </summary>
        /// <param name="sTabName">tab pagename</param>
        /// <param name="sExControlType">tab page inner control type</param>
        private void AddNewTabStrip(int nModuleId)
        {
            MessageStripFormatting.setMessageStrip(this.messageMyLabel);

            ModuleAccess.ModulesList.ModulesRow modulesRow = this.dsModulesList.Modules.FindByid(nModuleId);

            if (modulesRow != null)
            {

                RightsManagementLogic rightsManagement = new RightsManagementLogic(nModuleId);

                if (rightsManagement.UserHasAccess || nModuleId == 1) // harcodare -> 1 = Meniu Help, oricine are acces la help
                {
                    Type tipControl = Type.GetType(modulesRow.control);

                    if (tipControl != null)
                    {
                        if (!modulesRow.isopen)
                        {
                            try
                            {
                                FarsiLibrary.Win.FATabStripItem newTabPage = new FarsiLibrary.Win.FATabStripItem(modulesRow.name, null);
                                newTabPage.BackColor = Color.LightGray;
                                object newControl = Activator.CreateInstance(tipControl);

                                if (typeof(DatabaseSettingsControl).IsInstanceOfType(newControl))
                                {
                                    ((DatabaseSettingsControl)newControl).MessageStrip = this.messageMyLabel;
                                    ((DatabaseSettingsControl)newControl).event_Close += new MyControls.CustomControls.Event_Close(newControl_event_Close);
                                }

                                if (typeof(OtherSettingsControl).IsInstanceOfType(newControl))
                                {
                                    ((OtherSettingsControl)newControl).MessageStrip = this.messageMyLabel;
                                    ((OtherSettingsControl)newControl).event_Close += new MyControls.CustomControls.Event_Close(newControl_event_Close);
                                }

                                if (typeof(BaseControl).IsInstanceOfType(newControl))
                                {
                                    ((BaseControl)newControl).MessageStrip = this.messageMyLabel;
                                    ((BaseControl)newControl).AccessRights = rightsManagement;
                                    ((BaseControl)newControl).event_Close += new MyControls.CustomControls.BaseControl.Event_Close(newControl_event_Close);
                                    ((BaseControl)newControl).event_Start_Edit += new Event_Start_Edit(MainWindow_event_Start_Edit);
                                    ((BaseControl)newControl).event_Finish_Edit += new Event_Finish_Edit(MainWindow_event_Finish_Edit);
                                }

                               if (typeof(BasePivotControl).IsInstanceOfType(newControl))
                               {
                                    ((BasePivotControl)newControl).MessageStrip = this.messageMyLabel;
                                    ((BasePivotControl)newControl).event_Close += new MyControls.CustomControls.BaseControl.Event_Close(newControl_event_Close);
                               }

                                if(typeof(BaseHtmlViewerControl).IsInstanceOfType(newControl))
                                {
                                    ((BaseHtmlViewerControl)newControl).MessageStrip = this.messageMyLabel;
                                    ((BaseHtmlViewerControl)newControl).event_Close += new MyControls.CustomControls.BaseControl.Event_Close(newControl_event_Close);

                                }

                               if (typeof(BaseReportViewerControl).IsInstanceOfType(newControl))
                               {
                                   BaseReportViewerContainerControl rvContainer = new BaseReportViewerContainerControl();
                                   rvContainer.ReportViewerControlType = newControl.GetType().ToString();
                                   rvContainer.event_Close +=new MyControls.CustomControls.BaseControl.Event_Close(newControl_event_Close);
                                   ((BaseReportViewerControl)newControl).Dock = DockStyle.Fill;
                                   rvContainer.AddReportViewerControl((BaseReportViewerControl)newControl);
                                   rvContainer.MessageStrip = this.messageMyLabel;

                                   newControl = rvContainer;
                               }

                               if (typeof(BaseReportViewerContainerControl).IsInstanceOfType(newControl))
                               {
                                   ((BaseReportViewerContainerControl)newControl).MessageStrip = this.messageMyLabel;
                                   ((BaseReportViewerContainerControl)newControl).event_Close += new MyControls.CustomControls.BaseControl.Event_Close(newControl_event_Close);
                               }

                               ((UserControl)newControl).Dock = DockStyle.Fill;
                                newTabPage.Controls.Add((UserControl)newControl);

                                newTabPage.BackColor = Color.LightGray;
                                newTabPage.Tag = modulesRow.id;
                                newTabPage.CanClose = false;

                                workAreaFaTabStrip.AddTab(newTabPage);
                                workAreaFaTabStrip.SelectedItem = newTabPage;

                                modulesRow.isopen = true;
                            }
                            catch (Exception ex)
                            {
                                FileOperations.WriteToExceptionLog("GUI.MainWindow.MainWindow.AddNewTabStrip", ex.ToString(), nModuleId);
                                modulesRow.isopen = false;
                                throw ex;
                            }
                        }
                        else
                        {
                            MessageStripFormatting.setMessageStripCustomMessage(this.messageMyLabel,
                                string.Format("Modulul '{0}' este deja deschis...", modulesRow.name), MessageType.Message);

                            for (int i = 0; i < workAreaFaTabStrip.Items.Count; i++)
                            {
                                if ((int)workAreaFaTabStrip.Items[i].Tag == modulesRow.id)
                                {
                                    workAreaFaTabStrip.SelectedItem = workAreaFaTabStrip.Items[i];
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.messageMyLabel,
                        string.Format("Nu aveti acces la modulul '{0}'...", modulesRow.name), MessageType.Warrning);
                }
            }
            else
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.messageMyLabel,
                    string.Format("Nodul selectat nu contine informatii valide despre modulul asociat..."), MessageType.Error);
            }
        }

        /// <summary>
        /// opens selected node module
        /// </summary>
        private void OpenSelectedModule(TreeNode node)
        {
            ChangeTabStripVisibility(true);
            if (node.Level != 0)
            {
                if (node.Tag != null)
                {
                    if (node.Tag.ToString() != Properties.Resources.ModuleTreeTag 
                        && node.Tag.ToString() != string.Empty)
                    {
                        try
                        {
                            AddNewTabStrip(Convert.ToInt32(node.Tag));
                        }
                        catch (Exception ex)
                        {
                            MessageStripFormatting.setMessageStripCustomMessage(this.messageMyLabel,
                                ex.Message, MessageType.Error);
                        }
                    }
                    else
                    {
                        this.ChangeTabStripVisibility(false);
                    }
                }
            }
            else
            {
                this.ChangeTabStripVisibility(false);
            }
        }

        /// <summary>
        /// on module close logic
        /// </summary>
        /// <param name="tabItem">module tab</param>
        /// <param name="control">module</param>
        /// <param name="bRemoveTabItem">remove tab control from tabstrip colection</param>
        private void CloseModule(FarsiLibrary.Win.FATabStripItem tabItem, object control, bool bRemoveTabItem)
        {
            if (bRemoveTabItem)
            {
                this.workAreaFaTabStrip.Items.Remove(tabItem);
                if (this.workAreaFaTabStrip.Items.Count > 0)
                    this.workAreaFaTabStrip.SelectedItem = this.workAreaFaTabStrip.Items[this.workAreaFaTabStrip.Items.Count - 1];
            }
            if (control is BaseReportViewerContainerControl)
            {
                if (((BaseReportViewerContainerControl)control).ReportViewerControlType.Length > 0)
                {
                    this.dsModulesList.Modules.MarkModuleAsClosed(((BaseReportViewerContainerControl)control).ReportViewerControlType);
                }
                else
                {
                    this.dsModulesList.Modules.MarkModuleAsClosed(control.GetType().ToString());
                }
            }
            else
            {
                this.dsModulesList.Modules.MarkModuleAsClosed(control.GetType().ToString());
            }

            ChangeTabStripVisibility(false);
            MessageStripFormatting.setMessageStrip(this.messageMyLabel);

            if (control is MyControls.CustomControls.DatabaseSettingsControl)
                CloseWindow(false);
        }

        private void OnLogoutClick()
        {
            CloseWindow(false);
        }

        private void OnHelpClick()
        {
            this.ChangeTabStripVisibility(true);
            this.AddNewTabStrip(1); // harcodare -> 1 este modulul help
        }
        #endregion       
    }
}