using Microsoft.AspNetCore.Mvc;

namespace lab3sayem.Controllers
{
    public class Portfolio : Controller
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

        public IActionResult Referenes()
        {
            return View();
        }
    }
}
