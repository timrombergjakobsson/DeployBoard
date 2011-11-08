using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeployBoard.Models
{
    public class ApplicationViewModel
    {
        public int ApplicationId { get; set; }
        public string Name { get; set; }
        public int ServerId { get; set; }
        private int _deployNumber;

        [RegularExpression(@"[-+]?[0-9]*\.?[0-9]?[0-9]", ErrorMessage = "Number required.")]
        public int DeployNumber
        {
            get { return _deployNumber; }
            set { _deployNumber = value; }
        }

        public ICollection<Environment> Environments { get; set; }
    }
}