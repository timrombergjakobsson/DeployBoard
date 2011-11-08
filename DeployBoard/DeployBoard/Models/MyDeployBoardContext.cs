using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DeployBoard.Models
{
    class MyDeployBoardContext : DeployBoardContext
    {
        public MyDeployBoardContext() : base("MyDeployBoard") {}
        public DbSet<Application> Applications { get; set; }
        public DbSet<Environment> Environments { get; set; }

    }
}
