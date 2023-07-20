using _10_DeepOOP_Part01.Persons.Clients;

namespace _10_DeepOOP_Part01.Persons.Roles
{
    public class BaseRole
    {
        protected const string TitleSurName = "Фамилия";
        protected const string TitleFirstName = "Имя";
        protected const string TitlePatronymic = "Отчество";
        protected const string TitleTelephone = "Телефон";
        protected const string TitlePassport = "Паспорт";

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
    }
}
