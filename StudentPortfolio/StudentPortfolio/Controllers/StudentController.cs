using Microsoft.AspNetCore.Mvc;

namespace lab3sayem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}