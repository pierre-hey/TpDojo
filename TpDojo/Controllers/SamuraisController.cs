using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;
using TpDojo.Data;
using TPDojo.Models;

namespace TpDojo.Controllers
{
    public class SamuraisController : Controller
    {
        private readonly TpDojoContext _context;

        public SamuraisController(TpDojoContext context)
        {
            _context = context;
        }

        // GET: Samurais
        public async Task<IActionResult> Index()
        {
            var tpDojoContext = _context.Samurai.Include(s => s.Arme);
            return View(await tpDojoContext.ToListAsync());
        }

        // GET: Samurais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Samurai == null)
            {
                return NotFound();
            }

            var samurai = await _context.Samurai
                .Include(s => s.Arme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (samurai == null)
            {
                return NotFound();
            }

            return View(samurai);
        }

/*        // GET: Samurais/Create
        public IActionResult Create()
        {
            ViewData["ArmeId"] = new SelectList(_context.Arme, "Id", "Id");
            return View();
        }

        // POST: Samurais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Force,ArmeId")] Samurai samurai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(samurai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArmeId"] = new SelectList(_context.Arme, "Id", "Id", samurai.ArmeId);
            return View(samurai);
        }*/


        // GET: Samurais/Create
        public IActionResult Create()
        {
            SamuraiVM samuraiVM = new SamuraiVM();

            SelectList selectArme = new SelectList(_context.Arme, "Id", "Nom");
            samuraiVM.ArmesSelect = selectArme;


           // ViewData["ArmeId"] = new SelectList(selectArme, "Id", "Nom");
            return View(samuraiVM);
        }

        // POST: Samurais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Force,ArmeId")] SamuraiVM samuraiVM)
        {

            Samurai samurai = new Samurai();
            samurai.Nom = samuraiVM.Nom;
            samurai.Arme = _context.Arme.Find(samuraiVM.ArmeId);
            samurai.Force= samuraiVM.Force;

            Console.WriteLine($"#################");
            Console.WriteLine($"POST Samurai => Id: {samurai.Id} - Nom: {samurai.Nom} - ArmeId: {samurai.ArmeId} - Arme: {samurai.Arme.Nom}");
            Console.WriteLine($"#################");
            

       //     if (ModelState.IsValid)
        //    {
                _context.Add(samurai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
         //   }
        //    ViewData["ArmeId"] = new SelectList(_context.Arme, "Id", "Nom", samuraiVM.ArmeId);
            SelectList selectArme = new SelectList(_context.Arme, "Id", "Nom");
            samuraiVM.ArmesSelect = selectArme;
            return View(samuraiVM);
        }


        // GET: Samurais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Samurai == null)
            {
                return NotFound();
            }

            var samurai = await _context.Samurai.FindAsync(id);
            if (samurai == null)
            {
                return NotFound();
            }


            SamuraiVM samuraiVM = new SamuraiVM
            {
                Nom = samurai.Nom,
                Force = samurai.Force,
                Id = samurai.Id,
                ArmeId = samurai.ArmeId,
                ArmesSelect = new SelectList(_context.Arme, "Id", "Nom"),
        };


            //ViewData["ArmeId"] = new SelectList(_context.Arme, "Id", "Id", samurai.ArmeId);
            return View(samuraiVM);
        }

        // POST: Samurais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Force,ArmeId")] Samurai samurai)
        {
            if (id != samurai.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(samurai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SamuraiExists(samurai.Id))
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
            ViewData["ArmeId"] = new SelectList(_context.Arme, "Id", "Id", samurai.ArmeId);
            return View(samurai);
        }

        // GET: Samurais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Samurai == null)
            {
                return NotFound();
            }

            var samurai = await _context.Samurai
                .Include(s => s.Arme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (samurai == null)
            {
                return NotFound();
            }

            return View(samurai);
        }

        // POST: Samurais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Samurai == null)
            {
                return Problem("Entity set 'TpDojoContext.Samurai'  is null.");
            }
            var samurai = await _context.Samurai.FindAsync(id);
            if (samurai != null)
            {
                _context.Samurai.Remove(samurai);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SamuraiExists(int id)
        {
          return _context.Samurai.Any(e => e.Id == id);
        }
    }
}
