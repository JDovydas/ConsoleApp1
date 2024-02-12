//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ATM_Draft2
//{
//    internal class ATM
//    {
//        private static Dictionary<string, CardHolder> users = new Dictionary<string, CardHolder>();

//        public static void RegisterUser(string clientName, string clientSurname, string cardNumber, string password)
//        {
//            if (!users.ContainsKey(cardNumber))
//            {
//                users[cardNumber] = new CardHolder(clientName, clientSurname, cardNumber, password);
//                SaveUserToFile(users[cardNumber]);
//                Console.WriteLine("Registration successful.");
//            }
//            else
//            {
//                Console.WriteLine("Card number is already registered.");
//            }
//        }

//        public static bool LoginUser(string userCardNumber, string userPassword)
//        {
//            if (users.ContainsKey(userCardNumber) && users[userCardNumber].ValidatePassword(userPassword))
//            {
//                Console.WriteLine("Login successful.");
//                return true;
//            }
//            else
//            {
//                Console.WriteLine("Invalid card number or password.");
//                return false;
//            }
//        }

//        public static void ShowAccountInfo(string currentUser)
//        {
//            if (users.ContainsKey(currentUser))
//            {
//                users[currentUser].DisplayAccountInfo();
//            }
//        }

//        private static void SaveUserToFile(CardHolder cardHolder)
//        {
//            using (StreamWriter writer = new StreamWriter("user_data.txt", true))
//            {
//                writer.WriteLine($"{cardHolder.CardNumber},{cardHolder.Name},{cardHolder.Surname},{cardHolder.Password},{cardHolder.Balance}");
//            }
//        }

//    }
//}

