using Data.Entities;
using Data.Repository;
using Common.DTOs;

namespace Service
{
    public class UserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
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
            return _repository.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
