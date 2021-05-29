using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopAtlantico.Entities;

namespace PetshopAtlantico.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(c => c.Id);

            builder.Property(a => a.Nome).HasColumnType("varchar(100)");
            builder.Property(a => a.Logradouro).HasColumnType("varchar(200)");
            builder.Property(a => a.Numero).HasColumnType("varchar(10)");
            builder.Property(a => a.Bairro).HasColumnType("varchar(100)");
            builder.Property(a => a.Complemento).HasColumnType("varchar(100)");
            builder.Property(a => a.Cep).HasColumnType("varchar(8)");
            builder.Property(a => a.Cidade).HasColumnType("varchar(100)");
            builder.Property(a => a.Estado).HasColumnType("varchar(50)");

        }
    }
}
