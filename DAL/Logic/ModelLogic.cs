using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;
using DAL.Models.Security;
using Helpers.GeneralOperations;

namespace DAL
{
    public class ModelLogic
    {
        #region constants
        public const string _createdByUserIdColumnName = "created_by";
        public const string _createdAtColumnName = "created_at";
        public const string _updatedByUserIdColumnName = "updated_by";
        public const string _updatedAtColumnName = "updated_at";

        public const string _primaryKeyColumnName = "id";

        public const string _rowCountColumnName = "rowCount";
        public const string _lastDateColumnName = "lastDate";
        #endregion

        public static void AddAuditDataAdd(object oRow, int nUserId)
        {
            try
            {
                if (oRow.GetType().GetProperty(_createdByUserIdColumnName) != null)
                    oRow.GetType().GetProperty(_createdByUserIdColumnName).SetValue(oRow, nUserId, null);

                if (oRow.GetType().GetProperty(_createdAtColumnName) != null)
                    oRow.GetType().GetProperty(_createdAtColumnName).SetValue(oRow, DateTime.Now, null);
            }
            catch (Exception ex)
            {
                FileOperations.WriteToExceptionLog("DAL.ModelLogic.AddAuditDataAdd", ex.ToString(), oRow.ToString(), nUserId);
                throw ex;
            }
        }

        public static void AddAuditDataEdit(object oRow, int nUserId)
        {
            try
            {
                if (oRow.GetType().GetProperty(_updatedByUserIdColumnName) != null)
                    oRow.GetType().GetProperty(_updatedByUserIdColumnName).SetValue(oRow, nUserId, null);

                if (oRow.GetType().GetProperty(_updatedAtColumnName) != null)
                    oRow.GetType().GetProperty(_updatedAtColumnName).SetValue(oRow, DateTime.Now, null);
            }
            catch (Exception ex)
            {
                FileOperations.WriteToExceptionLog("DAL.ModelLogic.AddAuditDataEdit", ex.ToString(), oRow.ToString(), nUserId);
                throw ex;
            }
        }

        public static DataRow GetCurrentRecord(object oRow)
        {
            DataRowView dataRowView;
            if (typeof(DataRowView).IsInstanceOfType(oRow))
            {
                dataRowView = (DataRowView)oRow;
                return (DataRow)dataRowView.Row;
            }
            if (typeof(DataRow).IsInstanceOfType(oRow))
                return (DataRow)oRow;

            return null;
        }

        public static void VerifyRowValues(object oRow)
        {
            DataRow row = GetCurrentRecord(oRow);

            if (row == null)
                return;

            DataColumn crrColumn;
            row.ClearErrors();

            for (int i = 0; i < row.Table.Columns.Count; i++)
            {
                crrColumn = row.Table.Columns[i];

                if (!crrColumn.AllowDBNull && row.IsNull(crrColumn))
                    row.SetColumnError(crrColumn, "Valoarea trebuie completata obligatoriu!");

                if (crrColumn.DataType == typeof(string))
                {
                    if (!row.IsNull(crrColumn) && crrColumn.MaxLength > 0 && row[crrColumn].ToString().Length > crrColumn.MaxLength)
                        row.SetColumnError(crrColumn, string.Format("Puteti introduce maxim {0} caractere! Ati introdus {1}", crrColumn.MaxLength, row[crrColumn].ToString().Length));

                    row[crrColumn] = row[crrColumn].ToString().Replace(Environment.NewLine, string.Empty);
                }

                if (crrColumn.ColumnName.Substring(crrColumn.ColumnName.Length - 3).ToLower() == "_id")
                    continue;

                if (crrColumn.DataType == typeof(int) && !crrColumn.AllowDBNull)
                {
                    try
                    {
                        Convert.ToInt32(row[crrColumn]);
                    }
                    catch (Exception)
                    {
                        row.SetColumnError(crrColumn, "Introduceti / selectati o valoare numerica intreaga!");
                    }
                }

                if ((crrColumn.DataType == typeof(double) || crrColumn.DataType == typeof(float) || crrColumn.DataType == typeof(Single)) && !crrColumn.AllowDBNull)
                {
                    try
                    {
                        Convert.ToDouble(row[crrColumn]);
                    }
                    catch (Exception)
                    {
                        row.SetColumnError(crrColumn, "Introduceti o valoare numerica cu maxim 4 zecimale (2 daca acest camp reprezinta un pret)!");
                    }
                }
            }

            if (row.HasErrors)
                throw new Exception();
        }

        public static bool CheckUnique(object oRow)
        {
            #region Nomenclators
            if (oRow is Client)
                return NomenclatorsModelMethods.ClientMethods.CheckUniqueKey((Client)oRow);
            if (oRow is Entry_Type)
                return NomenclatorsModelMethods.EntryTypeMethods.CheckUniqueKey((Entry_Type)oRow);
            if (oRow is Field)
                return NomenclatorsModelMethods.FieldMethods.CheckUniqueKey((Field)oRow);
            if (oRow is Product_Type)
                return NomenclatorsModelMethods.ProductTypeMethods.CheckUniqueKey((Product_Type)oRow);
            if (oRow is Product)
                return NomenclatorsModelMethods.ProductMethods.CheckUniqueKey((Product)oRow);
            if (oRow is Subscription_Type)
                return NomenclatorsModelMethods.SubscriptionTypeMethods.CheckUniqueKey((Subscription_Type)oRow);
            #endregion

            #region Security
            if (oRow is User)
                return SecurityModelMethods.UserMethods.CheckUniqueKey((User)oRow);
            if (oRow is Role)
                return SecurityModelMethods.RoleMethods.CheckUniqueKey((Role)oRow);
            #endregion

            return true;
        }

        public static bool CanDelete(object oRow)
        {
            #region Nomenclators
            if (oRow is Client)
                return NomenclatorsModelMethods.ClientMethods.CanDelete((Client)oRow);
            if (oRow is Entry_Type)
                return NomenclatorsModelMethods.EntryTypeMethods.CanDelete((Entry_Type)oRow);
            if (oRow is Field)
                return NomenclatorsModelMethods.FieldMethods.CanDelete((Field)oRow);
            if (oRow is Product_Type)
                return NomenclatorsModelMethods.ProductTypeMethods.CanDelete((Product_Type)oRow);
            if (oRow is Product)
                return NomenclatorsModelMethods.ProductMethods.CanDelete((Product)oRow);
            if (oRow is Subscription_Type)
                return NomenclatorsModelMethods.SubscriptionTypeMethods.CanDelete((Subscription_Type)oRow); 
            #endregion

            #region Security
            if (oRow is Role)
                return SecurityModelMethods.RoleMethods.CanDelete((Role)oRow); 
            #endregion

            return true;
        }

        public static void CancelModifications(object oRow)
        {
            #region Nomenclators
            if (oRow is Client)
                NomenclatorsModelMethods.ClientMethods.CancelModifications((Client)oRow);
            if (oRow is Entry_Type)
                NomenclatorsModelMethods.EntryTypeMethods.CancelModifications((Entry_Type)oRow);
            if (oRow is Field)
                NomenclatorsModelMethods.FieldMethods.CancelModifications((Field)oRow);
            if (oRow is Organization_Detail)
                NomenclatorsModelMethods.OrganizationDetailsMethods.CancelModifications((Organization_Detail)oRow);
            if (oRow is Product_Type)
                NomenclatorsModelMethods.ProductTypeMethods.CancelModifications((Product_Type)oRow);
            if (oRow is Product)
                NomenclatorsModelMethods.ProductMethods.CancelModifications((Product)oRow);
            if (oRow is Subscription_Type)
                NomenclatorsModelMethods.SubscriptionTypeMethods.CancelModifications((Subscription_Type)oRow);
            #endregion
            #region Operations
            if (oRow is Entry)
                OperationsModelMethods.EntriesMethods.CancelModifications((Entry)oRow);
            if (oRow is Field_Reservation)
                OperationsModelMethods.FieldReservationsMethods.CancelModifications((Field_Reservation)oRow);
            if (oRow is Product_Entry)
                OperationsModelMethods.ProductEntriesMethods.CancelModifications((Product_Entry)oRow);
            if (oRow is Product_Sale)
                OperationsModelMethods.ProductSalesMethods.CancelModifications((Product_Sale)oRow);
            if (oRow is Subscription)
                OperationsModelMethods.SubscriptionMethods.CancelModifications((Subscription)oRow);
            #endregion
            #region Security
            if (oRow is Role)
                SecurityModelMethods.RoleMethods.CancelModifications((Role)oRow);
            if (oRow is User)
                SecurityModelMethods.UserMethods.CancelModifications((User)oRow);
            #endregion
        }

        public static void MergeTables(DataTable destinationDataTable, DataTable sourceDataTable, bool preserverChanges)
        {
            if (preserverChanges)
            {
                List<Object> changedRows = new List<object>();

                try
                {
                    for (int i = 0; i < destinationDataTable.Rows.Count; i++)
                    {
                        if (destinationDataTable.Rows[i].RowState != DataRowState.Unchanged && destinationDataTable.Rows[i].RowState != DataRowState.Detached)
                            changedRows.Add(new object[]{
                            destinationDataTable.Rows[i]
                            ,destinationDataTable.Rows[i].ItemArray
                            ,destinationDataTable.Rows[i].RowState
                        });
                    }
                }
                catch (Exception)
                {
                    return;
                }

                try
                {
                    destinationDataTable.Merge(sourceDataTable, false, MissingSchemaAction.Ignore);
                    destinationDataTable.AcceptChanges();
                }
                catch (Exception)
                {
                    if (destinationDataTable != null)
                        destinationDataTable.RejectChanges();
                    return;
                }
                try
                {

                    for (int i = 0; i < changedRows.Count; i++)
                    {
                        object[] changedRow;
                        changedRow = (object[])changedRows[i];

                        destinationDataTable.LoadDataRow(((object[])changedRow[1]), LoadOption.OverwriteChanges);

                        if ((DataRowState)changedRow[2] == DataRowState.Added && ((DataRow)changedRow[0]).RowState == DataRowState.Unchanged)
                            ((DataRow)changedRow[0]).SetAdded();
                        if ((DataRowState)changedRow[2] == DataRowState.Modified && ((DataRow)changedRow[0]).RowState == DataRowState.Unchanged)
                            ((DataRow)changedRow[0]).SetModified();
                        if ((DataRowState)changedRow[2] == DataRowState.Deleted && ((DataRow)changedRow[0]).RowState == DataRowState.Unchanged)
                            ((DataRow)changedRow[0]).Delete();
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
            else
            {
                try
                {
                    destinationDataTable.Merge(sourceDataTable, preserverChanges);
                }
                catch (Exception)
                {
                    if (destinationDataTable != null)
                        destinationDataTable.RejectChanges();
                    return;
                }
            }
        }

        public static bool TableHasModifiedData(DataTable table, AuditColumn auditColumn)
        {
            DataTable tmpTable = new DataTable();
            string sSqlStatement = string.Empty;
            int nDbCount = 0;
            DateTime dbDate = new DateTime(2000, 01, 01);

            try
            {
                sSqlStatement = string.Format("select count(*) as {0}, max({1}) as {2} from {3}",
                    _rowCountColumnName,
                    (auditColumn == AuditColumn.AddDateTime ? _createdAtColumnName : _updatedAtColumnName),
                    _lastDateColumnName,
                    table.TableName);
                GeneralDatabaseAccess.FillDataTable(sSqlStatement, tmpTable, DataFetchType.Fill);

                if (tmpTable == null || tmpTable.Rows.Count == 0)
                    return true;

                nDbCount = Convert.ToInt32(tmpTable.Rows[0][_rowCountColumnName]);
                if (!tmpTable.Rows[0].IsNull(_lastDateColumnName))
                {
                    dbDate = Convert.ToDateTime(tmpTable.Rows[0][_lastDateColumnName]);
                }

            }
            catch (SqlException se)
            {
                FileOperations.WriteToExceptionLog("DAL.ModelLogic.TableHasModifiedData", se.ToString(), table.TableName, auditColumn.ToString());
                throw se;
            }
            catch (Exception ex)
            {
                FileOperations.WriteToExceptionLog("DAL.ModelLogic.TableHasModifiedData", ex.ToString(), table.TableName, auditColumn.ToString());
                throw ex;
            }

            if (nDbCount != table.Rows.Count || dbDate.CompareTo(((TableModificationsInterface)table).LastModificationDate) > 0)
            {
                ((TableModificationsInterface)table).LastModificationDate = dbDate;
                return true;
            }
            return false;
        }

        public static void MergeRows(object oDestinationRow, object oSourceRow)
        {
            Type _destinationType = oDestinationRow.GetType();
            Type _sourceType = oSourceRow.GetType();

            if (!_destinationType.Equals(_sourceType))
            {
                FileOperations.WriteToExceptionLog("DAL.ModelLogic.MergeRows", "Different Row Types on Row Merge",
                    _destinationType.Name, oDestinationRow.GetType().GetProperty(_primaryKeyColumnName).GetValue(oDestinationRow, null),
                    _sourceType.Name, oSourceRow.GetType().GetProperty(_primaryKeyColumnName).GetValue(oSourceRow, null));
                throw new Exception("Different Row Types on Row Merge");
            }

            if (Convert.ToInt32(oDestinationRow.GetType().GetProperty(_primaryKeyColumnName).GetValue(oDestinationRow, null)) !=
                Convert.ToInt32(oSourceRow.GetType().GetProperty(_primaryKeyColumnName).GetValue(oSourceRow, null)))
            {
                FileOperations.WriteToExceptionLog("DAL.ModelLogic.MergeRows", "Different PK value on Row Merge",
                    _destinationType.Name, oDestinationRow.GetType().GetProperty(_primaryKeyColumnName).GetValue(oDestinationRow, null),
                    _sourceType.Name, oSourceRow.GetType().GetProperty(_primaryKeyColumnName).GetValue(oSourceRow, null));
                throw new Exception("Different PK value on Row Merge");
            }

            PropertyInfo[] _proprieties = oDestinationRow.GetType().GetProperties();

            for (int i = 0; i < _proprieties.Length; i++)
            {
                try
                {
                    if (_proprieties[i].Name.CompareTo(_primaryKeyColumnName) == 0 ||
                        _proprieties[i].Name.CompareTo(_createdByUserIdColumnName) == 0 ||
                        _proprieties[i].Name.CompareTo(_createdAtColumnName) == 0 ||
                        _proprieties[i].Name.CompareTo(_updatedByUserIdColumnName) == 0 ||
                        _proprieties[i].Name.CompareTo(_updatedAtColumnName) == 0)
                        continue;
                    if (!_proprieties[i].PropertyType.IsPrimitive && !(_proprieties[i].PropertyType.Equals(typeof(string))))
                        continue;

                    oDestinationRow.GetType().GetProperty(_proprieties[i].Name).SetValue(
                        oDestinationRow, oSourceRow.GetType().GetProperty(_proprieties[i].Name).GetValue(oSourceRow, null), null);
                }
                catch (Exception ex)
                {
                    FileOperations.WriteToExceptionLog("DAL.ModelLogic.MergeRows", ex.ToString(),
                        _destinationType.Name, oDestinationRow.GetType().GetProperty(_primaryKeyColumnName).GetValue(oDestinationRow, null),
                        _sourceType.Name, oSourceRow.GetType().GetProperty(_primaryKeyColumnName).GetValue(oSourceRow, null),
                        _proprieties[i].Name);
                    throw ex;
                }
            }

        }

        public static void MergeLists<T>(BindingList<T> oDestinationList, List<T> oSourceList)
        {
            for (int i = 0; i < oSourceList.Count; i++)
            {
                var _query = from oRow in oDestinationList
                             where Convert.ToInt32(oRow.GetType().GetProperty(_primaryKeyColumnName).GetValue(oRow, null)) == Convert.ToInt32(oSourceList[i].GetType().GetProperty(_primaryKeyColumnName).GetValue(oSourceList[i], null))
                             select oRow;

                object oOldRow = _query.FirstOrDefault();

                if (oOldRow == null)
                {
                    oDestinationList.Add(oSourceList[i]);
                    continue;
                }

                DateTime? sourceModifDate = (DateTime?)oSourceList[i].GetType().GetProperty(_updatedAtColumnName).GetValue(oSourceList[i], null);
                DateTime? destinationModifDate = (DateTime?)oOldRow.GetType().GetProperty(_updatedAtColumnName).GetValue(oOldRow, null);

                if ((sourceModifDate == null && destinationModifDate == null)
                    || (destinationModifDate != null && sourceModifDate == null)
                    || (destinationModifDate != null && sourceModifDate != null && ((DateTime?)destinationModifDate).Value.CompareTo((DateTime?)sourceModifDate) > 0))
                {
                    continue;
                }
                else
                {
                    MergeRows(oOldRow, oSourceList[i]);
                }
            }
        }
    }

    public enum AuditColumn
    {
        AddDateTime,
        EditDateTime
    }
}