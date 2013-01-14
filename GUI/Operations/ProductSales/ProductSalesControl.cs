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

namespace GUI.Operations.ProductSales
{
    public partial class ProductSalesControl : BaseControl
    {
        public ProductSalesControl()
        {
            InitializeComponent();
            this.productSalesDatemyDateTimePicker.Value = DateTime.Today;
            this.EnableFilterButton = true;
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();

            this.productsBindingSource.DataSource = NomenclatorsModelMethods.ProductMethods.GetActiveProducts();
            this.clientsBindingSource.DataSource = NomenclatorsModelMethods.ClientMethods.GetActiveClients();
            LoadData(DateTime.Now);
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                try
                {
                    ProductSalesLogic.CheckProductSale(this.CurrentRow());
                    ProductSalesLogic.CheckProductStock(this.CurrentRow());
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
            OperationsModelMethods.ProductSalesMethods.EditProductSale(this.CurrentRow());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            OperationsModelMethods.ProductSalesMethods.AddProductSale(this.CurrentRow());
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                OperationsModelMethods.ProductSalesMethods.DeleteProductSale(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected new Product_Sale CurrentRow()
        {
            return (Product_Sale)base.CurrentRow();
        }

        private void LoadData(DateTime p_date)
        {
            OperationsModelMethods.ProductSalesMethods.GetDataByDay(p_date);
            this.baseBindingSource.DataSource = Session.Product_Sales;
            MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                string.Format("Vanzari produse din data : {0}", p_date.ToString("dd MMM yyyy")),
                MessageType.Message);
        }

        private void SetPriceOnProductSale()
        {
            try
            {
                ProductSalesLogic.SetPriceOnProductSale(this.CurrentRow());
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                    ex.Message, MessageType.Warrning);
            }
        }

        private void SetDiscountOnProductSale()
        {
            try
            {
                ProductSalesLogic.SetDiscountOnProductSale(this.CurrentRow());
            }
            catch (Exception ex)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.MessageStrip,
                    ex.Message, MessageType.Warrning);
            }
        }

        private void dateFilterMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.LoadData(e.Start);
        }

        private void product_idmyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CurrentRow() != null
                && this.product_idmyComboBox.Focused
                && this.product_idmyComboBox.SelectedValue != null)
                this.SetPriceOnProductSale();
        }

        private void client_idmyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CurrentRow() != null
                && this.client_idmyComboBox.Focused
                && this.client_idmyComboBox.SelectedValue != null)
                this.SetDiscountOnProductSale();
        }
    }
}
