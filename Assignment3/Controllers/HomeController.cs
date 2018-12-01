using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment3.Models;
using Microsoft.AspNetCore.Authorization;

namespace Assignment3.Controllers
{
    [Route("[controller]"), Authorize]
    public class HomeController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
