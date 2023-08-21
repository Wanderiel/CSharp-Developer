using CSh10_DeepOOP_Part01.Interfaces;
using CSh10_DeepOOP_Part01.Persons.Clients;

namespace CSh10_DeepOOP_Part01.Persons.Staffs
{
    public class Consultant : IRole
    {
        protected const string TitleSurName = "Фамилия";
        protected const string TitleFirstName = "Имя";
        protected const string TitlePatronymic = "Отчество";
        protected const string TitleTelephone = "Телефон";
        protected const string TitlePassport = "Паспорт";

        public virtual string Title => "Консультант";

        public void Work()
        {
            throw new NotImplementedException();
        }

        protected bool TryData(string title, out string input)
        {
            Console.Write($"Введите данные клиента ({title}): ");
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                return false;

            return true;
        }

        protected bool TryChangeData(Client client, string titleOfChanges)
        {
            if (TryData(titleOfChanges, out string input) == false)
                return false;

            switch (titleOfChanges)
            {
                case TitleSurName:
                    client.ChangeSurName(input);
                    break;

                case TitleFirstName:
                    client.ChangeFirstName(input);
                    break;

                case TitlePatronymic:
                    client.ChangePatronymic(input);
                    break;

                case TitleTelephone:
                    client.ChangeTelephone(input);
                    break;

                case TitlePassport:
                    client.ChangePassport(input);
                    break;
            }

            return true;
        }

        protected virtual void ChangeData(Client client)
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
                            isChanged = TryChangeData(client, TitleTelephone);
                            break;

                        case CommandExit:
                            isWork = false;
                            break;
                    }
                }

                //if (isChanged)
                //    entry.LogIn(new Log(DateTime.Now, TitleSurName, "изменение", Title));
            }
        }

        protected virtual void ShowInfo(Client client)
        {
            string passport = new string('*', client.Passport.Length);
            //Log log = entry.LastLog;

            Console.WriteLine($"ФИО: {client.FullName}");
            Console.WriteLine($"телефон: {client.Telephone}");
            Console.WriteLine($"паспорт: {passport}");
            //Console.WriteLine($"последние изменения: {log.Data}");
        }
    }
}
