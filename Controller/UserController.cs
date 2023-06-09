﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.Model;
using GestionStock.DAL;

namespace GestionStock.Controller
{
    internal class UserController
    {
        ConnexionController connexionController = new ConnexionController();

        public DataTable TableAllUsers()
        {
            DataTable users = new DataTable();

            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                string query = "SELECT u.id, u.username, u.password, r.name AS role_name FROM [dbo].[users] AS u INNER JOIN [dbo].[roles] AS r ON u.role_id = r.id";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(users);
            }

            return users;
        }

        public void AddUser(User user)
        {
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                user.password = connexionController.HashPassword(user.password);
                string query = "INSERT INTO users (username, password, role_id) VALUES (@Username, @Password, @RoleId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user.username);
                command.Parameters.AddWithValue("@Password", user.password);
                command.Parameters.AddWithValue("@RoleId", user.role.id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool DeleteUserById(int userId)
        {
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM dbo.users WHERE id = @userId", connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }

}
