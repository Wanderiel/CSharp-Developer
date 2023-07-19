using _10_DeepOOP_Part01.Persons.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DeepOOP_Part01.Databases
{
    public class Database<T> where T : class
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            if (item == null)
                return;

            _items.Add(item);
        }

        public List<T> Get()
        {
            return new List<T>(_items);
        }
    }
}
