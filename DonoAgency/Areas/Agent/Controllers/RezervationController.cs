using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Areas.Agent.Controllers
{
    [Area("Agent")]
    [AllowAnonymous]
    public class RezervationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
