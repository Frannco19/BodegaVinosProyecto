// Controller/UserController.cs
using Microsoft.AspNetCore.Mvc;
using Service;
using Common.DTOs;
namespace BodegaDeVinosProyect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDTO user)
        {
            if (user == null || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                return BadRequest("Proporcionar un nombre de usuario y una contraseña.");
            }

            _userService.RegisterUser(user);
            return Ok("Usuario registrado correctamente.");
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null) return NotFound("Usuario no encontrado.");

            return Ok(user);
        }
    }
}

