using Aula1_aspnet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aula1_aspnet.Controllers
{
    public class HomeController : Controller
    {
    

        public IActionResult Index()
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