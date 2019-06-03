using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JA.API.Controllers
{
    public class HomeController : Controller
    {
        //private IRepository _repository;
        public HomeController()
        {
            
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
