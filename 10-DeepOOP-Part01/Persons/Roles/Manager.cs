using _10_DeepOOP_Part01.Databases;
using _10_DeepOOP_Part01.Interfaces;
using _10_DeepOOP_Part01.Persons.Clients;

namespace _10_DeepOOP_Part01.Persons.Roles
{
    public class Manager : BaseRole, IRole
    {
        public string Title => "Менеджер";

        public void ChangeData(Entry entry)
        {
            const ConsoleKey CommandChangeSurName = ConsoleKey.NumPad1;
            const ConsoleKey CommandChangeFirstName = ConsoleKey.NumPad2;
            const ConsoleKey CommandChangePatronymic = ConsoleKey.NumPad3;
            const ConsoleKey CommandChangeTelephone = ConsoleKey.NumPad4;
            const ConsoleKey CommandChangePassport = ConsoleKey.NumPad5;
            const ConsoleKey CommandExit = ConsoleKey.Q;

            bool isWork = true;

            while (isWork)
            {
                bool isChanged = false;

                Console.WriteLine($"{CommandChangeSurName} - изменить фамилию");
                Console.WriteLine($"{CommandChangeFirstName} - изменить имя");
                Console.WriteLine($"{CommandChangePatronymic} - изменить отчество");
                Console.WriteLine($"{CommandChangeTelephone} - изменить телефон");
                Console.WriteLine($"{CommandChangePassport} - изменить паспорт");
                Console.WriteLine($"{CommandExit} - назад");

                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case CommandChangeSurName:
                            isChanged = TryChangeData(entry.Client, TitleSurName);
                            break;

                        case CommandChangeFirstName:
                            isChanged = TryChangeData(entry.Client, TitleFirstName);
                            break;

                        case CommandChangePatronymic:
                            isChanged = TryChangeData(entry.Client, TitlePatronymic);
                            break;

                        case CommandChangeTelephone:
                            isChanged = TryChangeData(entry.Client, TitleTelephone);
                            break;

                        case CommandChangePassport:
                            isChanged = TryChangeData(entry.Client, TitlePassport);
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
            Log log = entry.LastLog;

            Console.WriteLine($"ФИО: {client.FullName}");
            Console.WriteLine($"телефон: {client.Telephone}");
            Console.WriteLine($"паспорт: {client.Passport}");
            Console.WriteLine($"последние изменения: {log.Data}");
        }
    }
}
