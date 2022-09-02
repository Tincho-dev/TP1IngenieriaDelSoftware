using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP1IngenieriaDelSoftware.Data;
using TP1IngenieriaDelSoftware.Model;

namespace TP1IngenieriaDelSoftware.Controllers
{
    public class ModelosController : Controller
    {
        private readonly Context _context;

        public ModelosController(Context context)
        {
            _context = context;
        }

        // GET: Modelos
        public async Task<IActionResult> Index()
        {
              return _context.Modelo != null ? 
                          View(await _context.Modelo.ToListAsync()) :
                          Problem("Entity set 'Context.Modelo'  is null.");
        }

        // GET: Modelos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Modelo == null)
            {
                return NotFound();
            }

            var modelo = await _context.Modelo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modelo == null)
            {
                return NotFound();
            }

            return View(modelo);
        }

        // GET: Modelos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Modelos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SKU,Denominacion,Lim_inferiorO,Lim_supO,Lim_inferiorR,Lim_supR")] Modelo modelo)
        {
            if (ModelState.IsValid)
            {
                modelo.Id = Guid.NewGuid();
                _context.Add(modelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }

        // GET: Modelos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Modelo == null)
            {
                return NotFound();
            }

            var modelo = await _context.Modelo.FindAsync(id);
            if (modelo == null)
            {
                return NotFound();
            }
            return View(modelo);
        }

        // POST: Modelos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,SKU,Denominacion,Lim_inferiorO,Lim_supO,Lim_inferiorR,Lim_supR")] Modelo modelo)
        {
            if (id != modelo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modelo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModeloExists(modelo.Id))
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
            return View(modelo);
        }

        // GET: Modelos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Modelo == null)
            {
                return NotFound();
            }

            var modelo = await _context.Modelo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modelo == null)
            {
                return NotFound();
            }

            return View(modelo);
        }

        // POST: Modelos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Modelo == null)
            {
                return Problem("Entity set 'Context.Modelo'  is null.");
            }
            var modelo = await _context.Modelo.FindAsync(id);
            if (modelo != null)
            {
                _context.Modelo.Remove(modelo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModeloExists(Guid id)
        {
          return (_context.Modelo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
