using _39_Paskaita_ManyToManyPart2.Models;
using _39_Paskaita_ManyToManyPart2;
using Microsoft.Data.SqlClient;

namespace _39_Paskaita_ManyToManyPart2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the directory path:");
            string directoryPath = Console.ReadLine();

            using (var context = new FileContext())
            {

                int rootFolderId = ScanDirectory(directoryPath, null, context);
            }

            Console.WriteLine("Files information inserted into the database.");
        }

        static int ScanDirectory(string directoryPath, int? parentFolderId, FileContext context)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            Folder folder = new Folder
            {
                Name = directory.Name,
                ParentFolderId = parentFolderId
            };
            context.Folders.Add(folder);
            context.SaveChanges();

            int currentFolderId = folder.Id;

            List<FileInformation> files = new List<FileInformation>();

            string[] fileEntries = Directory.GetFiles(directoryPath);

            foreach (string filePath in fileEntries)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                FileInformation file = new FileInformation
                {
                    Name = Path.GetFileName(filePath),
                    Size = fileInfo.Length,
                    FullPath = filePath,
                    FolderId = currentFolderId
                };
                files.Add(file);
            }

            foreach (string subdirectory in Directory.GetDirectories(directoryPath))
            {
                int subFolderId = ScanDirectory(subdirectory, currentFolderId, context);
            }

            context.Files.AddRange(files);

            foreach (var file in files)
            {
                List<Tag> tagsToAdd = GetTagsForFile(file);
                file.Tags.AddRange(tagsToAdd);
            }

            context.SaveChanges();

            return currentFolderId;
        }

        static List<Tag> GetTagsForFile(FileInformation file)
        {
            //////////////////
            return new List<Tag>();
        }

    }
}
