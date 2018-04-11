using System;
using System.Collections.Generic;

namespace PDFArt.DBModels
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactMessage { get; set; }
        public bool? ContactIsActive { get; set; }
        public DateTime? ContactCreateDate { get; set; }
        public DateTime? ContactUpdateDate { get; set; }
    }
}
