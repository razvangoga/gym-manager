using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using MyControls.CustomControls.BaseControl;

namespace MyControls.WindowsControls
{
    public delegate void AddNewItem_ButtonClick(object sender,NavigatorArgs e);
    public delegate void DeleteItem_ButtonClick(object sender, NavigatorArgs e);
    public delegate void SaveItem_ButtonClick(object sender, NavigatorArgs e);
    public delegate void EditItem_ButtonClick(object sender, NavigatorArgs e);
    public delegate void CancelItem_ButtonClick(object sender, NavigatorArgs e);

    public partial class myBindingNavigator : UserControl
    {
        #region global variables
        private bool bAddEnabled = true;
        private bool bDeleteEnabled = true;
        
        private BindingSource objectBindingSource = null;
        private BaseCommandsControl commandsControl = null;
        public event AddNewItem_ButtonClick AddNewItem_ButtonClick = null;
        public event DeleteItem_ButtonClick DeleteItem_ButtonClick = null;
        public event SaveItem_ButtonClick SaveItem_ButtonClick = null;
        public event EditItem_ButtonClick EditItem_ButtonClick = null;
        public event CancelItem_ButtonClick CancelItem_ButtonClick = null;
        #endregion

        public myBindingNavigator()
        {
            InitializeComponent();
        }

        public BindingSource BindingSource
        {
            get
            {
                return this.objectBindingSource;
            }
            set
            {
                this.objectBindingSource = value;
            }
        }

        public BaseCommandsControl CommandsControl
        {
            get
            {
                return this.commandsControl;
            }
            set
            {
                this.commandsControl = value;
            }
        }

        public bool PanelNavigation
        {
            get
            {
                return this.navigationPanel.Enabled;
            }

            set
            {
                this.navigationPanel.Enabled = value;
                this.enableDisableMovementButtons(value);
            }
        }
        public bool PanelAdd
        {
            get
            {
                return this.bAddEnabled;
            }

            set
            {
                this.bAddEnabled = value;
                this.enableDisableAddButton(value);
            }
        }
        public bool PanelEditing
        {
            get
            {
                return this.editPanel.Enabled;
            }

            set
            {
                this.editPanel.Enabled = value;
                this.enableDisableEditButton(value);
            }
        }
        public bool PanelDeleteing
        {
            get
            {
                return this.bDeleteEnabled;
            }

            set
            {
                this.bDeleteEnabled = value;
                this.enableDisableDeleteButton(value);
            }
        }

        #region movment events
        private void firstMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnFirstClick();
        }

        private void previousMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnPreviousClick();
        }

        private void nextMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnNextClick();
        }

        private void lastMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnLastClick();
        } 
        #endregion

        #region add / delete / save / edit / cancel events
        private void addNewMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnAddClick(e);
        }

        private void deleteMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnDeleteClick(e);
        }

        private void saveMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnSaveClick(e);
        }

        private void editMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnEditClick(e);
        }

        private void cancelMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.OnCancelClick(e);
        }
        #endregion

        #region on operatios button click actions
        public void OnAddClick(EventArgs e)
        {
            if (this.addNewMyRibbonMenuButton.Enabled)
            {
                NavigatorArgs na = new NavigatorArgs();
                if (AddNewItem_ButtonClick != null)
                {
                    AddNewItem_ButtonClick(this, na);

                    if (!na.Cancel)
                    {
                        enableDisableMovementButtons(false);
                        enableDisableAddButton(false);
                        enableDisableEditButton(false);
                        enableDisableCancelButton(true);
                        enableDisableDeleteButton(false);
                        enableDisableSaveButton(true);
                        enableDisableExitButton(false);
                    }
                }
            }
        }

        public void OnDeleteClick(EventArgs e)
        {
            if (deleteMyRibbonMenuButton.Enabled)
            {
                NavigatorArgs na = new NavigatorArgs();
                if (DeleteItem_ButtonClick != null)
                {
                    DeleteItem_ButtonClick(this, na);

                    if (!na.Cancel)
                    {
                        enableDisableAddButton(true);
                    }
                }
            }
        }

        public void OnSaveClick(EventArgs e)
        {
            if (saveMyRibbonMenuButton.Enabled)
            {
                NavigatorArgs na = new NavigatorArgs();
                if (SaveItem_ButtonClick != null)
                {
                    SaveItem_ButtonClick(this, na);

                    if (!na.Cancel)
                    {
                        enableDisableMovementButtons(true);
                        enableDisableAddButton(PanelAdd);
                        enableDisableEditButton(true);
                        enableDisableCancelButton(false);
                        enableDisableDeleteButton(PanelDeleteing);
                        enableDisableSaveButton(false);
                        enableDisableExitButton(true);
                    }
                }
            }
        }

        public void OnEditClick(EventArgs e)
        {
            if (editMyRibbonMenuButton.Enabled)
            {

                NavigatorArgs na = new NavigatorArgs();

                if (EditItem_ButtonClick != null)
                {
                    EditItem_ButtonClick(this, na);

                    if (!na.Cancel)
                    {
                        enableDisableMovementButtons(false);
                        enableDisableAddButton(false);
                        enableDisableEditButton(false);
                        enableDisableDeleteButton(false);
                        enableDisableSaveButton(true);
                        enableDisableCancelButton(true);
                        enableDisableExitButton(false);
                    }
                }
            }
        }

        public void OnCancelClick(EventArgs e)
        {
            if (cancelMyRibbonMenuButton.Enabled)
            {
                NavigatorArgs na = new NavigatorArgs();

                if (CancelItem_ButtonClick != null)
                {
                    CancelItem_ButtonClick(this, na);

                    if (!na.Cancel)
                    {
                        enableDisableMovementButtons(true);
                        enableDisableAddButton(PanelAdd);
                        enableDisableEditButton(true);
                        enableDisableCancelButton(false);
                        enableDisableDeleteButton(PanelDeleteing);
                        enableDisableSaveButton(false);
                        enableDisableExitButton(true);
                    }
                }
            }
        } 
        #endregion

        #region on navigation button click actions
        public void OnFirstClick()
        {
            if (this.objectBindingSource != null)
                this.objectBindingSource.MoveFirst();
        }

        public void OnPreviousClick()
        {
            if (this.objectBindingSource != null)
                this.objectBindingSource.MovePrevious();
        }

        public void OnNextClick()
        {
            if (this.objectBindingSource != null)
                this.objectBindingSource.MoveNext();
        }

        public void OnLastClick()
        {
            if (this.objectBindingSource != null)
                this.objectBindingSource.MoveLast();
        } 
        #endregion

        #region change enable status for buttons
        private void enableDisableMovementButtons(bool bStatus)
        {
            this.firstMyRibbonMenuButton.Enabled = bStatus;
            this.previousMyRibbonMenuButton.Enabled = bStatus;
            this.nextMyRibbonMenuButton.Enabled = bStatus;
            this.lastMyRibbonMenuButton.Enabled = bStatus;
        }

        private void enableDisableAddButton(bool bStatus)
        {
            this.addNewMyRibbonMenuButton.Enabled = bStatus;
        }

        private void enableDisableDeleteButton(bool bStatus)
        {
            this.deleteMyRibbonMenuButton.Enabled = bStatus;
        }

        private void enableDisableEditButton(bool bStatus)
        {
            this.editMyRibbonMenuButton.Enabled = bStatus;
        }

        private void enableDisableSaveButton(bool bStatus)
        {
            this.saveMyRibbonMenuButton.Enabled = bStatus;
        }

        private void enableDisableCancelButton(bool bStatus)
        {
            this.cancelMyRibbonMenuButton.Enabled = bStatus;
        } 

        private void enableDisableExitButton(bool bStatus)
        {
            this.commandsControl.EnableCommandButtons(bStatus);    
        }
        #endregion
    }

    public class NavigatorArgs : EventArgs
    {
        protected bool bCancel = false;

        public bool Cancel
        {
            get
            {
                return bCancel;
            }
            set
            {
                bCancel = value;
            }
        }
    }
}
