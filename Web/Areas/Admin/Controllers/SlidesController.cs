using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entites.Slide;
using Infrastructure.Data;
using Web.Areas.Admin.ViewModels.Slieds;
using Core.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidesController : Controller
    {
        private readonly IUnitOfWork<Slide> _slide;
        private readonly IHostingEnvironment _hosting;

        public SlidesController(IUnitOfWork<Slide> slide, IHostingEnvironment hosting)
        {
            _slide = slide;
            _hosting = hosting;
        }

        // GET: Certifications
        public IActionResult Index()
        {
            return View(_slide.Entity.GetAll());
        }

        // GET: Certifications/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slide = _slide.Entity.GetById(id);
            if (slide == null)
            {
                return NotFound();
            }

            return View(slide);
        }

        // GET: Certifications/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SlideViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.File != null)
                {
                    string uniqueFileName = ProcessUploadedFile(model);
                    Slide newSlide = new Slide
                    {
                        AddedDate = model.AddedDate,
                        Text1 = model.Text1,
                        Text2 = model.Text2,
                        SlideURL = uniqueFileName
                    };
                    _slide.Entity.Insert(newSlide);
                    _slide.Save();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }

        // GET: Certifications/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certification = _slide.Entity.GetById(id);

            if (certification == null)
            {
                return NotFound();
            }

            SlideEditViewModel slideEditViewModel = new SlideEditViewModel
            {
                Id = certification.Id,
                AddedDate = certification.AddedDate,
                Text1 = certification.Text1,
                Text2 = certification.Text2,
                ExstingSlideURL = certification.SlideURL
            };

            return View(slideEditViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SlideEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Slide slide = _slide.Entity.GetById(model.Id);
                    slide.AddedDate = model.AddedDate;
                    slide.Text1 = model.Text1;
                    slide.Text2 = model.Text2;

                    if (model.File != null)
                    {
                        if (model.ExstingSlideURL != null)
                        {
                            string filePath = Path.Combine(_hosting.WebRootPath, @"images\home\slide", model.ExstingSlideURL);
                            System.IO.File.Delete(filePath);
                        }
                        slide.SlideURL = ProcessUploadedFile(model);
                    }

                    _slide.Entity.Update(slide);
                    _slide.Save();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlideExists(model.Id))
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

        // GET: Certifications/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slide = _slide.Entity.GetById(id);
            if (slide == null)
            {
                return NotFound();
            }

            return View(slide);
        }

        // POST: Certifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _slide.Entity.Delete(id);
            _slide.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool SlideExists(Guid id)
        {
            return _slide.Entity.GetAll().Any(e => e.Id == id);
        }

        private string ProcessUploadedFile(SlideViewModel model)
        {
            string uniqueFileName = null;
            if (model.File != null)
            {
                string uploadsFolder = Path.Combine(_hosting.WebRootPath, @"images\home\slide");
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

