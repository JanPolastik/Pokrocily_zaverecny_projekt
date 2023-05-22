using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Pokrocily_zaverecny_projekt.Models
{
    public class Insured
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Adress { get; set; } = "";
        public string LastName { get; set; } = "";
        public int HouseNumber { get; set; }
        public string Email { get; set; } = "";
        public int PhoneNumber { get; set; }
        public int PSC { get; set; }
        public string Town { get; set; } = "";
    }
}
