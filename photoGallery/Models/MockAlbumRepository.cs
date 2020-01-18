using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace photoGallery.Models
{
    public class MockAlbumRepository : IAlbumRepository
    {
        private List<Album> _albumList;

        public MockAlbumRepository()
        {
            _albumList = new List<Album>()
            {
                new Album(){ID=1, AlbumName="Repository pattern", ThumbnailImage="Repository pattern", LastUpdatedBy="Repository pattern" },
                new Album(){ID=2, AlbumName="Repository pattern2", ThumbnailImage="Repository pattern2", LastUpdatedBy="Repository pattern2" }
            };
        }

        public IEnumerable<Album> GetAllAlbums()
        {
            return _albumList;
        }

        public Album GetAlbum(int id)
        {
            return this._albumList.FirstOrDefault(e => e.ID == id);
        }

        public Album Add(Album album)
        {
            album.ID = _albumList.Max(e => e.ID) + 1;
            _albumList.Add(album);
            return album;
        }

        public Album Delete(int id)
        {
            Album album = _albumList.FirstOrDefault(e => e.ID == id);
            if (album != null)
            {
                _albumList.Remove(album);
            }
            return album;
        }

        public Album Update(Album albumChange)
        {
            Album album = _albumList.FirstOrDefault(e => e.ID == albumChange.ID);
            if (album != null)
            {
                album.AlbumName = albumChange.AlbumName;
                album.ThumbnailImage = albumChange.ThumbnailImage;
                album.LastUpdatedBy = albumChange.LastUpdatedBy;
            }
            return album;
        }

    }
}