using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//namespace _31_ATM
//{
//internal class CardValidator
//{
//public static List<Card> validCards = new List<Card>();

//static CardValidator()
//{
//    LoadCardInfo("C:\\Users\\djuod\\source\\repos\\ConsoleApp1\\31_ATM\\Guid.txt");
//}

//private static void LoadCardInfo(string filePath)
//{
//try
//{
//    foreach (var item in File.ReadAllLines(filePath))
//    {
//        string[] array = item.Split(';');
//        validCards.Add(new Card
//        {
//            CardNumber = array[0],
//            Password = array[1],
//            Balance = decimal.Parse(array[2]),
//            Account = array[3]

//    //        });
//    //    }

//    }
//    catch (FileNotFoundException)
//    {
//        Console.WriteLine($"Error: {filePath} not found. No valid card found.");

//    }
//}

//public static bool IsValidCardGuid(string cardGuid)
//{


//     return !string.IsNullOrEmpty(cardGuid) && validCards.Any(x=>x.Id == cardGuid);


//}

//}
//}
