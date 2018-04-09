using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDFArt.Models;
using PDFArt.CustomModel;
namespace PDFArt.BussinessLogicLayer
{
    interface IBLL
    {
        HomeViewModel getAllBooksAndCatagories();
        BookCustomModel getBookDetailsByBookID(int ?id);
        bool isDownloadable(int?id);
        string downloadBookByBookId(int? bookID);
    }
}
