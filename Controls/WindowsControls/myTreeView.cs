using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyControls.WindowsControls
{
    public partial class myTreeView : TreeView
    {
        public myTreeView()
        {
            InitializeComponent();
            LoadMySettings();
        }

        public myTreeView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        
        private void LoadMySettings()
        {
            this.BackColor = Color.LightGray;
            this.BorderStyle = BorderStyle.None;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPlusMinus = false;
            this.ShowRootLines = false;
        }
    }
}
