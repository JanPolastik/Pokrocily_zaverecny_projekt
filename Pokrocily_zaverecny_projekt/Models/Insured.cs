using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Pokrocily_zaverecny_projekt.Models
{
    public class Insured
    {
        public int Id { get; set; }
        public string Jmeno { get; set; } = "";
        public string Adresa { get; set; } = "";
        public string Prijmeni { get; set; } = "";
        public int CisloDomu { get; set; }
        public string EmailInsured { get; set; } = "";
        public int Telefon { get; set; }
        public int SmerovaciCislo { get; set; }
        public string Mesto { get; set; } = "";
    }
}
