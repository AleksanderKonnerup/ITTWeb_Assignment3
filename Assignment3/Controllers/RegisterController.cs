using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Assignment3.Models;
using Assignment3.Util;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    [Route("[controller]")]
    public class RegisterController : Controller
    {
        private readonly Assignment3Context _context;

        public RegisterController(Assignment3Context context)
        {
            _context = context;
        }
        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser(RegisterModel registerModel)
        {
            IActionResult result = BadRequest();

            if (ModelState.IsValid)
            {
                CreateUser(registerModel);
                result = RedirectToAction("Login", "Login");
            }

            return result;
        }

        private void CreateUser(RegisterModel registerModel)
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
            _context.SaveChanges();
        }
    }
}