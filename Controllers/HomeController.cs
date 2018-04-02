using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PDFArt.BussinessLogicLayer;
using PDFArt.Models;
namespace PDFArt.Controllers
{
    public class HomeController : Controller
    {
     private   IBLL _bussinessLogicLayer = new BLL();
        public IActionResult Index()
        {
         HomeViewModel model=   _bussinessLogicLayer.getAllBooksAndCatagories();


            return View(model);
        }
    }
}