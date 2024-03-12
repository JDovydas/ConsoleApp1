using _36_Paskaita_Restaurant_System_Structure.Helpers;
using _36_Paskaita_Restaurant_System_Structure.Models;
using MimeKit;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _36_Paskaita_Restaurant_System_Structure.Sensitive;

namespace _36_Paskaita_Restaurant_System_Structure
{
    internal class WaitressUi
    {
        public List<Table> tables;
        public List<Product> products;
        public string filePath = "C:\\Users\\djuod\\source\\repos\\ConsoleApp1\\36_Paskaita_Restaurant_System_Structure\\Data\\food.txt";

        public WaitressUi()
        {
            this.products = LoadItemsFromFile(filePath);
            this.tables = new List<Table>();
            InitializeTables();

        }
        public void PrintOptions()
        {
            Console.Clear();
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
                        ConcoleClear.Clear();
                        products = LoadItemsFromFile(filePath);
                        PrintAllProductsAndPrices(products);
                        ConcoleClear.ClearView();
                        break;
                    case "2":
                        ConcoleClear.Clear();
                        AddNewProduct();
                        ConcoleClear.ClearView();
                        break;
                    case "3":
                        ConcoleClear.Clear();
                        StartNewOrder(products);
                        ConcoleClear.ClearView();
                        break;
                    case "4":
                        ConcoleClear.Clear();
                        MakeTableVacant();
                        ConcoleClear.ClearView();
                        break;
                    case "5":
                        ConcoleClear.Clear();
                        PrintTableInformation(tables);
                        ConcoleClear.ClearView();
                        break;
                    case "6":
                        ConcoleClear.Clear();
                        Console.WriteLine("Exiting");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again");
                        ConcoleClear.ClearView();
                        break;
                }

            }
            while (input != "6" || string.IsNullOrEmpty(input));
        }

        public void AddNewProduct()
        {
            using var dbContext = new OrderContext();
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

            UpdateProductFile(productName, productPrice);
        }

        public void UpdateProductFile(string productName, decimal productPrice)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("C:\\Users\\djuod\\source\\repos\\ConsoleApp1\\36_Paskaita_Restaurant_System_Structure\\Data\\food.txt", true))
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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNo free tables available");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine("Available tables:\n");

            foreach (var table in freeTables)
            {
                Console.WriteLine($"Table {table.TableNumber} - Seats: {table.NumberOfSeats}");
            }

            Console.WriteLine("\nEnter the table number to start a new order: ");
            if (int.TryParse(Console.ReadLine(), out int tableNumber))
            {
                var selectedTable = freeTables.FirstOrDefault(table => table.TableNumber == tableNumber);
                if (selectedTable != null)
                {
                    Order newOrder = new Order(selectedTable, products);
                    selectedTable.OccupyTable();
                    Console.WriteLine($"New order is initiated for Table {tableNumber} - this table is occupied now");

                    Console.WriteLine("\nThe following products are available for ordering:\n");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i].Name} - Price: {products[i].Price}");
                    }

                    while (true)
                    {
                        Console.WriteLine("\nEnter the number of the product to order (0 to finish):");

                        if (int.TryParse(Console.ReadLine(), out int productNumber))
                        {
                            if (productNumber == 0)
                            {
                                break;
                            }
                            else if (productNumber >= 1 && productNumber <= products.Count)
                            {
                                Console.Write($"\nEnter the quantity for {products[productNumber - 1].Name}: ");
                                if (int.TryParse(Console.ReadLine(), out int quantity))
                                {
                                    var selectedProduct = products[productNumber - 1];
                                    newOrder.Products.Add(new Product(selectedProduct.Name, selectedProduct.Price, quantity));
                                    newOrder.TotalAmount += selectedProduct.Price * quantity;
                                    Console.WriteLine($"{quantity} {selectedProduct.Name}(s) added to the order.");
                                }
                                else
                                {
                                    Errors.ReturnError();
                                }
                            }
                            else
                            {
                                Errors.ReturnError();
                            }
                        }
                        else
                        {
                            Errors.ReturnError();
                        }
                    }

                    Console.WriteLine($"\nTotal price of the order: {newOrder.TotalAmount} EUR");
                    SaveOrderToFile(newOrder);

                    CreateVoucherFile(newOrder);

                    Console.WriteLine("Should the voucher be sent to the client? If yes - type 1, if no - 0");
                    var input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.WriteLine("Enter email address: ");
                        var emailAddress = Console.ReadLine();

                        SendVoucherViaEmail(newOrder, emailAddress);
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid table number");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public List<Product> LoadItemsFromFile(string filePath)
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
                    selectedTable.VacateTable();

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
                using (StreamWriter sw = new StreamWriter("C:\\Users\\djuod\\source\\repos\\ConsoleApp1\\36_Paskaita_Restaurant_System_Structure\\Data\\Orders.txt", true))
                {
                    sw.WriteLine($"--- Order Details ---");
                    sw.WriteLine($"Table Number: {order.Table.TableNumber}");
                    sw.WriteLine($"Order Date/Time: {order.OrderDateTime}");
                    sw.WriteLine($"Total Amount: {order.TotalAmount:C}");
                    sw.WriteLine("--- Order Items ---");
                    foreach (var product in order.Products)
                    {
                        sw.WriteLine($"{product.Name} - Quantity: {product.Quantity}, Price: {product.Price:C}");
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
            string voucherFolder = @"C:\Users\djuod\source\repos\ConsoleApp1\36_Paskaita_Restaurant_System_Structure\Data\vouchers";
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
                    foreach (var item in order.Products)
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
        public void SendVoucherViaEmail(Order newOrder, string emailAddress)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Restaurant Vouchers", "djuodys@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", emailAddress));

            emailMessage.Subject = $"Your Restaurant Bill {DateTime.Now}";

            var emailBody = new TextPart("plain")
            {
                Text = $"Order details:\n\n" +
                   $"Table number: {newOrder.Table.TableNumber}\n" +
                   $"Order date: {newOrder.OrderDateTime}\n" +
                   $"Total amount: {newOrder.TotalAmount:C}\n" +
                   $"Items:\n"
            };

            foreach (var item in newOrder.Products)
            {
                emailBody.Text += $"- {item.Name}: {item.Price:C} x {item.Quantity}\n";
            }


            emailMessage.Body = emailBody;

            Console.WriteLine($"Voucher is being sent to the client - email address: {emailAddress}");

            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate("djuodys@gmail.com", PassInfo.SensitivePassInfo());
                    client.Send(emailMessage);
                    client.Disconnect(true);
                    Console.WriteLine("Voucher sent successfully");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFailure - voucher is not sent");
                Console.WriteLine(ex.Message);
                throw;
            }

        }

    }
}