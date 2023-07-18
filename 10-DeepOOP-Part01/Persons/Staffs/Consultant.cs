using _10_DeepOOP_Part01.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DeepOOP_Part01.Persons.Staffs
{
    public class Consultant : Person
    {
        protected readonly IController _controller;
        protected string Position = "Консультант";

        public Consultant(string surName, string firstName, string patronymic, IController controller)
            : base(surName, firstName, patronymic)
        {
            _controller = controller;
        }
    }
}
