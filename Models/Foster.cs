using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bodis_Bianca_Proiect.Models
{
    public class Foster
    {
        public int ID { get; set; }

        [Required, RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Numele trebuie să conțină doar litere și să înceapă cu literă mare!"), StringLength(40, MinimumLength = 2, ErrorMessage = "Numele trebuie să fie de minim 2 caractere!")]
        [Display(Name = "Îngrijitor")]
        public string FosterName { get; set; }


        [Required, RegularExpression(@"^(\d{10})$", ErrorMessage = "Numărul de de telefon trebuie să aibă 10 cifre!")]
        [Display(Name = "Număr de telefon")]
        public string Telefon { get; set; }


        [EmailAddress(ErrorMessage = "Introduceți o adresă validă de email!")]
        [Display(Name = "Adresă de email")]
        public string Email { get; set; }


        [Range(1, 50, ErrorMessage = "Vechimea trebuie să fie un număr mai mare decât 1!")]
        [Display(Name = "Vechime ca și îngrijitor (ani)")]
        public int Vechime { get; set; }


        [StringLength(250, MinimumLength = 2, ErrorMessage = "Informațiile suplimentare trebuie să fie de minimum 2 și maxim 250 caractere!")]
        [Display(Name = "Informații suplimentare")]
        public string DetaliiFoster { get; set; }
    }
}
