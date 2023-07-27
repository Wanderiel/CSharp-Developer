using _10_DeepOOP_Part01.Databases;
using _10_DeepOOP_Part01.Interfaces;
using _10_DeepOOP_Part01.Persons.Clients;
using System.Text.Json;

namespace _10_DeepOOP_Part01.Controllers
{
    public class Controller
    {
        private Database _database;
        private readonly string _path = @"Data\Database.json";

        public Controller()
        {
            AttachDatabase();
        }

        public void SaveDatabase()
        {
            Stream stream = new FileStream(_path, FileMode.Create, FileAccess.Write);
            JsonSerializer.Serialize(stream, _database);
            stream.Close();
        }

        private void AttachDatabase()
        {
            if (File.Exists(_path) == false)
            {
                _database = new Database();

                return;
            }

            Stream fileStream = new FileStream(_path, FileMode.Open, FileAccess.Read);
            List<Client> database = JsonSerializer.Deserialize<List<Client>>(fileStream);
            fileStream.Close();

            if (database == null)
                database = new();

            _database.Attach(database);
        }
    }
}