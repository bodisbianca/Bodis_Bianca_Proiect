using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bodis_Bianca_Proiect.Models
{
    public class Trait
    {
        public int ID { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "Numele trăsăturii trebuie să fie de minimum 3 și maxim 40 caractere!")]
        [Display(Name = "Denumire trăsătură")]
        public string TraitName { get; set; }

        [StringLength(150, MinimumLength = 3, ErrorMessage = "Avantajul trebuie să fie de minimum 3 și maxim 150 caractere!")]
        public string Avantaje { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "Dezvantajul trebuie să fie de minimum 3 și maxim 150 caractere!")]
        public string Dezavantaje { get; set; }

        [StringLength(250, MinimumLength = 10, ErrorMessage = "Sfaturile trebuie să aibă minimum 10 și maxim 250 caractere!")]
        [Display(Name = "Sfaturi și informații suplimentare")]
        public string TraitDetails{ get; set; }
        public ICollection<AnimalTrait> AnimalTraits { get; set; }
    }
}
