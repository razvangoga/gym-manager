using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public interface ModelLogicInterface
    {
        bool CheckUnique(object oRow);

        bool CanDeleteRow(object oRow);

        void AddAuditDataAdd(object oRow, int nUserId);

        void AddAuditDataEdit(object oRow, int nUserId);

        DataRow GetCurrentRecord(object oRow);
    }
}
