using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bodis_Bianca_Proiect.Models
{
    public class Specie
    {
        public int ID { get; set; }
        [Required, StringLength(40, MinimumLength = 3, ErrorMessage = "Numele speciei trebuie să fie de minim 3 caractere!")]
        [Display(Name = "Denumire specie")]
        public string SpecieName { get; set; }

        [Range(1, 200, ErrorMessage = "Vârsta trebuie să fie un număr cuprins între 1 și 200!")]
        [Display(Name = "Vârsta maximă")]
        public int VarstaMaxima { get; set; }

        [Display(Name = "Dificultate de întreținere")]
        public string DifIntretinere { get; set; }

        [StringLength(250, MinimumLength = 10, ErrorMessage = "Detaliile trebuie să fie de minimum 10 și maxim 250 caractere!")]
        [Display(Name = "Detalii specie")]
        public string DetaliiSpecie { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
