using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Alfa3.Model
{
    /// <summary>
    /// Represents a class for handling Role-related operations in the database.
    /// </summary>
    internal class Role
    {
        private SqlConnection connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
            // Establishes a database connection using the singleton pattern.
            connection = DatabaseSingleton.GetInstance();
        }

        /// <summary>
        /// Retrieves all roles from the database.
        /// </summary>
        /// <returns>A DataTable containing role information.</returns>
        public DataTable GetRole()
        {
            // Create a DataTable to store the retrieved data.
            DataTable selectTable = new DataTable();

            // Using a SqlCommand to execute a SELECT query.
            using (SqlCommand command = new SqlCommand("SELECT * FROM Role", connection))
            {
                // Using SqlDataAdapter to fill the DataTable with the results.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            // Return the DataTable containing role information.
            return selectTable;
        }

        /// <summary>
        /// Adds a new role to the database.
        /// </summary>
        /// <param name="name">The name of the role to be added.</param>
        public void AddRole(string name)
        {
            // Using a SqlCommand to execute an INSERT query.
            using (SqlCommand command = new SqlCommand("INSERT INTO Role (Nazev_role) VALUES (@Name)", connection))
            {
                // Adding parameters to the command to prevent SQL injection.
                command.Parameters.AddWithValue("@Name", name);

                // Execute the query to add the role to the database.
                command.ExecuteNonQuery();
            }
        }
    }
}
