using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.ViewComponents.Default
{
    public class _LatestPropertiePartial : ViewComponent
    {
        PropertieManager propertieManager = new PropertieManager(new EfPropertieDal());
        public IViewComponentResult Invoke()
        {
            var values = propertieManager.TGetLastN(3);
            return View(values);
        }
    }
}
