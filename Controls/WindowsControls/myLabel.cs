using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MyControls.WindowsControls
{
    public partial class myLabel : Label
    {
        public myLabel()
        {
            InitializeComponent();
            LoadMySettigs();
        }

        public myLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            LoadMySettigs();
        }

        private void LoadMySettigs()
        {
            this.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.White;
        }

        public new bool Enabled
        {
            get { return base.Enabled; }
            set
            {
                base.Enabled = value;
                this.ForeColor = Color.White;
            }
        }
    }
}
