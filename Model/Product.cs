using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Model
{
    internal class Product
    {
        private int id { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private int price { get; set; }
        private int quantity { get; set; }
        private Category category { get; set; }
        private Supplier supplier { get; set; }

        public Product(string name, string description, int price, int quantity, Category category, Supplier supplier)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.supplier = supplier;
        }

        public Product(int id, string name, string description, int price, int quantity, Category category, Supplier supplier)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.supplier = supplier;
        }
    }
}
