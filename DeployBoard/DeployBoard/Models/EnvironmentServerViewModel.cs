using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeployBoard.Models
{
    public class EnvironmentServerViewModel
    {
        public int ServerId { get; set; }
        public string Name { get; set; }
        public int ApplicationId { get; set; }
        public virtual ICollection<Application> Applications { get; set; }


    }
}