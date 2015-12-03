using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AndrewBaldridge.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("ContactMe")]
        public ActionResult Contact()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Contact";
            return View("Contact");
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Development()
        {
            return View();
        }

        public ActionResult Database()
        {
            return View();
        }

        public ActionResult Analysis()
        {
            return View();
        }

        public ActionResult References()
        {
            return View();
        }

        public ActionResult NoPageError()
        {
            return View();
        }

        public ActionResult PageErrorOnly()
        {
            return View();
        }

        public ActionResult TestException()
        {
            try
            {
                throw new Exception("Behold! A groovy inner exception.");
            }
            catch (Exception e)
            {
                throw new Exception("Look, I caught and wrapped an exception!", e);
            }
        }

        
    }
}