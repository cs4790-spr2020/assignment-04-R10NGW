using assignment04.DataStore.Adapters;
using assignment04.DataStore.Interfaces;
using assignment04.DataStore.Plugins;

namespace assignment04.Services
{
    public class BlabServiceFactory
    {
        public BlabAdapter CreateBlabAdapter(IBlabPlugin plugin = null)
        {
            if (plugin == null)
            {
                plugin = this.CreateBlabPlugin();
            }

            return new BlabAdapter(plugin);
        }
        public IBlabPlugin CreateBlabPlugin(string type = "")
        {
            if (type.ToUpper().Equals("MYSQL"))
            {
                return new MySqlBlab();
            }

            return new InMemory();
        }

        public BlabService CreateBlabService(BlabAdapter adapter = null)
        {
            if (adapter == null)
            {
                adapter = this.CreateBlabAdapter();
            }

            return new BlabService(adapter);
        }
    }
}
