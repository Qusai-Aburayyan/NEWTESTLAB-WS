using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entites.Aboutus;
using Infrastructure.Data;
using Core.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Web.Areas.Admin.ViewModels.Aboutus;
using System.IO;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutusController : Controller
    {
        private readonly IUnitOfWork<Aboutus> _aboutus;
        private readonly IHostingEnvironment _hosting;

        public AboutusController(IUnitOfWork<Aboutus> aboutus, IHostingEnvironment hosting)
        {
            _aboutus = aboutus;
            _hosting = hosting;
        }

        // GET: PortfolioItems
        public IActionResult Index()
        {
            return View(_aboutus.Entity.GetAll());
        }

        // GET: PortfolioItems/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutus = _aboutus.Entity.GetById(id);
            if (aboutus == null)
            {
                return NotFound();
            }

            return View(aboutus);
        }

        // GET: PortfolioItems/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutus = _aboutus.Entity.GetById(id);
            if (aboutus == null)
            {
                return NotFound();
            }

            AboutusViewModel aboutusViewModel = new AboutusViewModel
            {
                Id = aboutus.Id,
                ImageURL = aboutus.ImageURL,
                VisionMissionText = aboutus.VisionMissionText,
                Para1 = aboutus.Para1,
                Para2 = aboutus.Para2,
                QPParagraph = aboutus.QPParagraph
            };

            return View(aboutusViewModel);
        }

        // POST: PortfolioItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AboutusViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Aboutus aboutus = _aboutus.Entity.GetById(model.Id);
                    aboutus.Para1 = model.Para1;
                    aboutus.Para2 = model.Para2;
                    aboutus.QPParagraph = model.QPParagraph;
                    aboutus.VisionMissionText = model.VisionMissionText;

                    if (model.File != null)
                    {
                        if (model.ImageURL != null)
                        {
                            string filePath = Path.Combine(_hosting.WebRootPath, @"images\aboutus", model.ImageURL);
                            System.IO.File.Delete(filePath);
                        }
                        aboutus.ImageURL = ProcessUploadedFile(model);
                    }

                    _aboutus.Entity.Update(aboutus);
                    _aboutus.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutusExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("index");
            }
            return View(model);
        }

        private bool AboutusExists(Guid id)
        {
            return _aboutus.Entity.GetAll().Any(e => e.Id == id);
        }

        private string ProcessUploadedFile(AboutusViewModel model)
        {
            string uniqueFileName = null;
            if (model.File != null)
            {
                string uploadsFolder = Path.Combine(_hosting.WebRootPath, @"images\aboutus");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.File.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.File.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}