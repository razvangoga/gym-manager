using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Helpers.GeneralOperations;

namespace DAL.Logic
{
    public class GeneralDatabaseAccess
    {
        #region Execute queries, sp, scalars, readers
        private static object ExecuteStatement(string sSqlStatement, SqlParameter[] prmArray, CommandType commandType, ExecuteType executeType)
        {
            SqlConnection conn = null;
            SqlCommand cmd;
            object oResult = null;

            try
            {
                conn = new SqlConnection(Session.ConnectionString);

                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 10000;
                cmd.CommandText = sSqlStatement;
                cmd.CommandType = commandType;

                if (prmArray != null)
                    cmd.Parameters.AddRange(prmArray);

                if (executeType == ExecuteType.NonQuery)
                    oResult = cmd.ExecuteNonQuery();
                if (executeType == ExecuteType.Scalar)
                    oResult = cmd.ExecuteScalar();
                if (executeType == ExecuteType.Reader)
                    oResult = cmd.ExecuteReader();

                conn.Close();
            }
            catch (SqlException se)
            {
                string sPrmArrayValues = string.Format("[{0} : ",prmArray.ToString());

                for (int i=0; i<prmArray.Length; i++)
                {
                    sPrmArrayValues += string.Format("'{0}'{1}",prmArray[i].Value, ((i != prmArray.Length-1) ? "," : "]"));
                }

                FileOperations.WriteToExceptionLog("DAL.Logic.GeneralDatabaseAccess.ExecuteStatement", se.ToString(), sSqlStatement, sPrmArrayValues, commandType.ToString(), executeType.ToString());
                throw se;
            }
            finally
            {
                if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Executing
                    || conn.State == ConnectionState.Fetching || conn.State == ConnectionState.Connecting)
                {
                    conn.Close();
                }
            }

            return oResult;
        }

        /// <summary>
        /// Execute sp with parameters
        /// </summary>
        /// <param name="sSPName">sp name</param>
        /// <param name="prmArray">parameter array</param>
        /// <returns>nr of affected rows</returns>
        public static int ExecuteStoredProcedure(string sSPName, SqlParameter[] prmArray)
        {
            return Convert.ToInt32(ExecuteStatement(sSPName, prmArray, CommandType.StoredProcedure, ExecuteType.NonQuery));
        }

        /// <summary>
        /// Execute sp with no parameters
        /// </summary>
        /// <param name="sSPName">sp name</param>
        /// <returns>nr of affected rows</returns>
        public static int ExecuteStoredProcedure(string sSPName)
        {
            return Convert.ToInt32(ExecuteStatement(sSPName, null, CommandType.StoredProcedure, ExecuteType.NonQuery));
        }

        /// <summary>
        /// Execute query with parameters
        /// </summary>
        /// <param name="sSqlStatement">query</param>
        /// <param name="prmArray">parameter array</param>
        /// <param name="commandType">command type</param>
        /// <returns>nr of affected rows</returns>
        public static int ExecuteQuery(string sSqlStatement, SqlParameter[] prmArray, CommandType commandType)
        {
            return Convert.ToInt32(ExecuteStatement(sSqlStatement, prmArray, commandType, ExecuteType.NonQuery));
        }

        /// <summary>
        /// Execute query with parameters (command type is Text)
        /// </summary>
        /// <param name="sSqlStatement">query</param>
        /// <param name="prmArray">parameter array</param>
        /// <returns>nr of affected rows</returns>
        public static int ExecuteQuery(string sSqlStatement, SqlParameter[] prmArray)
        {
            return Convert.ToInt32(ExecuteStatement(sSqlStatement, prmArray, CommandType.Text, ExecuteType.NonQuery));
        }

        /// <summary>
        /// Execute query with no parameters (command type is Text)
        /// </summary>
        /// <param name="sSqlStatement">query</param>
        /// <returns>nr of affected rows</returns>
        public static int ExecuteQuery(string sSqlStatement)
        {
            return Convert.ToInt32(ExecuteStatement(sSqlStatement, null, CommandType.Text, ExecuteType.NonQuery));
        }

        /// <summary>
        /// Execute Scalar with parameters
        /// </summary>
        /// <param name="sSqlStatement">query</param>
        /// <param name="prmArray">parameter array</param>
        /// <param name="commandType">command type</param>
        /// <returns>scalar value</returns>
        public static object ExecuteScalar(string sSqlStatement, SqlParameter[] prmArray, CommandType commandType)
        {
            return ExecuteStatement(sSqlStatement, prmArray, commandType, ExecuteType.Scalar);
        }

        /// <summary>
        /// Execute Scalar with parameters (command type is Text)
        /// </summary>
        /// <param name="sSqlStatement">query</param>
        /// <param name="prmArray">parameter array</param>
        /// <returns>scalar value</returns>
        public static object ExecuteScalar(string sSqlStatement, SqlParameter[] prmArray)
        {
            return ExecuteStatement(sSqlStatement, prmArray, CommandType.Text, ExecuteType.Scalar);
        }

        /// <summary>
        /// Execute Scalar with no parameters (command type is Text)
        /// </summary>
        /// <param name="sSqlStatement">query</param>
        /// <returns>scalar value</returns>
        public static object ExecuteScalar(string sSqlStatement)
        {
            return ExecuteStatement(sSqlStatement, null, CommandType.Text, ExecuteType.Scalar);
        }

        public static SqlDataReader ExecuteReader(string sSqlStatement, SqlParameter[] prmArray)
        {
            return (SqlDataReader)ExecuteStatement(sSqlStatement, prmArray, CommandType.Text, ExecuteType.Reader);
        }

        public static SqlDataReader ExecuteReader(string sSqlStatement)
        {
            return (SqlDataReader)ExecuteStatement(sSqlStatement, null, CommandType.Text, ExecuteType.Reader);
        }
        #endregion

        #region Execute fill, merge
        public static void FillDataTable(string sSqlStatement, DataTable table, DataFetchType dataFetchType)
        {
            FillDataTable(sSqlStatement, table, dataFetchType, null, false);
        }

        public static void FillDataTable(string sSqlStatement, DataTable table, DataFetchType dataFetchType, bool preseveChanges)
        {
            FillDataTable(sSqlStatement, table, dataFetchType, null, preseveChanges);
        }

        public static void FillDataTable(string sSqlStatement, DataTable table, DataFetchType dataFetchType, SqlParameter[] prmArray)
        {
            FillDataTable(sSqlStatement, table, dataFetchType, prmArray, false);
        }

        public static void FillDataTable(string sSqlStatement, DataTable table, DataFetchType dataFetchType, SqlParameter[] prmArray, bool preseveChanges)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sda = null;

            conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandTimeout = 10000;
            cmd.CommandText = sSqlStatement;
            cmd.CommandType = CommandType.Text;

            if (prmArray != null)
                cmd.Parameters.AddRange(prmArray);
            sda = new SqlDataAdapter(cmd);

            if (dataFetchType == DataFetchType.Fill)
            {
                table.Clear();
                sda.Fill(table);
            }
            if (dataFetchType == DataFetchType.Merge)
            {
                DataTable tmpTable = new DataTable();
                sda.Fill(tmpTable);
                table.Merge(tmpTable, preseveChanges);
            }
            conn.Close();
        } 
        #endregion
       
    }

    #region enums
    public enum ExecuteType
    {
        NonQuery,
        Scalar,
        Reader
    }

    public enum DataFetchType
    {
        Fill,
        Merge
    } 
    #endregion
}
