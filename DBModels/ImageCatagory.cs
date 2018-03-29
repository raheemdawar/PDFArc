using System;
using System.Collections.Generic;

namespace PDFArt.DBModels
{
    public partial class ImageCatagory
    {
        public int ImageCatagoryId { get; set; }
        public DateTime? ImageCatagoryDateCreated { get; set; }
        public DateTime? ImageCatagoryDateUpdated { get; set; }
        public bool? ImageCatagoryIsActive { get; set; }
        public string ImageCatagoryUrl { get; set; }
        public int? FkCatagoryId { get; set; }

        public Catagory FkCatagory { get; set; }
    }
}
