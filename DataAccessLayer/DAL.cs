using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDFArt.DBModels;

namespace PDFArt.DataAccessLayer
{
    public class DAL : IDAL
    {

       private PDFARTContext _db = new PDFARTContext();
        public List<Book> getAllBooks()
        {
           return _db.Book.ToList();
        }

        public List<Catagory> getAllCatagories()
        {
            return _db.Catagory.ToList();
        }

        public Book getBookDetailByBookID(int id)
        {
            Book objectBook = _db.Book.Find(id);
            return objectBook;
        }
    }
}
