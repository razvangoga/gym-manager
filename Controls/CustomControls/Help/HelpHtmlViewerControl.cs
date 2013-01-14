using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyControls.CustomControls.Help
{
    public partial class HelpHtmlViewerControl : MyControls.CustomControls.BaseControl.BaseHtmlViewerControl
    {
        public HelpHtmlViewerControl()
        {
            InitializeComponent();
        }

        protected override void AfterLoad()
        {
            base.AfterLoad();
            this.LoadHtmlHelp();
        }
    }
}

