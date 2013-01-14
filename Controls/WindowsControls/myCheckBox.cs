using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyControls.WindowsControls
{
    public partial class myCheckBox : CheckBox
    {
        private bool readOnly;
        public event EventHandler OnCheckChangedActions;

        public myCheckBox()
        {
            InitializeComponent();
            LoadMySettings();
        }

        public myCheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void LoadMySettings()
        {
            this.ForeColor = Color.White;
            this.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAlign = ContentAlignment.MiddleRight;
        }

        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
            }
        }

        protected override void
            OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            if (readOnly)
                e.Handled = true;
            base.OnKeyDown(e);
        }

        protected override void
            OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (readOnly)
                e.Handled = true;
            base.OnKeyPress(e);
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // WM_LBUTTONDOWN && WM_LBUTTONDBLCLK
            if ((m.Msg != 0x201 && m.Msg != 0x203) || !readOnly)
                base.WndProc(ref m);
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            if (this.DataBindings.Count == 0)
            {
                if (OnCheckChangedActions != null)
                    OnCheckChangedActions(this, null);
                return;
            }

            if (((BindingSource)this.DataBindings[0].DataSource)!= null)
            {
                ((BindingSource)this.DataBindings[0].DataSource).RaiseListChangedEvents = false;
                if (OnCheckChangedActions != null)
                    OnCheckChangedActions(this, null);
                ((BindingSource)this.DataBindings[0].DataSource).RaiseListChangedEvents = true;
            }
        }
    }
}
