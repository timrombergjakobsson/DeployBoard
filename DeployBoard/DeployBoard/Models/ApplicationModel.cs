using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DeployBoard.Models
{
    public class ApplicationModel
    {
        private DeployBoardEntities deployBoardEntities = new DeployBoardEntities();

        public static IQueryable<Application> GetApplicationList(DeployBoardEntities deployBoardEntities)
        {
            var applications = deployBoardEntities.Applications.OrderByDescending(a => a.Name);
            return applications.AsQueryable<Application>().Distinct();
        }

        public void AddDEployNumber(ApplicationViewModel applicationView)
        {
          


        }
    }
}