using _10_DeepOOP_Part01.Persons.Clients;

namespace _10_DeepOOP_Part01.Databases
{
    public class Entry
    {
        private Client _client;
        private List<Log> _logs;

        public Entry(Client client)
        {
            _client = client;
            _logs = new List<Log>();
        }

        public Client Client => _client;
        public Log LastLog => _logs.LastOrDefault();
        public List<Log> AllLogs => new List<Log>(_logs);

        public void Add(Log log) => _logs.Add(log);
    }
}
