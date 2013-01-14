using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyControls.WindowsControls
{
    public partial class myTextBox : TextBox
    {
        public myTextBox()
        {
            InitializeComponent();
            LoadMySettings();
        }

        public myTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            LoadMySettings();
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if(!this.ReadOnly)
                this.BackColor = Color.LightBlue;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if(!this.ReadOnly)
                this.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }

        private void LoadMySettings()
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ForeColor = Color.Black;
        }

        public new bool ReadOnly
        {
            get
            {
                return base.ReadOnly;
            }
            set
            {
                base.ReadOnly = value;

                if (value)
                {
                    this.BackColor = Color.LightGray;
                    this.ForeColor = Color.Black;
                }
                else
                {
                    this.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    this.ForeColor = Color.Black;
                }
            }
        }
    }
}
