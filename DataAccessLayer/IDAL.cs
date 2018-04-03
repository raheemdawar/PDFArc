using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDFArt.DBModels;
namespace PDFArt.DataAccessLayer
{
    interface IDAL
    {
        List<Book> getAllBooks();

        List<Catagory> getAllCatagories();
        Book getBookDetailByBookID(int id);
    }
}
