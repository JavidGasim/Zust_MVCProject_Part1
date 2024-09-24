using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Zust.Business.Services.Abstracts;
using Zust.Entities.Entities;
using Zust.WebUI.Models;

namespace Zust.WebUI.ViewComponents
{
    public class UsersViewComponent : ViewComponent
    {
        private readonly ICustomIdentityUserService _customIdentityUserService;
        private readonly UserManager<CustomIdentityUser> _userManager;

        public UsersViewComponent(ICustomIdentityUserService customIdentityUserService, UserManager<CustomIdentityUser> userManager)
        {
            _customIdentityUserService = customIdentityUserService;
            _userManager = userManager;
        }
        public ViewViewComponentResult Invoke()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var users = _customIdentityUserService.GetAllAsync().Result;
            var datas = users.Where(u => u.Id != user.Id).OrderByDescending(u => u.IsOnline).ToList();
            return View(new UsersViewModel
            {
                Users = datas,
            });
        }
    }
}
