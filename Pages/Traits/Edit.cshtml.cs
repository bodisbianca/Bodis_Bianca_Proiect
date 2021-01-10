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

namespace Bodis_Bianca_Proiect.Pages.Traits
{
    public class EditModel : PageModel
    {
        private readonly Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext _context;

        public EditModel(Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Trait).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TraitExists(Trait.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TraitExists(int id)
        {
            return _context.Trait.Any(e => e.ID == id);
        }
    }
}
