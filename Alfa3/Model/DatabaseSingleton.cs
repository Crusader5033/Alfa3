using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Alfa3.Model
{
    /// <summary>
    /// Represents a singleton class for managing the database connection.
    /// </summary>
    internal class DatabaseSingleton
    {
        private static SqlConnection conn = null;

        /// <summary>
        /// Private constructor to prevent external instantiation.
        /// </summary>
        private DatabaseSingleton()
        {
            // The constructor is empty as the class is designed as a singleton.
        }

        /// <summary>
        /// Gets the instance of the database connection.
        /// </summary>
        /// <returns>A SqlConnection object representing the database connection.</returns>
        public static SqlConnection GetInstance()
        {
            if (conn == null)
            {
                try
                {
                    // Build a connection string using configuration settings.
                    SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
                    consStringBuilder.UserID = ReadSetting("Name");
                    consStringBuilder.Password = ReadSetting("Password");
                    consStringBuilder.InitialCatalog = ReadSetting("Database");
                    consStringBuilder.DataSource = ReadSetting("DataSource");
                    consStringBuilder.ConnectTimeout = 30;

                    // Create a new SqlConnection and open the connection.
                    conn = new SqlConnection(consStringBuilder.ConnectionString);
                    conn.Open();
                }
                catch (Exception ex)
                {
                    // Throw an exception if the connection cannot be established.
                    throw new Exception("Failed to establish a database connection.", ex);
                }
            }

            return conn;
        }

        /// <summary>
        /// Closes the database connection.
        /// </summary>
        public static void CloseConnection()
        {
            try
            {
                // Close and dispose of the connection if it is not null.
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                // Throw an exception if the connection cannot be closed.
                throw new Exception("Failed to close the database connection.", ex);
            }
            finally
            {
                // Set the connection to null after closing.
                conn = null;
            }
        }

        /// <summary>
        /// Reads a configuration setting from the application settings.
        /// </summary>
        /// <param name="key">The key of the configuration setting to read.</param>
        /// <returns>The value of the configuration setting.</returns>
        private static string ReadSetting(string key)
        {
            try
            {
                // Read the configuration setting using ConfigurationManager.
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (Exception ex)
            {
                // Handle configuration errors by throwing an exception.
                throw new Exception("Failed to read the configuration setting.", ex);
            }
        }

        /// <summary>
        /// Checks if the database connection is open.
        /// </summary>
        /// <returns>True if the connection is open, otherwise false.</returns>
        public static bool IsConnectionOpen()
        {
            // Check if the connection is open and return the result.
            return conn != null && conn.State == ConnectionState.Open;
        }
    }
}
