using _37_Paskaita_Exercise.Database.Models;
using _37_Paskaita_Exercise.Database;

namespace _37_Paskaita_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\djuod\OneDrive\Paskaitos\Level 2";

            Scanner.Scan(path);
            TagBuilder.Build();

            using (var db = new MsSqlDb())
            {
                var files = db.Files.ToList();
                LocalFile file = db.Files.FirstOrDefault(f => f.Id == 3);
                var tags = db.Tags.ToList();
                FileTag tag = db.Tags.FirstOrDefault(t => t.Id == 1);
                file.Tags.Add(tag);
                tag.Files.Add(file);
                db.SaveChanges();
            }
        }
    }
}
