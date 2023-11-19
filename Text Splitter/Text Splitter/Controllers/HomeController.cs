using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Text_Splitter.Models;

namespace Text_Splitter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(TextViewModel textViewModel) 
        {
            return View(textViewModel);
        }
        [HttpPost]
        public IActionResult Split(TextViewModel textViewModel)
        {
            var splitText = textViewModel.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            textViewModel.SplitText = string.Join(" ", splitText);

            return RedirectToAction(Environment.NewLine, splitText);
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