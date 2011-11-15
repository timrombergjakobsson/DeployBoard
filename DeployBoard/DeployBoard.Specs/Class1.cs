using Cone;
using DeployBoard.Controllers;
using DeployBoard.Models;

namespace DeployBoard.Specs
{
    [Describe(typeof(HomeController))]
    public class Class1
    {
        public void view_should_contain_cpx_applications()
        {
            var controller = new HomeController();
            DeployBoardEntities deployBoardEntities = new DeployBoardEntities();
            
        }
    }
}
