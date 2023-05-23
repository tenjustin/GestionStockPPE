using GestionStock.DAL;
using GestionStock.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestionStock.Controller
{
    internal class ProductController
    {
        CategoryController categoryController = new CategoryController();
        SuppliersController suppliersController = new SuppliersController();
        public List<string> SelectAllProductNames()
        {
            List<string> productNames = new List<string>();

            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();

                string query = "SELECT name FROM [dbo].[products]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader.GetString(0);
                            productNames.Add(productName);
                        }
                    }
                }
            }

            return productNames;
        }

        public Product SelectProductsByName(string productName)
        {
            // Définir la commande SQL pour sélectionner un produit par son nom
            string sql = "SELECT * FROM [dbo].[products] WHERE name = @name";

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
                        // Ajouter le paramètre de la commande SQL en utilisant le nom du produit
                        command.Parameters.AddWithValue("@name", productName);

                        // Créer un nouvel adaptateur de données pour remplir une DataTable avec les résultats de la commande SQL
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Créer une nouvelle DataTable pour stocker les résultats de la commande SQL
                            DataTable dataTable = new DataTable();

                            // Remplir la DataTable avec les résultats de la commande SQL
                            adapter.Fill(dataTable);

                            // Vérifier si un produit a été trouvé dans la DataTable
                            if (dataTable.Rows.Count > 0)
                            {
                                // Récupérer les données du produit dans la DataTable
                                int productId = (int)dataTable.Rows[0]["id"];
                                string name = dataTable.Rows[0]["name"].ToString();
                                string description = dataTable.Rows[0]["description"].ToString();
                                int categoryId = (int)dataTable.Rows[0]["category_id"];
                                int supplierId = (int)dataTable.Rows[0]["supplier_id"];
                                
                                double price = (double)dataTable.Rows[0]["price"];
                                int quantity = (int)dataTable.Rows[0]["quantity"];

                                // Récupérer les données de la catégorie et du fournisseur associés au produit
                                Category category = categoryController.GetCategoryById(categoryId);
                                Supplier supplier = suppliersController.GetSupplierById(supplierId);

                                // Créer un nouvel objet Product avec les données récupérées
                                Product product = new Product(productId, name, description, price, quantity, category, supplier);

                                // Retourner le produit
                                return product;
                            }
                            else
                            {
                                // Aucun produit n'a été trouvé dans la base de données
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la récupération du produit : " + ex.Message);
                    return null;
                }
            }
        }


        public DataTable TableAllProducts()
        {
            // Définir la commande SQL pour sélectionner tous les produits
            string sql = "SELECT p.id, p.name, p.description, p.price, p.quantity, c.name AS category_name, s.name AS supplier_name FROM [dbo].[products] AS p INNER JOIN [dbo].[categories] AS c ON p.category_id = c.id INNER JOIN [dbo].[suppliers] AS s ON p.supplier_id = s.id";

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
                        // Créer un adaptateur de données pour récupérer les données de la commande SQL
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Créer un nouveau DataTable pour stocker les données
                            DataTable dataTable = new DataTable();

                            // Remplir le DataTable avec les données de l'adaptateur de données
                            adapter.Fill(dataTable);

                            // Retourner le DataTable
                            return dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la récupération des produits : " + ex.Message);
                    return null;
                }
            }
        }

        public bool AddProduct(Product product)
        {
            // Définir la commande SQL pour insérer un nouveau produit
            string sql = "INSERT INTO products (name, category_id, supplier_id, price, quantity) " +
                         "VALUES (@name, @category_id, @supplier_id, @price, @quantity)";

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
                        // Ajouter les paramètres de la commande SQL en utilisant les propriétés du produit
                        command.Parameters.AddWithValue("@name", product.name);
                        command.Parameters.AddWithValue("@category_id", product.category.id);
                        command.Parameters.AddWithValue("@supplier_id", product.supplier.id);
                        command.Parameters.AddWithValue("@price", product.price);
                        command.Parameters.AddWithValue("@quantity", product.quantity);

                        // Exécuter la commande SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Retourner vrai si la commande SQL a réussi
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de l'ajout du produit : " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateProduct(Product product)
        {
            // Créer une nouvelle connexion à la base de données
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                // Ouvrir la connexion à la base de données
                connection.Open();
                string sql = "UPDATE products SET name = @name, category_id = @category_id, supplier_id = @supplier_id, price = @price, quantity = @quantity WHERE id = @id";

                // Créer une nouvelle commande SQL avec la requête SQL et la connexion
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Ajouter les paramètres de la commande SQL en utilisant les propriétés du produit
                    command.Parameters.AddWithValue("@name", product.name);
                    command.Parameters.AddWithValue("@category_id", product.category.id);
                    command.Parameters.AddWithValue("@supplier_id", product.supplier.id);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@quantity", product.quantity);
                    command.Parameters.AddWithValue("@id", product.id);

                    // Exécuter la commande SQL et retourner true si le produit a été mis à jour, sinon false
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return (rowsAffected > 0);
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("Echec de la maj du produit" + ex.Message);
                        return false;
                    }
                }
            }
        }

        public void DeleteProduct(int productId)
        {
            // Définir la commande SQL pour supprimer un produit par son identifiant
            string sql = "DELETE FROM products WHERE id = @id";

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
                        // Ajouter le paramètre de la commande SQL en utilisant l'identifiant de produit
                        command.Parameters.AddWithValue("@id", productId);

                        // Exécuter la commande SQL pour supprimer le produit
                        int rowsAffected = command.ExecuteNonQuery();

                        // Vérifier si le produit a été supprimé avec succès
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Le produit a été supprimé de la base de données.");
                        }
                        else
                        {
                            MessageBox.Show("Le produit n'a pas été trouvé dans la base de données.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la suppression du produit : " + ex.Message);
                }
            }
        }

    }
}

