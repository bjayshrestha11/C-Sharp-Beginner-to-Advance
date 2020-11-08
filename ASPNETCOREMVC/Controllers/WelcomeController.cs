using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPNETCOREMVC.Controllers {
    public class WelcomeController : Controller {
        private readonly ILogger<WelcomeController> _logger;
        public WelcomeController (ILogger<WelcomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Hello from Index";
            ViewBag.Greeting = "Hola Welcome";
            return View();
        }
        public IActionResult  Welcome(string name , int Id = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["Id"] = Id;
            ViewBag.Greeting = "Hola Welcome";
            return View();
        }
    }
}