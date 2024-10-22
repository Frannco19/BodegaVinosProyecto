using Common.DTOs;
using Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Service;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace BodegaVinos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IConfiguration _config;

        public AuthenticationController(IConfiguration config, UserService userService)
        {
            _config = config;
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserDTO userdto)
        {
            User? userAuthenticate = _userService.AutenticateUser(userdto.Username, userdto.Password);

            if (userAuthenticate is not null)
            {
                var securityPassword = new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"]));

                var signature = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);

                var claimsForToken = new List<Claim>();
                claimsForToken.Add(new Claim("sub", userAuthenticate.Id.ToString()));
                claimsForToken.Add(new Claim("given_name", userAuthenticate.Username));


                var jwtSecurityToken = new JwtSecurityToken(
                _config["Authentication:Issuer"],
                _config["Authentication:Audience"],
                claimsForToken,
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
                signature);

                var tokenToReturn = new JwtSecurityTokenHandler()
                    .WriteToken(jwtSecurityToken);

                return Ok(tokenToReturn);
            }
            return Unauthorized();
        }
    }
}
