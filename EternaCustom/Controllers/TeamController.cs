using Microsoft.AspNetCore.Mvc;

namespace EternaCustom.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
