using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entites.WebSettings;
using Infrastructure.Data;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PdfFilesController : Controller
    {
        private readonly AppDataContext _context;

        public PdfFilesController(AppDataContext context)
        {
            _context = context;
        }

        // GET: Admin/PdfFiles
        public async Task<IActionResult> Index()
        {
            return View(await _context.PdfFiles.ToListAsync());
        }

        // GET: Admin/PdfFiles/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdfFile = await _context.PdfFiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pdfFile == null)
            {
                return NotFound();
            }

            return View(pdfFile);
        }

        // GET: Admin/PdfFiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PdfFiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FileName,AddedDate,Id")] PdfFile pdfFile)
        {
            if (ModelState.IsValid)
            {
                pdfFile.Id = Guid.NewGuid();
                _context.Add(pdfFile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pdfFile);
        }

        // GET: Admin/PdfFiles/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdfFile = await _context.PdfFiles.FindAsync(id);
            if (pdfFile == null)
            {
                return NotFound();
            }
            return View(pdfFile);
        }

        // POST: Admin/PdfFiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FileName,AddedDate,Id")] PdfFile pdfFile)
        {
            if (id != pdfFile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pdfFile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PdfFileExists(pdfFile.Id))
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
            return View(pdfFile);
        }

        // GET: Admin/PdfFiles/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdfFile = await _context.PdfFiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pdfFile == null)
            {
                return NotFound();
            }

            return View(pdfFile);
        }

        // POST: Admin/PdfFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pdfFile = await _context.PdfFiles.FindAsync(id);
            _context.PdfFiles.Remove(pdfFile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PdfFileExists(Guid id)
        {
            return _context.PdfFiles.Any(e => e.Id == id);
        }
    }
}
