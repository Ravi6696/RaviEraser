using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RaviEraser.Data;
using RaviEraser.Models;

namespace RaviEraser.Controllers
{
    public class ErasersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ErasersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Erasers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Eraser.ToListAsync());
        }

        // GET: Erasers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eraser = await _context.Eraser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eraser == null)
            {
                return NotFound();
            }

            return View(eraser);
        }

        // GET: Erasers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Erasers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Color,Type,Price,Rating")] Eraser eraser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eraser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eraser);
        }

        // GET: Erasers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eraser = await _context.Eraser.FindAsync(id);
            if (eraser == null)
            {
                return NotFound();
            }
            return View(eraser);
        }

        // POST: Erasers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] Eraser eraser)
        {
            if (id != eraser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eraser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EraserExists(eraser.Id))
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
            return View(eraser);
        }

        // GET: Erasers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eraser = await _context.Eraser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eraser == null)
            {
                return NotFound();
            }

            return View(eraser);
        }

        // POST: Erasers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eraser = await _context.Eraser.FindAsync(id);
            _context.Eraser.Remove(eraser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EraserExists(int id)
        {
            return _context.Eraser.Any(e => e.Id == id);
        }
    }
}
