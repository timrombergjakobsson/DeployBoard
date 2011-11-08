using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeployBoard.Models
{
    public class Environment
    {
        public int ServerId { get; set; }
        public string Name { get; set; }
        public int ApplicationId { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
