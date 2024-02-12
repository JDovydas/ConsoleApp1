using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Paskaita_Restaurant_System.Models
{
    internal class Order
    {
        public Table Table { get; set; }
        public List<Product> Items { get; set; }
        public DateTime OrderDateTime { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }

        public Order(Table table, List<Product> items)
        {
            Table = table;
            Items = new List<Product>();
            OrderDateTime = DateTime.Now;

        }

        public Order()
        {
        }

        public void AddItem(Product item)
        {
            Items.Add(item);
            TotalAmount += item.Price;
        }

        public void StartNewOrder(List<Table> tables, List<Product> products)
        {
            var freeTables = tables.Where(table => !table.IsOccupied).ToList();

            if (freeTables.Count == 0)
            {
                Console.WriteLine("No free tables available");
                return;
            }
            Console.WriteLine("Available tables: ");

            foreach (var table in freeTables)
            {
                Console.WriteLine($"Table {table.TableNumber} - Seats: {table.NumberOfSeats}");
            }

            Console.WriteLine("Enter the table number to start a new order");
            if (int.TryParse(Console.ReadLine(), out int tableNumber))
            {
                var selectedTable = freeTables.FirstOrDefault(table => table.TableNumber == tableNumber);
                if (selectedTable != null)
                {
                    Table = selectedTable;
                    selectedTable.OccupyTable();
                    Console.WriteLine($"New order is initiated for Table {tableNumber}");

                    Console.WriteLine("Available Products:");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i].Name} - Price: {products[i].Price:C}");
                    }

                    Items = new List<Product>();
                    TotalAmount = 0;


                    while (true)
                    {
                        Console.WriteLine("Enter the number of the product to add (0 to finish):");
                        if (int.TryParse(Console.ReadLine(), out int productNumber))
                        {
                            if (productNumber == 0)
                            {
                                break;
                            }
                            else if (productNumber >= 1 && productNumber <= products.Count)
                            {
                                Console.WriteLine($"Enter the quantity for {products[productNumber - 1].Name}:");
                                if (int.TryParse(Console.ReadLine(), out int quantity))
                                {
                                    var selectedProduct = products[productNumber - 1];
                                    Items.Add(new Product(selectedProduct.Name, selectedProduct.Price, quantity));
                                    TotalAmount += selectedProduct.Price * quantity;
                                    Console.WriteLine($"{quantity} {selectedProduct.Name}(s) added to the order.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid quantity. Please enter a valid number.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid product number. Please enter a valid number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }

                    Console.WriteLine($"Order total amount: {TotalAmount:C}");
                }
                else
                {
                    Console.WriteLine("Invalid table number");
                }
            }
        }

    }
}
