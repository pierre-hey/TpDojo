using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;
using TpDojo.Data;

namespace TpDojo.Controllers
{
    public class ArmesController : Controller
    {
        private readonly TpDojoContext _context;

        public ArmesController(TpDojoContext context)
        {
            _context = context;
        }

        // GET: Armes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Arme.Include(a=>a.Samurai).ToListAsync());
        }

        // GET: Armes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Arme == null)
            {
                return NotFound();
            }

            var arme = await _context.Arme
                .Include(a => a.Samurai)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arme == null)
            {
                return NotFound();
            }

            return View(arme);
        }

        // GET: Armes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Armes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Degat")] Arme arme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arme);
        }

        // GET: Armes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Arme == null)
            {
                return NotFound();
            }

            var arme = await _context.Arme.FindAsync(id);
            if (arme == null)
            {
                return NotFound();
            }
            return View(arme);
        }

        // POST: Armes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Degat")] Arme arme)
        {
            if (id != arme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArmeExists(arme.Id))
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
            return View(arme);
        }

        // GET: Armes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Arme == null)
            {
                return NotFound();
            }

            var arme = await _context.Arme
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arme == null)
            {
                return NotFound();
            }

            return View(arme);
        }

        // POST: Armes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Arme == null)
            {
                return Problem("Entity set 'TpDojoContext.Arme'  is null.");
            }
            var arme = await _context.Arme.FindAsync(id);
            if (arme != null)
            {
                if(!_context.Samurai.Where(s=>s.Arme == arme).Any())
                {
                    _context.Arme.Remove(arme);
                }
                else
                {
                    Console.WriteLine("##################################");
                    Console.WriteLine("Retirer l'arme du samurai avant de la supprimer");
                    Console.WriteLine("##################################");
                    return Problem("Retirer l'arme du samurai avant de la supprimer");
                }
               
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArmeExists(int id)
        {
          return _context.Arme.Any(e => e.Id == id);
        }
    }
}
