using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Food : Product
    {
        public Food(string name, double price, DateTime expirationTime) : base(name, price)
        {
            ExpirationTime = expirationTime;
        }

        public void PrintFoodInfo()
        {
            Console.WriteLine($"Food name: {Name}, price: {Price}, expiration date: {ExpirationTime}");
        }


        public DateTime ExpirationTime { get; set; }
    }
}
