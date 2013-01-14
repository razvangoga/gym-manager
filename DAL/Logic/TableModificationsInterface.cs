using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface TableModificationsInterface
    {
        DateTime LastModificationDate
        {
            get;
            set;
        }

        void LoadStaticData();
    }
}
