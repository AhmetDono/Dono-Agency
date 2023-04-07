using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Controllers
{
    [AllowAnonymous]
    public class AgentController : Controller
    {
        Context c = new Context();
        AgentManager agentManager = new AgentManager(new EfAgentDal());
        public IActionResult Index()
        {
            var values = agentManager.TGetList();
            return View(values);
        }

        public IActionResult SingleAgent(int id)
        {
            //var values = c.Properties.Where(x => x.AgentID == id).ToList();
            var values = c.Agents.Include(x => x.Properties).FirstOrDefault(i => i.AgentID == id);
            return View(values);
        }
    }
}
