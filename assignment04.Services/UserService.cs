﻿using System;
using System.Collections;
using assignment04.DataStore.Adapters;
using assignment04.Domain.Entities;

namespace assignment04.Services
{
    public class UserService : IUserService
    {
        private readonly UserAdapter _adapter;
        public UserService(UserAdapter adapter)
        {
            _adapter = adapter;
        }

        public IEnumerable GetAll()
        {
            return _adapter.GetAll();
        }

        public void AddNewUser(string email)
        {
            try
            {
                _adapter.Add(CreateUser(email));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public User CreateUser(string email)
        {
            return new User(email);
        }

        public User FindUser(string email)
        {
            return _adapter.GetByEmail(email);
        }
    }
}
