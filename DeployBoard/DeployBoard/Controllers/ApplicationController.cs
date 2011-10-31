using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeployBoard.Models;

namespace DeployBoard.Controllers
{
    public class ApplicationController : Controller
    {
        //
        // GET: /Application/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListApplications()
        {
            return View("Index", ApplicationModel.GetApplicationList());
        }

    }
}
