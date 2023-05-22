using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Pokrocily_zaverecny_projekt.Models
{
    public class Insured
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Adress { get; set; } = "";
    }
}
