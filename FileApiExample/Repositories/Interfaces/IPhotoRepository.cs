using FileApiExample.Model;

namespace FileApiExample.Repositories.Interfaces
{
    public interface IPhotoRepository
    {
        void AddPhoto(Photo photo);
        void SaveChanges();
        Photo GetPhoto(int id);
    }
}
