namespace _10_DeepOOP_Part01.Persons.Clients
{
    public class Client : Person
    {
        public Client(
            int id,
            string surName,
            string firstName,
            string patronymic,
            string telephone,
            string passport)
            : base(surName, firstName, patronymic)
        {
            Id = id;
            Telephone = telephone;
            Passport = passport;
        }

        public int Id { get; }
        public string Telephone { get; private set; }
        public string Passport { get; private set; }

        public void ChangeTelephone(string telephone)
        {
            if (string.IsNullOrEmpty(telephone))
                return;

            Telephone = telephone;
        }

        public void ChangePassport(string passport)
        {
            if (string.IsNullOrEmpty(passport))
                return;

            Passport = passport;
        }
    }
}