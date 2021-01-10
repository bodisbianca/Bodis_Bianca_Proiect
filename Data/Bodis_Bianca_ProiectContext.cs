using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bodis_Bianca_Proiect.Models;

namespace Bodis_Bianca_Proiect.Data
{
    public class Bodis_Bianca_ProiectContext : DbContext
    {
        public Bodis_Bianca_ProiectContext (DbContextOptions<Bodis_Bianca_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Bodis_Bianca_Proiect.Models.Animal> Animal { get; set; }

        public DbSet<Bodis_Bianca_Proiect.Models.Specie> Specie { get; set; }

        public DbSet<Bodis_Bianca_Proiect.Models.Trait> Trait { get; set; }

        public DbSet<Bodis_Bianca_Proiect.Models.Foster> Foster { get; set; }
    }
}
