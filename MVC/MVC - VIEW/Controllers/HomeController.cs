using Ficha10.Controllers;
using Ficha10.Models;
using Microsoft.AspNetCore.Mvc;
using MVC___VIEW.Models;
using System.Diagnostics;

namespace MVC___VIEW.Controllers
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
            CharactersController chars = new CharactersController();
            return View(new Characters(chars.Get().ToList()));
        }

        public IActionResult Privacy()
        {
            IEmployees emps = new Employees();
            return View(emps);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}