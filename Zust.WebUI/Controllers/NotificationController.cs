﻿using Microsoft.AspNetCore.Mvc;

namespace Zust.WebUI.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
