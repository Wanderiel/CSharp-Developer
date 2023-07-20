using _10_DeepOOP_Part01.Databases;
using _10_DeepOOP_Part01.Interfaces;
using _10_DeepOOP_Part01.Persons.Clients;

namespace _10_DeepOOP_Part01.Persons.Roles
{
    internal class Consultant : BaseRole, IRole
    {
        public string Title => "Консультант";

        public void ChangeData(Entry entry)
        {
            Console.Write("Введите номер телефона: ");
            string telephone = Console.ReadLine();

            if (string.IsNullOrEmpty(telephone))
                return;

            entry.Client.ChangeTelephone(telephone);
        }

        private void ChangeTelephone(Client client)
        {
            if (TryData("телефон", out string input))
                client.ChangeTelephone(input);
        }

        public void ShowInfo(Entry entry)
        {
            Client client = entry.Client;
            string passport = new string('*', client.Passport.Length);
            Log log = entry.LastLog;

            Console.WriteLine($"ФИО: {client.FullName}");
            Console.WriteLine($"телефон: {client.Telephone}");
            Console.WriteLine($"паспорт: {passport}");
            Console.WriteLine($"последние изменения: {log.Data}");
        }
    }
}
