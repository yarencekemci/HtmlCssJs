using Lesson3_1_css_class_id.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson3_1_css_class_id.Controllers
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

        public IActionResult CssDeneme()
        {
            return View();
        }
    }
}
