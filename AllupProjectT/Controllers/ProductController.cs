using Microsoft.AspNetCore.Mvc;

namespace AllupProjectT.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
