using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Controller
{
    internal class UtvarController
    {

        private Utvar u;
        public UtvarController()
        {
            this.u = new Utvar();
        }



        public DataTable Listutvary()
        {
            return this.u.GetUtvary();
        }

        public void AddUtvar(string name,string type,string place)
        {
             this.u.AddUtvar(name,type,place);
        }
        public void UpdateUtvarPusobiste(int id, string updatedPusobiste)
        {
            this.u.UpdateUtvarPusobiste(id, updatedPusobiste);
        }
        public void DeleteUtvar(int id)
        {
            this.u.DeleteUtvar(id);
        }
    }
}
