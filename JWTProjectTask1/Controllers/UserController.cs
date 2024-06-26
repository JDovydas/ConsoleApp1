﻿using JWTProjectTask1.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace JWTProjectTask1.Controllers
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
                return Ok(_jwtService.GetJWT(username));
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
                PasswordSalt = passwordSalt
            };
            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        }
    }
}
