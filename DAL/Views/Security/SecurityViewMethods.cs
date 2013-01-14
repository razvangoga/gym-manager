using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;

namespace DAL.Views.Security
{
    public class SecurityViewMethods
    {
        public class LockedObjectsViewMethods
        {
            public static List<Locked_Objects_View> GetCurrentLockedObjects()
            {
                var _query = from locked_Object_View in Session.SecurityView.Locked_Objects_Views
                             select locked_Object_View;

                return _query.ToList();
            }
        }
    }
}
