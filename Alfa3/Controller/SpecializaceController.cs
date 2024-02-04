using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Controller
{
    internal class SpecializaceController
    {

        private Specializace s;
        public SpecializaceController()
        {
            this.s = new Specializace();
        }



        public DataTable ListSpecializace()
        {
            return this.s.GetSpecializace();
        }
        public void AddSpecializace(string name,string desc)
        {
             this.s.AddSpecializace(name,desc);
        }
    }
}
