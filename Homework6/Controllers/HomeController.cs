using Homework6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JsonTest()
        {
            return View();
        }

        //public IActionResult First()
        //{
        //    return View();
        //}

        public IActionResult Register()
        {
            return View();
        }

        /////1/31 p64
        public IActionResult Address()
        {
            return View();
        }

        /////1/31 p65
        public IActionResult Avatar()
        {
            return View();
        }


        public IActionResult Spots()
        {
            return View();
        }


        public IActionResult AutoComplete()
        {
            return View();
        }


        public IActionResult Spot()
        {
            return View();
        }


        public IActionResult Privacy()
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
