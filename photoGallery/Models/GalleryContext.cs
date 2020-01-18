using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PatternProject.Models
{
    public class GalleryContext : DbContext
    {
        public GalleryContext()
            : base("PatternProject")
        {
        }
        public DbSet<Album> ImageGalleries { get; set; }

        public DbSet<Photo> Photos { get; set; }
    }
    public class SampleData : System.Data.Entity.DropCreateDatabaseIfModelChanges<GalleryContext>
    {
    }
}