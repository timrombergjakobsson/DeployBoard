using System.Data.Entity;

namespace DeployBoard.Models
{
    public class DeployBoardContext : DbContext
    {
        public DbSet<Environment> EnvironmentServers { get; set; }
        public DbSet<Application> Applications { get; set; }

         
    }
}