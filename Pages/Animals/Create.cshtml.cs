using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bodis_Bianca_Proiect.Data;
using Bodis_Bianca_Proiect.Models;

namespace Bodis_Bianca_Proiect.Pages.Animals
{
    public class CreateModel : AnimalTraitsPageModel
    {
        private readonly Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext _context;

        public CreateModel(Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["SpecieID"] = new SelectList(_context.Set<Specie>(), "ID", "SpecieName");
            ViewData["FosterID"] = new SelectList(_context.Set<Foster>(), "ID", "FosterName");

            var animal = new Animal();
            animal.AnimalTraits = new List<AnimalTrait>();
            PopulateAssignedTraitData(_context, animal);

            return Page();
        }

        [BindProperty]
        public Animal Animal { get; set; }

        public async Task<IActionResult> OnPostAsync(string[] selectedTraits)
        {
            var newAnimal = new Animal();
            if (selectedTraits != null)
            {
                newAnimal.AnimalTraits = new List<AnimalTrait>();
                foreach (var cat in selectedTraits)
                {
                    var catToAdd = new AnimalTrait
                    {
                        TraitID = int.Parse(cat)
                    };
                    newAnimal.AnimalTraits.Add(catToAdd);
                }
            }
            if (await TryUpdateModelAsync<Animal>(
            newAnimal,
            "Animal",
            i => i.Name, i => i.Breed, i => i.Gender, i => i.Age, i => i.Details, i => i.ArrivalDate, i => i.SpecieID, i => i.FosterID))
            {
                _context.Animal.Add(newAnimal);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            PopulateAssignedTraitData(_context, newAnimal);
            return Page();
        }
    }
}
