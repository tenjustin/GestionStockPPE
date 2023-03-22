using GestionStock.DAL;
using GestionStock.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Controller
{
    internal class SuppliersController
    {

        public DataTable TableAllSuppliers()
        {
            string sql = "SELECT * FROM suppliers";

            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Créer une nouvelle commande SQL
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Créer un nouvel adaptateur de données
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Créer un nouveau DataTable pour stocker les données
                            DataTable table = new DataTable();

                            // Remplir le DataTable avec les données sélectionnées
                            adapter.Fill(table);

                            // Retourner le DataTable rempli
                            return table;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la récupération des fournisseurs : " + ex.Message);
                    return null;
                }
            }
        }

        public bool AddSupplier(Supplier supplier)
        {
            // Définir la commande SQL pour insérer un nouveau fournisseur
            string sql = "INSERT INTO suppliers (name, address, phone_number) VALUES (@name, @address, @phoneNumber)";

            // Créer une nouvelle connexion à la base de données
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Créer une nouvelle commande SQL avec les paramètres
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", supplier.name);
                        command.Parameters.AddWithValue("@address", supplier.address);
                        command.Parameters.AddWithValue("@phoneNumber", supplier.phone_number);

                        // Exécuter la commande SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Vérifier si des lignes ont été affectées par la commande SQL
                        if (rowsAffected > 0)
                        {
                            // La commande a réussi, retourner vrai
                            return true;
                        }
                        else
                        {
                            // La commande a échoué, retourner faux
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de l'ajout du fournisseur : " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            // Définir la commande SQL pour mettre à jour le fournisseur
            string sql = "UPDATE suppliers SET name = @name, address = @address, phone_number = @phoneNumber WHERE id = @id";

            // Créer une nouvelle connexion à la base de données
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Créer une nouvelle commande SQL avec les paramètres
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", supplier.id);
                        command.Parameters.AddWithValue("@name", supplier.name);
                        command.Parameters.AddWithValue("@address", supplier.address);
                        command.Parameters.AddWithValue("@phoneNumber", supplier.phone_number);

                        // Exécuter la commande SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Vérifier si des lignes ont été affectées par la commande SQL
                        if (rowsAffected > 0)
                        {
                            // La commande a réussi, retourner vrai
                            return true;
                        }
                        else
                        {
                            // La commande a échoué, retourner faux
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la mise à jour du fournisseur : " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteSupplier(int id)
        {
            // Définir la commande SQL pour supprimer le fournisseur
            string sql = "DELETE FROM suppliers WHERE id = @id";

            // Créer une nouvelle connexion à la base de données
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Créer une nouvelle commande SQL avec les paramètres
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        // Exécuter la commande SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Vérifier si des lignes ont été affectées par la commande SQL
                        if (rowsAffected > 0)
                        {
                            // La commande a réussi, retourner vrai
                            return true;
                        }
                        else
                        {
                            // La commande a échoué, retourner faux
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la suppression du fournisseur : " + ex.Message);
                    return false;
                }
            }
        }

        public List<string> SelectAllSuppliersNames()
        {
            List<string> supplierNames = new List<string>();

            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();

                string query = "SELECT name FROM [dbo].[suppliers]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader.GetString(0);
                            supplierNames.Add(productName);
                        }
                    }
                }
            }

            return supplierNames;
        }

        public Supplier GetSupplierByName(string supplierName)
        {
            // Définir la commande SQL pour sélectionner un fournisseur par son nom
            string sql = "SELECT * FROM suppliers WHERE name = @name";

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
                        // Ajouter le paramètre de la commande SQL en utilisant le nom de fournisseur
                        command.Parameters.AddWithValue("@name", supplierName);

                        // Lire les données de la commande SQL en utilisant un DataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Vérifier si le fournisseur a été trouvé
                            if (reader.Read())
                            {
                                // Créer un nouveau fournisseur en utilisant les données du DataReader
                                int supplierId = (int)reader["id"];
                                string SupplierName = reader["name"].ToString();
                                string supplierAddress = reader["address"].ToString();
                                string supplierPhoneNumber = reader["phone_number"].ToString();
                                Supplier supplier = new Supplier(supplierId, SupplierName, supplierAddress, supplierPhoneNumber);

                                // Retourner le fournisseur
                                return supplier;
                            }
                            else
                            {
                                // Retourner null si le fournisseur n'a pas été trouvé
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la récupération du fournisseur : " + ex.Message);
                    return null;
                }
            }
        }

        public Supplier GetSupplierById(int supplierId)
        {
            // Définir la commande SQL pour sélectionner un fournisseur par son identifiant
            string sql = "SELECT * FROM suppliers WHERE id = @id";

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
                        // Ajouter le paramètre de la commande SQL en utilisant l'identifiant de fournisseur
                        command.Parameters.AddWithValue("@id", supplierId);

                        // Créer un nouvel adaptateur de données pour remplir une DataTable avec les résultats de la commande SQL
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Créer une nouvelle DataTable pour stocker les résultats de la commande SQL
                            DataTable dataTable = new DataTable();

                            // Remplir la DataTable avec les résultats de la commande SQL
                            adapter.Fill(dataTable);

                            // Vérifier si un fournisseur a été trouvé dans la DataTable
                            if (dataTable.Rows.Count > 0)
                            {
                                // Récupérer les données du fournisseur dans la DataTable
                                int id = (int)dataTable.Rows[0]["id"];
                                string name = dataTable.Rows[0]["name"].ToString();
                                string address = dataTable.Rows[0]["address"].ToString();
                                string phoneNumber = dataTable.Rows[0]["phone_number"].ToString();

                                // Créer un nouvel objet Supplier avec les données récupérées
                                Supplier supplier = new Supplier(id, name, address, phoneNumber);

                                // Retourner le fournisseur
                                return supplier;
                            }
                            else
                            {
                                // Aucun fournisseur n'a été trouvé dans la base de données
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la récupération du fournisseur : " + ex.Message);
                    return null;
                }
            }
        }

    }
}
