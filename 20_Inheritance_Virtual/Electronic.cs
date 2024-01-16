using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Electronic : Product
    {
        public Electronic(string name, double price, DateOnly warranty) : base(name, price)
        {
            Warranty = warranty;
        }


        public void ElectronicInfo()
        {
            Console.WriteLine($"Electronic name: {Name}, price: {Price}, warranty expires: {Warranty}");
        }
        public DateOnly Warranty { get; set; }

    }
}
