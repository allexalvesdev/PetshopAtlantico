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

            builder.Property(c => c.Nome).HasColumnType("varchar(100)");
            builder.Property(c => c.Telefone).HasColumnType("varchar(14)");
            builder.Property(c => c.Logradouro).HasColumnType("varchar(200)");
            builder.Property(c => c.Numero).HasColumnType("varchar(10)");
            builder.Property(c => c.Bairro).HasColumnType("varchar(100)");
            builder.Property(c => c.Complemento).HasColumnType("varchar(100)");
            builder.Property(c => c.Cep).HasColumnType("varchar(8)");
            builder.Property(c => c.Cidade).HasColumnType("varchar(100)");
            builder.Property(c => c.Estado).HasColumnType("varchar(50)");

        }
    }
}
