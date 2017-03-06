using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WebApp_WSFederation_DotNet.Models;

namespace WebApp_WSFederation_DotNet.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeIndexModel();

            if (User.Identity.IsAuthenticated)
            {
                model.IsDomainUser = User.IsInRole("Domain Users");
                model.IsRobUser = User.IsInRole("ROB Users");
                model.Claims = ((ClaimsIdentity)User.Identity).Claims.ToList();
            }

            return View(model);
        }

        [Authorize(Roles ="Domain Users")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "ROB Users")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Error(string message)
        {
            ViewBag.Message = message;
            return View("Error");
        }
    }
}