using System.Collections;
using assignment04.Domain.Entities;

namespace assignment04.Services
{
    public interface IBlabService
    {
       void AddBlab(string message, string email);
       void AddBlab(Blab blab);
       IEnumerable FindUserBlabs(string email);
       IEnumerable GetAll(); 
    }
}