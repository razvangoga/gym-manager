using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Helpers.GeneralOperations
{
    public class FileOperations
    {
        #region private members
        private static string _sApplicationPath = string.Empty;
        private const string _sLogFolderName = "Logs"; 
        #endregion

        static FileOperations()
        {
            _sApplicationPath = AppDomain.CurrentDomain.BaseDirectory;
        }

        /// <summary>
        /// Checks if the specified folder path exists.
        /// If the folder path does not exist, it will be created.
        /// </summary>
        /// <param name="sPath">path to be checked</param>
        public static void CheckIfExistsAndCreateFolder(string p_sPath)
        {
            if (!Directory.Exists(p_sPath))
                try
                {
                    Directory.CreateDirectory(p_sPath);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        /// <summary>
        /// Checks if the specified file exists in the specified path.
        /// If the file does not exist, it will be created. 
        /// </summary>
        /// <param name="sPath">path to be checked</param>
        /// <param name="sFileName">file to be checked</param>
        /// <returns>true is file exists, false if file does not exist (and is created)</returns>
        public static bool CheckIfExistsAndCreateFile(string p_sPath, string p_sFileName)
        {
            CheckIfExistsAndCreateFolder(p_sPath);

            if (!File.Exists(string.Format("{0}\\{1}", p_sPath, p_sFileName)))
            {
                try
                {
                    FileStream fs = File.Create(string.Format("{0}\\{1}", p_sPath, p_sFileName));
                    fs.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Writes given string to specified file in specified path
        /// </summary>
        /// <param name="sPath">the file path</param>
        /// <param name="sFileName">the file to append</param>
        /// <param name="sText">text to be written</param>
        public static void WriteToFile(string p_sPath, string p_sFileName, string p_sText)
        {
            CheckIfExistsAndCreateFile(p_sPath, p_sFileName);

            StreamWriter sw = File.AppendText(string.Format("{0}\\{1}", p_sPath, p_sFileName));
            sw.WriteLine(p_sText);
            sw.Close();
        }

        /// <summary>
        /// Writes Exception text to today's exception log.
        /// The date of the log write is added automaticaly.
        /// </summary>
        /// <param name="p_sExceptionOrigin">exception origin place</param>
        /// <param name="p_sLogEntry">text to be logged</param>
        /// <param name="p_sOriginParameters">exeception method arguments</param>
        public static void WriteToExceptionLog(string p_sExceptionOrigin, string p_sLogEntry, params object[] p_oOriginParameters)
        {
            string sFullLogEntry = string.Empty;
            sFullLogEntry += string.Format("[Exception log time : {0}]{1}",
               DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), Environment.NewLine);
            sFullLogEntry += string.Format("[Exception origin : {0}]{1}",
                p_sExceptionOrigin, Environment.NewLine);

            sFullLogEntry += "[Exception parameters : ";
            for (int i = 0; i < p_oOriginParameters.Length; i++)
            {
                sFullLogEntry += string.Format("'{0}'{1}", 
                    p_oOriginParameters[i].ToString(), ((i != p_oOriginParameters.Length - 1) ? "," : string.Empty));
            }
            sFullLogEntry += string.Format("]{0}", Environment.NewLine);

            sFullLogEntry += string.Format("{0}{1}",
                p_sLogEntry, Environment.NewLine);

            WriteToFile(string.Format("{0}\\{1}", _sApplicationPath, _sLogFolderName),
                string.Format("{0}_Exceptions.log", DateTime.Today.ToString("yyyyMMdd")),
                sFullLogEntry);
        }
    }
}
