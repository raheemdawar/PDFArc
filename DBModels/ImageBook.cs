using System;
using System.Collections.Generic;

namespace PDFArt.DBModels
{
    public partial class ImageBook
    {
        public int ImageBookId { get; set; }
        public DateTime? ImageBookDateCreated { get; set; }
        public DateTime? ImageBookDateUpdated { get; set; }
        public bool? ImageBookIsActive { get; set; }
        public string ImageBookUrl { get; set; }
        public int? FkBookId { get; set; }

        public Book FkBook { get; set; }
    }
}
