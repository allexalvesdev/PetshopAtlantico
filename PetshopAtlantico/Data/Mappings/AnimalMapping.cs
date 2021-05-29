using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopAtlantico.Entities;

namespace PetshopAtlantico.Data.Mappings
{
    public class AnimalMapping : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome).HasColumnType("varchar(50)");

            builder.ToTable("Animais");
        }
    }
}
