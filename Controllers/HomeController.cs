using Microsoft.AspNetCore.Mvc;
using PDFArt.BussinessLogicLayer;
using PDFArt.Models;
using PDFArt.CustomModel;
namespace PDFArt.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult contact()
        {
            bool isViewAble = _bussinessLogicLayer.isContactFormViewable();
            if(isViewAble)
            {
                return View();
            }
            return RedirectToAction("ErrorPage");
            
        }
        public IActionResult contact(ContactCustomModel model)
        {
            if(ModelState.IsValid)
            {
             bool isConactAdded=   _bussinessLogicLayer.addContact(model);
                if(isConactAdded)
                {
                    //success screen 
                }else
                {
                    // contact not submitted due to invalid 
                }

            }
            return RedirectToAction("ErrorPage");
        }
     private   IBLL _bussinessLogicLayer = new BLL();
        public IActionResult Index()
        {
         HomeViewModel model=   _bussinessLogicLayer.getAllBooksAndCatagories();


            return View(model);
        }
        public IActionResult Book(int ?id)
        {
            BookCustomModel model = _bussinessLogicLayer.getBookDetailsByBookID(id);
            return View(model);
        }
        public IActionResult download(int id)
        {
            bool isDownloadable = _bussinessLogicLayer.isDownloadable(id);
            if(isDownloadable)
            {
                string url = _bussinessLogicLayer.downloadBookByBookId(id);

            }
            return RedirectToAction("ErrorPage");
        }
    }
}