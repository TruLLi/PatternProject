using System;
using System.Web;

namespace PatternProject.Models
{
    public interface IGalleryItem
    {
        int ID { get; set; }

        HttpPostedFileBase File { get; set; }

        DateTime? InsertedDateTime { get; set; }

        DateTime? LastUpdatedDatetime { get; set; }

        string InsertedBy { get; set; }

        string LastUpdatedBy { get; set; }
    }
}
