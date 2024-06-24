using FileApiExample.Model;

namespace FileApiExample.Repositories.Interfaces
{
    public interface IThumbnailRepository
    {
        void AddThumbnail(Thumbnail thumbnail);
        void SaveChanges();
        Thumbnail GetThumbnail(int photoId);
    }
}
