using JWTAuthenticationAndAuthorization.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace JWTAuthenticationAndAuthorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly ProjectContext _userContext;
        private readonly IJWTService _jwtService;

        public UserController(ProjectContext userContext, IJWTService jwtService)
        {
            _userContext = userContext;
            _jwtService = jwtService;
        }
        [AllowAnonymous]
        [HttpPost("SignUp")]
        public User SignUp(string username, string password)
        {
            var user = CreateUser(username, password);
            if (!_userContext.Users.Any()) // if no users in databas upon creation, the first user will be Admin
            {
                user.Role = "Admin";
            }
            _userContext.Add(user);
            _userContext.SaveChanges();
            return user;
        }

        [AllowAnonymous]
        [HttpGet("LogIn")]
        public ActionResult LogIn(string username, string password)
        {
            var user = _userContext.Users.FirstOrDefault(x => x.Username == username);

            if (VerifyPassword(password, user.PasswordHash, user.PasswordSalt))
            {
                var role = user.Role;
                return Ok(_jwtService.GetJWT(username, role));
            }

            return Unauthorized();
        }


        [HttpGet("GetUser")]
        [Authorize]
        public ActionResult GetUser(string username)
        {
            var user = _userContext.Users.FirstOrDefault(x => x.Username == username);

            return Ok(user);
        }

        private bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }

        private User CreateUser(string username, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            User user = new User
            {
                Username = username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Role = "User"

            };
            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        }


        [HttpPost("PromoteToAdmin/{username}")]
        [Authorize(Roles = "Admin")]
        public IActionResult PromoteToAdmin(string username)
        {
            var user = _userContext.Users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                return NotFound();
            }

            user.Role = "Admin";
            _userContext.SaveChanges();
            return Ok();
        }

        [HttpPost("DemoteToUser/{username}")]
        [Authorize(Roles = "Admin")]
        public IActionResult DemoteToUser(string username)
        {
            var user = _userContext.Users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                return NotFound();
            }

            user.Role = "User";
            _userContext.SaveChanges();
            return Ok();
        }



        [HttpPost("ChangeTheRole")]
        [Authorize(Roles = "User")]

        public IActionResult ChangeRole(string username, string newrole)
        {
            var user = _userContext.Users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                return NotFound();
            }
            user.Role = newrole;
            _userContext.SaveChanges();
            return Ok();

        }


    }
}
