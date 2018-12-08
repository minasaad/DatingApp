using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.DTOs;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserToRegisterDTO userToRegisterDTO)
        {
          

            if (await _repo.UserExists(userToRegisterDTO.username))
                return BadRequest("User Already Exists");

            var UserToCreate = new User
            {
                Username = userToRegisterDTO.username
            };
            var createdUser = await _repo.Register(UserToCreate, userToRegisterDTO.password);

            return StatusCode(201);
        }
    }
}