using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using DAL.Logic;
using DAL.Models;

namespace MyControls.CustomControls.BaseControl
{
    public partial class BaseSearchControl : UserControl
    {
        #region private members
        private SearchType searchType = SearchType.FaraCautare;
        private string sOriginalFiler = string.Empty;
        private object oSelectedValue = null;
        private DataSet dsSearchDataSet;
        #endregion

        #region public members
        public Button AcceptButton
        {
            get
            {
                return this.selectMyRibbonMenuButton;
            }
        }

        public Button CancelButton
        {
            get
            {
                return this.exitMyRibbonMenuButton;
            }
        } 
        #endregion

        #region constructors
        public BaseSearchControl()
        {
            InitializeComponent();
        }

        public BaseSearchControl(SearchType searchType, string sOriginalFilter)
            : this()
        {
            this.searchType = searchType;
            this.sOriginalFiler = sOriginalFilter;
        } 
        #endregion

        #region event handlers
        private void selectMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            this.SaveAndClose();
        }

        private void exitMyRibbonMenuButton_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        }

        private void BaseSearchControl_Load(object sender, EventArgs e)
        {
            this.SetSearchDataSource();
            this.SetColumnDataProprieties();
            this.SetObjectName();
        }

        private void listMyDataGridViewRO_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.SaveAndClose();
            }
        }

        private void codeFilterMyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.SaveAndClose();
            }
        }

        private void nameFilterMyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.SaveAndClose();
            }
        }

        private void codeFilterMyTextBox_TextChanged(object sender, EventArgs e)
        {
            this.FilterDataSource();
        }

        private void nameFilterMyTextBox_TextChanged(object sender, EventArgs e)
        {
            this.FilterDataSource();
        } 
        #endregion

        #region private methods
        public static object ShowDialog(SearchType searchType, string sOriginalFilter)
        {
            Form frmSearch = new Form();
            frmSearch.Size = new Size(505, 355);
            frmSearch.StartPosition = FormStartPosition.CenterParent;
            frmSearch.FormBorderStyle = FormBorderStyle.None;
            frmSearch.ShowInTaskbar = false;

            BaseSearchControl baseSearchControl = new BaseSearchControl(searchType, sOriginalFilter);
            frmSearch.Controls.Add(baseSearchControl);
            baseSearchControl.Dock = DockStyle.Fill;

            frmSearch.AcceptButton = baseSearchControl.AcceptButton;
            frmSearch.CancelButton = baseSearchControl.CancelButton;

            frmSearch.ShowDialog();

            return baseSearchControl.oSelectedValue;
        }

        private void SetObjectName()
        {
            this.searchGroupBox.Text = string.Format(this.searchGroupBox.Text, this.searchType.ToString().Replace("_", " "));
            this.codeMyLabel.Text = string.Format(this.codeMyLabel.Text, this.searchType.ToString().Replace("_"," "));
            this.nameMyLabel.Text = string.Format(this.nameMyLabel.Text, this.searchType.ToString().Replace("_", " "));
        }

        private void SetSearchDataSource()
        {
            try
            {
                //if (searchType == SearchType.Produs || searchType == SearchType.Categorie_Produse)
                //{
                //    dsSearchDataSet = Session.ProductsModel;
                //    this.listBindingSource.DataSource = dsSearchDataSet;

                //    if (searchType == SearchType.Produs)
                //    {
                //        this.listBindingSource.DataMember = ((ProductsModel)dsSearchDataSet).products.TableName;
                //    }
                //    else
                //    {
                //        this.listBindingSource.DataMember = ((ProductsModel)dsSearchDataSet).product_types.TableName;
                //    }
                //}

                this.listBindingSource.Filter = this.sOriginalFiler;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SetColumnDataProprieties()
        {
            try
            {
                colId.DataPropertyName = dsSearchDataSet.Tables[listBindingSource.DataMember].Columns[0].ColumnName;

                //if (searchType == SearchType.Articol_Furnizor || searchType == SearchType.UM ||
                //    searchType == SearchType.Produs || searchType == SearchType.Ambalaj)
                //{
                //    colCod.DataPropertyName = dsSearchDataSet.Tables[listBindingSource.DataMember].Columns[1].ColumnName;
                //    colName.DataPropertyName = dsSearchDataSet.Tables[listBindingSource.DataMember].Columns[2].ColumnName;
                //}
                //else
                //{
                //    colName.DataPropertyName = dsSearchDataSet.Tables[listBindingSource.DataMember].Columns[1].ColumnName;
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SaveAndClose()
        {
            DialogResult dr = MessageBox.Show("Selectati linia curenta ?", "Atentie...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes && (DataRowView)this.listBindingSource.Current != null)
            {
                this.oSelectedValue = ((DataRowView)this.listBindingSource.Current).Row[0];
                ((Form)this.Parent).Close();
            }
        }

        private void FilterDataSource()
        {
            string sFilter = string.Empty;

            if (this.codeFilterMyTextBox.Text.Trim().Length > 0 && this.codeFilterMyTextBox.ReadOnly == false)
            {
                sFilter += string.Format("{0} LIKE '%{1}%' AND ",
                    this.dsSearchDataSet.Tables[this.listBindingSource.DataMember].Columns[colCod.DataPropertyName].ColumnName,
                    this.codeFilterMyTextBox.Text.Trim());
            }

            if (this.nameFilterMyTextBox.Text.Trim().Length > 0)
            {
                sFilter += string.Format("{0} LIKE '%{1}%' AND ", 
                    this.dsSearchDataSet.Tables[this.listBindingSource.DataMember].Columns[colName.DataPropertyName].ColumnName,
                    this.nameFilterMyTextBox.Text.Trim());
            }

            if (this.sOriginalFiler != null)
            {
                if (this.sOriginalFiler.Length > 0)
                {
                    sFilter += string.Format("{0} AND ", this.sOriginalFiler);
                }
            }

            try
            {
                if (sFilter.Length > 0)
                {
                    listBindingSource.Filter = sFilter.Substring(0, sFilter.Length - 4);
                }
                else
                {
                    listBindingSource.Filter = string.Empty;
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        #endregion
    }

    public enum SearchType
    {
        Product =0,
        Entry = 1,
        SubscriptionType = 2,
        Field = 3,
        FaraCautare = 4
    }
}
