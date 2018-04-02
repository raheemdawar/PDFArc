using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDFArt.CustomModel
{
    public class BookCustomModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthorName { get; set; }
        public string BookEdition { get; set; }
        public string BookImageUrl { get; set; }
    }
}
