﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency.Areas.Member.Controllers
{
    public class CommentController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
