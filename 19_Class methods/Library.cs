using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace _19_Class_methods
{
    internal class Library
    {
        private List<Book> books = new();


        public void AddBooks(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} has been added to the library.");
        }

        public void PrintBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);

            }
        }

        public void RemoveBooks(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.WriteLine($"{book.Title} has been removed from the list");
            }
            else
            {
                Console.WriteLine($"{book.Title} is not found in the list been removed from the list");
            }
        }




    }


}
