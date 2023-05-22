using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pokrocily_zaverecny_projekt.Models;

namespace Pokrocily_zaverecny_projekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Pokrocily_zaverecny_projekt.Models.Insured>? Insured { get; set; }
    }
}