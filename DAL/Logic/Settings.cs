using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL.Logic
{
    public static class Settings
    {
        public static string Gray_GymManagerConnectionString
        {
            get
            {
                return Properties.Settings.Default.ConnectionString;
            }
            set
            {
                Properties.Settings.Default["ConnectionString"] = value;
                Properties.Settings.Default["Gray_GymManagerConnectionString"] = value;
            }
        }

        public static void Save()
        {
            Properties.Settings.Default.Save();
        }

        public static void Load()
        {
            Properties.Settings.Default["Gray_GymManagerConnectionString"] = Properties.Settings.Default.ConnectionString;
        }

        public static string BareConnectionString
        {
            get
            {
                return DAL.Properties.Resources.BareConnectionString;
            }
        }

        /// <summary>
        /// static method for testing database connection string
        /// </summary>
        /// <param name="sCnnString">connection string</param>
        /// <param name="sErrMsg"> output error messge ( if connection atempt fails)</param>
        /// <returns>true if string allows db connection, false otherwise</returns>
        public static bool TestConnection(string sCnnString, out string sErrMsg)
        {
            SqlConnection cnnTest = new SqlConnection(string.Format(sCnnString));

            try
            {
                cnnTest.Open();
            }
            catch (SqlException se)
            {
                sErrMsg = se.Message;
                return false;
            }
            cnnTest.Close();
            sErrMsg = string.Empty;
            Session.ResetSessionConnections();
            return true;
        }
    }
}