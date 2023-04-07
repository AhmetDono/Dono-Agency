using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class MemberListAdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MemberListAdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        //listeleme
        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        //silme
        public IActionResult DeleteMember(int id)
        {
            return View();
        }


    }
}
