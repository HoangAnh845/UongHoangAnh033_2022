#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UongHoangAnh2022033.Data;
using UongHoangAnh2022033.Models;

namespace UongHoangAnh2022033.Controllers
{
    public class UHA1033Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public UHA1033Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UHA1033
        public async Task<IActionResult> Index()
        {
            return View(await _context.UHA1033.ToListAsync());
        }

        // GET: UHA1033/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uHA1033 = await _context.UHA1033
                .FirstOrDefaultAsync(m => m.UHAID == id);
            if (uHA1033 == null)
            {
                return NotFound();
            }

            return View(uHA1033);
        }

        // GET: UHA1033/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UHA1033/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UHAID,UHAName,UHA")] UHA1033 uHA1033)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uHA1033);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uHA1033);
        }

        // GET: UHA1033/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uHA1033 = await _context.UHA1033.FindAsync(id);
            if (uHA1033 == null)
            {
                return NotFound();
            }
            return View(uHA1033);
        }

        // POST: UHA1033/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UHAID,UHAName,UHA")] UHA1033 uHA1033)
        {
            if (id != uHA1033.UHAID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uHA1033);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UHA1033Exists(uHA1033.UHAID))
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
            return View(uHA1033);
        }

        // GET: UHA1033/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uHA1033 = await _context.UHA1033
                .FirstOrDefaultAsync(m => m.UHAID == id);
            if (uHA1033 == null)
            {
                return NotFound();
            }

            return View(uHA1033);
        }

        // POST: UHA1033/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var uHA1033 = await _context.UHA1033.FindAsync(id);
            _context.UHA1033.Remove(uHA1033);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UHA1033Exists(string id)
        {
            return _context.UHA1033.Any(e => e.UHAID == id);
        }
    }
}
