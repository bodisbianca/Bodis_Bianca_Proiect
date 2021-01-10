using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Bodis_Bianca_Proiect.Models
{
    public class AnimalData
    {
        public IEnumerable<Animal> Animals { get; set; }
        public IEnumerable<Trait> Traits { get; set; }

        public IEnumerable<AnimalTrait> AnimalTraits { get; set; }
    }
}
