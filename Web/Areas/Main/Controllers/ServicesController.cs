using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Main.Controllers
{
    [AllowAnonymous]
    [Area("Main")]

    public class ServicesController : Controller
    {

        public IActionResult Geotechnical()
        {
            return View();
        }
        public IActionResult Material()
        {
            return View();
        }
        public IActionResult Water()
        {
            return View();
        }
        public IActionResult Evaluation()
        {
            return View();
        }
        public IActionResult Masonary()
        {
            return View();
        }
    }
}
