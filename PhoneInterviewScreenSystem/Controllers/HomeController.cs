using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhoneInterviewScreenSystem.Models;

namespace PhoneInterviewScreenSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Phone Screen App Usage.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact us for any feedback, problems, or enhancements that you may find. ";

            return View();
        }

        public IActionResult PhoneScreen()
        {
            ViewData["Message"] = "Screen a new applicant";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
