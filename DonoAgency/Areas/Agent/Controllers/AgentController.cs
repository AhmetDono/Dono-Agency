using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Areas.Agent.Controllers
{
    public class AgentController : Controller
    {
        [Area("Agent")]
        [AllowAnonymous]
        [Route("Agent/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
