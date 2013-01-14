using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyControls.WindowsControls.PivotTableColumns
{
    public class PivotTableDataColumn
    {
        #region Enums
        public enum PivotTableDataColumnType { DataAxis, RowAxis, ColumnAxis, CalculatedTotal };
        public enum PivotTableDataColumnExpandType { Expanded, Collapsed };
        #endregion

        public readonly DataColumn dataColumn;
        public readonly PivotTableDataColumnType dataColumnType;
        public readonly Microsoft.Office.Interop.Owc11.PivotTotalFunctionEnum dataColumnFunction = Microsoft.Office.Interop.Owc11.PivotTotalFunctionEnum.plFunctionSum;
        public readonly Microsoft.Office.Interop.Owc11.PivotShowAsEnum dataColumnShowAs= Microsoft.Office.Interop.Owc11.PivotShowAsEnum.plShowAsNormal;
        public readonly PivotTableDataColumnExpandType dataColumnExpandType= PivotTableDataColumnExpandType.Expanded;
        public readonly string dataColumnName = null;
        public readonly bool showSubTotals=false;
        public readonly string numberFormat="General";
        public readonly string sort=null;
        public Array orderMembers=null;
        public readonly string calculatedExpression=null;
        public readonly int solveOrder;
        public readonly Int32 totalIndex = -1;

        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, bool showSubTotals)
        {
            this.dataColumn = dataColumn;
            this.dataColumnName = dataColumn.ColumnName;
            this.dataColumnType = dataColumnType;
            this.showSubTotals = showSubTotals;
        }
        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, bool showSubTotals, string numberFormat)
        {
            this.dataColumn = dataColumn;
            this.dataColumnName = dataColumn.ColumnName;
            this.dataColumnType = dataColumnType;
            this.showSubTotals = showSubTotals;
            this.numberFormat = numberFormat;
        }
        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, bool showSubTotals, string numberFormat, string sort, Array orderMembers)
        {
            this.dataColumn = dataColumn;
            this.dataColumnName = dataColumn.ColumnName;
            this.dataColumnType = dataColumnType;
            this.showSubTotals = showSubTotals;
            this.numberFormat = numberFormat;
            this.sort = sort;
            this.orderMembers = orderMembers;
        }
        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, string dataColumnName, bool showSubTotals)
        {
            this.dataColumn = dataColumn;
            this.dataColumnType = dataColumnType;
            this.dataColumnName = dataColumnName;
            this.showSubTotals = showSubTotals;
        }
        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, string dataColumnName, bool showSubTotals, string numberFormat)
        {
            this.dataColumn = dataColumn;
            this.dataColumnType = dataColumnType;
            this.dataColumnName = dataColumnName;
            this.showSubTotals = showSubTotals;
            this.numberFormat = numberFormat;
        }
        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, PivotTableDataColumnExpandType dataColumnExpandType, bool showSubTotals)
        {
            this.dataColumn = dataColumn;
            this.dataColumnName = dataColumn.ColumnName;
            this.dataColumnType = dataColumnType;
            this.showSubTotals = showSubTotals;
            this.dataColumnExpandType = dataColumnExpandType;
        }
        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, PivotTableDataColumnExpandType dataColumnExpandType, bool showSubTotals, string numberFormat, string sort, Array orderMembers)
        {
            this.dataColumn = dataColumn;
            this.dataColumnName = dataColumn.ColumnName;
            this.dataColumnType = dataColumnType;
            this.showSubTotals = showSubTotals;
            this.numberFormat = numberFormat;
            this.sort = sort;
            this.orderMembers = orderMembers;
            this.dataColumnExpandType = dataColumnExpandType;
        }
        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, Microsoft.Office.Interop.Owc11.PivotShowAsEnum dataColumnShowAs, string dataColumnName, bool showSubTotals)
        {
            this.dataColumn = dataColumn;
            this.dataColumnType = dataColumnType;
            this.dataColumnName = dataColumnName;
            this.showSubTotals = showSubTotals;
            this.dataColumnShowAs = dataColumnShowAs;
        }
        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, Microsoft.Office.Interop.Owc11.PivotTotalFunctionEnum dataColumnFunctionType, string dataColumnName, bool showSubTotals, string numberFormat)
        {
            this.dataColumn = dataColumn;
            this.dataColumnType = dataColumnType;
            this.dataColumnFunction = dataColumnFunctionType;
            this.dataColumnName = dataColumnName;
            this.showSubTotals = showSubTotals;
            this.numberFormat = numberFormat;
        }
        public PivotTableDataColumn(DataColumn dataColumn, PivotTableDataColumnType dataColumnType, Microsoft.Office.Interop.Owc11.PivotTotalFunctionEnum dataColumnFunctionType, string dataColumnName, bool showSubTotals)
        {
            this.dataColumn = dataColumn;
            this.dataColumnType = dataColumnType;
            this.dataColumnFunction = dataColumnFunctionType;
            this.dataColumnName = dataColumnName;
            this.showSubTotals = showSubTotals;
        }

        public PivotTableDataColumn(string fieldName, string expression, int solveOrder, string numberFormat, int totalIndex)
        {
            this.dataColumnType = PivotTableDataColumnType.CalculatedTotal;
            this.dataColumnName = fieldName;
            this.calculatedExpression = expression;
            this.solveOrder = solveOrder;
            this.numberFormat = numberFormat;
            this.totalIndex = totalIndex;
        }
    }
}
