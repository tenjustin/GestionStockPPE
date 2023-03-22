using GestionStock.DAL;
using GestionStock.Model;
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

            using (SqlConnection connection = new DBConnexion().GetConnection())
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

        public Role GetRoleByName(string roleName)
        {
            Role role = null;

            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.roles WHERE name = @roleName", connection))
                {
                    command.Parameters.AddWithValue("@roleName", roleName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new Role(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }
            }

            return role;
        }
    }
}
