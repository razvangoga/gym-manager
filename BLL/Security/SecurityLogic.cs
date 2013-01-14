using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

using DAL;
using DAL.Logic;
using DAL.Models.Security;

namespace BLL.Security
{
    public class SecurityLogic
    {
        public static bool DoLogin(string p_sLogin, string p_sPassword)
        {
            User user = SecurityModelMethods.UserMethods.GetUserFromCredentials(p_sLogin, p_sPassword);
            if (user != null)
            {
                Session.LoggedUser = user;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetLoggedUserNameAndRole()
        {
            Role role = SecurityModelMethods.RoleMethods.GetRoleByRoleId(Session.LoggedUser.Role_id);

            return string.Format("{0} {1} - {2}",
                Session.LoggedUser.FirstName,
                Session.LoggedUser.LastName,
                role == null ? "n/a" : role.RoleName);
        }

        public static bool CheckIfPassWordsMatch(string p_sPassword, string p_sRePassword)
        {
            return p_sPassword.CompareTo(p_sRePassword) == 0 ? true : false;
        }

        public static void AddNewRoleAccessRight(Role p_role, Access_Right p_accessRight)
        {
            if (p_role == null || p_accessRight == null)
                return;

            CheckIfRoleAlreadyHasAccessRight(p_role, p_accessRight);

            Roles_Access_Right _roles_Access_Right = new Roles_Access_Right();

            _roles_Access_Right.Role_id = p_role.id;
            _roles_Access_Right.Role = p_role;

            _roles_Access_Right.Access_Right_id = p_accessRight.id;
            _roles_Access_Right.Access_Right = p_accessRight;

            _roles_Access_Right.HasNew = false;
            _roles_Access_Right.HasEdit = false;
            _roles_Access_Right.HasDelete = false;

            Session.SecurityModel.Roles_Access_Rights.InsertOnSubmit(_roles_Access_Right);
        }

        public static void CheckIfRoleAlreadyHasAccessRight(Role p_role, Access_Right p_accessRight)
        {
            var _query = from roleAccessRight in Session.Roles_Access_Rights
                         where roleAccessRight.Role_id == p_role.id
                            && roleAccessRight.Access_Right_id == p_accessRight.id
                         select roleAccessRight;

            Roles_Access_Right _result = _query.FirstOrDefault();

            if (_result != null)
                throw new Exception(string.Format("Rolul '{0}' are acces la Modulul '{1}'",
                    p_role.RoleName,
                    p_accessRight.Description));
        }

        public static bool CanSaveRole(Role p_role)
        {
            var _query = from rar in p_role.Roles_Access_Rights
                         where rar.CanSaveRow == false
                         select rar;

            List<Roles_Access_Right> _list = _query.ToList();

            if (_list.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void SetUpdateMarkers(Roles_Access_Right p_roles_Access_Right)
        {
            ModelLogic.AddAuditDataEdit(p_roles_Access_Right, Session.LoggedUser.id);
        }

        public static class LockedObjectsLogis
        {
            public static void CheckLockOnObject(int p_nModuleCode, int p_nPkId)
            {
                User _user = SecurityModelMethods.LockedObjectMethods.CheckLockOnObject(p_nModuleCode, p_nPkId);

                if (_user != null)
                    throw new Exception(string.Format("Obiectul este in curs de editare de catre utilizatorul : {0} {1}",
                        _user.FirstName, _user.LastName));
            }
            public static void SetLockOnObject(int p_nModuleCode, int p_nPkId)
            {
                SecurityModelMethods.LockedObjectMethods.SetLockOnObject(p_nModuleCode, Session.LoggedUser.id, p_nPkId);
            }
            public static void RemoveLockFromObject(int p_nModuleCode, int p_nPkId)
            {
                SecurityModelMethods.LockedObjectMethods.RemoveLockFromObject(p_nModuleCode, Session.LoggedUser.id, p_nPkId);
            }
            public static void RemoveLockFromObject(int p_nModuleCode, int p_nUserId, int p_nPkId)
            {
                SecurityModelMethods.LockedObjectMethods.RemoveLockFromObject(p_nModuleCode, p_nUserId, p_nPkId);
            }
        }
    }
}
