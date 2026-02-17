using Microsoft.AspNetCore.Mvc;

namespace LabTask1.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
