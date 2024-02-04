using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Model
{
    internal class Specializace
    {

      
        private SqlConnection connection;

        public Specializace()
        {
            connection = DatabaseSingleton.GetInstance();
        }

        public DataTable GetSpecializace()
        {
            DataTable selectTable = new DataTable();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Specializace", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            return selectTable;
        }

        public void AddSpecializace(string name, string desc)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Specializace (Nazev_specializace  , Popis) VALUES (@Name, @Desc)", connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Desc", desc);


                command.ExecuteNonQuery();
            }
        }
    }
}
