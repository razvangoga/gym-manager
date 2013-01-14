using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Security;

namespace DAL.Models.Security
{
    public class SecurityModelMethods
    {
        #region Users
        public class UserMethods
        {
            public static User GetUserFromCredentials(string p_sLogin, string p_sPassword)
            {
                try
                {
                    ISingleResult<User> _result = Session.SecurityModel.Users_GetUserByCredentials(p_sLogin, p_sPassword);
                    return _result.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static User GetUserByUserId(int p_nUserId)
            {
                var _user = from user in Session.Users
                            where user.id == p_nUserId
                            select user;

                return _user.FirstOrDefault();
            }

            public static User GetDataById(int p_id)
            {
                try
                {
                    var _query = from user in Session.SecurityRefresherModel.Users
                                 where user.id == p_id
                                 select user;
                    return _query.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string GetUserNameByUserId(int p_nUserId)
            {
                User _user = GetUserByUserId(p_nUserId);

                if (_user == null)
                {
                    return "n/a";
                }
                else
                {
                    return string.Format("{0} {1}", _user.FirstName, _user.LastName);
                }
            }

            public static void GetData()
            {
                try
                {
                    var _users = from user in Session.SecurityModel.Users
                                 select user;

                    Session.Users = ((IListSource)_users).GetList() as BindingList<User>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static bool CheckUniqueKey(User p_user)
            {
                try
                {
                    ISingleResult<User> _result = Session.SecurityModel.Users_GetUserByUniqueKey(p_user.Login, p_user.id);
                    if (_result.FirstOrDefault() == null)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Acest utilizator este folosit deja : '{0}'", p_user.Login));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void AddUser(User p_user, string p_sPassword)
            {
                try
                {
                    int? nId = -1;

                    Session.SecurityModel.Users_Insert(ref nId, p_user.FirstName, p_user.LastName,
                                p_user.Login, p_sPassword, p_user.Role_id, p_user.IsActive, p_user.created_by, p_user.created_at);
                    p_user.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditUser(User p_user, string p_sPassword)
            {
                try
                {
                    Session.SecurityModel.Users_Update(p_user.id, p_user.FirstName, p_user.LastName,
                        p_user.Login, p_sPassword, p_user.Role_id, p_user.IsActive,
                        p_user.updated_by, p_user.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }

            }

            public static void CancelModifications(User p_user)
            {
                if (p_user != null)
                    ModelLogic.MergeRows(p_user, GetDataById(p_user.id));
            }
        }
        #endregion

        #region Roles
        public class RoleMethods
        {
            public static Role GetRoleByRoleId(int p_nRoleId)
            {
                var _role = from role in Session.Roles
                            where role.id == p_nRoleId
                            select role;

                return _role.FirstOrDefault();
            }

            public static void GetData()
            {
                try
                {
                    var _roles = from role in Session.SecurityModel.Roles
                                 select role;

                    Session.Roles = ((IListSource)_roles).GetList() as BindingList<Role>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static Role GetDataById(int p_id)
            {
                try
                {
                    var _query = from role in Session.SecurityRefresherModel.Roles
                                 where role.id == p_id
                                 select role;
                    return _query.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static bool CheckUniqueKey(Role p_role)
            {
                try
                {
                    ISingleResult<Role> _result = Session.SecurityModel.Roles_GetRoleByUniqueKey(p_role.RoleName, p_role.id);
                    if (_result.FirstOrDefault() == null)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Acest role este definit deja : '{0}'", p_role.RoleName));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static bool CanDelete(Role p_role)
            {
                try
                {
                    var _result = Session.SecurityModel.Roles_CanDelete(p_role.id);

                    int _nCount = _result.FirstOrDefault().RoleCount.Value;
                    if (_nCount == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Rolul '{0}' nu poate fi sters! Exista utilizatori cu acest rol!", p_role.RoleName));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Role p_role)
            {
                if (p_role != null)
                {
                    Session.SecurityModel.Refresh(RefreshMode.OverwriteCurrentValues, p_role);
                    var _query_mem = from rar in p_role.Roles_Access_Rights
                                     where rar.Role_id == p_role.id && rar.id == 0
                                     select rar;
                    List<Roles_Access_Right> _list_mem = _query_mem.ToList();

                    for (int i = 0; i < _list_mem.Count; i++)
                    {
                        _list_mem[i].Detach();
                        _list_mem[i] = null;
                    }

                    var _query_db = from rar in Session.SecurityRefresherModel.Roles_Access_Rights
                                  where rar.Role_id == p_role.id
                                  select rar;
                    List<Roles_Access_Right> _list_db = _query_db.ToList();

                    for (int i = 0; i < _list_db.Count; i++)
                    {
                        var _qrar = from rar in p_role.Roles_Access_Rights
                                    where rar.Role_id == p_role.id && rar.id == _list_db[i].id
                                    select rar;

                        Roles_Access_Right _rar = _qrar.FirstOrDefault();

                        if (_rar == null)
                        {
                            Roles_Access_Right _rar_mem = (from rar in Session.SecurityModel.Roles_Access_Rights
                                                           where rar.id == _list_db[i].id
                                                           select rar).FirstOrDefault();

                            if (_rar_mem != null)
                            {
                                _rar_mem.Role = p_role;
                                _rar_mem.Role_id = p_role.id;
                                Session.SecurityModel.Refresh(RefreshMode.OverwriteCurrentValues, _rar_mem);
                            }
                            else
                            {
                                Session.SecurityModel.Roles_Access_Rights.Attach(_list_db[i]);
                            }
                        }
                        else
                        {
                            ModelLogic.MergeRows(_rar, _list_db[i]);
                        }
                    }
                }
            }
        }
        #endregion

        #region RolesAccessRights
        public class RolesAccessRigtsMethods
        {
            public static Roles_Access_Right GetAccessRightsByModuleCode(int p_nModuleCode)
            {
                var _roleAccessRights = from role_Access_Right in Session.SecurityModel.Roles_Access_Rights
                                        where role_Access_Right.Access_Right_id == p_nModuleCode
                                            && role_Access_Right.Role_id == Session.LoggedUser.Role_id
                                        select role_Access_Right;

                return _roleAccessRights.FirstOrDefault();
            }

            public static void GetData()
            {
                try
                {
                    var _roleAccessRights = from role_Access_Right in Session.SecurityModel.Roles_Access_Rights
                                            select role_Access_Right;

                    Session.Roles_Access_Rights = ((IListSource)_roleAccessRights).GetList() as BindingList<Roles_Access_Right>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private static Roles_Access_Right GetDataById(int p_id)
            {
                try
                {
                    var _query = from roleAccessRight in Session.SecurityRefresherModel.Roles_Access_Rights
                                 where roleAccessRight.id == p_id
                                 select roleAccessRight;
                    return _query.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion

        #region Access Rights
        public class AccessRightsMethods
        {
            public static void GetData()
            {
                try
                {
                    var _accessRights = from access_Right in Session.SecurityModel.Access_Rights
                                        select access_Right;

                    Session.Access_Rights = ((IListSource)_accessRights).GetList() as BindingList<Access_Right>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string BuildSortByDescription()
            {
                return "Description ASC";
            }

            public static string GetAccessRightDescription(int p_nModuleCode)
            {
                Access_Right _access_Right = GetAccessRightById(p_nModuleCode);

                if (_access_Right == null)
                {
                    return "n/a";
                }
                else
                {
                    return _access_Right.Description;
                }
            }

            public static Access_Right GetAccessRightById(int p_nModuleCode)
            {
                var _result = from access_Right in Session.Access_Rights
                              where access_Right.id == p_nModuleCode
                              select access_Right;

                return _result.FirstOrDefault();
            }
        }
        #endregion

        #region Locked Objects
        public class LockedObjectMethods
        {
            public static User CheckLockOnObject(int p_nModuleCode, int p_nPkId)
            {
                ISingleResult<Locked_Object> _result = null;

                try
                {
                    _result = Session.SecurityModel.Locked_Objects_CheckLockOnObject(p_nModuleCode, p_nPkId);
                }
                catch (SqlException se)
                {
                    throw se;
                }

                Locked_Object _locked_Object = _result.FirstOrDefault();

                if (_locked_Object != null)
                {
                    return UserMethods.GetUserByUserId(_locked_Object.User_id);
                }
                else
                {
                    return null;
                }

            }

            public static void SetLockOnObject(int p_nModuleCode, int p_nUserId, int p_nPkId)
            {
                try
                {
                    Session.SecurityModel.Locked_Objects_SetLockOnObject(p_nModuleCode, p_nUserId, p_nPkId);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void RemoveLockFromObject(int p_nModuleCode, int p_nUserId, int p_nPkId)
            {
                try
                {
                    Session.SecurityModel.Locked_Objects_RemoveLockFromObject(p_nModuleCode, p_nUserId, p_nPkId);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }
        }
        #endregion
    }
}