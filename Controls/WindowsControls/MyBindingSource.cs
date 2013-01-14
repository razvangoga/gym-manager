using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace MyControls.WindowsControls
{
    public class myBindingSource : BindingSource
    {
        public myBindingSource() : base() { }
        public myBindingSource(IContainer container) : base(container) { }
        public myBindingSource(object dataSource, string dataMember) : base(dataSource, dataMember) { }

        public override bool SupportsFiltering
        {
            get
            {
                return true;
            }
        }
    }
}
