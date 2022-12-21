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
            ViewData["ArmeSortParam"] = sortOrder == "Arme" ? "arme_asc" : "Arme";
            ViewData["IdSortParam"] = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["PotentielSortParam"] = sortOrder == "Potentiel" ? "potentiel_desc" : "Potentiel";


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
                case "id_desc":
                    samurais = samurais.OrderByDescending(s => s.Id);
                    break;

                case "name_desc":
                    samurais = samurais.OrderByDescending(s => s.Nom);
                    break;

                case "Force":
                    samurais = samurais.OrderByDescending(s => s.Force);
                    break;

                case "force_asc":
                    samurais = samurais.OrderBy(s => s.Force);
                    break;

                case "Arme":
                    samurais = samurais.Include(s => s.Arme).OrderByDescending(s => s.Arme.Nom);
                    break;
                case "arme_asc":
                    samurais = samurais.Include(s => s.Arme).OrderBy(s => s.Arme.Nom);
                    break;

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

            int potentielDegat = (samurai.Force + (samurai.Arme is null ? 0 : samurai.Arme.Degat))
                                    * ((samurai.ArtMartiaux is null ? 1 : samurai.ArtMartiaux.Count() + 1));
            ViewData["potentielDegat"] = potentielDegat;

            return View(samurai);
        }

        // GET: Samurais/Create
        public IActionResult Create()
        {
            SamuraiVM samuraiVM = new SamuraiVM
            {
                Samurai = new Samurai(),
                ArmesSelect = BuildSelectListArme(),
                ArtsMartiauxSelect = BuildSelectListArtsMartiaux(),

            };

            return View(samuraiVM);
        }

        // POST: Samourais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SamuraiVM samuraiVM)
        {

            if (ModelState.IsValid)
            {
                if (samuraiVM.Samurai.ArmeId != null && _context.Samurai.Any(s => s.ArmeId == samuraiVM.Samurai.ArmeId))
                {
                    return BadRequest();
                }

                samuraiVM.Samurai.ArtMartiaux = _context.ArtMartial.Where(a => samuraiVM.IdsArtsMartiaux.Contains(a.Id)).ToList();

                _context.Add(samuraiVM.Samurai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            samuraiVM.ArmesSelect = BuildSelectListArme();
            samuraiVM.ArtsMartiauxSelect = BuildSelectListArtsMartiaux();

            return View(samuraiVM);
        }


        // GET: Samurais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Samurai == null)
            {
                return NotFound();
            }

            var samuraiAModifie = await _context.Samurai
                .Include(s => s.Arme)
                .Include(s => s.ArtMartiaux)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (samuraiAModifie == null)
            {
                return NotFound();
            }

            SamuraiVM samuraiVM = new SamuraiVM
            {
                Samurai = samuraiAModifie,
                IdsArtsMartiaux = samuraiAModifie.ArtMartiaux.Select(a => a.Id).ToList(),
                ArmesSelect = BuildSelectListArme(id),
                ArtsMartiauxSelect = BuildSelectListArtsMartiaux(),
            };

            return View(samuraiVM);
        }

        // POST: Samurais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SamuraiVM samuraiVM)
        {
            if (id != samuraiVM.Samurai.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Samurai? samurai = _context.Samurai.Include(s => s.Arme)
                                     .Include(s => s.ArtMartiaux)
                                     .FirstOrDefault(s => s.Id == id);

                    if (samurai is null) return NotFound();


                    // Si l'arme est null && si l'id du samurai est différent de celui que l'on modifie && si l'arme du samurai est déjà utilisé
                    if (samuraiVM.Samurai.ArmeId != null && _context.Samurai.Any(s => s.Id != id && s.ArmeId == samuraiVM.Samurai.ArmeId))
                    {
                        return BadRequest();
                    }

                    samurai.Nom = samuraiVM.Samurai.Nom;
                    samurai.Force = samuraiVM.Samurai.Force;
                    samurai.ArmeId = samuraiVM.Samurai.ArmeId;

                    if (samuraiVM.IdsArtsMartiaux != null && samuraiVM.IdsArtsMartiaux.Any())
                    {
                        samurai.ArtMartiaux = _context.ArtMartial.Where(a => samuraiVM.IdsArtsMartiaux
                                                                 .Contains(a.Id))
                                                                 .ToList();
                    }
                    else
                    {
                        samurai.ArtMartiaux = new List<ArtMartial>();
                    }
                    //_context.Update(samuraiVM.Samurai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SamuraiExists(samuraiVM.Samurai.Id))
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

            samuraiVM.ArmesSelect = BuildSelectListArme(id);
            samuraiVM.ArtsMartiauxSelect = BuildSelectListArme();
            return View(samuraiVM.Samurai);
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

            //int potentielDegat = (samurai.Force + (samurai.Arme is null ? 0 : samurai.Arme.Degat)) 
            //                                                 * ((samurai.ArtMartiaux is null ? 1 : samurai.ArtMartiaux.Count() + 1));
            //ViewData["potentielDegat"] = potentielDegat;

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

        private SelectList BuildSelectListArme(int? samuraiId = null)
        {
            return new SelectList(_context.Arme
                                        .Where(a => a.Samurai == null || a.Samurai.Id == samuraiId)
                                        .ToList(), "Id", "Nom");
        }

        private SelectList BuildSelectListArtsMartiaux()
        {
            return new SelectList(_context.ArtMartial, "Id", "Nom");
        }

    }
}
