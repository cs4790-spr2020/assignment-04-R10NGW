using System;
using System.Collections;
using assignment04.DataStore.Adapters;
using assignment04.Domain.Entities;

namespace assignment04.Services
{
    public class BlabService : IBlabService
    {
        private readonly BlabAdapter _adapter;
        public void AddBlab(string message, string email)
        {
            _adapter.Add(CreateBlab(message, email));
        }
        public void AddBlab(Blab blab)
        {
            _adapter.Add(blab);
        }
        public BlabService(BlabAdapter adapter)
        {
            _adapter = adapter;
        }

        public IEnumerable GetAll()
        {
            return _adapter.GetAll();
        }
        public IEnumerable FindUserBlabs(string email)
        {
            return null;
        }

        public Blab CreateBlab(string msg, string email)
        {
            User usr = new User(email);
            return new Blab(msg, usr);
        }
    }
}
