using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feb1Assessment.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<string> list = new List<string>()
            {
            "David",
            "Sam",
            "Mike",
            "Madhav",
            "Kate"
            };
            ViewBag.NameList = list;
            return View();
        }
        public ActionResult ReDirectDemo() 
        {
            TempData["WelcomeMessage"] = "Welcome to Customer Page";
            return RedirectToAction("DisplayMessage");
        }
        public ActionResult DisplayMessage() 
        {
            string welcomeMessage = TempData["WelcomeMessage"] as string;
            TempData.Remove("WelcomeMessage");
            ViewBag.WelcomeMessage = welcomeMessage;
            return View();
        }
    }
}