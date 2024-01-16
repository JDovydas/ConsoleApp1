using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Paskaita_Generics
{
    internal class Repository<T>
    {
        private List<T> _list = new List<T>(); //for privare the field should start with underscore and lowercase

        public void AddItem(T item)
        {
            _list.Add(item);
        }

        public void RemoveItem(T item)
        {
            _list.Remove(item);
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public List<T> GetList()
        {
            return _list;
        }

        public void Print()
        {
            Console.WriteLine("*-------------------------------------*");
            foreach (T item in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*-------------------------------------*");
        }

        public void Shufle()
        {
            Random rnd = new Random();
            _list = _list.OrderBy(x => rnd.Next()).ToList();
        }

    }
}
