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
    internal class CategoryController
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

        public List<string> SelectAllCategoryNames()
        {
            List<string> categoryNames = new List<string>();

            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();

                string query = "SELECT name FROM [dbo].[categories]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader.GetString(0);
                            categoryNames.Add(productName);
                        }
                    }
                }
            }

            return categoryNames;
        }

        public Category GetCategoryByName(string categoryName)
        {
            // Définir la commande SQL pour sélectionner une catégorie par son nom
            string sql = "SELECT * FROM categories WHERE name = @name";

            // Créer une nouvelle connexion à la base de données
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Créer une nouvelle commande SQL avec la requête SQL et la connexion
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Ajouter le paramètre de la commande SQL en utilisant le nom de catégorie
                        command.Parameters.AddWithValue("@name", categoryName);

                        // Lire les données de la commande SQL en utilisant un DataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Vérifier si la catégorie a été trouvée
                            if (reader.Read())
                            {
                                // Créer une nouvelle catégorie en utilisant les données du DataReader
                                int categoryId = (int)reader["id"];
                                string CategoryName = reader["name"].ToString();
                                Category category = new Category(categoryId, CategoryName);

                                // Retourner la catégorie
                                return category;
                            }
                            else
                            {
                                // Retourner null si la catégorie n'a pas été trouvée
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la récupération de la catégorie : " + ex.Message);
                    return null;
                }
            }
        }

        public Category GetCategoryById(int categoryId)
        {
            // Définir la commande SQL pour sélectionner une catégorie par son identifiant
            string sql = "SELECT * FROM categories WHERE id = @id";

            // Créer une nouvelle connexion à la base de données
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Créer une nouvelle commande SQL avec la requête SQL et la connexion
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Ajouter le paramètre de la commande SQL en utilisant l'identifiant de catégorie
                        command.Parameters.AddWithValue("@id", categoryId);

                        // Créer un nouvel adaptateur de données pour remplir une DataTable avec les résultats de la commande SQL
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Créer une nouvelle DataTable pour stocker les résultats de la commande SQL
                            DataTable dataTable = new DataTable();

                            // Remplir la DataTable avec les résultats de la commande SQL
                            adapter.Fill(dataTable);

                            // Vérifier si une catégorie a été trouvée dans la DataTable
                            if (dataTable.Rows.Count > 0)
                            {
                                // Récupérer les données de la catégorie dans la DataTable
                                int id = (int)dataTable.Rows[0]["id"];
                                string name = dataTable.Rows[0]["name"].ToString();

                                // Créer un nouvel objet Category avec les données récupérées
                                Category category = new Category(id, name);

                                // Retourner la catégorie
                                return category;
                            }
                            else
                            {
                                // Aucune catégorie n'a été trouvée dans la base de données
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la récupération de la catégorie : " + ex.Message);
                    return null;
                }
            }
        }


    }
}
