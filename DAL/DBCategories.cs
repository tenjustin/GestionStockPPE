using GestionStock.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.DAL
{
    internal class DBCategories
    {
        private DataTable dt;
        private SqlDataAdapter sda;
        private string connectionString;

        public void AddCategorie(string categorieName)
        {
            
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();
                string query = "Insert into categories (name) values (@name)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", categorieName);

                    try
                    {
                        int affectedRows = command.ExecuteNonQuery();
                       
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Echec de l'ajout de la categorie" + ex.Message);
                        
                    }
                }
            }
            
        }

        public DataTable TableAllCategories()
        {
            DataTable categoriesTable = new DataTable();

            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                string query = "SELECT * FROM [dbo].[categories]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(categoriesTable);
                    }
                }
            }

            return categoriesTable;
        }

        public bool DeleteCategoryById(int categoryId)
        {
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                string query = "DELETE FROM [dbo].[categories] WHERE id = @id";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", categoryId);

                    int affectedRows = command.ExecuteNonQuery();
                    return affectedRows > 0;
                }
            }
        }

        public bool UpdateCategoryById(int categoryId, string newName)
        {
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                string query = "UPDATE [dbo].[categories] SET name = @name WHERE id = @id";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", categoryId);
                    command.Parameters.AddWithValue("@name", newName);

                    int affectedRows = command.ExecuteNonQuery();
                    return affectedRows > 0;
                }
            }
        }
    }
}
