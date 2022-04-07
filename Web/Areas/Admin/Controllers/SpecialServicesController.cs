using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entites.SpecialService;
using Infrastructure.Data;
using Core.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Web.Areas.Admin.ViewModels.SpecialServices;
using System.IO;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialServicesController : Controller
    {
        private readonly IUnitOfWork<SpecialService> _specialService;
        private readonly IHostingEnvironment _hosting;

        public SpecialServicesController(IUnitOfWork<SpecialService> specialService, IHostingEnvironment hosting)
        {
            _specialService = specialService;
            _hosting = hosting;
        }

        // GET: Services/Services
        public IActionResult Index()
        {
            return View(_specialService.Entity.GetAll());
        }

        // GET: Services/Services/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialService = _specialService.Entity.GetById(id);
            if (specialService == null)
            {
                return NotFound();
            }

            return View(specialService);
        }

        // GET: Services/Services/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SpecialServiceCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                SpecialService newSpecialService = new SpecialService
                {
                    Title = model.Title,
                    AddedDate = model.AddedDate,
                    Content = model.Content,
                    ImageURL = uniqueFileName,
                    ActionName=model.ActionName
                };
                _specialService.Entity.Insert(newSpecialService);
                _specialService.Save();
                return RedirectToAction("index");
            }
            return View();
        }

        // GET: Services/Services/Edit/5
        public IActionResult Edit(Guid? id)
        {
            var speciaService = _specialService.Entity.GetById(id);
            SpecialServiceEditViewModel specialServiceEditViewModel = new SpecialServiceEditViewModel
            {
                Id = speciaService.Id,                
                Title = speciaService.Title,
                AddedDate = speciaService.AddedDate,
                Content = speciaService.Content,
                ExistingPhotoPath = speciaService.ImageURL,
                ActionName=speciaService.ActionName
            };
            return View(specialServiceEditViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SpecialServiceEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                SpecialService specialService = _specialService.Entity.GetById(model.Id);
                specialService.Title = model.Title;
                specialService.AddedDate = model.AddedDate;
                specialService.Content = model.Content;
                specialService.ActionName = model.ActionName;
                if (model.File != null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(_hosting.WebRootPath, @"images\specialServices", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    specialService.ImageURL = ProcessUploadedFile(model);
                }

                _specialService.Entity.Update(specialService);
                _specialService.Save();
                return RedirectToAction("index");
            }
            return View();
        }

        // GET: Services/Services/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = _specialService.Entity.GetById(id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _specialService.Entity.Delete(id);
            _specialService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialServiceExists(Guid id)
        {
            return _specialService.Entity.GetAll().Any(e => e.Id == id);
        }

        private string ProcessUploadedFile(SpecialServiceCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.File != null)
            {
                string uploadsFolder = Path.Combine(_hosting.WebRootPath, @"images\specialServices");
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
