using Microsoft.AspNetCore.Mvc;

namespace EternaCustom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
