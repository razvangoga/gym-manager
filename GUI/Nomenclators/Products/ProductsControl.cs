using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL.Nomenclators;
using DAL.Logic;
using DAL.Models.Nomenclators;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Nomenclators.Products
{
    public partial class ProductsControl : BaseControl
    {
        public ProductsControl()
        {
            InitializeComponent();
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();
            this.productsTypeBindingSource.DataSource = NomenclatorsModelMethods.ProductTypeMethods.GetActiveProductTypes();
            this.baseBindingSource.DataSource = Session.Products;
        }

        protected override bool SaveBeforeActions()
        {
            if (base.SaveBeforeActions())
            {
                try
                {
                    ProductsLogic.CheckPrice(this.CurrentRow());
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
            NomenclatorsModelMethods.ProductMethods.EditProduct(this.CurrentRow());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            NomenclatorsModelMethods.ProductMethods.AddProduct(this.CurrentRow());
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                NomenclatorsModelMethods.ProductMethods.DeleteProduct(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected new Product CurrentRow()
        {
            return (Product)base.CurrentRow();
        }
    }
}
