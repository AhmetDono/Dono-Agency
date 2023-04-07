using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.ViewComponents.Default
{
    public class _IntroSectionPartial : ViewComponent
    {
        PropertieManager propertieManager = new PropertieManager(new EfPropertieDal());
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
