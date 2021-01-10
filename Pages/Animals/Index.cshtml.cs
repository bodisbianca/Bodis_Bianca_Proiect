using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bodis_Bianca_Proiect.Data;
using Bodis_Bianca_Proiect.Models;

namespace Bodis_Bianca_Proiect.Pages.Animals
{
    public class IndexModel : PageModel
    {
        private readonly Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext _context;

        public IndexModel(Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext context)
        {
            _context = context;
        }

        public IList<Animal> Animal { get;set; }
        public AnimalData AnimalD { get; set; }
        public int AnimalID { get; set; }
        public int TraitID { get; set; }

        public async Task OnGetAsync(int? id, int? traitID)
        {
            AnimalD = new AnimalData();

            AnimalD.Animals = await _context.Animal
            .Include(b => b.Specie)
            .Include(b => b.Foster)
            .Include(b => b.AnimalTraits)
            .ThenInclude(b => b.Trait)
            .AsNoTracking()
            .OrderBy(b => b.Name)
            .ToListAsync();
            if (id != null)
            {
                AnimalID = id.Value;
                Animal animal = AnimalD.Animals
                .Where(i => i.ID == id.Value).Single();
                AnimalD.Traits = animal.AnimalTraits.Select(s => s.Trait);
            }
        }
    }
}
