using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace MyControls.Logic
{
    public class XsltTransformWorker
    {
        public const string _HelpIndexPage = "Manual/Index.html";

        public static void Transform(DataSet dsSource, Stream sXsltResourcePath, string sOutputPath)
        {
            try
            {
                string sFullOutputPath = string.Format("{0}\\Reports\\{1}",
                    Application.StartupPath, sOutputPath);

                #region verify and create reports directory
                DirectoryInfo dr = new DirectoryInfo(string.Format("{0}\\Reports",
                    Application.StartupPath));

                if (!dr.Exists)
                    dr.Create(); 
                #endregion

                // read xml file
                XmlDataDocument xmlSourceDocument = new XmlDataDocument(dsSource);
                XPathDocument xslTransformationDocument = new XPathDocument(sXsltResourcePath);

                // compile the html output file
                XslCompiledTransform myXslTrans = new XslCompiledTransform();
                myXslTrans.Load(xslTransformationDocument);
                XmlTextWriter myWriter = new XmlTextWriter
                    (sFullOutputPath, null);
                myXslTrans.Transform(xmlSourceDocument, null, myWriter);
                myWriter.Close();
            }
            catch (XmlException xe)
            {
                throw xe;
            }
            catch (XPathException xpe)
            {
                throw xpe;
            }
            catch (XsltCompileException xce)
            {
                throw xce;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
