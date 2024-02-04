using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Model
{
    internal class Vojak
    {

      
        private SqlConnection connection;

        public Vojak()
        {
            connection = DatabaseSingleton.GetInstance();
        }

        public DataTable GetVojaci()
        {
            DataTable selectTable = new DataTable();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Vojaci", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            return selectTable;
        }

        public DataTable GetVojaciSpecializace()
        {
            DataTable selectTable = new DataTable();

            using (SqlCommand command = new SqlCommand("SELECT * FROM  Vojaci_S_Specializacemi", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            return selectTable;
        }

        public void AddVojak(string name,string surname,DateTime date,Single height,bool deploy)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Vojaci (Jmeno, Prijmeni, Datum_narozeni , Vyska , Zucastil_se_mise ) VALUES (@Name, @Surname, @Date, @Height, @Deployment)", connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Height", height);
                command.Parameters.AddWithValue("@Deployment", deploy);

                command.ExecuteNonQuery();
            }
        }
         public void AddVojakWithZkouska(string name, string surname, DateTime date, double height, bool deploy)
        {
            // Začátek transakce
            SqlTransaction transaction = null;

            try
            {

                // Získání transakce
                transaction = connection.BeginTransaction();

                using (SqlCommand command = new SqlCommand("INSERT INTO Vojaci (Jmeno, Prijmeni, Datum_narozeni, Vyska, Zucastil_se_mise) VALUES (@Name, @Surname, @Date, @Height, @Deployment); SELECT SCOPE_IDENTITY()", connection, transaction))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Height", height);
                    command.Parameters.AddWithValue("@Deployment", deploy);

                    // Získání ID nově vloženého vojáka
                    int vojakId = Convert.ToInt32(command.ExecuteScalar());

                    // Přidání zkoušky s využitím ID vojáka
                    using (SqlCommand zkouskaCommand = new SqlCommand("INSERT INTO Zkousky (ID_Vojaka, ID_Specializace, Datum_zkousky, Misto_konani, Vysledek_zkousky) VALUES (@VojakId,@ZkId,@Datum, @Misto, @Vysledek)", connection, transaction))
                    {
                        zkouskaCommand.Parameters.AddWithValue("@VojakId", vojakId);
                        zkouskaCommand.Parameters.AddWithValue("@ZkId", 6);
                        zkouskaCommand.Parameters.AddWithValue("@Datum", DateTime.UtcNow);
                        zkouskaCommand.Parameters.AddWithValue("@Misto", "Vyškov");
                        zkouskaCommand.Parameters.AddWithValue("@Vysledek", "100%");

                        zkouskaCommand.ExecuteNonQuery();
                    }

                    // Komitování transakce
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                // Rollback transakce v případě chyby
                transaction?.Rollback();
                throw ex;
            }
           
        }
        public void DeleteVojak(int id)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Vojaci WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
