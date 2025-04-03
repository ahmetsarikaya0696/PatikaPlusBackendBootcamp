using Microsoft.AspNetCore.Mvc;
using Pratik46.Contexts;
using Pratik46.Models;
using Pratik46.Services;

namespace Pratik46.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ITokenService _tokenService;

        public AuthController(AppDbContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User userInput)
        {
            var user = _context.Users.SingleOrDefault(u =>
                u.Email == userInput.Email && u.Password == userInput.Password);

            if (user == null) return Unauthorized("Geçersiz kullanıcı");

            var token = _tokenService.CreateToken(user);
            return Ok(new { token });
        }
    }
}