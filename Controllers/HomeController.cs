using Microsoft.AspNetCore.Mvc;

namespace JoinBike_Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
