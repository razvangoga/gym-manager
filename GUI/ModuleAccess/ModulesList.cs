using System.IO;
using System.Reflection;

namespace GUI.ModuleAccess {


    partial class ModulesList
    {
        partial class ModulesDataTable
        {
            /// <summary>
            /// load modules from xml document
            /// </summary>
            public void LoadModules()
            {
                Assembly assembly = Assembly.GetAssembly(typeof(GUI.Properties.Resources));
                Stream stream;
                stream = assembly.GetManifestResourceStream("GUI.ModuleAccess.ModulesList.xml");

                this.ReadXml(stream);

                stream.Dispose();
                assembly = null;
            }

            /// <summary>
            /// markes the contol of the specified type as closed
            /// </summary>
            /// <param name="sModuleType">module type</param>
            public void MarkModuleAsClosed(string sModuleType)
            {
                for (int i = 0; i < this.Rows.Count; i++)
                {
                    if (((ModulesRow)this.Rows[i]).control.Contains(sModuleType))
                    {
                        ((ModulesRow)this.Rows[i]).isopen = false;
                        return;
                    }
                }
            }
        }
    }
}
