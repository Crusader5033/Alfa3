
using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Controller
{
    internal class ZkouskaController
    {
        private Zkouska z;
        public ZkouskaController()
        {
            this.z = new Zkouska();
        }



        public DataTable ListZkousky()
        {
            return this.z.GetZkousky();
        }
      /*  public DataTable ListSluzbyWithID()
        {
            return this.s.GetSluzbyWithID();
        }*/
        public void AddZkouska(int name, int test, string place,string result, DateTime when)
        {
            this.z.AddZkouska(name, test, when, place, result);
        }
        public void DeleteZkouska(int id)
        {
            
        }
        public void DeleteZkouskaByVojakId(int id)
        {
            this.z.DeleteZkouskaVojakId(id);
        }
        /*public void DeleteSluzbyByUtvarId(int id)
        {
            this.s.DeleteSluzbyByUtvarId(id);
        }*/
    }
}
