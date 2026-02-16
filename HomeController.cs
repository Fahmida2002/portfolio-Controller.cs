using Microsoft.AspNetCore.Mvc;
using portfolio_Controller.cs.Models;
using System.Diagnostics;

namespace portfolio_Controller.cs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Education() 
        {
            return View();
        }

        public IActionResult Project()
        {
            return View();
        }

        public IActionResult References()
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
