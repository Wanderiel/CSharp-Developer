using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DeepOOP_Part01.Persons
{
    public class Person
    {
        private readonly string _surName;
        private readonly string _firstName;
        private readonly string _patronymic;

        public Person(string surName, string firstName, string patronymic)
        {
            _surName = surName;
            _firstName = firstName;
            _patronymic = patronymic;
        }

        public void ShowInfo()
        {

        }
    }
}
