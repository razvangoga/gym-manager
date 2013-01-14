using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MyControls.WindowsControls
{
    public partial class myDateTimePicker : DateTimePicker
    {
        private bool readOnly;
        public event EventHandler OnValueChangedActions;

        public myDateTimePicker()
        {
            InitializeComponent();
            LoadMySettings();
        }

        public myDateTimePicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void LoadMySettings()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CustomFormat = "dd - MMM - yyyy     hh : mm tt";
            this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Size = new System.Drawing.Size(229, 20);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public bool ReadOnly
        {
            get { return readOnly; }
            set { readOnly = value; }
        }

        public new System.Nullable<DateTime> Value
        {
            get
            {
                if (this.Checked)
                    return base.Value;
                else
                {
                    return new System.Nullable<DateTime>();
                }
            }

            set
            {
                if (value.HasValue)
                {
                    base.Value = value.Value;
                    if (this.ShowCheckBox) this.Checked = true;
                }
                else
                {
                    this.ShowCheckBox = true;
                    this.Checked = false;
                }
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

        protected override void OnValueChanged(EventArgs eventargs)
        {
            base.OnValueChanged(eventargs);

            if (this.DataBindings.Count == 0)
                return;

            if(((BindingSource)this.DataBindings[0].DataSource) != null)
            {
                ((BindingSource)this.DataBindings[0].DataSource).RaiseListChangedEvents = false;
                if (this.OnValueChangedActions != null)
                    this.OnValueChangedActions(this, null);
                ((BindingSource)this.DataBindings[0].DataSource).RaiseListChangedEvents = true;
            }
        }
    }
}
