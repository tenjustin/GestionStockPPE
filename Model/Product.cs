using GestionStock.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestionStock.Model
{
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public Category category { get; set; }
        public Supplier supplier { get; set; }

        public Product(string name, string description, double price, int quantity, Category category, Supplier supplier)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.supplier = supplier;
        }

        public Product(int id, string name, string description, double price, int quantity, Category category, Supplier supplier)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.supplier = supplier;
        }

        public Product(string name, double price, int quantity, Category category, Supplier supplier)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.supplier = supplier;
        }

        public override string ToString()
        {
            return name;
        }

        public int GetStock()
        {
            using(SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();
                string query = "select quantity from products where id=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", this.id);

                    int stock = (int)command.ExecuteScalar();
                    return stock;
                }
            } 
        }

        public void updateStock(Order order)
        {
            using(SqlConnection connection = new DBConnexion().GetConnection())
            {
                connection.Open();
                string query = "update products set quantity=@quantity where id=@id";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    int stock = order.product.GetStock() - order.quantity;
                    command.Parameters.AddWithValue("@quantity", stock);
                    command.Parameters.AddWithValue("@id", order.product.id);

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

        public void SetStock(int stock)
        {
            this.quantity= stock;
        }
    }
}
