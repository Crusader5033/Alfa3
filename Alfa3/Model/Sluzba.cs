using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Alfa3.Model
{
    /// <summary>
    /// Represents a class for handling service-related operations in the database.
    /// </summary>
    internal class Sluzba
    {
        private SqlConnection connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sluzba"/> class.
        /// </summary>
        public Sluzba()
        {
            // Establishes a database connection using the singleton pattern.
            connection = DatabaseSingleton.GetInstance();
        }

        /// <summary>
        /// Retrieves all services with soldiers from the database.
        /// </summary>
        /// <returns>A DataTable containing service information with soldiers.</returns>
        public DataTable GetSluzby()
        {
            DataTable selectTable = new DataTable();

            // Using a SqlCommand to execute a SELECT query.
            using (SqlCommand command = new SqlCommand("SELECT * FROM Vojaci_S_Sluzbami", connection))
            {
                // Using SqlDataAdapter to fill the DataTable with the results.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            // Return the DataTable containing service information with soldiers.
            return selectTable;
        }

        /// <summary>
        /// Retrieves all services with IDs from the database.
        /// </summary>
        /// <returns>A DataTable containing service information with IDs.</returns>
        public DataTable GetSluzbyWithID()
        {
            DataTable selectTable = new DataTable();

            // Using a SqlCommand to execute a SELECT query.
            using (SqlCommand command = new SqlCommand("SELECT * FROM Sluzby", connection))
            {
                // Using SqlDataAdapter to fill the DataTable with the results.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            // Return the DataTable containing service information with IDs.
            return selectTable;
        }

        /// <summary>
        /// Adds a new service to the database.
        /// </summary>
        /// <param name="name">ID of the soldier.</param>
        /// <param name="unit">ID of the unit.</param>
        /// <param name="role">ID of the role.</param>
        /// <param name="from">Start date of the service.</param>
        /// <param name="to">End date of the service.</param>
        public void AddSluzba(int name, int unit, int role, DateTime from, DateTime to)
        {
            // Using a SqlCommand to execute an INSERT query.
            using (SqlCommand command = new SqlCommand("INSERT INTO Sluzby (ID_Vojaka, ID_Utvaru, ID_Role, Datum_nastupu, Datum_odchodu) VALUES (@Name, @Unit, @Role, @From, @To)", connection))
            {
                // Adding parameters to the command to prevent SQL injection.
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Unit", unit);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@From", from);
                command.Parameters.AddWithValue("@To", to);

                // Execute the query to add the service to the database.
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes services for a specific soldier by ID.
        /// </summary>
        /// <param name="id">ID of the soldier.</param>
        public void DeleteSluzbyByVojakId(int id)
        {
            // Using a SqlCommand to execute a DELETE query based on soldier ID.
            using (SqlCommand command = new SqlCommand("DELETE FROM Sluzby WHERE ID_Vojaka = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes services for a specific unit by ID.
        /// </summary>
        /// <param name="id">ID of the unit.</param>
        public void DeleteSluzbyByUtvarId(int id)
        {
            // Using a SqlCommand to execute a DELETE query based on unit ID.
            using (SqlCommand command = new SqlCommand("DELETE FROM Sluzby WHERE ID_Utvaru = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes services for a specific role by ID.
        /// </summary>
        /// <param name="id">ID of the role.</param>
        public void DeleteSluzbyByRoleId(int id)
        {
            // Using a SqlCommand to execute a DELETE query based on role ID.
            using (SqlCommand command = new SqlCommand("DELETE FROM Sluzby WHERE ID_Role = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Updates the role of a specific service by ID.
        /// </summary>
        /// <param name="id">ID of the service.</param>
        /// <param name="newRole">The new role to be updated.</param>
        public void UpdateSluzbaRole(int id, string newRole)
        {
            // Create a new connection using the singleton pattern.
            SqlConnection conn = DatabaseSingleton.GetInstance();

            // Using a SqlCommand to execute an UPDATE query for the role.
            using (SqlCommand command = new SqlCommand("UPDATE Sluzby SET Role = @newrole WHERE id = @id", conn))
            {
                command.Parameters.AddWithValue("@newData", newRole);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes a specific service by ID.
        /// </summary>
        /// <param name="id">ID of the service to be deleted.</param>
        public void DeleteSluzba(int id)
        {
            // Using a SqlCommand to execute a DELETE query based on service ID.
            using (SqlCommand command = new SqlCommand("DELETE FROM Sluzby WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
