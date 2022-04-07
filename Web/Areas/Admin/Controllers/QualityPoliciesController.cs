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

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QualityPoliciesController : Controller
    {
        private readonly IUnitOfWork<QualityPolicy> _qualityPolicy;
        private readonly IHostingEnvironment _hosting;

        public QualityPoliciesController(IUnitOfWork<QualityPolicy> qualityPolicy, IHostingEnvironment hosting)
        {
            _qualityPolicy = qualityPolicy;
            _hosting = hosting;
        }

        // GET: Services
        public IActionResult Index()
        {
            return View(_qualityPolicy.Entity.GetAll());
        }

        // GET: Services/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qualityPolicy = _qualityPolicy.Entity.GetById(id);
            if (qualityPolicy == null)
            {
                return NotFound();
            }

            return View(qualityPolicy);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(QualityPolicy model)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    QualityPolicy qualityPolicy = new QualityPolicy
                    {
                        AddedDate = model.AddedDate,
                        Point = model.Point
                    };

                    qualityPolicy.Id = Guid.NewGuid();

                    _qualityPolicy.Entity.Insert(qualityPolicy);
                    _qualityPolicy.Save();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }

        // GET: Services/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qualityPolicy = _qualityPolicy.Entity.GetById(id);
            if (qualityPolicy == null)
            {
                return NotFound();
            }

            return View(qualityPolicy);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, QualityPolicy model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    QualityPolicy qualityPolicy = new QualityPolicy
                    {
                        Id = model.Id,
                        AddedDate = model.AddedDate,
                        Point = model.Point
                    };

                    _qualityPolicy.Entity.Update(qualityPolicy);
                    _qualityPolicy.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Services/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qualityPolicy = _qualityPolicy.Entity.GetById(id);
            if (qualityPolicy == null)
            {
                return NotFound();
            }

            return View(qualityPolicy);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _qualityPolicy.Entity.Delete(id);
            _qualityPolicy.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(Guid id)
        {
            return _qualityPolicy.Entity.GetAll().Any(e => e.Id == id);
        }
    }
}
