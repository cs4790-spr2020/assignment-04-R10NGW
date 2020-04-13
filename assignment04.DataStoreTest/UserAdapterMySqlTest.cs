using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using assignment04.DataStore.Adapters;
using assignment04.DataStore.Plugins;
using assignment04.Domain.Entities;

namespace assignment04.DataStoreTest
{
    [TestClass]
    public class UserAdapter_MySql_UnitTests
    {
        private User _user;
        private UserAdapter _harness = new UserAdapter(new MySqlUser());
        private readonly string _email = "foobar@example.com";

        [TestInitialize]
        public void Setup()
        {
            _user = new User(_email);
        }
        [TestCleanup]
        public void TearDown()
        {
            User user = new User(_email);
            _harness.Remove(user);
        }

        [TestMethod]
        public void Canary()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestAddAndGetUser()
        {
            //Arrange
            _user.RegisterDTTM =DateTime.Now;
            _user.LastLoginDTTM = DateTime.Now;
            //Act
            _harness.Add(_user);
            User actual = _harness.GetById(_user.Id);
            //Assert
            Assert.AreEqual(_user.Id, actual.Id);
        }
        [TestMethod]
        public void TestAddAndGetAll()
        {
            //Arrange
            _user.RegisterDTTM =DateTime.Now;
            _user.LastLoginDTTM = DateTime.Now;
            _harness.Add(_user);
            //Act
            ArrayList users = (ArrayList)_harness.GetAll();
            User actual = (User)users[0];
            //Assert
            Assert.AreEqual(_user.Id.ToString(), actual.Id.ToString());
        }
    }
}
