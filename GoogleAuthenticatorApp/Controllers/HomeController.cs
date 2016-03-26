using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleAuthenticatorApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(GoogleAuthService.GenerateQRCode());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ValidateKey(string userKey)
        {
            var validateValue = GoogleAuthService.ValidateUserKey(userKey);
            return Json(validateValue, JsonRequestBehavior.AllowGet);
        }
        
    }
}