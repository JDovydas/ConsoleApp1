using FileApiExample.Model;
using FileApiExample.Repositories.Interfaces;
using FileApiExample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;

namespace FileApiExample.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository _photoRepo;
        private readonly IThumbnailRepository _thumbnailRepo;

        public PhotoService(IPhotoRepository photoRepo, IThumbnailRepository thumbnailRepo)
        {
            _photoRepo = photoRepo;
            _thumbnailRepo = thumbnailRepo;
        }

        public PhotoService(IPhotoRepository photoRepo)
        {
            _photoRepo = photoRepo;

        }

        public bool AddPhoto(IFormFile photo)
        {
            try
            {
                string photosPath = "Photos";
                string filePath = $"{photosPath}/{photo.FileName}_{DateTime.Now.ToString("yyyy_MM_dd_H_m_s")}{Path.GetExtension(photo.FileName)}";

                if (!Directory.Exists(photosPath))
                {
                    Directory.CreateDirectory(photosPath);
                }

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    photo.CopyTo(fileStream);
                }

                var photoEntry = new Photo
                {
                    ContentType = photo.ContentType,
                    Name = photo.FileName,
                    FilePath = filePath
                };

                _photoRepo.AddPhoto(photoEntry);
                _photoRepo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public FileContentResult GetPhoto(int id)
        {
            var photo = _photoRepo.GetPhoto(id);
            if (photo != null)
            {
                byte[] fileBytes = File.ReadAllBytes(photo.FilePath);
                return new FileContentResult(fileBytes, photo.ContentType);
            }
            else
            {
                return null;
            }
        }

    }
}

