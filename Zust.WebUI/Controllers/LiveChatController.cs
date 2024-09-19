using Microsoft.AspNetCore.Mvc;

namespace Zust.WebUI.Controllers
{
    public class LiveChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
