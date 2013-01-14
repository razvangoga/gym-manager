using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using DAL.Models.Security;

namespace BLL.RightsMangement
{
    public class RightsManagementLogic
    {
        #region global variables
        private int nModuleId = 0;

        private bool bUserHasAccess = false;
        private bool bUserHasNew = false;
        private bool bUserHasEdit = false;
        private bool bUserHasDelete = false; 
        #endregion

        #region constructors
        public RightsManagementLogic()
        {
            this.UserHasNew = false;
            this.UserHasDelete = false;
            this.UserHasEdit = false;
        }

        public RightsManagementLogic(int nModuleId)
        {
            this.ModuleId = nModuleId;
        } 
        #endregion

        #region get / set proprieties
        public bool UserHasAccess
        {
            get
            {
                return this.bUserHasAccess;
            }
            set
            {
                this.bUserHasAccess = value;
            }
        }

        public bool UserHasNew
        {
            get
            {
                return this.bUserHasNew;
            }
            set
            {
                this.bUserHasNew = value;
            }
        }

        public bool UserHasEdit
        {
            get
            {
                return this.bUserHasEdit;
            }
            set
            {
                this.bUserHasEdit = value;
            }
        }

        public bool UserHasDelete
        {
            get
            {
                return this.bUserHasDelete;
            }
            set
            {
                this.bUserHasDelete = value;
            }
        }

        public int ModuleId
        {
            get
            {
                return this.nModuleId;
            }
            set
            {
                this.nModuleId = value;
                SetAccessRights();
            }
        }
        #endregion

        /// <summary>
        /// sets access rights for given module
        /// </summary>
        private void SetAccessRights()
        {
            Roles_Access_Right roles_Access_Right = SecurityModelMethods.RolesAccessRigtsMethods.GetAccessRightsByModuleCode(this.nModuleId);
            if (roles_Access_Right != null)
            {
                this.bUserHasNew = roles_Access_Right.HasNew;
                this.bUserHasEdit = roles_Access_Right.HasEdit;
                this.bUserHasDelete = roles_Access_Right.HasDelete;
                this.bUserHasAccess = true;
            }
            else
            {
                this.bUserHasAccess = false;
            }
        }
    }
}
