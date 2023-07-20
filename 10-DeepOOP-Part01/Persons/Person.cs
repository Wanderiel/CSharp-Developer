namespace _10_DeepOOP_Part01.Persons
{
    public class Person
    {
        public Person(string surName, string firstName, string patronymic)
        {
            SurName = surName;
            FirstName = firstName;
            Patronymic = patronymic;
        }

        public string SurName { get; private set; }
        public string FirstName { get; private set; }
        public string Patronymic { get; private set; }
        public string FullName => $"{SurName} {FirstName} {Patronymic}";

        public void ChangeSurName(string surName) => SurName = surName;

        public void ChangeFirstName(string firstName) => FirstName = firstName;

        public void ChangePatronymic(string patronymic) => Patronymic = patronymic;
    }
}
