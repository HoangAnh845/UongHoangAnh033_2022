#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UongHoangAnh2022033.Models;
using UongHoangAnh2022033.Data;

namespace UongHoangAnh2022033.Controllers
{
    public class PersonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Persons
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonUHA2022033.ToListAsync());
        }

        // GET: Persons/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personUHA2022033 = await _context.PersonUHA2022033
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personUHA2022033 == null)
            {
                return NotFound();
            }

            return View(personUHA2022033);
        }

        // GET: Persons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Persons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,PersonName")] PersonUHA2022033 personUHA2022033)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personUHA2022033);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personUHA2022033);
        }

        // GET: Persons/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personUHA2022033 = await _context.PersonUHA2022033.FindAsync(id);
            if (personUHA2022033 == null)
            {
                return NotFound();
            }
            return View(personUHA2022033);
        }

        // POST: Persons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,PersonName")] PersonUHA2022033 personUHA2022033)
        {
            if (id != personUHA2022033.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personUHA2022033);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonUHA2022033Exists(personUHA2022033.PersonID))
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
            return View(personUHA2022033);
        }

        // GET: Persons/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personUHA2022033 = await _context.PersonUHA2022033
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personUHA2022033 == null)
            {
                return NotFound();
            }

            return View(personUHA2022033);
        }

        // POST: Persons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personUHA2022033 = await _context.PersonUHA2022033.FindAsync(id);
            _context.PersonUHA2022033.Remove(personUHA2022033);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonUHA2022033Exists(string id)
        {
            return _context.PersonUHA2022033.Any(e => e.PersonID == id);
        }
    }
}
