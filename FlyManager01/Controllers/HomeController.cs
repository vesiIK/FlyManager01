using FlyManager01.Data;
using FlyManager01.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FlyManager01.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FlyManagerData _context;

        public HomeController(ILogger<HomeController> logger, FlyManagerData context)
        {
            _logger = logger;
            _context = context;
        }

        //

        //public HomeController()
        //{
        //    
        //}

        public IActionResult Index()
        {
            return View(_context.Flights);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult IndexLong()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}