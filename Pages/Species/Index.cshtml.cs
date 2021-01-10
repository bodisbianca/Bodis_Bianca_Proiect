using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bodis_Bianca_Proiect.Data;
using Bodis_Bianca_Proiect.Models;

namespace Bodis_Bianca_Proiect.Pages.Species
{
    public class IndexModel : PageModel
    {
        private readonly Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext _context;

        public IndexModel(Bodis_Bianca_Proiect.Data.Bodis_Bianca_ProiectContext context)
        {
            _context = context;
        }

        public IList<Specie> Specie { get;set; }

        public async Task OnGetAsync()
        {
            Specie = await _context.Specie.ToListAsync();
        }
    }
}
