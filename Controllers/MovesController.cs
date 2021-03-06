using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Controllers
{
    public class MovesController : Controller
    {
        private readonly Context _context;

        public MovesController(Context context)
        {
            _context = context;
        }

        // GET: Moves
        public async Task<IActionResult> Index()
        {
              return _context.Moves != null ? 
                          View(await _context.Moves.ToListAsync()) :
                          Problem("Entity set 'Context.Moves'  is null.");
        }

        // GET: Moves/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Moves == null)
            {
                return NotFound();
            }

            var moves = await _context.Moves
                .FirstOrDefaultAsync(m => m.ID == id);
            if (moves == null)
            {
                return NotFound();
            }

            return View(moves);
        }

        // GET: Moves/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Moves/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Type,Power,StartPP,Accuracy,Effect")] Moves moves)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moves);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moves);
        }

        // GET: Moves/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Moves == null)
            {
                return NotFound();
            }

            var moves = await _context.Moves.FindAsync(id);
            if (moves == null)
            {
                return NotFound();
            }
            return View(moves);
        }

        // POST: Moves/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Type,Power,StartPP,Accuracy,Effect")] Moves moves)
        {
            if (id != moves.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moves);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovesExists(moves.ID))
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
            return View(moves);
        }

        // GET: Moves/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Moves == null)
            {
                return NotFound();
            }

            var moves = await _context.Moves
                .FirstOrDefaultAsync(m => m.ID == id);
            if (moves == null)
            {
                return NotFound();
            }

            return View(moves);
        }

        // POST: Moves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Moves == null)
            {
                return Problem("Entity set 'Context.Moves'  is null.");
            }
            var moves = await _context.Moves.FindAsync(id);
            if (moves != null)
            {
                _context.Moves.Remove(moves);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovesExists(int id)
        {
          return (_context.Moves?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
