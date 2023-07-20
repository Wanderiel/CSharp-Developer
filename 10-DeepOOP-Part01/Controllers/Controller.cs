using _10_DeepOOP_Part01.Databases;
using _10_DeepOOP_Part01.Interfaces;
using _10_DeepOOP_Part01.Persons.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DeepOOP_Part01.Controllers
{
    public class Controller
    {
        private Database _databases;

        private bool TryGetNames(string input, out string[] names)
        {
            names = input.Trim().Split(' ');

            if (names.Length != 3)
                return false;

            return true;
        }


        public void CreateClient()
        {
            Console.Write("Введите ФИО клиента: ");
            string userInput = Console.ReadLine();

            if (TryGetNames(userInput, out string[] names) == false)
            {
                Console.WriteLine("Некорректный ввод");
                Console.ReadKey();
            }

            Console.WriteLine("Введите номер телефона: ");
            string telephone = Console.ReadLine();

            Console.WriteLine("Введите серию и номер паспорта");
            string passport = Console.ReadLine();

            Client client = new Client(names[0], names[1], names[3], telephone, passport);

            _databases.Add(client);
            Console.WriteLine("Новый клиент успешно создан");
        }

    }
}
