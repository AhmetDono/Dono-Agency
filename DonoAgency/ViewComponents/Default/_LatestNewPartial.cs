using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.ViewComponents.Default
{
    public class _LatestNewPartial : ViewComponent
    {
        NewManager newManager = new NewManager(new EfNewDal());
        public IViewComponentResult Invoke()
        {
            var values = newManager.TGetLastN(3);
            return View(values);
        }
    }
}
