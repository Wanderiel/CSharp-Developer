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
                            ChangeSurName(entry.Client);
                            break;

                        case CommandChangeFirstName:
                            ChangeFirstName(entry.Client);
                            break;

                        case CommandChangePatronymic:
                            ChangePatronymic(entry.Client);
                            break;

                        case CommandChangeTelephone:
                            ChangeTelephone(entry.Client);
                            break;

                        case CommandChangePassport:
                            ChangePassport(entry.Client);
                            break;

                        case CommandExit:
                            isWork = false;
                            break;
                    }
                }
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

        private void ChangeSurName(Client client)
        {
            if (TryData("фамилию", out string input))
                client.ChangeSurName(input);
        }

        private void ChangeFirstName(Client client)
        {
            if (TryData("имя", out string input))
                client.ChangeFirstName(input);
        }

        private void ChangePatronymic(Client client)
        {
            if (TryData("отчество", out string input))
                client.ChangePatronymic(input);
        }

        private void ChangeTelephone(Client client)
        {
            if (TryData("телефон", out string input))
                client.ChangeTelephone(input);
        }

        private void ChangePassport(Client client)
        {
            if (TryData("серию и номер паспорта", out string input))
                client.ChangePassport(input);
        }
    }
}
