using System;
using System.ComponentModel.DataAnnotations;


namespace DatiAnagrafici.ClassDatiAnag
{
    public class DatiAnag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Devi inserire il nome ! ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Devi inserire il cognome ")]
        public string Cognome { get; set; }

        [Required(ErrorMessage = "Devi inserire la data di nascita ! ")]
        public DateTime Data_di_nascita { get; set; }

        [Required(ErrorMessage = "Devi inserire il luogo di nascita ! ")]
        public string Luogo_di_nascita { get; set; }

        [Required(ErrorMessage = "Devi inserire il codice fiscale ! ")]
        public string Codice_fiscale { get; set; }

        [Required(ErrorMessage = "Devi inserire un indirizzo email ! ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Devi inserire un numero di telefono/celullare ! ")]
        public int Tel_cel { get; set; }

        [Required(ErrorMessage = "Devi inserire l'indirizzo ! ")]
        public string Indirizzo { get; set; }

        [Required(ErrorMessage = "Devi inserire il numero civico ! ")]
        public string Civico { get; set; }

        [Required(ErrorMessage = "Devi inserire la città ! ")]
        public string Citta { get; set; }

        [Required(ErrorMessage = "Devi inserire il CAP ! ")]
        public int Cap { get; set; }
    }
}
