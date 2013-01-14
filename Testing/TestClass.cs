using System;
using System.ComponentModel;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Testing
{
    public class TestClass<T> : BindingList<T>, IBindingListView
    {
        #region IBindingListView Members

        public void ApplySort(ListSortDescriptionCollection sorts)
        {
            throw new NotImplementedException();
        }

        public string Filter
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void RemoveFilter()
        {
            throw new NotImplementedException();
        }

        public ListSortDescriptionCollection SortDescriptions
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsAdvancedSorting
        {
            get { return false; }
        }

        public bool SupportsFiltering
        {
            get { return true; }
        }

        #endregion
    }
}
