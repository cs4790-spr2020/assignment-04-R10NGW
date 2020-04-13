using System.Collections;

namespace assignment04.DataStore.Interfaces
{
    public interface IBlabPlugin : IPlugin
    {
        IEnumerable ReadByUserId(string Id);
    }
}