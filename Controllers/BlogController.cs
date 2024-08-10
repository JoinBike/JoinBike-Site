using Microsoft.AspNetCore.Mvc;

namespace JoinBike_Site.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
