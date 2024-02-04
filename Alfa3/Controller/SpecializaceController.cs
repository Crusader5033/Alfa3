using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Alfa3.Controller
{
    /// <summary>
    /// Represents a controller class for handling operations related to specializations.
    /// </summary>
    internal class SpecializaceController
    {
        private Specializace s;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecializaceController"/> class.
        /// </summary>
        public SpecializaceController()
        {
            // Instantiates a Specializace object to interact with specialization-related database operations.
            this.s = new Specializace();
        }

        /// <summary>
        /// Retrieves a DataTable containing information about specializations.
        /// </summary>
        /// <returns>A DataTable containing specialization information.</returns>
        public DataTable ListSpecializace()
        {
            // Calls the GetSpecializace method of the associated Specializace object to retrieve specialization information.
            return this.s.GetSpecializace();
        }

        /// <summary>
        /// Adds a new specialization to the database.
        /// </summary>
        /// <param name="name">The name of the specialization to be added.</param>
        /// <param name="desc">The description of the specialization to be added.</param>
        public void AddSpecializace(string name, string desc)
        {
            // Calls the AddSpecializace method of the associated Specializace object to add a new specialization to the database.
            this.s.AddSpecializace(name, desc);
        }
    }
}
