using _37_Paskaita_Exercise.Database;
using _37_Paskaita_Exercise.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Paskaita_Exercise
{
    internal static class TagBuilder
    {
        public static void Build()
        {
            using (var db = new MsSqlDb())
            {
                foreach (var file in db.Files.ToList())
                {
                    string ext = file.Name.Substring(file.Name.LastIndexOf('.'));
                    FileTag newTag = new();
                    newTag.TagWord = ext switch
                    {
                        ".txt" => "Text",
                        ".pdf" => "PDF",
                        ".docx" => "Word",
                        ".xlsx" => "Excerl",
                        ".pptx" => "PowerPoint",
                        _ => "Other"
                    };

                    FileTag? existingTag = db.Tags.FirstOrDefault(t => t.TagWord == newTag.TagWord);
                    if (existingTag == null)
                    {
                        file.Tags.Add(newTag);
                        db.Tags.Add(newTag);
                        db.SaveChanges();
                    }
                    else
                    {
                        file.Tags.Add(existingTag);
                        db.SaveChanges();
                    }
                }

                //foreach (var file in db.Files.ToList())
                //{
                //    string ext = file.Name.Substring(file.Name.LastIndexOf('.'));
                //    FileTag newTag = new();
                //    newTag.TagWord = ext switch
                //    {
                //        ".txt" => "Document",
                //        ".pdf" => "Document",
                //        ".docx" => "Document",
                //        ".xlsx" => "Document",
                //        ".pptx" => "Document",
                //        _ => "None"

                //    };

                //    FileTag? existingTag = db.Tags.FirstOrDefault(t => t.TagWord == newTag.TagWord);
                //    if (existingTag == null)
                //    {
                //        file.Tags.Add(newTag);
                //        //db.Tags.Add(newTag);
                //        db.SaveChanges();

                //    }
                //    else
                //    {
                //        file.Tags.Add(existingTag);
                //        db.SaveChanges();
                //    }

                //}

            }
        }
    }
}
