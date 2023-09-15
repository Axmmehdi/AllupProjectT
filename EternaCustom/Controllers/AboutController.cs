using Microsoft.AspNetCore.Mvc;

namespace EternaCustom.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
