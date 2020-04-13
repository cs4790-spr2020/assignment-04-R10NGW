using Microsoft.VisualStudio.TestTools.UnitTesting;
using assignment04.DataStore.Adapters;
using assignment04.DataStore.Plugins;

namespace assignment04.DataStoreTest
{
    [TestClass]
    public class UserAdapter_InMemory_UnitTests 
    {
        private UserAdapter _harness = new UserAdapter(new InMemory());

        [TestMethod]
        public void Canary()
        {
            Assert.AreEqual(true, true);
        }
    }
}
