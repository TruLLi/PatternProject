using PatternProject.Models;
using System.Linq;


namespace photoGallery.Models
{
    public class GalleryData : IGalleryData
    {
        private GalleryContext db = new GalleryContext();

        public IQueryable<IGalleryItem> GetImageGalleries()
        {
            return db.ImageGalleries;
        }

        public IQueryable<IGalleryItem> GetPhotos()
        {
            return db.Photos;
        }
    }
}