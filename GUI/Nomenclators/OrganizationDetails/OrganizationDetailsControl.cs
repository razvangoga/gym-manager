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

namespace GUI.Nomenclators.OrganizationDetails
{
    public partial class OrganizationDetailsControl : BaseControl
    {
        public OrganizationDetailsControl()
        {
            InitializeComponent();
        }

        protected override void AfterControlLoad()
        {
            base.AfterControlLoad();
            this.baseMyBindingNavigator.PanelAdd = false;
            this.baseMyBindingNavigator.PanelDeleteing = false;
            this.baseMyBindingNavigator.PanelNavigation = false;

            this.baseBindingSource.DataSource = Session.Organization_Details;
        }

        protected override void SaveEditAfterActions()
        {
            base.SaveEditAfterActions();
            NomenclatorsModelMethods.OrganizationDetailsMethods.EditOrganizationDetails(this.CurrentRow());
        }

        protected new Organization_Detail CurrentRow()
        {
            return (Organization_Detail)base.CurrentRow();
        }
    }
}
