using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace WebApplication4.Controllers
{
    public class SessionsController : Controller
    {
        // GET: Sessions
        public ActionResult OneView()
        {
            TempData["oneViewTemp"] = "Data came from one view page as temp data";
            Session["oneViewSession"] = "Data came from one view page as session data";
            return RedirectToAction("TwoView");
        }

        public ActionResult TwoView()
        {
            return View();
        }
        
    }
}