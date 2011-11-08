using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DeployBoard.Models
{
    public class ApplicationModel
    {
        public static DeployBoardEntities DeployBoardEntities = new DeployBoardEntities();

        public static IQueryable<Application> GetApplicationList()
        {
            var applications = DeployBoardEntities.Applications.OrderByDescending(a => a.Name);
            return applications.AsQueryable<Application>().Distinct();
        }

        public void AddDEployNumber(ApplicationViewModel applicationView)
        {
          


        }
    }
}