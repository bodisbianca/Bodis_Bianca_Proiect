using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bodis_Bianca_Proiect.Models
{
    public class Animal
    {
        public int ID { get; set; }

        [Required, StringLength(40, MinimumLength = 1, ErrorMessage = "Animalul trebuie sa aibă un nume!")]
        [Display(Name = "Nume")]
        public string Name { get; set; }

        [StringLength(150, MinimumLength = 2, ErrorMessage = "Denumirea rasei trebuie să aibă minimum 2 caractere!")]
        [Display(Name = "Rasă")]
        public string Breed { get; set; }


        [Display(Name = "Gen")]
        public string Gender { get; set; }

        [Range(1, 200, ErrorMessage = "Vârsta trebuie să fie un număr cuprins între 1 și 200!")]
        [Display(Name = "Vârstă")]
        public decimal Age { get; set; }

        [StringLength(250, MinimumLength = 2, ErrorMessage = "Povestea trebuie să aibă minimum 2 și maxim 250 caractere!")]
        [Display(Name = "Povestea animalului")]
        public string Details { get; set; }


        [Display(Name = "Sosire la adăpost")]
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        public int SpecieID { get; set; }
        public Specie Specie { get; set; }
        
        public int FosterID { get; set; }
        public Foster Foster { get; set; }

        [Display(Name = "Personalitate")]
        public ICollection<AnimalTrait> AnimalTraits { get; set; }

       
    }
}
