using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Assignment3.Data;
using Assignment3.Models;
using Assignment3.Util;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Controllers
{
    public class LoginController : Controller
    {
        private readonly Assignment3Context _context;

        public LoginController(Assignment3Context context)
        {
            _context = context;
        }

        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}


        [AllowAnonymous]
        [HttpPost("Register")]
        public IActionResult Register([FromBody]RegisterModel registerModel)
        {
            var user = _context.User.FirstOrDefault(x => x.Email == registerModel.Email);
            if (user != null)
                BadRequest("User already exists");


            CreateUser(registerModel);

            return Ok();
        }



        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody]LoginModel login)
        {
            IActionResult response = Unauthorized();

            var user = Authenticate(login);


            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Role.ToString()),
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    //IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. Required when setting the 
                    // ExpireTimeSpan option of CookieAuthenticationOptions 
                    // set with AddCookie. Also required when setting 
                    // ExpiresUtc.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                response = Ok(new { message = "Success" });
            }

            return response;
        }

        public UserModel Authenticate(LoginModel login)
        {
            var user = _context.User.First(x => x.Email == login.Email);

            UserModel returnValue = null;

            if (user.UserCredentials != null)
            {
                var hash = Hash.Create(login.Password, user.UserCredentials.Salt);

                if (hash == user.UserCredentials.Hash)
                {
                    returnValue = user;
                }
            }

            return returnValue;
        }

        public void CreateUser(RegisterModel registerModel)
        {
            var salt = Salt.Create();
            var hash = Hash.Create(registerModel.Password, salt);

            var credentials = new UserCredentials() { Email = registerModel.Email, Hash = hash, Salt = salt };


            var newUser = new UserModel()
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                AUId = registerModel.AUId,
                PhoneNumber = registerModel.PhoneNumber,
                StaffInitials = registerModel.StaffInitials,
                Email = registerModel.Email,
                Role = Role.Admin,
                UserCredentials = credentials
            };


            _context.User.Add(newUser);
        }
    }
}