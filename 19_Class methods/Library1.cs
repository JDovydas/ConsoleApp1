using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_methods
{
    internal class Library1
    {
        List<string> books = new List<string>();

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public void RemoveBook(string book)
        {
            books.Remove(book);
        }

        public void PrintBooks()
        {
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }

    }
}
