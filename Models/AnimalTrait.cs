using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bodis_Bianca_Proiect.Models
{
    public class AnimalTrait
    {
        public int ID { get; set; }
        public int AnimalID { get; set; }
        public Animal Animal { get; set; }
        public int TraitID { get; set; }
        public Trait Trait { get; set; }
    }
}
