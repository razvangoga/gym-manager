using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;

using MyControls.Logic;

using Testing;
using System.Drawing.Printing;
using Helpers.GeneralOperations;
using DAL.Models.Security;
using DAL;

namespace Testing
{
    public partial class Form1 : Form
    {
        SecurityModelDataContext db = new SecurityModelDataContext();

        public Form1()
        {
            InitializeComponent();

        }

        private void roleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.roleBindingSource.EndEdit();
            this.roles_Access_RightsBindingSource.EndEdit();

            Role r = this.roleBindingSource.Current as Role;

            ModelLogic.AddAuditDataAdd(r, 1);

            foreach (Roles_Access_Right rar in r.Roles_Access_Rights)
            {
                ModelLogic.AddAuditDataAdd(rar, 1);
            }

            db.SubmitChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.accessRightBindingSource.DataSource = from ar in db.Access_Rights
                                                       select ar;

            this.roleBindingSource.DataSource = db.Roles;
        }

        private void roles_Access_RightsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.ToString());
        }
    }
}