using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Alfa3.Controller
{
    /// <summary>
    /// Represents a controller class for handling operations related to military service (sluzba).
    /// </summary>
    internal class SluzbaController
    {
        private Sluzba s;

        /// <summary>
        /// Initializes a new instance of the <see cref="SluzbaController"/> class.
        /// </summary>
        public SluzbaController()
        {
            // Instantiates a Sluzba object to interact with military service-related database operations.
            this.s = new Sluzba();
        }

        /// <summary>
        /// Retrieves a DataTable containing information about military services.
        /// </summary>
        /// <returns>A DataTable containing military service information.</returns>
        public DataTable ListSluzby()
        {
            // Calls the GetSluzby method of the associated Sluzba object to retrieve military service information.
            return this.s.GetSluzby();
        }

        /// <summary>
        /// Retrieves a DataTable containing information about military services with associated IDs.
        /// </summary>
        /// <returns>A DataTable containing military service information with IDs.</returns>
        public DataTable ListSluzbyWithID()
        {
            // Calls the GetSluzbyWithID method of the associated Sluzba object to retrieve military service information with IDs.
            return this.s.GetSluzbyWithID();
        }

        /// <summary>
        /// Adds a new military service to the database.
        /// </summary>
        /// <param name="name">The ID of the soldier associated with the military service.</param>
        /// <param name="unit">The ID of the military unit associated with the military service.</param>
        /// <param name="role">The ID of the role associated with the military service.</param>
        /// <param name="from">The start date of the military service.</param>
        /// <param name="to">The end date of the military service.</param>
        public void AddSluzba(int name, int unit, int role, DateTime from, DateTime to)
        {
            // Calls the AddSluzba method of the associated Sluzba object to add a new military service to the database.
            this.s.AddSluzba(name, unit, role, from, to);
        }

        /// <summary>
        /// Deletes a specific military service by ID.
        /// </summary>
        /// <param name="id">ID of the military service to be deleted.</param>
        public void DeleteSluzba(int id)
        {
            // Calls the DeleteSluzba method of the associated Sluzba object to delete a specific military service by ID.
            this.s.DeleteSluzba(id);
        }

        /// <summary>
        /// Deletes military services associated with a specific soldier by ID.
        /// </summary>
        /// <param name="id">ID of the soldier whose military services will be deleted.</param>
        public void DeleteSluzbyByVojakId(int id)
        {
            // Calls the DeleteSluzbyByVojakId method of the associated Sluzba object to delete military services associated with a specific soldier by ID.
            this.s.DeleteSluzbyByVojakId(id);
        }

        /// <summary>
        /// Deletes military services associated with a specific military unit by ID.
        /// </summary>
        /// <param name="id">ID of the military unit whose military services will be deleted.</param>
        public void DeleteSluzbyByUtvarId(int id)
        {
            // Calls the DeleteSluzbyByUtvarId method of the associated Sluzba object to delete military services associated with a specific military unit by ID.
            this.s.DeleteSluzbyByUtvarId(id);
        }
    }
}
