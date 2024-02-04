using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Alfa3.Model
{
    /// <summary>
    /// Represents a class for handling unit-related operations in the database.
    /// </summary>
    internal class Utvar
    {
        private SqlConnection connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="Utvar"/> class.
        /// </summary>
        public Utvar()
        {
            // Establishes a database connection using the singleton pattern.
            connection = DatabaseSingleton.GetInstance();
        }

        /// <summary>
        /// Retrieves all units from the database.
        /// </summary>
        /// <returns>A DataTable containing unit information.</returns>
        public DataTable GetUtvary()
        {
            DataTable selectTable = new DataTable();

            // Using a SqlCommand to execute a SELECT query.
            using (SqlCommand command = new SqlCommand("SELECT * FROM Utvary", connection))
            {
                // Using SqlDataAdapter to fill the DataTable with the results.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            // Return the DataTable containing unit information.
            return selectTable;
        }

        /// <summary>
        /// Adds a new unit to the database.
        /// </summary>
        /// <param name="name">The name of the unit.</param>
        /// <param name="type">The type of the unit.</param>
        /// <param name="place">The location where the unit operates.</param>
        public void AddUtvar(string name, string type, string place)
        {
            // Using a SqlCommand to execute an INSERT query.
            using (SqlCommand command = new SqlCommand("INSERT INTO Utvary (Nazev_utvaru, Zamereni, Pusobiste) VALUES (@Name, @Type, @Place)", connection))
            {
                // Adding parameters to the command to prevent SQL injection.
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Place", place);

                // Execute the query to add the unit to the database.
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Updates the operating location of a specific unit by ID.
        /// </summary>
        /// <param name="id">ID of the unit.</param>
        /// <param name="updatedPusobiste">The updated operating location.</param>
        public void UpdateUtvarPusobiste(int id, string updatedPusobiste)
        {
            // Create a new connection using the singleton pattern.
            SqlConnection conn = DatabaseSingleton.GetInstance();

            // Using a SqlCommand to execute an UPDATE query for the operating location.
            using (SqlCommand command = new SqlCommand("UPDATE Utvary SET Pusobiste=@newData WHERE id=@id", conn))
            {
                command.Parameters.AddWithValue("@newData", updatedPusobiste);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes a specific unit by ID.
        /// </summary>
        /// <param name="id">ID of the unit to be deleted.</param>
        public void DeleteUtvar(int id)
        {
            // Using a SqlCommand to execute a DELETE query based on unit ID.
            using (SqlCommand command = new SqlCommand("DELETE FROM Utvary WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
