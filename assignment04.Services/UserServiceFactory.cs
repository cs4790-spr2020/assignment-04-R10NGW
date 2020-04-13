using assignment04.DataStore.Adapters;
using assignment04.DataStore.Interfaces;
using assignment04.DataStore.Plugins;

namespace assignment04.Services
{
    public class UserServiceFactory
    {
        public UserAdapter CreateUserAdapter(IUserPlugin plugin = null)
        {
            if (plugin == null)
            {
                plugin = this.CreateUserPlugin();
            }

            return new UserAdapter(plugin);
        }
        public IUserPlugin CreateUserPlugin(string type = "")
        {
            if (type.ToUpper().Equals("MYSQL"))
            {
                return new MySqlUser();
            }

            return new InMemory();
        }

        public UserService CreateUserService(UserAdapter adapter = null)
        {
            if (adapter == null)
            {
                adapter = this.CreateUserAdapter();
            }

            return new UserService(adapter);
        }
    }
}
