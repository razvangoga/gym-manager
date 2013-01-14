using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL.Security;
using DAL.Logic;
using DAL.Models.Nomenclators;
using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace GUI.Nomenclators.ProductTypes
{
    public partial class ProductTypesControl : BaseControl
    {
        public ProductTypesControl()
        {
            InitializeComponent();
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();
            this.baseBindingSource.DataSource = Session.Product_Types;
        }

        protected override void SaveEditAfterActions()
        {
            base.SaveEditAfterActions();
            NomenclatorsModelMethods.ProductTypeMethods.EditProductType(this.CurrentRow());
        }

        protected override void SaveNewAfterActions()
        {
            base.SaveNewAfterActions();
            NomenclatorsModelMethods.ProductTypeMethods.AddProductType(this.CurrentRow());
        }

        protected override bool DeleteBeforeActions()
        {
            if (base.DeleteBeforeActions())
            {
                NomenclatorsModelMethods.ProductTypeMethods.DeleteProductType(this.CurrentRow());
                return true;
            }
            else
            {
                return false;
            }
        }

        protected new Product_Type CurrentRow()
        {
            return (Product_Type)base.CurrentRow();
        }
    }
}
