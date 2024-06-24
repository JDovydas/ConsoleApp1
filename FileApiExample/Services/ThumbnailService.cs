using FileApiExample.Model;
using FileApiExample.Repositories.Interfaces;
using FileApiExample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;

namespace FileApiExample.Services
{
    public class ThumbnailService : IThumbnailService
    {
        private readonly IThumbnailRepository _thumbnailRepo;
        private readonly IPhotoRepository _photoRepo;


        public ThumbnailService(IPhotoRepository photoRepo, IThumbnailRepository thumbnailRepo)
        {
            _photoRepo = photoRepo;
            _thumbnailRepo = thumbnailRepo;
        }

        public byte[] GetThumbnail(int id)
        {
            var thumbnail = _thumbnailRepo.GetThumbnail(id);
            if (thumbnail == null)
            {
                return null;
            }
            try
            {
                return File.ReadAllBytes(thumbnail.FilePath);
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IActionResult CreateThumbnail(int photoId)
        {
            var photo = _photoRepo.GetPhoto(photoId);
            if (photo == null)
            {
                return new NotFoundResult();
            }

            try
            {
                string photosPath = "Photos";
                string thumbnailsPath = $"{photosPath}/Thumbnails";
                string thumbnailPath = $"{thumbnailsPath}/{photo.Name}_{DateTime.Now.ToString("yyyy_MM_dd_H_m_s")}_thumb{Path.GetExtension(photo.FilePath)}";

                if (!Directory.Exists(thumbnailsPath))
                {
                    Directory.CreateDirectory(thumbnailsPath);
                }

                using (var image = Image.FromFile(photo.FilePath))
                {
                    var thumbnail = image.GetThumbnailImage(100, 100, () => false, IntPtr.Zero);
                    using (var thumbStream = new FileStream(thumbnailPath, FileMode.Create))
                    {
                        thumbnail.Save(thumbStream, ImageFormat.Jpeg);
                    }
                }

                var thumbnailEntry = new Thumbnail
                {
                    ContentType = photo.ContentType,
                    Name = $"{photo.Name}_thumb",
                    FilePath = thumbnailPath,
                    PhotoId = photo.Id
                };

                _thumbnailRepo.AddThumbnail(thumbnailEntry);
                _thumbnailRepo.SaveChanges();

                return new OkObjectResult(thumbnailEntry);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }


    }
}
