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
    public class SocialMediaAddressesController : Controller
    {
        private readonly AppDataContext _context;

        public SocialMediaAddressesController(AppDataContext context)
        {
            _context = context;
        }

        // GET: Admin/SocialMediaAddresses
        public async Task<IActionResult> Index()
        {
            return View(await _context.SocialMediaAddresses.ToListAsync());
        }

        // GET: Admin/SocialMediaAddresses/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialMediaAddresses = await _context.SocialMediaAddresses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialMediaAddresses == null)
            {
                return NotFound();
            }

            return View(socialMediaAddresses);
        }

        // GET: Admin/SocialMediaAddresses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SocialMediaAddresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FbAdress,InstaAdress,LinkedinAdress,Id")] SocialMediaAddresses socialMediaAddresses)
        {
            if (ModelState.IsValid)
            {
                socialMediaAddresses.Id = Guid.NewGuid();
                _context.Add(socialMediaAddresses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socialMediaAddresses);
        }

        // GET: Admin/SocialMediaAddresses/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialMediaAddresses = await _context.SocialMediaAddresses.FindAsync(id);
            if (socialMediaAddresses == null)
            {
                return NotFound();
            }
            return View(socialMediaAddresses);
        }

        // POST: Admin/SocialMediaAddresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FbAdress,InstaAdress,LinkedinAdress,Id")] SocialMediaAddresses socialMediaAddresses)
        {
            if (id != socialMediaAddresses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socialMediaAddresses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocialMediaAddressesExists(socialMediaAddresses.Id))
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
            return View(socialMediaAddresses);
        }

        // GET: Admin/SocialMediaAddresses/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialMediaAddresses = await _context.SocialMediaAddresses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialMediaAddresses == null)
            {
                return NotFound();
            }

            return View(socialMediaAddresses);
        }

        // POST: Admin/SocialMediaAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var socialMediaAddresses = await _context.SocialMediaAddresses.FindAsync(id);
            _context.SocialMediaAddresses.Remove(socialMediaAddresses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocialMediaAddressesExists(Guid id)
        {
            return _context.SocialMediaAddresses.Any(e => e.Id == id);
        }
    }
}
