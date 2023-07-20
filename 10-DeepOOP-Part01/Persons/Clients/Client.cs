using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DeepOOP_Part01.Persons.Clients
{
    public class Client : Person
    {
        public Client(string surName, string firstName, string patronymic,
            string telephone, string passport)
            : base(surName, firstName, patronymic)
        {
            Telephone = telephone;
            Passport = passport;
        }

        public string Telephone { get; private set; }
        public string Passport { get; private set; }

        public void ChangeTelephone(string telephone) => Telephone = telephone;

        public void ChangePassport(string passport) => Passport = passport;
    }
}
