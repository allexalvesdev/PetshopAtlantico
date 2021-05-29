using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopAtlantico.Entities;

namespace PetshopAtlantico.Data.Mappings
{
    public class AlojamentoMapping : IEntityTypeConfiguration<Alojamento>
    {
        public void Configure(EntityTypeBuilder<Alojamento> builder)
        {
            builder.ToTable("Alojamentos");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome).HasColumnType("varchar(50)");
        }
    }
}
