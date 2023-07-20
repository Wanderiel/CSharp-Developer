namespace _10_DeepOOP_Part01.Persons.Roles
{
    public class BaseRole
    {
        protected bool TryData(string title, out string input)
        {
            Console.Write($"Введите {title} клиента: ");
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                return false;

            return true;
        }
    }
}
