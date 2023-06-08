using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ActionResult WithOutView() 
        {
            return View();
        }
        public string Index2()
        {
            return "Hello from Zishan";
        }

        public string Name()
        {
            return "Myself Zishan";
        }



    }
}