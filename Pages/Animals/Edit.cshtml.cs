using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bodis_Bianca_Proiect.Data;
using Bodis_Bianca_Proiect.Models;

namespace Bodis_Bianca_Proiect.Pages.Animals
{
    public class EditModel : AnimalTraitsPageModel
    {
        private readonly Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext _context;

        public EditModel(Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Animal Animal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Animal = await _context.Animal.
                Include(b => b.Specie).Include(b => b.Foster).
                Include(b => b.AnimalTraits).ThenInclude(b => b.Trait)
                .AsNoTracking().FirstOrDefaultAsync(m => m.ID == id);

            if (Animal == null)
            {
                return NotFound();
            }

            PopulateAssignedTraitData(_context, Animal);

            ViewData["SpecieID"] = new SelectList(_context.Set<Specie>(), "ID", "SpecieName");
            ViewData["FosterID"] = new SelectList(_context.Set<Foster>(), "ID", "FosterName");
            return Page();
        }


        public async Task<IActionResult> OnPostAsync(int? id, string[] selectedTraits)
        {
            if (id == null)
            {
                return NotFound();
            }
            var animalToUpdate = await _context.Animal
                .Include(i => i.Specie).Include(i => i.Foster)
                .Include(i => i.AnimalTraits).ThenInclude(i => i.Trait)
                .FirstOrDefaultAsync(s => s.ID == id);
            if (animalToUpdate == null)
            {
                return NotFound();
            }
            if (await TryUpdateModelAsync<Animal>(
            animalToUpdate,
            "Animal",
            i => i.Name, i => i.Breed, 
            i => i.Gender, i => i.Age, 
            i => i.Details, i => i.ArrivalDate, 
            i => i.SpecieID, i => i.FosterID))
            {
                UpdateAnimalTraits(_context, selectedTraits, animalToUpdate);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            UpdateAnimalTraits(_context, selectedTraits, animalToUpdate);
            PopulateAssignedTraitData(_context, animalToUpdate);
            return Page();
        }
    }
}
