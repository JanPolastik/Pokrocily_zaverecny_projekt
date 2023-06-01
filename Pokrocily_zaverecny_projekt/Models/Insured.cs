using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace Pokrocily_zaverecny_projekt.Models
{
    public class Insured
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vyplňte jméno")]
        public string Jmeno { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte adresu")]
        public string Adresa { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte příjmení")]
        public string Prijmeni { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte číslo domu")]
        public int CisloDomu { get; set; }
        [Required(ErrorMessage = "Vyplňte Email")]
        public string EmailInsured { get; set; } = ""; 
        [Required(ErrorMessage = "Vyplňte telefon")]
        public int Telefon { get; set; }
        [Required(ErrorMessage = "Vyplňte PSČ")]
        public int SmerovaciCislo { get; set; }
        [Required(ErrorMessage = "Vyplňte město")]
        public string Mesto { get; set; } = "";
        public virtual ICollection<Insurance>? Insurances { get; set; }
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni;
        }
    }
}
