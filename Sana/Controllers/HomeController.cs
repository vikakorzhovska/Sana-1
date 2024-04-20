using Microsoft.AspNetCore.Mvc;
using Sana.Models;
using System.Diagnostics;

namespace Sana.Controllers
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

        [HttpPost]
        public ActionResult Page(Users model)
        {
            return RedirectToAction("Page", "Home", new { name = model.Name });
        }

        // GET: Home/Greet
        public ActionResult Page(string name)
        {
            ViewBag.Name = name;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}