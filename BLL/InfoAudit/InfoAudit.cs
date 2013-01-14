using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using DAL;
using DAL.Logic;
using DAL.Models.Security;

namespace BLL.InfoAudit
{
    public class InfoAudit
    {
        #region private proprieties
        private string _PkId = "n/a";
        private string _CreatedByUser = "n/a";
        private DateTime _CreateDate = new DateTime(2000, 01, 01);
        private bool _WasUpdated = false;
        private string _UpdatedByUser = "n/a";
        private DateTime _UpdateDate = new DateTime(2000, 01, 01);
        #endregion

        #region public proprieties
        public string PkId
        {
            get { return _PkId; }
            set { _PkId = value; }
        }

        public string CreatedByUser
        {
            get { return _CreatedByUser; }
            set { _CreatedByUser = value; }
        }

        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        public bool WasUpdated
        {
            get { return _WasUpdated; }
            set { _WasUpdated = value; }
        }

        public string UpdatedByUser
        {
            get { return _UpdatedByUser; }
            set { _UpdatedByUser = value; }
        }

        public DateTime UpdateDate
        {
            get { return _UpdateDate; }
            set { _UpdateDate = value; }
        }
        #endregion

        public static InfoAudit ExtractAuditInfoFromRow(object p_oRow)
        {
            InfoAudit ia = new InfoAudit();

            #region primary key
            if (p_oRow.GetType().GetProperty(ModelLogic._primaryKeyColumnName) != null)
            {
                ia._PkId = p_oRow.GetType().GetProperty(ModelLogic._primaryKeyColumnName).GetValue(p_oRow, null).ToString();
            } 
            #endregion

            #region creation fields
            if (p_oRow.GetType().GetProperty(ModelLogic._createdByUserIdColumnName) != null)
            {
                User _user = SecurityModelMethods.UserMethods.GetUserByUserId(
                    Convert.ToInt32(p_oRow.GetType().GetProperty(ModelLogic._createdByUserIdColumnName).GetValue(p_oRow, null)));

                ia._CreatedByUser = string.Format("{0} {1}",
                    _user.FirstName,
                    _user.LastName);
            }

            if (p_oRow.GetType().GetProperty(ModelLogic._createdAtColumnName) != null)
            {
                ia._CreateDate = Convert.ToDateTime(p_oRow.GetType().GetProperty(ModelLogic._createdAtColumnName).GetValue(p_oRow, null));
            } 
            #endregion

            #region last update fields
            if (p_oRow.GetType().GetProperty(ModelLogic._updatedByUserIdColumnName) != null)
            {
                if (p_oRow.GetType().GetProperty(ModelLogic._updatedByUserIdColumnName).GetValue(p_oRow,null) != null)
                {
                    User _user = SecurityModelMethods.UserMethods.GetUserByUserId(
                        Convert.ToInt32(p_oRow.GetType().GetProperty(ModelLogic._updatedByUserIdColumnName).GetValue(p_oRow, null)));

                        ia._UpdatedByUser = string.Format("{0} {1}",
                            _user.FirstName,
                            _user.LastName);

                        ia._WasUpdated = true;
                }
            }

            if (p_oRow.GetType().GetProperty(ModelLogic._updatedAtColumnName) != null)
            {
                if (p_oRow.GetType().GetProperty(ModelLogic._updatedAtColumnName).GetValue(p_oRow,null) != null)
                {
                    ia._UpdateDate = Convert.ToDateTime(p_oRow.GetType().GetProperty(ModelLogic._updatedAtColumnName).GetValue(p_oRow,null));
                }
            } 
            #endregion

            return ia;
        }
    }
}
