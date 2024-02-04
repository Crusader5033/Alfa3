using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Model
{
    internal class Utvar
    {

      
        private SqlConnection connection;

        public Utvar()
        {
            connection = DatabaseSingleton.GetInstance();
        }

        public DataTable GetUtvary()
        {
            DataTable selectTable = new DataTable();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Utvary", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            return selectTable;
        }
        public void AddUtvar(string name, string type,string place)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Utvary (Nazev_utvaru , Zamereni , Pusobiste) VALUES (@Name, @Type, @Place)", connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Place", place);
           

                command.ExecuteNonQuery();
            }
        }
        public void UpdateUtvarPusobiste(int id, string updatedPusobiste)
        {
            SqlConnection conn = DatabaseSingleton.GetInstance();


            using (SqlCommand command = new SqlCommand("UPDATE Utvary SET Pusobiste=@newData WHERE id=@id", conn))
            {
                command.Parameters.AddWithValue("@newData", updatedPusobiste);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();



            }
        }

        public void DeleteUtvar(int id)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Utvary WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
