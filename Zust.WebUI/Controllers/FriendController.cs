using Microsoft.AspNetCore.Mvc;

namespace Zust.WebUI.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
