using CSh10_DeepOOP_Part01.Persons.Clients;

namespace CSh10_DeepOOP_Part01.Persons.Staffs
{
    public class Manager : Consultant
    {
        public override string Title => "Менеджер";

        private void AddClient()
        {
            if (TryData(TitleFirstName, out string surName) == false)
                return;

            if (TryData(TitleFirstName, out string firstName) == false)
                return;

            if (TryData(TitlePatronymic, out string patronymic) == false)
                return;

            if (TryData(TitleTelephone, out string telephone) == false)
                return;

            if (TryData(TitlePassport, out string passport) == false)
                return;

            //Client client = new Client(surName, firstName, patronymic, telephone, passport);
            //Log log = new Log(DateTime.Now, "все поля", "создание", Title);

            return;
        }


        protected override void ChangeData(Client client)
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
                            isChanged = TryChangeData(client, TitleSurName);
                            break;

                        case CommandChangeFirstName:
                            isChanged = TryChangeData(client, TitleFirstName);
                            break;

                        case CommandChangePatronymic:
                            isChanged = TryChangeData(client, TitlePatronymic);
                            break;

                        case CommandChangeTelephone:
                            isChanged = TryChangeData(client, TitleTelephone);
                            break;

                        case CommandChangePassport:
                            isChanged = TryChangeData(client, TitlePassport);
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

        protected override void ShowInfo(Client client)
        {
            //Log log = entry.LastLog;

            Console.WriteLine($"ФИО: {client.FullName}");
            Console.WriteLine($"телефон: {client.Telephone}");
            Console.WriteLine($"паспорт: {client.Passport}");
            //Console.WriteLine($"последние изменения: {log.Data}");
        }
    }
}
