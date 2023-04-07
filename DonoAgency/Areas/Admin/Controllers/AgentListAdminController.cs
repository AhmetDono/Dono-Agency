using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Areas.Admin.Controllers
{
    [AllowAnonymous]
    //[Authorize(Roles = "Admin")]
    [Area("Admin")]
    //[Route("Admin/[controller]/[action]")]
    public class AgentListAdminController : Controller
    {
        
        PropertieManager propertieManager = new PropertieManager(new EfPropertieDal());
        AgentManager agentManager = new AgentManager(new EfAgentDal());
        [HttpGet]
        public IActionResult Index()
        {
            //Context c = new Context();
            //var values = c.Properties.Include(x => x.Agent).ToList();
            //return View(values);
            var values = agentManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteAgent(int id)
        {
            var values = agentManager.TGetById(id);
            agentManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
