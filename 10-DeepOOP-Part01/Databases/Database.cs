namespace _10_DeepOOP_Part01.Databases
{
    public class Database
    {
        private List<Entry> _entrys = new List<Entry>();

        public void Add(Entry entry)
        {
            if (entry == null)
                return;

            _entrys.Add(entry);
        }

        public List<Entry> Get() => new List<Entry>(_entrys);
    }
}
