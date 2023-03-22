using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Controller
{
    internal class RoleController
    {
        public List<string> GetAllRoleNames()
        {
            List<string> roleNames = new List<string>();

            using (SqlConnection connection = new SqlConnection("connectionString"))
            {
                SqlCommand command = new SqlCommand("SELECT Name FROM Roles", connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roleNames.Add(reader.GetString(0));
                    }
                }
            }

            return roleNames;
        }

    }
}
