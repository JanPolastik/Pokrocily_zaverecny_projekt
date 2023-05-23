using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace Pokrocily_zaverecny_projekt.Models
{
    public class Insured
    {
        public int Id { get; set; }
        public string Jmeno { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte jméno")]
        public string Adresa { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte adresu")]
        public string Prijmeni { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte příjmení")]
        public int CisloDomu { get; set; }
        [Required(ErrorMessage = "Vyplňte číslo domu")]
        public string EmailInsured { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte Email")]
        public int Telefon { get; set; }
        [Required(ErrorMessage = "Vyplňte telefon")]
        public int SmerovaciCislo { get; set; }
        [Required(ErrorMessage = "Vyplňte PSČ")]
        public string Mesto { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte město")]
    }
}
