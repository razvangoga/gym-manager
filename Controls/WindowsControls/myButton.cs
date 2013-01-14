using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyControls.WindowsControls
{
    public partial class myButton : Button
    {
        public myButton()
        {
            InitializeComponent();
            LoadMySettings();
        }

        public myButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            LoadMySettings();
        }

        private void LoadMySettings()
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FlatStyle = FlatStyle.Flat;
        }
    }
}
