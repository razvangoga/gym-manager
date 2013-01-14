using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MyControls.CustomControls.BaseControl;
using MyControls.Logic;

namespace MyControls.WindowsControls
{
    public partial class myComboBox : ComboBox
    {
        #region private members
        private bool readOnly;
        private Label messageStrip = null;
        private SearchType searchType = SearchType.FaraCautare;
        #endregion

        #region public members
        public SearchType SearchType
        {
            get { return searchType; }
            set { searchType = value; }
        }

        public Label MessageStrip
        {
            get { return messageStrip; }
            set { messageStrip = value; }
        }

        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;

                if (readOnly)
                {
                    this.BackColor = Color.LightGray;
                }
                else
                {
                    this.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                }
            }
        } 
        #endregion

        #region constructors
        public myComboBox()
        {
            InitializeComponent();
            LoadMySettings();
        }

        public myComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            LoadMySettings();
        } 
        #endregion

        #region miscelaneous methods
        private void LoadMySettings()
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormattingEnabled = true;
            this.ForeColor = Color.Black;
            this.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.DropDownStyle = ComboBoxStyle.DropDown;
        } 
        #endregion

        #region overriden events
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            if (!this.readOnly)
            {
                this.BackColor = Color.LightBlue;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (!this.readOnly)
                this.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }

        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            if (readOnly)
                e.Handled = true;
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (readOnly)
                e.Handled = true;
            base.OnKeyPress(e);
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // WM_LBUTTONDOWN && WM_LBUTTONDBLCLK
            if ((m.Msg != 0x201 && m.Msg != 0x203) || !readOnly)
            {
                base.WndProc(ref m);
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (this.messageStrip != null && this.searchType != SearchType.FaraCautare 
                    && this.readOnly == false
                    )
                {
                    if (this.DataSource != null && this.DataSource is BindingSource)
                    {
                        try
                        {
                            string sOriginalFilter = ((BindingSource)this.DataSource).Filter;

                            object oSelectedValue = BaseSearchControl.ShowDialog(this.searchType, sOriginalFilter);

                            if (oSelectedValue != null)
                            {
                                this.SelectedValue = oSelectedValue;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageStripFormatting.setMessageStripCustomMessage(this.messageStrip,
                                ex.Message, MessageType.Error);
                        }
                    }
                }
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (this.messageStrip != null && this.searchType != SearchType.FaraCautare && this.readOnly == false)
            {
                MessageStripFormatting.setMessageStripCustomMessage(this.messageStrip,
                    string.Format("Apasati F5 pentru deschiderea ferestrei de cautare {0}!", this.searchType.ToString().Replace("_", " ")),
                    MessageType.Message);
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (this.messageStrip != null && this.searchType != SearchType.FaraCautare && this.readOnly == false)
            {
                MessageStripFormatting.setMessageStrip(this.messageStrip);
            }
        } 
        #endregion
    }
}
