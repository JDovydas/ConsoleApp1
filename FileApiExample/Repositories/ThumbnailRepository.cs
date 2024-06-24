using FileApiExample.Model;
using FileApiExample.Repositories.Interfaces;

namespace FileApiExample.Repositories
{
    public class ThumbnailRepository : IThumbnailRepository
    {
        private readonly FileContext _context;

        public ThumbnailRepository(FileContext context)
        {
            _context = context;
        }

        public void AddThumbnail(Thumbnail thumbnail)
        {
            _context.Thumbnails.Add(thumbnail);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Thumbnail GetThumbnail(int photoid)
        {
            return _context.Thumbnails.FirstOrDefault(x => x.PhotoId == photoid);

        }

    }
}
