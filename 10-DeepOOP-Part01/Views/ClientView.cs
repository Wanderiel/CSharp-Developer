namespace _10_DeepOOP_Part01.Views
{
    public class ClientView
    {
        public void Show(string name, string telephone, string passport)
        {
            Console.WriteLine($"ФИО: {name}");
            Console.WriteLine($"телефон: {telephone}");
            Console.WriteLine($"паспорт: {passport}");
        }
    }
}
