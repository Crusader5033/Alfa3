using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Model
{
    internal class Zkouska
    {


        private SqlConnection connection;

        public Zkouska()
        {
            connection = DatabaseSingleton.GetInstance();
        }

        public DataTable GetZkousky()
        {
            DataTable selectTable = new DataTable();

            using (SqlCommand command = new SqlCommand("SELECT Z.id AS ZkouskaID,V.Jmeno,V.Prijmeni,S.Nazev_specializace,Z.Datum_zkousky,Z.Misto_konani,Z.Vysledek_zkousky FROM Zkousky Z INNER JOIN    Vojaci V ON Z.ID_Vojaka = V.id INNER JOIN    Specializace S ON Z.ID_Specializace = S.id;", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            return selectTable;
        }
        public DataTable GetZkouskyWithID()
        {
            DataTable selectTable = new DataTable();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Zkousky", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            return selectTable;
        }

        public void AddZkouska(int name, int test,DateTime when, string place,string result )
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Zkousky (ID_Vojaka,ID_Specializace, Datum_zkousky, Misto_konani, Vysledek_zkousky) VALUES (@Name, @Test, @When, @Place, @Result)", connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Test", test);
                command.Parameters.AddWithValue("@When", when);
                command.Parameters.AddWithValue("@Place", place);
                command.Parameters.AddWithValue("@Result", result);

                command.ExecuteNonQuery();
            }
        }
        public void DeleteZkouskaVojakId(int id)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Zkousky WHERE ID_Vojaka  = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteZkouskaBySpecializaceId(int id)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Zkouska WHERE ID_Specializace   = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }




    }
}
