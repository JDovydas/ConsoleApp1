using FileApiExample.Model;
using FileApiExample.Repositories.Interfaces;

namespace FileApiExample.Repositories
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly FileContext _context;

        public PhotoRepository(FileContext context)
        {
            _context = context;
        }

        public void AddPhoto(Photo photo)
        {
            _context.Photos.Add(photo);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Photo GetPhoto(int id)
        {
            return _context.Photos.FirstOrDefault(p => p.Id == id);
        }

    }
}
