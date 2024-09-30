using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository
    {
        public List<User> Users { get; set; } = new List<User>();

        public void AddUser(User user)
        {
            Users.Add(user);
        }


    }
}
