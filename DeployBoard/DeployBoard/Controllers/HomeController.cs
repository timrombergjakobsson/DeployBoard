﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeployBoard.Models;

namespace DeployBoard.Controllers
{
    public class HomeController : Controller
    {
        private readonly DeployBoardContext _deployBoard;

       
        public HomeController()
        {
            //_deployBoard = new DeployBoardContext();
        }

        public ActionResult Index()
        {

            return View();
        }

   
        /*public ActionResult ListApplications()
        {
            return View("Index", ApplicationModel.GetApplicationList());
        }*/

         public ActionResult About()
        {
            return View();
        }

       [HttpPost] 
       public ActionResult InsertDeployNumber(ApplicationViewModel model)
       {
           try
           {
               if(ModelState.IsValid)
               {
                   //_deployBoard.Applications.Add();
                   //_deployBoard.SaveChanges();
                   return RedirectToAction("Index");
               }

           }
           catch (DataException)
           {
               
               ModelState.AddModelError("", "oops sorry to say but something went wrong");
           }
           

           return View("Error");


       }


    }
}
