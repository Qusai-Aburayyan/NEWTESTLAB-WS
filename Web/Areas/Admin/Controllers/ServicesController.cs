using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entites.Service;
using Infrastructure.Data;
using Core.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Web.Areas.Admin.ViewModels.Services;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly IUnitOfWork<Service> _service;
        private readonly IHostingEnvironment _hosting;

        public ServicesController(IUnitOfWork<Service> service, IHostingEnvironment hosting)
        {
            _service = service;
            _hosting = hosting;
        }

        // GET: Services/Services
        public IActionResult Index()
        {
            return View(_service.Entity.GetAll());
        }

        // GET: Services/Services/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = _service.Entity.GetById(id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Services/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServiceCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                Service newService = new Service
                {
                    Title = model.Title,
                    AddedDate = model.AddedDate,
                    Content = model.Content,
                    ImageURL = uniqueFileName,
                    ActionName = model.ActionName
                };
                _service.Entity.Insert(newService);
                _service.Save();
                return RedirectToAction("index");
            }
            return View();
        }

        // GET: Services/Services/Edit/5
        public IActionResult Edit(Guid? id)
        {
            var service = _service.Entity.GetById(id);
            ServiceEditViewModel serviceEditViewModel = new ServiceEditViewModel
            {
                Id = service.Id,
                Title = service.Title,
                AddedDate = service.AddedDate,
                Content = service.Content,
                ExistingPhotoPath = service.ImageURL,
                ActionName = service.ActionName
            };
            return View(serviceEditViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, ServiceEditViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //Service service = _service.Entity.GetById(model.Id);

                Service service = new Service
                {
                    Id = model.Id,
                    Title = model.Title,
                    ActionName = model.ActionName,
                    AddedDate = model.AddedDate,
                    Content = model.Content,
                    ImageURL = model.ExistingPhotoPath
                };

                //service.Title = model.Title;
                //service.AddedDate = model.AddedDate;
                //service.Content = model.Content;
                //service.ActionName = model.ActionName;
                //service.ImageURL = model.File.FileName;

                if (model.File != null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(_hosting.WebRootPath, @"images\service", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    service.ImageURL = ProcessUploadedFile(model);
                }

                _service.Entity.Update(service);
                _service.Save();
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

            var service = _service.Entity.GetById(id);
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
            _service.Entity.Delete(id);
            _service.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(Guid id)
        {
            return _service.Entity.GetAll().Any(e => e.Id == id);
        }

        private string ProcessUploadedFile(ServiceCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.File != null)
            {
                string uploadsFolder = Path.Combine(_hosting.WebRootPath, @"images\service");
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
