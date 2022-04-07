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

    public class SpecialServices : Controller
    {
        public IActionResult Robotic()
        {
            return View();
        }
        public IActionResult Steel()
        {
            return View();
        }
        public IActionResult Ultrasonic()
        {
            return View();
        }
        public IActionResult Electrical()
        {
            return View();
        }
        public IActionResult Pile()
        {
            return View();
        }
        public IActionResult Triaxial()
        {
            return View();
        }   
    }
}
