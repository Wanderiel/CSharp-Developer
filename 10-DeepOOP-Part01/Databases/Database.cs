namespace _10_DeepOOP_Part01.Databases
{
    public class Database
    {
        private List<Entry> _entries = new List<Entry>();

        public void Add(Entry entry)
        {
            if (entry == null)
                return;

            _entries.Add(entry);
        }

        public List<Entry> Get() => new List<Entry>(_entries);

        public void Attach(List<Entry>? database)
        {
            if (database == null)
                return;

            _entries = new List<Entry>(database);
        }
    }
}
