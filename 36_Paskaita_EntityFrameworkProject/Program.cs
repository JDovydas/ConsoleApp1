using _36_Paskaita_EntityFrameworkProject.Database;
using _36_Paskaita_EntityFrameworkProject.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace _36_Paskaita_EntityFrameworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                var transaction = db.Database.BeginTransaction();

                try
                {
                    Book book = new Book()
                    {
                        Id = Guid.NewGuid(),
                        Name = "100M Dollar Leads",
                    };
                    db.Books.Add(book);
                    db.SaveChanges();

                    transaction.CreateSavepoint("Create Book");
                    transaction.Commit();

                    for (int i = 0; i < 300; i++)
                    {
                        Page page = new Page(i, $"Content-{i}");
                        page.Book = book;
                        db.Pages.Add(page);
                        db.SaveChanges();

                    }
                    throw new Exception("Test");
                    Book book2 = db.Books.Include(x => x.Pages).FirstOrDefault(x => x.Name == "100M Dollar Leads");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.RollbackToSavepoint("Create Book");
                    Console.WriteLine("-----------------------");
                    transaction.Rollback();
                }
                finally
                {
                    transaction.Commit();
                }
            }
        }
    }
}
