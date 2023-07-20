using _10_DeepOOP_Part01.Databases;

namespace _10_DeepOOP_Part01.Interfaces
{
    public interface IRole
    {
        public string Title { get; }

        void ChangeData(Entry entry);

        void ShowInfo(Entry entry);
    }
}
