using System;
using System.Collections.Generic;

namespace PDFArt.DBModels
{
    public partial class Catagory
    {
        public Catagory()
        {
            Book = new HashSet<Book>();
            ImageCatagory = new HashSet<ImageCatagory>();
        }

        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
        public DateTime? CatagoryDateCreated { get; set; }
        public DateTime? CatagoryDateUpdated { get; set; }
        public bool? CatagoryIsActive { get; set; }

        public ICollection<Book> Book { get; set; }
        public ICollection<ImageCatagory> ImageCatagory { get; set; }
    }
}
