using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ATM
{
    public class CardHolder //: IAtm
    {
        private static Dictionary<string, BankAccount> users = new Dictionary<string, BankAccount>();

        public static string RegisterUser(string name, string surname)
        {
            var fullName = name + " " + surname;
            string uniqueClientReference = Guid.NewGuid().ToString();
            BankAccount newAccount = new BankAccount();
            users.Add(uniqueClientReference, newAccount);

            Console.WriteLine($"User {fullName} registered with reference: {uniqueClientReference}");
            Console.WriteLine($"Your current balance is: EUR {newAccount.Balance}");
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();

            return uniqueClientReference;
        }

        public static bool LoginUser(string reference)
        {
            if (users.ContainsKey(reference))
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Login failed. User not found.");
                Console.Clear();
                return false;
            }
        }




        //public string Name { get; set; }
        //public string LastName { get; set; }

        //public int ClientID { get; set; }

        //public int Pin { get; set; }

        //public int CardNumber { get; set; }

        //public CardHolder(string name, string lastName, int clientID, int pin, int cardNumber)
        //{
        //    Name = name;
        //    LastName = lastName;
        //    ClientID = clientID;
        //    Pin = pin;
        //    CardNumber = cardNumber;
        //}

        //public string GetName()
        //{
        //    return Name;
        //}

        //public string GetLastName()
        //{
        //    return LastName;
        //}
        //public int GetClientID()
        //{
        //    return ClientID;
        //}

        //public int GetPin()
        //{
        //    return Pin;
        //}

        //public int GetCardNumber()
        //{
        //    return CardNumber;
        //}


        //public Dictionary<string, string> Registration(string name, string lastName)
        //{
        //    //Dictionary<string, string> clientInfo = new Dictionary<string, string>(); // 

        //    Console.Clear();


        //    string fullName = name + " " + lastName;

        //    string currentUser = fullName;

        //    Random r = new Random();
        //    int uniqueClientId = r.Next(100000);
        //    string sixDigitClientID = uniqueClientId.ToString("D6");

        //    Console.WriteLine(sixDigitClientID);

        //    clientInfo.Add(sixDigitClientID, currentUser);

        //    return clientInfo;




        //nematomas nr, pagal kurį pavaliduot "Unikalų" vartotoją
        //public static string RegisterUser(string name, string lastName) // to change the name to Guid Generator
        //{
        //    var clientGuid = Guid.NewGuid(); // 4e19c13d-cab0-467b-8776-423eaee61f2a
        //    Console.WriteLine(clientGuid);
        //    string uniqueClientReference = clientGuid.ToString();
        //    return uniqueClientReference;

        //}


    }
}
