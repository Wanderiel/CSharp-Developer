using _10_DeepOOP_Part01.Persons.Clients;

namespace _10_DeepOOP_Part01.Databases
{
    public class Database
    {
        private List<Client> _clients = new();

        public void Add(Client client)
        {
            if (client == null)
                return;

            _clients.Add(client);
        }

        public void Attach(List<Client> database)
        {
            if (database == null)
                return;

            _clients = new(database);
        }

        public Client Get(int id)
        {
            if (id < 0)
                return null;

            if (id > _clients.Last().Id)
                return null;

            foreach (Client client in _clients)
            {
                if (id == client.Id)
                    return client;
            }

            return null;
        }

        public List<Client> GetAll() => new(_clients);
    }
}