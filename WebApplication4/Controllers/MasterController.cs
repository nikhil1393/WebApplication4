using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class MasterController : Controller
    {
            public ActionResult SiteMaster()
            {
            ViewBag.Title = "SiteMaster";
                return View("SiteMaster", "_Layout");
            }

            public ActionResult About()
            {
            ViewBag.Title = "About";
            return View("About", "_Layout");
        }

            public ActionResult Contact()
            {
            ViewBag.Title = "Contact";
            return View("Contact", "_Layout");
        }
        }
}