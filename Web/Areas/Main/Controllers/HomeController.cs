using Core.Entites.Aboutus;
using Core.Entites.Contactus;
using Core.Entites.Service;
using Core.Entites.Slide;
using Core.Entites.SpecialService;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Main.ViewModels;

namespace Web.Areas.Main.Controllers
{
    [AllowAnonymous]
    [Area("Main")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Slide> _slide;
        private readonly IUnitOfWork<Aboutus> _aboutus;
        private readonly IUnitOfWork<Service> _service;
        private readonly IUnitOfWork<SpecialService> _specialService;


        public HomeController(
            IUnitOfWork<Slide> slide,
            IUnitOfWork<Aboutus> aboutus,
            IUnitOfWork<Service> service,
            IUnitOfWork<SpecialService> specialService)
        {
            _slide = slide;
            _aboutus = aboutus;
            _service = service;
            _specialService = specialService;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Slides = _slide.Entity.GetAll().ToList(),
                Aboutus = _aboutus.Entity.GetAll().FirstOrDefault(),
                Services = _service.Entity.GetAll().ToList(),
                SpecialServices = _specialService.Entity.GetAll().ToList(),
            };
            return View(homeViewModel);
        }
    }
}
