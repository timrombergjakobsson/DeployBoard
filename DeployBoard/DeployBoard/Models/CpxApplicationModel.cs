using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DeployBoard.Models
{
    public class CpxApplicationModel
    {
        public static DeployBoardEntities DeployBoardEntities = new DeployBoardEntities();

        public static IQueryable<CpxApplicationModel> GetApplicationList()
        {
            var cpxapplications = DeployBoardEntities.Cpx_Applications.OrderByDescending(a => a.Name);
            return Queryable.AsQueryable<CpxApplicationModel>().Distinct();
        }

        public void AddDEployNumber(CpxApplicationViewModel applicationView)
        {
          


        }
    }
}