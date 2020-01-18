using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PatternProject.Models
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly GalleryContext db = new GalleryContext();

        public List<Photo> GetAll()
        {
            var photos = db.Photos.Include(p => p.Album).ToList();
            return photos;
        }

    }
}