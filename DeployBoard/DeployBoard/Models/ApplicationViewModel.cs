using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeployBoard.Models
{
    public class ApplicationViewModel
    {
        public int ApplicationId { get; set; }
        public string Name { get; set; }
        public int ServerId { get; set; }
        [RegularExpression(@"[-+]?[0-9]*\.?[0-9]?[0-9]", ErrorMessage = "Number required.")]
        public int DeployNumber { get; set; }
        public ICollection<Environment> Environments { get; set; }
    }
}