using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeployBoard.Models
{
    public class ApplicationModel
    {
       
        public static IQueryable<Application> GetApplicationList()
        {
            DeployBoardEntities deployBoardEntities = new DeployBoardEntities();
            var applications = from a in deployBoardEntities.Applications
                               orderby a.Name descending 
                               select a;
            return applications.AsQueryable<Application>().Distinct();
               }
    }
}