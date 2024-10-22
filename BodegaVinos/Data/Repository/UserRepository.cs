using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BodegaContext _context;

        public UserRepository(BodegaContext context)
        {
            _context = context;
        }
        // Tercer Endpoint
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        // Bonus
        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }
        // Bonus
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User? Get(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
