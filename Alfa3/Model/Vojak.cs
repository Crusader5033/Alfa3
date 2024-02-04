using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Alfa3.Model
{
    /// <summary>
    /// Represents a class for handling soldier-related operations in the database.
    /// </summary>
    internal class Vojak
    {
        private SqlConnection connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vojak"/> class.
        /// </summary>
        public Vojak()
        {
            // Establishes a database connection using the singleton pattern.
            connection = DatabaseSingleton.GetInstance();
        }

        /// <summary>
        /// Retrieves all soldiers from the database.
        /// </summary>
        /// <returns>A DataTable containing soldier information.</returns>
        public DataTable GetVojaci()
        {
            DataTable selectTable = new DataTable();

            // Using a SqlCommand to execute a SELECT query.
            using (SqlCommand command = new SqlCommand("SELECT * FROM Vojaci", connection))
            {
                // Using SqlDataAdapter to fill the DataTable with the results.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            // Return the DataTable containing soldier information.
            return selectTable;
        }

        /// <summary>
        /// Retrieves all soldiers with specializations from the database.
        /// </summary>
        /// <returns>A DataTable containing soldier information with specializations.</returns>
        public DataTable GetVojaciSpecializace()
        {
            DataTable selectTable = new DataTable();

            // Using a SqlCommand to execute a SELECT query.
            using (SqlCommand command = new SqlCommand("SELECT * FROM Vojaci_S_Specializacemi", connection))
            {
                // Using SqlDataAdapter to fill the DataTable with the results.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            // Return the DataTable containing soldier information with specializations.
            return selectTable;
        }

        /// <summary>
        /// Adds a new soldier to the database.
        /// </summary>
        /// <param name="name">The first name of the soldier.</param>
        /// <param name="surname">The last name of the soldier.</param>
        /// <param name="date">The date of birth of the soldier.</param>
        /// <param name="height">The height of the soldier.</param>
        /// <param name="deploy">A flag indicating if the soldier participated in a mission.</param>
        public void AddVojak(string name, string surname, DateTime date, Single height, bool deploy)
        {
            // Using a SqlCommand to execute an INSERT query.
            using (SqlCommand command = new SqlCommand("INSERT INTO Vojaci (Jmeno, Prijmeni, Datum_narozeni, Vyska, Zucastil_se_mise) VALUES (@Name, @Surname, @Date, @Height, @Deployment)", connection))
            {
                // Adding parameters to the command to prevent SQL injection.
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Height", height);
                command.Parameters.AddWithValue("@Deployment", deploy);

                // Execute the query to add the soldier to the database.
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Adds a new soldier to the database along with a test (zkouska) record.
        /// </summary>
        /// <param name="name">The first name of the soldier.</param>
        /// <param name="surname">The last name of the soldier.</param>
        /// <param name="date">The date of birth of the soldier.</param>
        /// <param name="height">The height of the soldier.</param>
        /// <param name="deploy">A flag indicating if the soldier participated in a mission.</param>
        public void AddVojakWithZkouska(string name, string surname, DateTime date, double height, bool deploy)
        {
            // Start a transaction
            SqlTransaction transaction = null;

            try
            {
                // Get a transaction
                transaction = connection.BeginTransaction();

                using (SqlCommand command = new SqlCommand("INSERT INTO Vojaci (Jmeno, Prijmeni, Datum_narozeni, Vyska, Zucastil_se_mise) VALUES (@Name, @Surname, @Date, @Height, @Deployment); SELECT SCOPE_IDENTITY()", connection, transaction))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Height", height);
                    command.Parameters.AddWithValue("@Deployment", deploy);

                    // Get the ID of the newly inserted soldier
                    int soldierId = Convert.ToInt32(command.ExecuteScalar());

                    // Add a test record using the soldier ID
                    using (SqlCommand zkouskaCommand = new SqlCommand("INSERT INTO Zkousky (ID_Vojaka, ID_Specializace, Datum_zkousky, Misto_konani, Vysledek_zkousky) VALUES (@VojakId, @ZkId, @Datum, @Misto, @Vysledek)", connection, transaction))
                    {
                        zkouskaCommand.Parameters.AddWithValue("@VojakId", soldierId);
                        zkouskaCommand.Parameters.AddWithValue("@ZkId", 6);  // Replace with the actual ID of the specialization
                        zkouskaCommand.Parameters.AddWithValue("@Datum", DateTime.UtcNow);
                        zkouskaCommand.Parameters.AddWithValue("@Misto", "Vyškov");
                        zkouskaCommand.Parameters.AddWithValue("@Vysledek", "100%");

                        zkouskaCommand.ExecuteNonQuery();
                    }

                    // Commit the transaction
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                // Rollback the transaction in case of an error
                transaction?.Rollback();
                throw ex;
            }
        }

        /// <summary>
        /// Deletes a specific soldier by ID.
        /// </summary>
        /// <param name="id">ID of the soldier to be deleted.</param>
        public void DeleteVojak(int id)
        {
            // Using a SqlCommand to execute a DELETE query based on soldier ID.
            using (SqlCommand command = new SqlCommand("DELETE FROM Vojaci WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}

