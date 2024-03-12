using _39_Paskaita_ManyToManyPart1.Models;

namespace _39_Paskaita_ManyToManyPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the directory path:");
            string directoryPath = Console.ReadLine();

            List<FileInformation> files = ScanDirectory(directoryPath);

            InsertFiles(files);

            Console.WriteLine("Files information inserted into the database.");
        }

        static List<FileInformation> ScanDirectory(string directoryPath)
        {
            List<FileInformation> files = new List<FileInformation>();

            string[] fileEntries = Directory.GetFiles(directoryPath);

            foreach (string filePath in fileEntries)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                FileInformation file = new FileInformation
                {
                    Name = Path.GetFileName(filePath),
                    Size = fileInfo.Length,
                    FullPath = filePath
                };
                files.Add(file);
            }

            return files;
        }

        static void InsertFiles(List<FileInformation> files)
        {
            using (var context = new FileContext())
            {

                foreach (var file in files)
                {
                    context.Files.Add(file);
                }
                context.SaveChanges();
            }
        }
    }
}
