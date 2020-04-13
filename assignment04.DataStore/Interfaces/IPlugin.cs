using System;
using System.Collections;
using assignment04.Domain.Interfaces;

namespace assignment04.DataStore.Interfaces
{
    public interface IPlugin
    {
        void Create(IEntity obj);
        IEnumerable ReadAll();
        IEntity ReadById(Guid Id);
        void Update(IEntity obj);
        void Delete(IEntity obj);
    }
}