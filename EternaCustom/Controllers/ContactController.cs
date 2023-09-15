using Microsoft.AspNetCore.Mvc;

namespace EternaCustom.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
