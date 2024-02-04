using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Alfa3.Model
{
    /// <summary>
    /// Represents a class for handling specialization-related operations in the database.
    /// </summary>
    internal class Specializace
    {
        private SqlConnection connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="Specializace"/> class.
        /// </summary>
        public Specializace()
        {
            // Establishes a database connection using the singleton pattern.
            connection = DatabaseSingleton.GetInstance();
        }

        /// <summary>
        /// Retrieves all specializations from the database.
        /// </summary>
        /// <returns>A DataTable containing specialization information.</returns>
        public DataTable GetSpecializace()
        {
            DataTable selectTable = new DataTable();

            // Using a SqlCommand to execute a SELECT query.
            using (SqlCommand command = new SqlCommand("SELECT * FROM Specializace", connection))
            {
                // Using SqlDataAdapter to fill the DataTable with the results.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            // Return the DataTable containing specialization information.
            return selectTable;
        }

        /// <summary>
        /// Adds a new specialization to the database.
        /// </summary>
        /// <param name="name">The name of the specialization.</param>
        /// <param name="desc">The description of the specialization.</param>
        public void AddSpecializace(string name, string desc)
        {
            // Using a SqlCommand to execute an INSERT query.
            using (SqlCommand command = new SqlCommand("INSERT INTO Specializace (Nazev_specializace, Popis) VALUES (@Name, @Desc)", connection))
            {
                // Adding parameters to the command to prevent SQL injection.
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Desc", desc);

                // Execute the query to add the specialization to the database.
                command.ExecuteNonQuery();
            }
        }
    }
}
