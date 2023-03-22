using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Model
{
    internal class Order
    {
        public int id { get; set; }
        public DateTime order_date { get; set; }
        public Product product { get; set; }
        public int quantity { get; set; }
        public double unit_price { get; set; }

        public Order(DateTime order_date, Product product, int quantity, double unit_price)
        {
            this.order_date = order_date;
            this.product = product;
            this.quantity = quantity;
            this.unit_price = unit_price;
        }

        public Order(int id, DateTime order_date, Product product, int quantity, double unit_price)
        {
            this.id = id;
            this.order_date = order_date;
            this.product = product;
            this.quantity = quantity;
            this.unit_price = unit_price;
        }
    }
}
