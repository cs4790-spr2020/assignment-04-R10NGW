﻿using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using assignment04.DataStore.Adapters;
using assignment04.DataStore.Plugins;
using assignment04.Domain.Entities;
using assignment04.Services;

namespace assignment04.ServicesTest
{
    [TestClass]
    public class UserServiceTest
    {
        private UserServiceFactory _userServiceFactory = new UserServiceFactory();

        [TestMethod]
        public void TestCanary()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void GetAllEmptyTest()
        {
            //Arrange
            UserService userService = _userServiceFactory.CreateUserService();
            ArrayList expected = new ArrayList();
            //Act
            IEnumerable actual = userService.GetAll();
            //Assert
            Assert.AreEqual(expected.Count, (actual as ArrayList).Count);
        }

        [TestMethod]
        public void AddNewUserSuccessTest()
        {
            //Arrange
            string email = "user@example.com"; 
            UserService userService = _userServiceFactory.CreateUserService();
            User expected = userService.CreateUser(email);
            userService.AddNewUser(email);
            //Act
            User actual = userService.FindUser(email);
            //Assert
            Assert.AreEqual(expected.Email, actual.Email);
        }
    }
}
