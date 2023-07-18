using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DeepOOP_Part01.Persons.Staffs
{
    internal class Consultant : Person
    {
        string _type = "Консультант";

        public Consultant(string surName, string firstName, string patronymic)
            : base(surName, firstName, patronymic)
        {
        }
    }
}
