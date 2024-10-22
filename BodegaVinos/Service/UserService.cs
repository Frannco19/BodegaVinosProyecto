using Data.Entities;
using Data.Repository;
using Common.DTOs;

namespace Service
{
    public class UserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void RegisterUser(UserDTO userDto)
        {
            var user = new User
            {
                Id = userDto.Id,
                Username = userDto.Username,
                Password = userDto.Password 
            };

            _repository.AddUser(user);
        }

        public User GetUserById(int id)
        {
            return _repository.GetUserById(id);
        }

        public User? AutenticateUser(string username, string password)
        {
            User? userToReturn = _repository.Get(username);
            if (userToReturn is not null && userToReturn.Password == password)
            {
                return userToReturn;
            }
            return null;
        }
    }
}
