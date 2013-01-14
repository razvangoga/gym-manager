using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MyControls.WindowsControls.PivotTableColumns
{
    public class PivotTableFormater
    {
        public static void Format(AxMicrosoft.Office.Interop.Owc11.AxPivotTable axPivotTable1, List<PivotTableDataColumn> pivotTableDataColumns)
        {
            string columnName = "";
            int fontSize = 7;
            string fontName = "Microsoft Sans Serif";
            Microsoft.Office.Interop.Owc11.PivotFieldSet fieldSet = null;
            Microsoft.Office.Interop.Owc11.PivotTotalFunctionEnum function;
            Microsoft.Office.Interop.Owc11.PivotTotal pivotTotal;

            for (int i = 0; i < pivotTableDataColumns.Count; i++)
            {
                try
                {
                    fieldSet = null;
                    if (pivotTableDataColumns[i].dataColumn != null) 
                        columnName = pivotTableDataColumns[i].dataColumn.ColumnName;
                    else columnName = pivotTableDataColumns[i].dataColumnName;

                    #region Data Axis
                    if (pivotTableDataColumns[i].dataColumnType == PivotTableDataColumn.PivotTableDataColumnType.DataAxis)
                    {
                        axPivotTable1.ActiveView.DataAxis.InsertFieldSet(axPivotTable1.ActiveView.FieldSets[columnName], null, false);

                        function = pivotTableDataColumns[i].dataColumnFunction;

                        if (pivotTableDataColumns[i].dataColumnName != null)
                            pivotTotal = axPivotTable1.ActiveView.AddTotal(pivotTableDataColumns[i].dataColumnName, axPivotTable1.ActiveView.FieldSets[columnName].Fields[columnName], function);
                        else
                            pivotTotal = axPivotTable1.ActiveView.AddTotal(columnName, axPivotTable1.ActiveView.FieldSets[columnName].Fields[columnName], function);

                        if (pivotTableDataColumns[i].totalIndex == -1) axPivotTable1.ActiveView.DataAxis.InsertTotal(pivotTotal, false);
                        else axPivotTable1.ActiveView.DataAxis.InsertTotal(pivotTotal, pivotTableDataColumns[i].totalIndex);

                        if (pivotTableDataColumns[i].numberFormat != null) pivotTotal.NumberFormat = pivotTableDataColumns[i].numberFormat;
                        pivotTotal.ShowAs = pivotTableDataColumns[i].dataColumnShowAs;

                        fieldSet = axPivotTable1.ActiveView.DataAxis.FieldSets[columnName];
                    }
                    #endregion

                    #region Row Axis
                    if (pivotTableDataColumns[i].dataColumnType == PivotTableDataColumn.PivotTableDataColumnType.RowAxis)
                    {
                        axPivotTable1.ActiveView.RowAxis.InsertFieldSet(axPivotTable1.ActiveView.FieldSets[columnName], null, false);
                        fieldSet = axPivotTable1.ActiveView.RowAxis.FieldSets[columnName];
                    }
                    #endregion

                    #region Column Axis
                    if (pivotTableDataColumns[i].dataColumnType == PivotTableDataColumn.PivotTableDataColumnType.ColumnAxis)
                    {
                        axPivotTable1.ActiveView.ColumnAxis.InsertFieldSet(axPivotTable1.ActiveView.FieldSets[columnName], null, false);
                        fieldSet = axPivotTable1.ActiveView.ColumnAxis.FieldSets[columnName];
                    }
                    #endregion

                    #region Calculated Total
                    if (pivotTableDataColumns[i].dataColumnType == PivotTableDataColumn.PivotTableDataColumnType.CalculatedTotal)
                    {
                        //Microsoft.Office.Interop.Owc11.PivotFieldSet fs;
                        //fs = axPivotTable1.ActiveView.AddFieldSet(columnName);
                        //fs.AddCalculatedField(columnName, columnName, columnName, pivotTableDataColumns[i].calculatedExpression);
                        //pivotTotal = axPivotTable1.ActiveView.AddTotal(columnName, fs.Fields[columnName], pivotTableDataColumns[i].dataColumnFunction);

                        pivotTotal = axPivotTable1.ActiveView.AddCalculatedTotal(columnName, columnName, pivotTableDataColumns[i].calculatedExpression, pivotTableDataColumns[i].solveOrder);
                        pivotTotal.NumberFormat = pivotTableDataColumns[i].numberFormat;
                        pivotTotal.ShowAs = pivotTableDataColumns[i].dataColumnShowAs;
                        if (pivotTableDataColumns[i].totalIndex == -1) axPivotTable1.ActiveView.DataAxis.InsertTotal(pivotTotal, null);
                        else axPivotTable1.ActiveView.DataAxis.InsertTotal(pivotTotal, pivotTableDataColumns[i].totalIndex);
                    }
                    #endregion

                    if (fieldSet != null)
                    {
                        if (pivotTableDataColumns[i].numberFormat != null) fieldSet.Fields[columnName].NumberFormat = pivotTableDataColumns[i].numberFormat;
                        if (!pivotTableDataColumns[i].showSubTotals) fieldSet.Fields[columnName].set_Subtotals(0, false);
                        else
                        {
                            fieldSet.Fields[columnName].SubtotalBackColor = Color.Yellow.ToArgb();
                            fieldSet.Fields[columnName].SubtotalFont.Name = fontName;
                            fieldSet.Fields[columnName].SubtotalFont.Size = fontSize;
                            fieldSet.Fields[columnName].SubtotalLabelBackColor = Color.Yellow.ToArgb();
                            fieldSet.Fields[columnName].SubtotalLabelFont.Name = fontName;
                            fieldSet.Fields[columnName].SubtotalLabelFont.Size = fontSize;

                            fieldSet.Fields[columnName].Caption = pivotTableDataColumns[i].dataColumnName;

                            fieldSet.Caption = pivotTableDataColumns[i].dataColumnName;
                        }
                        if (pivotTableDataColumns[i].dataColumnExpandType == PivotTableDataColumn.PivotTableDataColumnExpandType.Collapsed) fieldSet.Fields[columnName].Expanded = false;

                        if (pivotTableDataColumns[i].sort == "custom")
                        {
                            fieldSet.Fields[columnName].SortDirection = Microsoft.Office.Interop.Owc11.PivotFieldSortDirectionEnum.plSortDirectionCustom;
                            fieldSet.Fields[columnName].OrderedMembers = pivotTableDataColumns[i].orderMembers;
                        }
                        fieldSet.Fields[columnName].GroupedFont.Name = fontName;
                        fieldSet.Fields[columnName].GroupedFont.Size = fontSize;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(string.Format("col:{0}, index: {1}", columnName, i), ex);
                }
            }

            //sa nu apara acele +/- mici in dreptul fiecarei coloane sau rand
            axPivotTable1.ActiveView.ExpandDetails = Microsoft.Office.Interop.Owc11.PivotTableExpandEnum.plExpandNever;

            axPivotTable1.ActiveView.HeaderFont.Name = fontName;
            axPivotTable1.ActiveView.HeaderFont.Size = fontSize;
            axPivotTable1.ActiveView.FieldLabelFont.Name = fontName;
            axPivotTable1.ActiveView.FieldLabelFont.Size = fontSize;
            axPivotTable1.ActiveView.TotalFont.Name = fontName;
            axPivotTable1.ActiveView.TotalFont.Size = fontSize;
            axPivotTable1.ActiveView.DataAxis.Label.Font.Name = fontName;
            axPivotTable1.ActiveView.DataAxis.Label.Font.Size = fontSize;
            axPivotTable1.ActiveView.ColumnAxis.Label.Font.Name = fontName;
            axPivotTable1.ActiveView.ColumnAxis.Label.Font.Size = fontSize;
            axPivotTable1.ActiveView.RowAxis.Label.Font.Name = fontName;
            axPivotTable1.ActiveView.RowAxis.Label.Font.Size = fontSize;

            axPivotTable1.ActiveView.DisplayCalculatedMembers = false;
        }
    }
}
