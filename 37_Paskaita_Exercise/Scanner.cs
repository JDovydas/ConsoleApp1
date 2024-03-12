using _37_Paskaita_Exercise.Database;
using _37_Paskaita_Exercise.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Paskaita_Exercise
{
    internal class Scanner
    {
        public static void Scan(string path)
        {
            DirectoryInfo localDirInfo = new DirectoryInfo(path);
            LocalDirectory localDir = new LocalDirectory
            {
                Name = localDirInfo.Name,
                FullPath = localDirInfo.FullName
            };

            var files = localDirInfo.EnumerateFiles();
            foreach (var file in files)
            {
                LocalFile localFile = new LocalFile
                {
                    Name = file.Name,
                    FullPath = file.FullName,
                    Size = file.Length
                };
                localDir.Files.Add(localFile);
            }
            using (var db = new MsSqlDb())
            {
                db.Directories.Add(localDir);
                db.Files.AddRange(localDir.Files);
                db.SaveChanges();
            }

            var dirs = localDirInfo.EnumerateDirectories();
            if (dirs.Count() == 0)
            {
                return;
            }
            foreach (var dir in dirs)
            {
                Scan(dir.FullName);
            }

        }
    }
}
