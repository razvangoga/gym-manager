using System;
using System.Collections.Generic;
using System.Text;

using DAL.Logic;
using DAL.Models.Security;

namespace BLL.LoginLogic
{
    public class LoginLogic
    {
        #region private members
        private static bool _bLoginComplete = false;
        private static bool _bExitApplication = false;
        private static bool _bIsReLogin = false;
        #endregion

        #region public members
        public static bool LoginComplete
        {
            get
            {
                return _bLoginComplete;
            }
            set
            {
                _bLoginComplete = value;
            }
        }
        public static bool ExitApplication
        {
            get
            {
                return _bExitApplication;
            }
            set
            {
                _bExitApplication = value;
            }
        }
        public static bool IsReLogin
        {
            get
            {
                return _bIsReLogin;
            }
            set
            {
                _bIsReLogin = value;
            }
        }
        #endregion
    }
}
