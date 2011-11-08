using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeployBoard.Models;

namespace DeployBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

   
        public ActionResult ListApplications()
        {
            return View("Index", ApplicationModel.GetApplicationList());
        }

         public ActionResult About()
        {
            return View();
        }


    }
}
