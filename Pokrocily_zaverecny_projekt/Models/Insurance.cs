namespace Pokrocily_zaverecny_projekt.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string InsuranceName { get; set; } = "";
        public int InsuredId { get; set; }
        public int InsuranceValue { get; set; }
        public string InsurenceObject { get; set; } = "";
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
