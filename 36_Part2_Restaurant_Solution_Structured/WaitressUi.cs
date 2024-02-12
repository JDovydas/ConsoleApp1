using _36_Part2_Restaurant_Solution_Structured.Services;
using _36_Paskaita_Restaurant_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _36_Part2_Restaurant_Solution_Structured
{
    internal class WaitressUi
    {
        public List<Table> tables;
        public List<Product> products;
        public string filePath = "C:\\Users\\djuod\\source\\repos\\ConsoleApp1\\36_Part2_Restaurant_Solution_Structured\\Data\\food.txt";
        private readonly TableService tableService;

        public WaitressUi(List<Product> products, List<Table> tables)
        {
            this.products = LoadItemsFromFile(products, filePath);
            this.tables = tables;
            InitializeTables();//į repository
            //products = LoadItemsFromFile(products, filePath);
            //LoadItemsFromFile(products, filePath); //į repository
            //LoadItemsFromFile(products, "food.txt");
        }


        public void PrintOptions()
        {

            Console.WriteLine("\r\n  _____           _                              _                          _ _           _   _             \r\n |  __ \\         | |                            | |       /\\               | (_)         | | (_)            \r\n | |__) |___  ___| |_ __ _ _   _ _ __ __ _ _ __ | |_     /  \\   _ __  _ __ | |_  ___ __ _| |_ _  ___  _ __  \r\n |  _  // _ \\/ __| __/ _` | | | | '__/ _` | '_ \\| __|   / /\\ \\ | '_ \\| '_ \\| | |/ __/ _` | __| |/ _ \\| '_ \\ \r\n | | \\ \\  __/\\__ \\ || (_| | |_| | | | (_| | | | | |_   / ____ \\| |_) | |_) | | | (_| (_| | |_| | (_) | | | |\r\n |_|  \\_\\___||___/\\__\\__,_|\\__,_|_|  \\__,_|_| |_|\\__| /_/    \\_\\ .__/| .__/|_|_|\\___\\__,_|\\__|_|\\___/|_| |_|\r\n                                                               | |   | |                                    \r\n                                                               |_|   |_|                                    \r\n");
            Console.WriteLine("Application options: ");
            Console.WriteLine("1. Check all available products and prices");
            Console.WriteLine("2. Add product and its price");
            Console.WriteLine("3. Start a new order");
            Console.WriteLine("4. Make table vacant");
            Console.WriteLine("5. Print table overview");
            Console.WriteLine("6. Close application");
        }

        public void Run()
        {
            var input = "";

            do
            {
                PrintOptions();
                Console.WriteLine("\nEnter your option: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You selected option 1");
                        products = LoadItemsFromFile(products, filePath);
                        PrintAllProductsAndPrices(products);
                        break;
                    case "2":
                        Console.WriteLine("You selected option 2");
                        AddNewProduct();
                        break;
                    case "3":
                        Console.WriteLine("You selected option 3");
                        StartNewOrder(products);
                        break;
                    case "4":
                        Console.WriteLine("You selected option 4");
                        MakeTableVacant();
                        break;
                    case "5":
                        Console.WriteLine("You selected option 5");
                        PrintTableInformation(tables);
                        break;
                    case "6":
                        Console.WriteLine("Exiting");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again");
                        break;


                }

            }
            while (input != "6" || string.IsNullOrEmpty(input));
        }

        public void AddNewProduct()
        {
            Console.WriteLine("Enter the product name: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter the product price in Eur: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal productPrice))
            {
                products.Add(new Product(productName, productPrice));
                Console.WriteLine("Product added successfully");
            }
            else
            {
                Console.WriteLine("Invalid price - enter a valid number");
            }

            updateProductFile(productName, productPrice);
        }

        public void updateProductFile(string productName, decimal productPrice)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("C:\\Users\\djuod\\source\\repos\\ConsoleApp1\\36_Part2_Restaurant_Solution_Structured\\Data\\food.txt", true))
                {

                    sw.WriteLine($"{productName}; {productPrice}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating product file: {ex.Message}");
            }
        }


        public void InitializeTables()
        {
            tables = new List<Table>
            {
                new Table(1,4),
                new Table(2,4),
                new Table(3,2),
                new Table(4,6),
                //new Table(5,8),
                //new Table(6,8),
                //new Table(7,6),
                //new Table(8,4),
            };
        }



        public void PrintAllProductsAndPrices(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price} EUR");
            }
        }

        public void PrintTableInformation(List<Table> tables)
        {
            foreach (var table in tables)
            {
                var status = "";
                if (table.IsOccupied == false)
                {
                    status = "- Not Occupied";
                    Console.WriteLine($"Table number: {table.TableNumber}, number of seats: {table.NumberOfSeats}, Is table occupied? {status}");
                }
                else
                {
                    status = "- Occupied";
                    Console.WriteLine($"Table number: {table.TableNumber}, number of seats: {table.NumberOfSeats}, Is table occupied? {status}");
                }

            }

        }
        public void StartNewOrder(List<Product> products)
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
                    Order newOrder = new Order(selectedTable, products);
                    tableService.OccupyTable(selectedTable);
                    Console.WriteLine($"New order is initiated for Table {tableNumber} - this table is occupied now");

                    Console.WriteLine("The following products are available for ordering:");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i].Name} - Price: {products[i].Price}");
                    }

                    newOrder.Items = new List<Product>();
                    newOrder.TotalAmount = 0;

                    while (true)
                    {
                        Console.WriteLine("Enter the number of the product to order (0 to finish):");

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
                                    newOrder.Items.Add(new Product(selectedProduct.Name, selectedProduct.Price, quantity));
                                    newOrder.TotalAmount += selectedProduct.Price * quantity;
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

                    Console.WriteLine($"Total price of the order: {newOrder.TotalAmount} EUR");
                    SaveOrderToFile(newOrder);

                    CreateVoucherFile(newOrder);

                }
                else
                {
                    Console.WriteLine("Invalid table number");
                }
            }
        }

        public void GenerateVouchers()
        {
            GenerateVouchers();
        }

        public List<Product> LoadItemsFromFile(List<Product> products, string filePath)
        {
            List<Product> loadedProducts = new List<Product>();
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(';');
                            if (parts.Length == 2 && decimal.TryParse(parts[1], out decimal price))
                            {
                                loadedProducts.Add(new Product(parts[0], price));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading items from {filePath}: {ex.Message}");
            }
            return loadedProducts;
        }

        public void MakeTableVacant()
        {
            Console.WriteLine("Occupied tables: ");

            var occupiedTables = tables.Where(table => table.IsOccupied).ToList();
            if (occupiedTables.Count == 0)
            {
                Console.WriteLine("No occupied tables");
                return;
            }

            foreach (var table in occupiedTables)
            {
                Console.WriteLine($"Table {table.TableNumber} - Seats: {table.NumberOfSeats}");
            }

            Console.WriteLine("Enter the table number to make it vacant: ");

            if (int.TryParse(Console.ReadLine(), out int tableNumber))
            {
                var selectedTable = occupiedTables.FirstOrDefault(table => table.TableNumber == tableNumber);
                if (selectedTable != null)
                {
                    tableService.VacateTable(selectedTable);
                    Console.WriteLine($"Table {tableNumber} has been made vacant");
                }
                else
                {
                    Console.WriteLine("Invalid table number");
                }
            }
        }

        private void SaveOrderToFile(Order order)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("C:\\Users\\djuod\\source\\repos\\ConsoleApp1\\36_Part2_Restaurant_Solution_Structured\\Data\\Orders.txt", true))
                {
                    sw.WriteLine($"--- Order Details ---");
                    sw.WriteLine($"Table Number: {order.Table.TableNumber}");
                    sw.WriteLine($"Order Date/Time: {order.OrderDateTime}");
                    sw.WriteLine($"Total Amount: {order.TotalAmount:C}");
                    sw.WriteLine("--- Order Items ---");
                    foreach (var item in order.Items)
                    {
                        sw.WriteLine($"{item.Name} - Quantity: {item.Quantity}, Price: {item.Price:C}");
                    }
                    sw.WriteLine(new string('-', 30));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving order to 'Orders.txt': {ex.Message}");
            }
        }

        private void CreateVoucherFile(Order order)
        {
            string voucherFolder = @"C:\Users\djuod\source\repos\ConsoleApp1\36_Part2_Restaurant_Solution_Structured\Data\vouchers";
            string fileName = $"Voucher_{order.Table.TableNumber}_{order.OrderDateTime:yyyyMMddHHmmss}.txt";
            string fullPath = Path.Combine(voucherFolder, fileName);

            try
            {
                Directory.CreateDirectory(voucherFolder);
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    sw.WriteLine($"--- Voucher ---");
                    sw.WriteLine($"Table Number: {order.Table.TableNumber}");
                    sw.WriteLine($"Order Date/Time: {order.OrderDateTime}");
                    sw.WriteLine($"Total Amount: {order.TotalAmount:C}");
                    sw.WriteLine("--- Order Items ---");
                    foreach (var item in order.Items)
                    {
                        sw.WriteLine($"{item.Name} - Quantity: {item.Quantity}, Price: {item.Price:C}");
                    }
                    Console.WriteLine($"Voucher created: {fileName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating voucher: {ex.Message}");
            }
        }

    }
}