using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DeepOOP_Part01.Persons
{
    public class Person
    {
        protected string _surName;
        protected string _firstName;
        protected string _patronymic;

        public Person(string surName, string firstName, string patronymic)
        {
            _surName = surName;
            _firstName = firstName;
            _patronymic = patronymic;
        }
    }
}
