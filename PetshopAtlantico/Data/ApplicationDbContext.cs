using Microsoft.EntityFrameworkCore;
using PetshopAtlantico.Entities;

namespace PetshopAtlantico.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Alojamento> Alojamentos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
