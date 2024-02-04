using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Alfa3.Controller
{
    /// <summary>
    /// Represents a controller class for handling operations related to soldiers (vojaci).
    /// </summary>
    internal class VojakController
    {
        private Vojak v;

        /// <summary>
        /// Initializes a new instance of the <see cref="VojakController"/> class.
        /// </summary>
        public VojakController()
        {
            // Instantiates a Vojak object to interact with soldier-related database operations.
            this.v = new Vojak();
        }

        /// <summary>
        /// Retrieves a DataTable containing information about soldiers.
        /// </summary>
        /// <returns>A DataTable containing soldier information.</returns>
        public DataTable ListVojaci()
        {
            // Calls the GetVojaci method of the associated Vojak object to retrieve soldier information.
            return this.v.GetVojaci();
        }

        /// <summary>
        /// Retrieves a DataTable containing information about soldiers with associated specializations.
        /// </summary>
        /// <returns>A DataTable containing soldier information with associated specializations.</returns>
        public DataTable ListVojaciSpecializace()
        {
            // Calls the GetVojaciSpecializace method of the associated Vojak object to retrieve soldier information with associated specializations.
            return this.v.GetVojaciSpecializace();
        }

        /// <summary>
        /// Adds a new soldier to the database.
        /// </summary>
        /// <param name="name">The first name of the soldier to be added.</param>
        /// <param name="surname">The last name of the soldier to be added.</param>
        /// <param name="date">The date of birth of the soldier to be added.</param>
        /// <param name="height">The height of the soldier to be added.</param>
        /// <param name="deploy">A boolean indicating whether the soldier has participated in a mission (deployment).</param>
        public void AddVojak(string name, string surname, DateTime date, Single height, bool deploy)
        {
            // Calls the AddVojak method of the associated Vojak object to add a new soldier to the database.
            this.v.AddVojak(name, surname, date, height, deploy);
        }

        /// <summary>
        /// Deletes a specific soldier by ID.
        /// </summary>
        /// <param name="id">ID of the soldier to be deleted.</param>
        public void DeleteVojak(int id)
        {
            // Calls the DeleteVojak method of the associated Vojak object to delete a specific soldier by ID.
            this.v.DeleteVojak(id);
        }

        /// <summary>
        /// Adds a new soldier with a corresponding test (zkouska) to the database.
        /// </summary>
        /// <param name="name">The first name of the soldier to be added.</param>
        /// <param name="surname">The last name of the soldier to be added.</param>
        /// <param name="date">The date of birth of the soldier to be added.</param>
        /// <param name="height">The height of the soldier to be added.</param>
        /// <param name="deploy">A boolean indicating whether the soldier has participated in a mission (deployment).</param>
        public void AddVojakWithZkouska(string name, string surname, DateTime date, double height, bool deploy)
        {
            // Calls the AddVojakWithZkouska method of the associated Vojak object to add a new soldier with a corresponding test to the database.
            this.v.AddVojakWithZkouska(name, surname, date, height, deploy);
        }
    }
}
