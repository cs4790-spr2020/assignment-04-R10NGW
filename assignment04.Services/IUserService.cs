using System.Collections;
using assignment04.Domain.Entities;

namespace assignment04.Services
{
    public interface IUserService
    {
       IEnumerable GetAll(); 
       void AddNewUser(string email);
       User CreateUser(string email);
       User FindUser(string email);
    }
}