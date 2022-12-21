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
using TpDojo.Migrations;

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
        public async Task<IActionResult> Index(
                                            string sortOrder, 
                                            string currentFilter, 
                                            string searchString, 
                                            int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["ForceSortParam"] = sortOrder == "Force" ? "force_asc" : "Force";
            /*ViewData["ArmeSortParam"] = sortOrder == "Arme" ? "arme_asc" : "Arme";*/
            

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            var samurais = _context.Samurai.Select(s => s);


            if (!String.IsNullOrEmpty(searchString))
            {
                samurais = samurais.Where(s => s.Nom.StartsWith(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    samurais = samurais.OrderByDescending(s => s.Nom);
                    break;

                case "Force":
                    samurais = samurais.OrderBy(s => s.Force);
                    break;
/*
                case "Arme":
                    samurais = samurais.Include(s=>s.Arme).OrderBy(s => s.Arme.Nom);
                    break;*/

                default: 
                    samurais = samurais.OrderBy(s => s.Id);
                    break;
            }

            int pageSize = 7;
            return View(await PaginatedList<Samurai>.CreateAsync(samurais.Include(s => s.Arme)
                                                            .Include(s => s.ArtMartiaux)
                                                            .AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Samurais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Samurai == null)
            {
                return NotFound();
            }

            var samurai = await _context.Samurai
                .Include(sam => sam.Arme)
                .Include(samu => samu.ArtMartiaux)
                .FirstOrDefaultAsync(samur => samur.Id == id);
            if (samurai == null)
            {
                return NotFound();
            }

     
            int potentielDegat = (samurai.Force + (samurai.Arme is null ? 0 : samurai.Arme.Degat)) * ((samurai.ArtMartiaux is null ? 1 : samurai.ArtMartiaux.Count() + 1));
            ViewData["potentielDegat"] = potentielDegat;

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

            samuraiVM.ArmesSelect = new SelectList(_context.Arme, "Id", "Nom"); ;
            samuraiVM.ArtMartiauxSelect = new SelectList(_context.ArtMartial, "Id", "Nom");

            ViewData["ArmeId"] = new SelectList(_context.Arme, "Id", "Nom");
            ViewData["ArtMartiauxId"] = new SelectList(_context.ArtMartial, "Id", "Nom");

            // ViewData["ArmeId"] = new SelectList(selectArme, "Id", "Nom");
            return View(samuraiVM);
   //         return View();
        }


        /*        // POST: Samurais/Create
                // To protect from overposting attacks, enable the specific properties you want to bind to.
                // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
                [HttpPost]
                [ValidateAntiForgeryToken]
                public async Task<IActionResult> Create([Bind("Id,Nom,Force,ArmeId,ArtMartiauxId")] Samurai samurai)
                {

                    *//*     Samurai samurai = new Samurai();
                         samurai.Nom = samuraiVM.Nom;
                         samurai.Arme = _context.Arme.Find(samuraiVM.ArmeId);
                         samurai.Force= samuraiVM.Force;*//*

                    Console.WriteLine($"#################");
                    Console.WriteLine($"POST Samurai => Id: {samurai.Id}" +
                        $"- Nom: {samurai.Nom} " +
                        $"- ArmeId: {samurai.ArmeId} " +
                        $"- Arme: {_context.Arme.Find(samurai.ArmeId).Nom}");


                    Console.WriteLine(Environment.NewLine + "Détails Art martiaux :");


                    foreach (var art in samurai.ArtMartiaux)
                    {
                        Console.WriteLine($"      Art martial : {_context.ArtMartial.Find(art.Id)}");
                    }

                    Console.WriteLine($"#################");


                    if (ModelState.IsValid)
                    {
                        _context.Add(samurai);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    ViewData["ArmeId"] = new SelectList(_context.Arme, "Id", "Nom", samurai.ArmeId);
                    ViewData["ArtMartiauxId"] = new SelectList(_context.ArtMartial, "Id", "Nom");
                    //  SelectList selectArme = new SelectList(_context.Arme, "Id", "Nom");
                    //  SelectList selectArtMartiaux = new SelectList(_context.ArtMartial, "Id", "Nom");


                    *//*     samuraiVM.ArmesSelect = selectArme;*/
        /*return View(samuraiVM);*//*
        return View(samurai);
    }
    */


        // POST: Samourais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nom,Force,ArmeId,ArtMartiauxId")] SamuraiVM samuraiVM)
        {

            List<ArtMartial> artMartiauxSamurai= new List<ArtMartial>();
            foreach (var art in samuraiVM.ArtMartiauxId)
            {
                ArtMartial artMartial = _context.ArtMartial.Find(art);
                artMartiauxSamurai.Add(artMartial);
            }

            Samurai samurai = new Samurai
            {
                Nom = samuraiVM.Nom,
                Force = samuraiVM.Force,
                Arme = _context.Arme?.Find(samuraiVM.ArmeId),
                ArtMartiaux = artMartiauxSamurai,
            };

            if (ModelState.IsValid)
            {
                _context.Add(samurai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
          
            ViewData["ArmeId"] = new SelectList(_context.Arme, "Id", "Nom", samuraiVM.ArmeId);
            ViewData["ArtMartiauxId"] = new SelectList(_context.ArtMartial, "Id", "Nom");
            return View(samuraiVM);
        }


        // GET: Samurais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Samurai == null)
            {
                return NotFound();
            }

           // var samurai = await _context.Samurai.FindAsync(id);

            var samurai = await _context.Samurai
                .Include(sam => sam.Arme)
                .Include(samu => samu.ArtMartiaux)
                .FirstOrDefaultAsync(samur => samur.Id == id);


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
                ArtMartiauxId = samurai.ArtMartiaux.Select(a => a.Id).ToList(),
                ArtMartiauxSelect = new SelectList(_context.ArtMartial, "Id", "Nom"),
            };

            Console.WriteLine($"######################" +
                                $"{Environment.NewLine}" +
                                $"Samurai: {samuraiVM.Nom}" +
                                $" Arme: {samuraiVM.ArmeId}" +
                                $"{Environment.NewLine}");
            foreach (var i in samuraiVM.ArtMartiauxId)
            {
                Console.WriteLine($"id Art martial : {i}");
            }


      //      ViewData["ArmeId"] = new SelectList(_context.Arme, "Id", "Nom", samuraiVM.ArmeId);
         //   ViewData["ArtMartiauxId"] = new SelectList(_context.ArtMartial, "Id", "Nom");
            
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
                .Include(s => s.ArtMartiaux)
                .FirstOrDefaultAsync(m => m.Id == id);

            int potentielDegat = (samurai.Force + (samurai.Arme is null ? 0 : samurai.Arme.Degat)) * ((samurai.ArtMartiaux is null ? 1 : samurai.ArtMartiaux.Count() + 1));
            ViewData["potentielDegat"] = potentielDegat;
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
