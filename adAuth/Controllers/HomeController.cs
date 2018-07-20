using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace adAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {           
            if (((System.Security.Claims.ClaimsIdentity)User.Identity).HasClaim(ClaimTypes.Name, "Anbarasu"))
            {
                ViewBag.Message = "Your application description page.";
                return View();
            }
            return View();           
        }

        [Authorize(Users = "Anbarasu")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}