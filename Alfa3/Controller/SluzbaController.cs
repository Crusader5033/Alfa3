using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Controller
{
    internal class SluzbaController
    {

        private Sluzba s;
        public SluzbaController()
        {
            this.s = new Sluzba();
        }



        public DataTable ListSluzby()
        {
            return this.s.GetSluzby();
        }
        public DataTable ListSluzbyWithID()
        {
            return this.s.GetSluzbyWithID();
        }
        public void AddSluzba(int name,int unit,int role,DateTime from,DateTime to)
        {
             this.s.AddSluzba(name,unit,role,from,to);
        }
        public void DeleteSluzba(int id)
        {
            this.s.DeleteSluzba(id);
        }
        public void DeleteSluzbyByVojakId(int id)
        {
            this.s.DeleteSluzbyByVojakId(id);
        }
        public void DeleteSluzbyByUtvarId(int id)
        {
            this.s.DeleteSluzbyByUtvarId(id);
        }

    }
}
