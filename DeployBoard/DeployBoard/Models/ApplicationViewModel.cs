using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeployBoard.Models
{
    public class ApplicationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ServerId { get; set; }
        public List<string> NameList { get; set; }
    }
}