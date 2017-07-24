using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication4.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        public ActionResult AddUserV()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUserV(Models.UserModels model)
        {

            if (string.IsNullOrEmpty(model.B.ToString()))
            {
                ModelState.AddModelError("B","Null Model object error");
            }

            model.Result = model.A + model.B;
            return View(model);
            

        }
        public ActionResult chkno(int no)
        {
            if (no == 12)
                return Json("Number already exist", JsonRequestBehavior.AllowGet);
            return Json("true", JsonRequestBehavior.AllowGet);




        }
    }
}