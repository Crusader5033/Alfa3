using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Alfa3.Controller
{
    internal class VojakController
    {
       
        private Vojak v;
          public VojakController()
          {
              this.v = new Vojak();
          }

         

        public DataTable ListVojaci()
        {
            return this.v.GetVojaci();
        }
        public DataTable ListVojaciSpecializace()
        {
            return this.v.GetVojaciSpecializace();
        }

        public void AddVojak(string name, string surname, DateTime date, Single height, bool deploy)
        {
             this.v.AddVojak(name,surname,date,height,deploy);
        }
        public void DeleteVojak(int id)
        {
            this.v.DeleteVojak(id);
        }
        public void AddVojakWithZkouska(string name, string surname, DateTime date, double height, bool deploy)
        {
            this.v.AddVojakWithZkouska(name, surname, date, height, deploy);

        }
    }
}
