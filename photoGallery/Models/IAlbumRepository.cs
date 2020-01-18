using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace photoGallery.Models
{
    public class IAlbumRepository
    {
        Album GetAlbum(int Id);
        IEnumerable<Album> GetAllAlbums();
        Album Add(Album album);
        Album Update(Album albumChanges);
        Album Delete(int Id);
    }
}