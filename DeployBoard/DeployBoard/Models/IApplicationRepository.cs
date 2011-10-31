using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeployBoard.Models
{
    public interface IApplication
    {
        IList<Application> ListAll();

    }
}
