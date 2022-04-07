using Core.Entites.Aboutus;
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
    public class AboutusController : Controller
    {
        private readonly IUnitOfWork<Aboutus> _aboutus;
        private readonly IUnitOfWork<Certification> _certification;
        private readonly IUnitOfWork<QualityPolicy> _qualityPolicy;

        public AboutusController(
            IUnitOfWork<Aboutus> aboutus,
            IUnitOfWork<Certification> certification,
            IUnitOfWork<QualityPolicy> qualitypolicy
            )
        {
            _aboutus = aboutus;
            _certification = certification;
            _qualityPolicy = qualitypolicy;
        }
        public IActionResult Index()
        {
            var aboutusPageViewModel = new AboutusPageViewModel
            {
                Aboutus = _aboutus.Entity.GetAll().FirstOrDefault(),
                Certifications = _certification.Entity.GetAll().ToList(),
                QualityPolicies = _qualityPolicy.Entity.GetAll().ToList()
            };

            return View(aboutusPageViewModel);
        }
    }
}
