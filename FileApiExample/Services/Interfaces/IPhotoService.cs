using FileApiExample.Model;
using Microsoft.AspNetCore.Mvc;

namespace FileApiExample.Services.Interfaces
{
    public interface IPhotoService
    {
        bool AddPhoto(IFormFile photo);
        FileContentResult GetPhoto(int id);



    }
}
