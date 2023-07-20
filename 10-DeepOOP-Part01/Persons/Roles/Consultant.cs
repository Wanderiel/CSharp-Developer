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
            const ConsoleKey CommandChangeTelephone = ConsoleKey.NumPad1;
            const ConsoleKey CommandExit = ConsoleKey.Q;

            bool isWork = true;

            while (isWork)
            {
                bool isChanged = false;

                Console.WriteLine($"{CommandChangeTelephone} - изменить данные ({TitleTelephone})");
                Console.WriteLine($"{CommandExit} - назад");

                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case CommandChangeTelephone:
                            isChanged = TryChangeData(entry.Client, TitleTelephone);
                            break;

                        case CommandExit:
                            isWork = false;
                            break;
                    }
                }

                if (isChanged)
                    entry.LogIn(new Log(DateTime.Now, TitleSurName, "изменение", Title));
            }
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
