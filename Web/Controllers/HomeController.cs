using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var countdown = CountdownService.Get();
            return View(countdown);
        }
    }
}
