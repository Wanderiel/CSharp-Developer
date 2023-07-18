using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DeepOOP_Part01.Persons.Clients
{
    internal class Client : Person
    {
        private readonly string _telephone;
        private readonly string _passport;

        public Client(string surName, string firstName, string patronymic,
            string telephone, string passport)
            : base(surName, firstName, patronymic)
        {
            _telephone = telephone;
            _passport = passport;
        }
    }
}
