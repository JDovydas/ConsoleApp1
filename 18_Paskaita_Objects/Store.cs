using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Paskaita_Objects
{
    internal class Store
    {

        public Store(string name, int yearOfOpening, List<string> products)
        {
            Name = name;
            YearOfOpening = yearOfOpening;
            Products = products;

        }

        public string Name { get; set; }
        public int YearOfOpening { get; set; }
        public List<string> Products { get; set; }


    }


}
