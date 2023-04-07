using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
    public class PropertieController : Controller
    {
        PropertieManager propertieManager = new PropertieManager(new EfPropertieDal());
        AgentManager agentManager = new AgentManager(new EfAgentDal());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Properties.Include(x => x.Agent).ToList();
            return View(values);
        }

        public IActionResult PropertieSingle(int id)
        {
            ViewBag.i = id;
            var values = c.Properties.Include(x => x.Agent).FirstOrDefault(i => i.PropertieID == id);
            return View(values);
        }

        //public IActionResult ContactWithAgent(int id)
        //{
        //    ViewModel model = new ViewModel();
        //    ViewBag.i = id;
        //    var values = propertieManager.TGetById(id);
        //    //var foragent = propertieManager.TGetList().FirstOrDefault(x => x.PropertieID == id);
        //    model.PropertieList = propertieManager.TGetList();
        //    model.AgentList = agentManager.TGetList();
        //    //var values = agentManager.TGetById(agentID);
        //    return View(model);
        //}
    }
}
