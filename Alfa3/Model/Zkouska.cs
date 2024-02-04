using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Alfa3.Model
{
    /// <summary>
    /// Represents a class for handling test-related operations in the database.
    /// </summary>
    internal class Zkouska
    {
        private SqlConnection connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zkouska"/> class.
        /// </summary>
        public Zkouska()
        {
            // Establishes a database connection using the singleton pattern.
            connection = DatabaseSingleton.GetInstance();
        }

        /// <summary>
        /// Retrieves all tests from the database, including associated soldier and specialization information.
        /// </summary>
        /// <returns>A DataTable containing test information with related soldier and specialization details.</returns>
        public DataTable GetZkousky()
        {
            DataTable selectTable = new DataTable();

            // Using a SqlCommand to execute a SELECT query with JOINs.
            using (SqlCommand command = new SqlCommand("SELECT Z.id AS ZkouskaID, V.Jmeno, V.Prijmeni, S.Nazev_specializace, Z.Datum_zkousky, Z.Misto_konani, Z.Vysledek_zkousky FROM Zkousky Z INNER JOIN Vojaci V ON Z.ID_Vojaka = V.id INNER JOIN Specializace S ON Z.ID_Specializace = S.id;", connection))
            {
                // Using SqlDataAdapter to fill the DataTable with the results.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            // Return the DataTable containing test information with related soldier and specialization details.
            return selectTable;
        }

        /// <summary>
        /// Adds a new test to the database.
        /// </summary>
        /// <param name="name">The ID of the soldier associated with the test.</param>
        /// <param name="test">The ID of the specialization associated with the test.</param>
        /// <param name="when">The date of the test.</param>
        /// <param name="place">The location where the test took place.</param>
        /// <param name="result">The result of the test.</param>
        public void AddZkouska(int name, int test, DateTime when, string place, string result)
        {
            // Using a SqlCommand to execute an INSERT query.
            using (SqlCommand command = new SqlCommand("INSERT INTO Zkousky (ID_Vojaka, ID_Specializace, Datum_zkousky, Misto_konani, Vysledek_zkousky) VALUES (@Name, @Test, @When, @Place, @Result)", connection))
            {
                // Adding parameters to the command to prevent SQL injection.
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Test", test);
                command.Parameters.AddWithValue("@When", when);
                command.Parameters.AddWithValue("@Place", place);
                command.Parameters.AddWithValue("@Result", result);

                // Execute the query to add the test to the database.
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes tests associated with a specific soldier by ID.
        /// </summary>
        /// <param name="id">ID of the soldier whose tests will be deleted.</param>
        public void DeleteZkouskaVojakId(int id)
        {
            // Using a SqlCommand to execute a DELETE query based on soldier ID.
            using (SqlCommand command = new SqlCommand("DELETE FROM Zkousky WHERE ID_Vojaka = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes tests associated with a specific specialization by ID.
        /// </summary>
        /// <param name="id">ID of the specialization whose tests will be deleted.</param>
        public void DeleteZkouskaBySpecializaceId(int id)
        {
            // Using a SqlCommand to execute a DELETE query based on specialization ID.
            using (SqlCommand command = new SqlCommand("DELETE FROM Zkousky WHERE ID_Specializace = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
