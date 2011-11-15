using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeployBoard.Models
{
    public class PortalApplicationsViewModel
    {
        public string PortalId { get; set; }
        public string Name { get; set; }
        [RegularExpression(@"[-+]?[0-9]*\.?[0-9]?[0-9]", ErrorMessage = "Number required.")]
        public int DeployNumber { get; set; }
    }
}