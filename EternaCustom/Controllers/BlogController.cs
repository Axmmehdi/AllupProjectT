using Microsoft.AspNetCore.Mvc;

namespace EternaCustom.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Single(int? id) 
        {
            return View();
        }
    }
}
