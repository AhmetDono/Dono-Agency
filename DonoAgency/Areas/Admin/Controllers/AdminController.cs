using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        [AllowAnonymous]
        //[Authorize(Roles = "Admin")]
        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
