using DemoProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<UserDetails> UserDetails { get; set; } 
        public DbSet<AddressDetails> Addresses { get; set; }
        public DbSet<EducationalDetails> EducationalDetails { get; set;}
    }
}
