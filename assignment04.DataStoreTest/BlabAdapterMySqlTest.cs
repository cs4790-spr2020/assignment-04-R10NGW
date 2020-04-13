using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using assignment04.DataStore.Adapters;
using assignment04.DataStore.Plugins;
using assignment04.Domain.Entities;

namespace assignment04.DataStoreTest
{
    [TestClass]
    public class BlabAdapter_MySql_UnitTests
    {
        private BlabAdapter _harness = new BlabAdapter(new MySqlBlab());

        [TestMethod]
        public void Canary()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestAddAndGetBlab()
        {
            //Arrange
            string email = "fooabar@example.com";
            User mockUser = new User(email);
            Blab blab = new Blab("Now is the time for, blabs...", mockUser);
            //Act
            _harness.Add(blab);
            ArrayList actual = (ArrayList)_harness.GetByUserId(email);
            //Assert
            Assert.AreEqual(1, actual.Count);
        }
    }
}
