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
    public class BlabServiceFactoryTest
    {
        BlabServiceFactory harness = new BlabServiceFactory();

        [TestMethod]
        public void CanaryTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void BuildAdapterPluginTest()
        {
            //Arrange and Act
            BlabAdapter blabAdapter = harness.CreateBlabAdapter();
            //Assert
            Assert.IsTrue(blabAdapter is BlabAdapter);
        }
        [TestMethod]
        public void BuildServiceAdapterPluginTest()
        {
            //Arrange and Act
            BlabService blabService = harness.CreateBlabService();
            //Assert
            Assert.IsTrue(blabService is BlabService);
        }
    }
}
