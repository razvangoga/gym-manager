using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using System.Windows.Forms;

namespace MyControls.Logic
{
    public class Miscelanious
    {
        public static bool IsDesignMode()
        {
            return System.Reflection.Assembly.GetEntryAssembly() == null;
        }

        public static void SetBindingSource(BindingSource destinationBindingSource, BindingSource sourceBindingSource)
        {
            destinationBindingSource.DataSource = sourceBindingSource.DataSource;
            destinationBindingSource.DataMember = sourceBindingSource.DataMember;
            destinationBindingSource.Filter = sourceBindingSource.Filter;
            destinationBindingSource.AllowNew = sourceBindingSource.AllowNew;
            destinationBindingSource.Sort = sourceBindingSource.Sort;
            if (sourceBindingSource is IBindingListView && ((IBindingListView)sourceBindingSource).SortDescriptions != null)
                ((IBindingListView)destinationBindingSource).ApplySort(((IBindingListView)sourceBindingSource).SortDescriptions);

            destinationBindingSource.Position = sourceBindingSource.Position;
        }

        public static void IsNumber(string sFieldName, string sValue, NumberType nType)
        {
            try
            {
                if (nType == NumberType.Int)
                    Convert.ToInt32(sValue);
                if (nType == NumberType.Float)
                    Convert.ToDouble(sValue);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("In campul '{0}' trebuie introdusa o valoare numerica!",sFieldName));
            }

            if (sFieldName == "Pret" && Convert.ToDouble(sValue) < 0)
                throw new Exception("Pretul nu poate fii negativ!");
        }
    }

    public enum NumberType { Int, Float }
}
