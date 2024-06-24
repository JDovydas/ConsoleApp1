using FileApiExample.Model;
using FileApiExample.Services;
using FileApiExample.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NuGet.Packaging;
using System.Drawing;
using System.Drawing.Imaging;

namespace FileApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : Controller
    {
        private readonly IPhotoService _photoService;

        private readonly IThumbnailService _thumbnailService;

        public PhotosController(IPhotoService photoService, IThumbnailService thumbnailService)
        {
            _photoService = photoService;
            _thumbnailService = thumbnailService;
        }

        [HttpPost("Add")]
        public IActionResult Add(IFormFile photo)
        {
            var success = _photoService.AddPhoto(photo);
            if (success)
            {
                return Ok("Photo added successfully.");
            }
            else
            {
                return BadRequest("Failed to add photo.");
            }
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            return _photoService.GetPhoto(id);
        }


        [HttpPost("CreateThumbnail/{photoId}")]
        public IActionResult CreateThumbnail(int photoId)
        {
            return _thumbnailService.CreateThumbnail(photoId);
        }


        [HttpGet("thumbnail/{photoId}")]
        public IActionResult GetThumbnail(int photoId)
        {
            try
            {
                var fileBytes = _thumbnailService.GetThumbnail(photoId);
                return File(fileBytes, "image/jpeg");
            }
            catch (KeyNotFoundException knf)
            {
                return NotFound(knf.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

    }
}
