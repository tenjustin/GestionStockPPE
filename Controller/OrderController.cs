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
    internal class OrderController
    {

        public void AddOrder(Order order)
        {

            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();
                string query = "Insert into orders (order_date, product_id, quantity, unit_price) values (@order_date, @product_id, @quantity, @unit_price)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@order_date", order.order_date);
                    command.Parameters.AddWithValue("@product_id", order.product.id);
                    command.Parameters.AddWithValue("@quantity", order.quantity);
                    command.Parameters.AddWithValue("@unit_price", order.unit_price);


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

        public DataTable TableAllOrders()
        {
            DataTable ordersTable = new DataTable();

            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();
                string query = @"SELECT o.id, o.order_date, o.quantity, o.unit_price,
                                    p.name AS product_name
                             FROM [dbo].[orders] AS o
                             INNER JOIN [dbo].[products] AS p ON o.product_id = p.id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(ordersTable);
                    }
                }
            }

            return ordersTable;
        }

        public bool UpdateCommande(Order order)
        {
            // Obtenir une instance de la connexion à la base de données à partir de la méthode GetConnexion() de la classe DBConnexion
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Définir la commande SQL pour mettre à jour la commande
                    string sql = "UPDATE orders SET product_id = (SELECT id FROM products WHERE name = @nomProduit), quantity = @quantite, unit_price = @prixUnitaire, order_date = @dateCommande WHERE id = @commandeId";

                    // Créer une nouvelle commande SQL avec les paramètres
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nomProduit", order.product.name);
                        command.Parameters.AddWithValue("@quantite", order.quantity);
                        command.Parameters.AddWithValue("@prixUnitaire", order.unit_price);
                        command.Parameters.AddWithValue("@dateCommande", order.order_date);
                        command.Parameters.AddWithValue("@commandeId", order.id);

                        // Exécuter la commande SQL et retourner true si elle réussit
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la mise à jour de la commande : " + ex.Message);
                }
            }

            // Retourner false si la commande SQL n'a pas été exécutée avec succès
            return false;
        }

        public bool DeleteCommande(int commandeId)
        {
            // Créer une nouvelle connexion à la base de données
            using (SqlConnection connection = new DBConnexion().GetConnection())
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Définir la commande SQL pour supprimer la commande
                    string sql = "DELETE FROM orders WHERE id = @commandeId";

                    // Créer une nouvelle commande SQL avec les paramètres
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@commandeId", commandeId);

                        // Exécuter la commande SQL et retourner true si elle réussit
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show("Une erreur s'est produite lors de la suppression de la commande : " + ex.Message);
                }
            }

            // Retourner false si la commande SQL n'a pas été exécutée avec succès
            return false;
        }




    }
}
