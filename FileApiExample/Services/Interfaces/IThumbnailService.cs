using FileApiExample.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FileApiExample.Services.Interfaces
{
    public interface IThumbnailService
    {
        byte[] GetThumbnail(int id);
        IActionResult CreateThumbnail(int photoId);
    }
}
