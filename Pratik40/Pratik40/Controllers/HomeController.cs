using Microsoft.AspNetCore.Mvc;

namespace Pratik40.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
