using AndrewBaldridge.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AndrewBaldridge.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Contact(ContactPage contactPage)
        {
            if (ModelState.IsValid)
            {
                return View("Index", contactPage);
            }
            else
            {
                return View();
            }
            
        }
    }
}