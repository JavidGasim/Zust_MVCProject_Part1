using Microsoft.AspNetCore.Mvc;

namespace Zust.WebUI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
