using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Alfa3.Controller
{
    /// <summary>
    /// Represents a controller class for handling operations related to roles.
    /// </summary>
    internal class RoleController
    {
        private Role r;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleController"/> class.
        /// </summary>
        public RoleController()
        {
            // Instantiates a Role object to interact with role-related database operations.
            this.r = new Role();
        }

        /// <summary>
        /// Retrieves a DataTable containing information about roles.
        /// </summary>
        /// <returns>A DataTable containing role information.</returns>
        public DataTable ListRole()
        {
            // Calls the GetRole method of the associated Role object to retrieve role information.
            return this.r.GetRole();
        }

        /// <summary>
        /// Adds a new role to the database.
        /// </summary>
        /// <param name="name">The name of the role to be added.</param>
        public void AddRole(string name)
        {
            // Calls the AddRole method of the associated Role object to add a new role to the database.
            this.r.AddRole(name);
        }
    }
}
