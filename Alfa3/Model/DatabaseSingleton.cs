using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Model
{
    internal class DatabaseSingleton
    {
        private static SqlConnection conn = null;

        private DatabaseSingleton()
        {

        }

        public static SqlConnection GetInstance()
        {
            if (conn == null)
            {
                try
                {
                    SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
                    consStringBuilder.UserID = ReadSetting("Name");
                    consStringBuilder.Password = ReadSetting("Password");
                    consStringBuilder.InitialCatalog = ReadSetting("Database");
                    consStringBuilder.DataSource = ReadSetting("DataSource");
                    consStringBuilder.ConnectTimeout = 30;
                    conn = new SqlConnection(consStringBuilder.ConnectionString);
                    conn.Open();
                }
                catch (Exception ex)
                {

                    throw new Exception("Failed to establish a database connection.", ex);
                }
            }

            return conn;
        }

        public static void CloseConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Failed to close the database connection.", ex);
            }
            finally
            {
                conn = null;
            }
        }

        private static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (Exception ex)
            {
                // Handle configuration errors here
                // For example, log the exception or display an error message
                throw new Exception("Failed to read the configuration setting.", ex);
            }
        }



        public static bool IsConnectionOpen()
        {
            // Check if the connection is open
            // Return true if the connection is open, otherwise false
            return conn != null && conn.State == ConnectionState.Open;
        }

    }
}
