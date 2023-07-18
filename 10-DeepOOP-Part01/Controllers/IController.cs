using _10_DeepOOP_Part01.Persons.Clients;

namespace _10_DeepOOP_Part01.Controllers
{
    public interface IController
    {
        void AddClient();

        void ShowInfo(Client client);
    }
}
