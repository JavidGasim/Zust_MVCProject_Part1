using Microsoft.AspNetCore.Mvc;

namespace Zust.WebUI.Controllers
{
    public class NewsFeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
