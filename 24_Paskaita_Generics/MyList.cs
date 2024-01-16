using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Paskaita_Generics
{
    public class MyList<T>
    {
        private T[] items;
        private int count;

        public MyList(int capacity)
        {
            items = new T[capacity];
            count = 0;

        }
        public void Add(T item)
        {
            if (count < items.Length)
            {
                items[count] = item;
                count++;
            }
            else
            {
                Console.WriteLine("List is full");
            }



        }

        public void Display()
        {
            Console.WriteLine("List items: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }

        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(items, item);

            if (index >= 0)
            {
                for (int i = index; i < count; i++)
                {
                    items[i] = items[i + 1];
                }
                count--;
                items[count] = default(T);
            }
            else
            {
                Console.WriteLine("No such item in the list");

            }
        }
    }



}
