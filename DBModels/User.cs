using System;
using System.Collections.Generic;

namespace PDFArt.DBModels
{
    public partial class User
    {
        public User()
        {
            Book = new HashSet<Book>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime? UserDateCreated { get; set; }
        public DateTime? UserDateUpdated { get; set; }
        public bool? UserIsActive { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
