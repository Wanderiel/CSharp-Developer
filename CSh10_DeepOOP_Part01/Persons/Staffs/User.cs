using CSh10_DeepOOP_Part01.Interfaces;

namespace CSh10_DeepOOP_Part01.Persons.Staffs
{
    public class User : Person
    {
        protected readonly IRole _role;

        public User(string surName, string firstName, string patronymic, IRole role)
            : base(surName, firstName, patronymic)
        {
            _role = role;
        }
    }
}
