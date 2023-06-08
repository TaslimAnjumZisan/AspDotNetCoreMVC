using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View("Rename");
        }
        public ActionResult AboutUs() { 
        
            return View();
        }
        public ActionResult Contact()
        {
            return View("~/Views/MyView/NewView.cshtml");
        }
        public string EmployeeProfile(int id)

        {
            string profile=string.Empty;
            if (id == 1)
            {
                return "Employee profile 1";
            }
            else if (id == 2)
            {
                return "Employee profile 2";
            }
            else
            {
                return "Profile not found";
            }
            return profile;
            
        }

        public string Address(int id, string department)
        {
            return "id= " + id + "dept=" + department;
        }

        public string Details(int id, int? code=null)
        {
            return "id= " + id + "dept=" + code;
        }
    }
}