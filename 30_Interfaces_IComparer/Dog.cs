﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class Dog : IAnimal, IMammal, IComparable<Dog>
    {

        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"The dog '{Name}' is eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine($"The dog '{Name}' gave birth to a puppy");
        }

        public int CompareTo(Dog other)
        {
            return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
        }


    }
}
