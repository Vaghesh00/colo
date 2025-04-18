using Microsoft.AspNetCore.Mvc;

namespace ColoWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
