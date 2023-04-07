using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Controllers
{
    [AllowAnonymous]
    public class AgentsPropertiesController : Controller
    {
        public IActionResult Index(int id)
        {
            Context c = new Context();
            var values = c.Properties.Where(x => x.AgentID == id).ToList();
            return View(values);
        }
    }
}
