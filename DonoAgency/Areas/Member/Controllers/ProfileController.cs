using DonoAgency.Areas.Member.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Areas.Member.Controllers
{
    [Authorize]
    
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Area("Member")]
        [Route("Member/[controller]/[action]")]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name = values.Name + values.Surname;
            ViewBag.userName = values.UserName;
            ViewBag.mail = values.Email;
            ViewBag.phoneNumber = values.PhoneNumber;
            ViewBag.img = values.ImageUrl;
            return View();
        }
    }
}
