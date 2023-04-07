﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DonoAgency.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Areas.Agent.Controllers
{
    [Area("Agent")]
    [AllowAnonymous]
    public class PropertieListAgentController : Controller
    {
        PropertieManager propertieManager = new PropertieManager(new EfPropertieDal());
        Context c = new Context();
        private readonly UserManager<AppUser> _userManager;

        public PropertieListAgentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        //[Route("Admin/[Controller]/[action]")]
        public IActionResult Index()
        {
            var values = c.Properties.Include(x => x.Agent).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPropertie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPropertie(Propertie propertie)
        {
            propertieManager.TAdd(propertie);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePropertie(int id)
        {
            var values = propertieManager.TGetById(id);
            propertieManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePropertie(int id)
        {
            var values = propertieManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePropertie(Propertie propertie)
        {
            propertieManager.TUpdate(propertie);
            return RedirectToAction("Index");
        }
    }
}
