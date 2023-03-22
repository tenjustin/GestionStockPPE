using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.Model;

namespace GestionStock.Controller
{
    internal class UserController
    {
        public DataTable TableAllUsers()
        {
            DataTable users = new DataTable();

            using (SqlConnection connection = new SqlConnection("connectionString"))
            {
                string query = "SELECT id, username, password, role_id FROM users";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(users);
            }

            return users;
        }

        public void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection("connectionString"))
            {
                string query = "INSERT INTO users (username, password, role_id) VALUES (@Username, @Password, @RoleId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user.username);
                command.Parameters.AddWithValue("@Password", user.password);
                command.Parameters.AddWithValue("@RoleId", user.role.id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }

}
