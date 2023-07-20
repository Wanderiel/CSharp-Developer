using _10_DeepOOP_Part01.Databases;
using _10_DeepOOP_Part01.Interfaces;
using System.Text.Json;

namespace _10_DeepOOP_Part01.Controllers
{
    public class Controller
    {
        private Database _database;
        private readonly IRole _role;
        private readonly string _path = @"Data\Database.json";

        public Controller(IRole role)
        {
            _role = role;
            AttachDatabase();
        }

        public void SaveDatabase(List<Entry> entries)
        {
            Stream stream = new FileStream(_path, FileMode.Create, FileAccess.Write);
            JsonSerializer.Serialize(stream, entries);
            stream.Close();
        }

        private void AttachDatabase()
        {
            if (File.Exists(_path) == false)
                _database = new Database();

            Stream fileStream = new FileStream(_path, FileMode.Open, FileAccess.Read);
            List<Entry> database = JsonSerializer.Deserialize<List<Entry>>(fileStream);
            fileStream.Close();

            _database.Attach(database);
        }
    }
}
