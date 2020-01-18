using System.Linq;

namespace PatternProject.Models
{
    public interface IGalleryData
    {
        IQueryable<IGalleryItem> GetImageGalleries();

        IQueryable<IGalleryItem> GetPhotos();
    }
}
