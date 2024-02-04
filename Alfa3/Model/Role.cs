using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa3.Model
{
    internal class Role
    {
        private SqlConnection connection;

        public Role()
        {
            connection = DatabaseSingleton.GetInstance();
        }

        public DataTable GetRole()
        {
            DataTable selectTable = new DataTable();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Role", connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(selectTable);
            }

            return selectTable;
        }
        public void AddRole(string name)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Role (Nazev_role ) VALUES (@Name)", connection))
            {
                command.Parameters.AddWithValue("@Name", name);
             

                command.ExecuteNonQuery();
            }
        }
    }
}
