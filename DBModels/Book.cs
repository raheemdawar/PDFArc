using System;
using System.Collections.Generic;

namespace PDFArt.DBModels
{
    public partial class Book
    {
        public Book()
        {
            ImageBook = new HashSet<ImageBook>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthorName { get; set; }
        public string BookEdition { get; set; }
        public DateTime? BookDateCreated { get; set; }
        public DateTime? BookDateUpdated { get; set; }
        public bool? BookIsActive { get; set; }
        public int? FkUserId { get; set; }
        public int? FkCatagoryId { get; set; }
        public string bookUrl { get; set; }
        public Catagory FkCatagory { get; set; }
        public User FkUser { get; set; }
        public ICollection<ImageBook> ImageBook { get; set; }
    }
}
