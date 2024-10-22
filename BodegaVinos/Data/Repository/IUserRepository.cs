using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUserById(int id);
        List<User> GetAllUsers();
        User? Get(string username);
    }
}
