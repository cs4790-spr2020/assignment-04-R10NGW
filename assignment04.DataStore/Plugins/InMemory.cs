using System;
using System.Collections;
using assignment04.DataStore.Interfaces;
using assignment04.Domain.Entities;
using assignment04.Domain.Interfaces;

namespace assignment04.DataStore.Plugins
{
    public class InMemory : IBlabPlugin, IUserPlugin
    {
        private ArrayList buffer;
        public InMemory()
        {
            this.buffer = new ArrayList();
        }

        public void Create(IEntity obj)
        {
            this.buffer.Add(obj);
        }

        public IEnumerable ReadAll()
        {
            return this.buffer;
        }

        public IEntity ReadById(Guid Id)
        {
            foreach(IEntity obj in this.buffer)
            {
                if (Id.Equals(obj.Id)) return obj;
            }
            return null;
        }
        public IEnumerable ReadByUserId(string Id)
        {
            return null;
        }
        public IEntity ReadByUserEmail(string email)
        {
            foreach(User user in buffer)
            {
                if (user.Email.Equals(email))
                {
                    return user;
                }
            }
            return null;
        }

        public void Update(IEntity obj)
        {
            this.Delete(obj);
            this.Create(obj);
        }

        public void Delete(IEntity obj)
        {
            this.buffer.Remove(obj);
        }
    }
}
