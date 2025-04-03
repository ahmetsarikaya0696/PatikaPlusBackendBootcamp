using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pratik45.Contexts;
using Pratik45.Models;
using System.Security.Cryptography;
using System.Text;

namespace Pratik45.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UsersController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _appDbContext.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }


        [HttpPost]
        public IActionResult Register([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User cannot be null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            user.Password = EncryptPassword(user.Password);
            _appDbContext.Users.Add(new User() { Email = user.Email, Password = user.Password });
            _appDbContext.SaveChanges();
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        private string EncryptPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
