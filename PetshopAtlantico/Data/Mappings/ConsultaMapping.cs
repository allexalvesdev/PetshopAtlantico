using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopAtlantico.Entities;

namespace PetshopAtlantico.Data.Mappings
{
    public class ConsultaMapping : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consultas");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Motivo).HasColumnType("varchar(200)");
            
        }
    }
}
