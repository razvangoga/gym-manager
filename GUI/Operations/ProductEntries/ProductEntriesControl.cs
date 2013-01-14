using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL.Operations;
using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Operations.ProductEntries
{
    public partial class ProductEntriesControl : BaseControl
    {
        public ProductEntriesControl()
        {
            InitializeComponent();
            this.productEntryDatemyDateTimePicker.Value = DateTime.Today;
            this.EnableFilterButton = true;
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();

            this.productsBindingSource.DataSource = NomenclatorsModelMethods.ProductMethods.GetActiveProducts();
            LoadData(DateTime.Now);
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                try
                {
                    ProductEntriesLogic.CheckProductEntry(this.CurrentRow());
                    return true;
                }
                catch (Exception ex)
                {
                    MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                        ex.Message, MessageType.Warrning);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        protected override void SaveEditAfterActions()
        {
            base.SaveEditAfterActions();
            OperationsModelMethods.ProductEntriesMethods.EditProductEntry(this.CurrentRow());
            ProductEntriesLogic.SaveEntryDataOnProduct(this.CurrentRow());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            OperationsModelMethods.ProductEntriesMethods.AddProductEntry(this.CurrentRow());
            ProductEntriesLogic.SaveEntryDataOnProduct(this.CurrentRow());
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                OperationsModelMethods.ProductEntriesMethods.DeleteProductEntry(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected new Product_Entry CurrentRow()
        {
            return (Product_Entry)base.CurrentRow();
        }

        private void LoadData(DateTime p_date)
        {
            OperationsModelMethods.ProductEntriesMethods.GetDataByDay(p_date);
            this.baseBindingSource.DataSource = Session.Product_Entries;
            MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                string.Format("Achizitii produse din data : {0}", p_date.ToString("dd MMM yyyy")),
                MessageType.Message);
        }

        private void dateFilterMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadData(e.Start);
        }
    }
}
