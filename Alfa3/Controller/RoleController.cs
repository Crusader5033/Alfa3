using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Controller
{
    internal class RoleController
    {

        private Role r;
        public RoleController()
        {
            this.r = new Role();
        }



        public DataTable ListRole()
        {
            return this.r.GetRole();
        }
        public void AddRole(string name)
        {
             this.r.AddRole(name);
        }
    }
}
