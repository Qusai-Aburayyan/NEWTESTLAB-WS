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
using Web.Areas.Admin.ViewModels.Certifications;
using System.IO;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CertificationsController : Controller
    {
        private readonly IUnitOfWork<Certification> _certification;
        private readonly IHostingEnvironment _hosting;

        public CertificationsController(IUnitOfWork<Certification> certification, IHostingEnvironment hosting)
        {
            _certification = certification;
            _hosting = hosting;
        }

        // GET: Certifications
        public IActionResult Index()
        {
            return View(_certification.Entity.GetAll());
        }

        // GET: Certifications/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certification = _certification.Entity.GetById(id);
            if (certification == null)
            {
                return NotFound();
            }

            return View(certification);
        }

        // GET: Certifications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Certifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CertificationCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.File != null)
                {
                    string uniqueFileName = ProcessUploadedFile(model);
                    Certification newCertification = new Certification
                    {
                        AddedDate = model.AddedDate,
                        CertificationName = model.CertificationName,
                        CertificationURL = uniqueFileName
                    };
                    _certification.Entity.Insert(newCertification);
                    _certification.Save();
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

            var certification = _certification.Entity.GetById(id);

            if (certification == null)
            {
                return NotFound();
            }

            CertificationEditViewModel certificationEditViewModel = new CertificationEditViewModel
            {
                Id = certification.Id,
                AddedDate = certification.AddedDate,
                CertificationName = certification.CertificationName,
                ExistingPhotoPath = certification.CertificationURL
            };

            return View(certificationEditViewModel);
        }

        // POST: Certifications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CertificationEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Certification certification = _certification.Entity.GetById(model.Id);
                    certification.AddedDate = model.AddedDate;
                    certification.CertificationName = model.CertificationName;

                    if (model.File != null)
                    {
                        if (model.ExistingPhotoPath != null)
                        {
                            string filePath = Path.Combine(_hosting.WebRootPath, @"images\aboutus", model.ExistingPhotoPath);
                            System.IO.File.Delete(filePath);
                        }
                        certification.CertificationURL = ProcessUploadedFile(model);
                    }

                    _certification.Entity.Update(certification);
                    _certification.Save();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CertificationExists(model.Id))
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

            var certification = _certification.Entity.GetById(id);
            if (certification == null)
            {
                return NotFound();
            }

            return View(certification);
        }

        // POST: Certifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _certification.Entity.Delete(id);
            _certification.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool CertificationExists(Guid id)
        {
            return _certification.Entity.GetAll().Any(e => e.Id == id);
        }

        private string ProcessUploadedFile(CertificationCreateViewModel model)
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
