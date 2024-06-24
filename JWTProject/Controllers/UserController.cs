using JWTProject.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace JWTProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserContext _usercontext;
        private readonly IJWTService _jwtService;

        public UserController(UserContext userContext, IJWTService jwtService)
        {
            _usercontext = userContext;
            _jwtService = jwtService;
        }

        [AllowAnonymous]
        [HttpPost("SignUp")]
        public User SignUp(string username, string password)
        {
            var user = CreateUser(username, password);
            _usercontext.Add(user);
            _usercontext.SaveChanges();
            return user;
        }

        [AllowAnonymous]
        [HttpGet("LogIn")]
        public ActionResult GetUser(string username, string password)
        {
            var user = _usercontext.Users.FirstOrDefault(x => x.Username == username);
            if (VerifyPassword(password, user.PasswordHash, user.PasswordSalt))
            {
                return Ok(_jwtService.GetJWT(username));
            }
            return Unauthorized();
        }


        [HttpGet("GetUser")]
        [Authorize]
        public ActionResult GetUser(string username)
        {
            var user = _usercontext.Users.FirstOrDefault(x => x.Username == username);
            return Ok(user);
        }

        private bool VerifyPassword(string password, byte[] PasswordHash, byte[] PasswordSalt)
        {
            using var hmac = new HMACSHA3_512(PasswordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            // 231564968541652156 == 231564968541652156
            // computedHash == passwordHash

            return computedHash.SequenceEqual(PasswordHash);
        }

        private User CreateUser(string username, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            User user = new User
            {
                Username = username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA3_512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

    }
}
