using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Paskaita_Restaurant_System_Structure.Models
{
    internal class Order
    {
        public int Id { get; set; } // Add an Id property as the primary key
        public int TableId { get; set; } // Add a foreign key to relate to the Table

        public Table Table { get; set; }
        public List<Product> Products { get; set; }

        public DateTime OrderDateTime { get; set; }

        public decimal TotalAmount { get; set; }

        public int Quantity { get; set; }

        public Order(Table table, List<Product> items)
        {
            Table = table;
            Products = new List<Product>();
            OrderDateTime = DateTime.Now;

        }

        public void AddItem(Product item)
        {
            Products.Add(item);
            TotalAmount += item.Price;
        }

    }
}
