using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bodis_Bianca_Proiect.Data;
using Bodis_Bianca_Proiect.Models;

namespace Bodis_Bianca_Proiect.Pages.Traits
{
    public class DetailsModel : PageModel
    {
        private readonly Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext _context;

        public DetailsModel(Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext context)
        {
            _context = context;
        }

        public Trait Trait { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trait = await _context.Trait.FirstOrDefaultAsync(m => m.ID == id);

            if (Trait == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
