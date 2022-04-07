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
    public class WebSettingsController : Controller
    {
        private readonly AppDataContext _context;

        public WebSettingsController(AppDataContext context)
        {
            _context = context;
        }

        // GET: Admin/WebSettings
        public async Task<IActionResult> Index()
        {
            return View(await _context.WebSettings.ToListAsync());
        }

        // GET: Admin/WebSettings/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webSettings = await _context.WebSettings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (webSettings == null)
            {
                return NotFound();
            }

            return View(webSettings);
        }

        // GET: Admin/WebSettings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/WebSettings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LogoURL,Adress,EmailAdress,FbAdress,InstaAdress,LinkedinAdress,WhatsApp,Phone,FotterLogoURL,FotterText,Id")] WebSettings webSettings)
        {
            if (ModelState.IsValid)
            {
                webSettings.Id = Guid.NewGuid();
                _context.Add(webSettings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(webSettings);
        }

        // GET: Admin/WebSettings/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webSettings = await _context.WebSettings.FindAsync(id);
            if (webSettings == null)
            {
                return NotFound();
            }
            return View(webSettings);
        }

        // POST: Admin/WebSettings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("LogoURL,Adress,EmailAdress,FbAdress,InstaAdress,LinkedinAdress,WhatsApp,Phone,FotterLogoURL,FotterText,Id")] WebSettings webSettings)
        {
            if (id != webSettings.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(webSettings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebSettingsExists(webSettings.Id))
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
            return View(webSettings);
        }

        // GET: Admin/WebSettings/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webSettings = await _context.WebSettings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (webSettings == null)
            {
                return NotFound();
            }

            return View(webSettings);
        }

        // POST: Admin/WebSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var webSettings = await _context.WebSettings.FindAsync(id);
            _context.WebSettings.Remove(webSettings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebSettingsExists(Guid id)
        {
            return _context.WebSettings.Any(e => e.Id == id);
        }
    }
}
