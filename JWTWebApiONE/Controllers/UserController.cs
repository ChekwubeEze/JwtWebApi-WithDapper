using JWTWebApiONE.DTO;
using JWTWebApiONE.Interfaces;
using JWTWebApiONE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTWebApiONE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost("RegisterUser")]
        public string RegisterAUser([FromQuery]UserRegisterDTO userRegisterDTO)
        {
            string message = _userRepository.RegisterAUser(userRegisterDTO);
            return message;
        }
        [HttpPost("Login")]
        public string LoginUser([FromQuery] UserLoginDTO userLoginDTO)
        {
            return _userRepository.LoginUser(userLoginDTO);
        }
        [HttpGet("Get-All-Users")]
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}
