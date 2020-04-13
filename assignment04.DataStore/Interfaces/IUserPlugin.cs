using assignment04.Domain.Interfaces;

namespace assignment04.DataStore.Interfaces
{
    public interface IUserPlugin : IPlugin
    {
        IEntity ReadByUserEmail(string email);
    }
}