using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDFArt.Models;
using PDFArt.DBModels;
using PDFArt.CustomModel;
using PDFArt.DataAccessLayer;
namespace PDFArt.BussinessLogicLayer
{
    public class BLL : IBLL
    {
        private IDAL _dataAccessLayer = new DAL();

        public HomeViewModel getAllBooksAndCatagories()
        {
            List<Book> allBooks = _dataAccessLayer.getAllBooks();
            List<Catagory> allCatagories = _dataAccessLayer.getAllCatagories();
            HomeViewModel dto = new HomeViewModel();

            //counting books 
            if (allBooks.Count > 0)
            {
                //iterating over books 
                foreach (var book in allBooks)
                {
                    //Creating onject for list
                    BookCustomModel item = new BookCustomModel();
                    item.BookAuthorName = book.BookAuthorName;
                    item.BookEdition = book.BookEdition;
                    item.BookId = book.BookId;
                   
                    //extracting book image url
                    List<ImageBook> bookImages = book.ImageBook.ToList();
                    string BookImageUrl = (from bookImagesRecord in bookImages
                                           where bookImagesRecord.ImageBookIsActive == true
                                           select bookImagesRecord.ImageBookUrl).FirstOrDefault();
                    //assigning book image url
                    item.BookImageUrl = BookImageUrl;

                    //adding book custom model in dto 
                    dto.listOfBooks.Add(item);
                }
                //counting Catagories 
                

            }
            if (allCatagories.Count > 0)
            {
                //iterating over Catagories 
                foreach (var catagory in allCatagories)
                {
                    //Creating object for list
                    CatagoryCustomModel item = new CatagoryCustomModel();
                    item.catagoryID = catagory.CatagoryId;
                    item.CatagoryName = catagory.CatagoryName;

                    //extracting Catagories image url
                    List<ImageCatagory> CatagorieImage = catagory.ImageCatagory.ToList();
                    string catagoryImageUrl = (from catagoryImagesRecord in CatagorieImage
                                               where catagoryImagesRecord.ImageCatagoryIsActive == true
                                               select catagoryImagesRecord.ImageCatagoryUrl).FirstOrDefault();
                    //assigning Catagories image url
                    item.catagoryImageUrl = catagoryImageUrl;

                    //adding book custom model in dto 
                    dto.listOfCatagories.Add(item);
                }

               
            }
            return dto;
        }
    }
}
