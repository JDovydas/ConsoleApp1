using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Paskaita_DelegatesAndAnonymous
{
    public class PersonTask2
    {
        public string Name { get; set; }
        public List<Animal> Pet { get; set; }

        public PersonTask2(string name, List<Animal> pet)
        {
            Name = name;
            Pet = pet;
        }

    }


}
