using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Alfa3.Controller
{
    /// <summary>
    /// Represents a controller class for handling operations related to military units (utvary).
    /// </summary>
    internal class UtvarController
    {
        private Utvar u;

        /// <summary>
        /// Initializes a new instance of the <see cref="UtvarController"/> class.
        /// </summary>
        public UtvarController()
        {
            // Instantiates a Utvar object to interact with military unit-related database operations.
            this.u = new Utvar();
        }

        /// <summary>
        /// Retrieves a DataTable containing information about military units.
        /// </summary>
        /// <returns>A DataTable containing military unit information.</returns>
        public DataTable Listutvary()
        {
            // Calls the GetUtvary method of the associated Utvar object to retrieve military unit information.
            return this.u.GetUtvary();
        }

        /// <summary>
        /// Adds a new military unit to the database.
        /// </summary>
        /// <param name="name">The name of the military unit to be added.</param>
        /// <param name="type">The type of the military unit to be added.</param>
        /// <param name="place">The location or base of the military unit to be added.</param>
        public void AddUtvar(string name, string type, string place)
        {
            // Calls the AddUtvar method of the associated Utvar object to add a new military unit to the database.
            this.u.AddUtvar(name, type, place);
        }

        /// <summary>
        /// Updates the location or base (Pusobiste) of a specific military unit by ID.
        /// </summary>
        /// <param name="id">ID of the military unit to be updated.</param>
        /// <param name="updatedPusobiste">The new location or base information.</param>
        public void UpdateUtvarPusobiste(int id, string updatedPusobiste)
        {
            // Calls the UpdateUtvarPusobiste method of the associated Utvar object to update the location or base of a specific military unit by ID.
            this.u.UpdateUtvarPusobiste(id, updatedPusobiste);
        }

        /// <summary>
        /// Deletes a specific military unit by ID.
        /// </summary>
        /// <param name="id">ID of the military unit to be deleted.</param>
        public void DeleteUtvar(int id)
        {
            // Calls the DeleteUtvar method of the associated Utvar object to delete a specific military unit by ID.
            this.u.DeleteUtvar(id);
        }
    }
}
