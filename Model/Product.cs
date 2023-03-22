using System;
using System.Collections.Generic;
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
    }
}
