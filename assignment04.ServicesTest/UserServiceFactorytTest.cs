using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using assignment04.DataStore.Adapters;
using assignment04.DataStore.Plugins;
using assignment04.Domain.Entities;
using assignment04.Services;

namespace assignment04.ServicesTest
{
    [TestClass]
    public class UserServiceFactoryTest
    {
        UserServiceFactory harness = new UserServiceFactory();

        [TestMethod]
        public void CanaryTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void BuildAdapterPluginTest()
        {
            //Arrange and Act
            UserAdapter userAdapter = harness.CreateUserAdapter();
            //Assert
            Assert.IsTrue(userAdapter is UserAdapter);
        }
        [TestMethod]
        public void BuildServiceAdapterPluginTest()
        {
            //Arrange and Act
            UserService userService = harness.CreateUserService();
            //Assert
            Assert.IsTrue(userService is UserService);
        }
    }
}
