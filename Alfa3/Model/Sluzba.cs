using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Model
{
    internal class Sluzba
    {

        private SqlConnection connection;

        public Sluzba()
        {
            connection = DatabaseSingleton.GetInstance();
        }

        public DataTable GetSluzby()
        {
            DataTable selectTable = new DataTable();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Vojaci_S_Sluzbami", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            return selectTable;
        }
        public DataTable GetSluzbyWithID()
        {
            DataTable selectTable = new DataTable();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Sluzby", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            return selectTable;
        }

        public void AddSluzba(int name, int unit, int role, DateTime from, DateTime to)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Sluzby (ID_Vojaka , ID_Utvaru , ID_Role  , Datum_nastupu  , Datum_odchodu  ) VALUES (@Name, @Unit, @Role, @From, @To)", connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Unit", unit);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@From", from);
                command.Parameters.AddWithValue("@To", to);

                command.ExecuteNonQuery();
            }
        }
        public void DeleteSluzbyByVojakId(int id)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Sluzby WHERE ID_Vojaka  = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSluzbyByUtvarId(int id)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Sluzby WHERE ID_Utvaru   = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteSluzbyByRoleId(int id)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Sluzby WHERE ID_Role   = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateSluzbaRole(int id, string newRole)
        {
            SqlConnection conn = DatabaseSingleton.GetInstance();


            using (SqlCommand command = new SqlCommand("UPDATE Sluzby SET Role=@newrole WHERE id=@id", conn))
            {
                command.Parameters.AddWithValue("@newData", newRole);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();



            }
        }
        public void DeleteSluzba(int id)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Sluzby WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
