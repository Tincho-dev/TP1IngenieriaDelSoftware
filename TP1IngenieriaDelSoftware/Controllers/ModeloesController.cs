using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API_TFI.Model;
using TP1IngenieriaDelSoftware.Data;

namespace TP1IngenieriaDelSoftware.Controllers
{
    public class ModeloesController : Controller
    {
        private readonly TP1IngenieriaDelSoftwareContext _context;

        public ModeloesController(TP1IngenieriaDelSoftwareContext context)
        {
            _context = context;
        }

        // GET: Modeloes
        public async Task<IActionResult> Index()
        {
              return _context.Modelo != null ? 
                          View(await _context.Modelo.ToListAsync()) :
                          Problem("Entity set 'TP1IngenieriaDelSoftwareContext.Modelo'  is null.");
        }

        // GET: Modeloes/Details/5
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

        // GET: Modeloes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Modeloes/Create
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

        // GET: Modeloes/Edit/5
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

        // POST: Modeloes/Edit/5
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

        // GET: Modeloes/Delete/5
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

        // POST: Modeloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Modelo == null)
            {
                return Problem("Entity set 'TP1IngenieriaDelSoftwareContext.Modelo'  is null.");
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
